using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace HRXML.Net
{
    public partial class AcknowledgeType
    {
        /// <summary>
        /// Create an NACK Acknowledgement from a .NET exception with a reference to one or more EntityId's
        /// </summary>
        /// <param name="ex">Exception that is thrown</param>
        /// <param name="references">References to Entity Id's</param>
        /// <returns>AcknowledgeType with exception payload.</returns>
        public static AcknowledgeType CreateFromException(Exception ex, List<EntityIdType> references)
        {
            var result = new AcknowledgeType();
            result.lang = CultureInfo.CurrentCulture.Name;

            if (result.PayloadResponseSummary == null)
                result.PayloadResponseSummary = new PayloadResponseSummaryType();

            result.PayloadResponseSummary.AcknowledgementCreationTimestamp = DateTime.Now;
            result.PayloadResponseSummary.AcknowledgementCreationTimestampSpecified = true;
            result.PayloadResponseSummary.ReferenceId = references;

            foreach (var entityId in references)
            {
                var payloadDisposition = new PayloadDispositionTypeEntityDisposition();

                payloadDisposition.EntityIdentifier = entityId;
                
                var entityException = new EntityExceptionType();
                Exception loop = ex;

                do
                {
                    var xmlException = new ExceptionType();
                    xmlException.ExceptionIdentifier = ex.GetType().FullName;
                    xmlException.ExceptionMessage = ex.Message;
                    entityException.Exception.Add(xmlException);
                    loop = loop.InnerException;
                }
                while (loop != null);

                payloadDisposition.Item = entityException;
                result.PayloadDisposition.Add(payloadDisposition);
            }
            return result;
        }

        /// <summary>
        /// Create an ACK Acknowledgementwith a reference to one or more EntityId's
        /// </summary>
        /// <param name="references">References to Entity Id's</param>
        /// <returns>AcknowledgeType with exception payload.</returns>
        public static AcknowledgeType CreateAcknowledgement(List<EntityIdType> references)
        {
            var result = new AcknowledgeType();
            result.lang = CultureInfo.CurrentCulture.Name;

            if (result.PayloadResponseSummary == null)
                result.PayloadResponseSummary = new PayloadResponseSummaryType();

            result.PayloadResponseSummary.AcknowledgementCreationTimestamp = DateTime.Now;
            result.PayloadResponseSummary.AcknowledgementCreationTimestampSpecified = true;
            result.PayloadResponseSummary.ReferenceId = references;

            foreach (var entityId in references)
            {
                var payloadDisposition = new PayloadDispositionTypeEntityDisposition();

                payloadDisposition.EntityIdentifier = entityId;
                payloadDisposition.Item = new PayloadDispositionTypeEntityDispositionEntityNoException();
                result.PayloadDisposition.Add(payloadDisposition);
            }
            return result;
        }
    }
}
