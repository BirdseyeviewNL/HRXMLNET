using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Description;

namespace HRXML.Net
{
    public class SchemaValidationBehavior : IEndpointBehavior
    {
        public void AddBindingParameters(ServiceEndpoint endpoint,
           System.ServiceModel.Channels.BindingParameterCollection
                                                bindingParameters)
        {
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint,
                System.ServiceModel.Dispatcher.ClientRuntime clientRuntime)
        {
            HRXMLMessageInspector inspector =
               new HRXMLMessageInspector();
            clientRuntime.MessageInspectors.Add(inspector);
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint,
             System.ServiceModel.Dispatcher.EndpointDispatcher
                                              endpointDispatcher)
        {
            HRXMLMessageInspector inspector =
               new HRXMLMessageInspector();
            endpointDispatcher.DispatchRuntime.MessageInspectors.Add(inspector);
        }

        public void Validate(ServiceEndpoint endpoint)
        {
        }
    }

}
