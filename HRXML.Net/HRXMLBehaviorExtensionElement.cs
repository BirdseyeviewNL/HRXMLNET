using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Configuration;

namespace HRXML.Net
{
    public class HRXMLBehaviorExtensionElement : BehaviorExtensionElement
    {
        public HRXMLBehaviorExtensionElement()
        {
        }

        public override Type BehaviorType
        {
            get
            {
                return typeof(SchemaValidationBehavior);
            }
        }

        protected override object CreateBehavior()
        {
            return new SchemaValidationBehavior();
        }

    }

}
