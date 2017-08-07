using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Dispatcher;
using System.Xml;
using System.Xml.Schema;
using System.IO;
using System.ServiceModel;

namespace HRXML.Net
{
    public class HRXMLMessageInspector : IClientMessageInspector, IDispatchMessageInspector
    {
        private bool isRequest = false;

        #region IClientMessageInspector Members

        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            ValidateMessageBody(ref reply, false);
        }

        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel)
        {
            ValidateMessageBody(ref request, true);
            return null;
        }

        #endregion

        #region IDispatchMessageInspector Members

        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel, System.ServiceModel.InstanceContext instanceContext)
        {
            ValidateMessageBody(ref request, true);
            return null;
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            // Inspect the reply, catch a possible validation error 
            try
            {
                ValidateMessageBody(ref reply, false);
            }
            catch (FaultException fault)
            {
                // if a validation error occurred, the message is replaced
                // with the validation fault.
                reply = System.ServiceModel.Channels.Message.CreateMessage(reply.Version,
                        fault.CreateMessageFault(), reply.Headers.Action);
            }
        }

        #endregion

        void ValidateMessageBody(ref System.ServiceModel.Channels.Message message, bool isRequest)
        {
            if (!message.IsFault)
            {
                XmlDictionaryReaderQuotas quotas =
                        new XmlDictionaryReaderQuotas();
                XmlReader bodyReader = message.GetReaderAtBodyContents().ReadSubtree();
                XmlReaderSettings wrapperSettings =
                                      new XmlReaderSettings();
                wrapperSettings.CloseInput = true;
                wrapperSettings.Schemas = EntityBase<object>.Schemas;
                wrapperSettings.ValidationFlags =
                                        XmlSchemaValidationFlags.None;
                wrapperSettings.ValidationType = ValidationType.Schema;
                wrapperSettings.ValidationEventHandler += new ValidationEventHandler(InspectionValidationHandler);
                XmlReader wrappedReader = XmlReader.Create(bodyReader,
                                                    wrapperSettings);

                // pull body into a memory backed writer to validate
                this.isRequest = isRequest;
                MemoryStream memStream = new MemoryStream();
                XmlDictionaryWriter xdw = XmlDictionaryWriter.CreateBinaryWriter(memStream);
                xdw.WriteNode(wrappedReader, false);
                xdw.Flush(); memStream.Position = 0;
                XmlDictionaryReader xdr =
                XmlDictionaryReader.CreateBinaryReader(memStream, quotas);

            }
        }

        void InspectionValidationHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Error)
            {
                throw new FaultException(e.Message);
            }
        }

    }
}
