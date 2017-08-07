using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRXML.Net
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute("StaffingWorkSiteEnvironment", Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingWorkSiteEnvironmentType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingWorkSiteEnvironmentType : EntityBase<StaffingWorkSiteEnvironmentType>
    {

        private StaffingWorkSiteEnvironmentTypeEnvironmentId environmentIdField;

        private string environmentNameField;

        private string environmentDescriptionField;

        private List<StaffingWorkSiteEnvironmentTypeEnvironmentConsideration> environmentConsiderationField;

        /// <summary>
        /// StaffingWorkSiteEnvironmentType class constructor
        /// </summary>
        public StaffingWorkSiteEnvironmentType()
        {
            this.environmentConsiderationField = new List<StaffingWorkSiteEnvironmentTypeEnvironmentConsideration>();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaffingWorkSiteEnvironmentTypeEnvironmentId EnvironmentId
        {
            get
            {
                return this.environmentIdField;
            }
            set
            {
                if ((this.environmentIdField != null))
                {
                    if ((environmentIdField.Equals(value) != true))
                    {
                        this.environmentIdField = value;
                        this.OnPropertyChanged("EnvironmentId");
                    }
                }
                else
                {
                    this.environmentIdField = value;
                    this.OnPropertyChanged("EnvironmentId");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EnvironmentName
        {
            get
            {
                return this.environmentNameField;
            }
            set
            {
                if ((this.environmentNameField != null))
                {
                    if ((environmentNameField.Equals(value) != true))
                    {
                        this.environmentNameField = value;
                        this.OnPropertyChanged("EnvironmentName");
                    }
                }
                else
                {
                    this.environmentNameField = value;
                    this.OnPropertyChanged("EnvironmentName");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EnvironmentDescription
        {
            get
            {
                return this.environmentDescriptionField;
            }
            set
            {
                if ((this.environmentDescriptionField != null))
                {
                    if ((environmentDescriptionField.Equals(value) != true))
                    {
                        this.environmentDescriptionField = value;
                        this.OnPropertyChanged("EnvironmentDescription");
                    }
                }
                else
                {
                    this.environmentDescriptionField = value;
                    this.OnPropertyChanged("EnvironmentDescription");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("EnvironmentConsideration")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<StaffingWorkSiteEnvironmentTypeEnvironmentConsideration> EnvironmentConsideration
        {
            get
            {
                return this.environmentConsiderationField;
            }
            set
            {
                if ((this.environmentConsiderationField != null))
                {
                    if ((environmentConsiderationField.Equals(value) != true))
                    {
                        this.environmentConsiderationField = value;
                        this.OnPropertyChanged("EnvironmentConsideration");
                    }
                }
                else
                {
                    this.environmentConsiderationField = value;
                    this.OnPropertyChanged("EnvironmentConsideration");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingWorkSiteEnvironmentTypeEnvironmentId", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingWorkSiteEnvironmentTypeEnvironmentId : EntityBase<StaffingWorkSiteEnvironmentTypeEnvironmentId>
    {

        private string idField;

        private StaffingWorkSiteEnvironmentTypeEnvironmentIdDomain domainField;

        /// <summary>
        /// StaffingWorkSiteEnvironmentTypeEnvironmentId class constructor
        /// </summary>
        public StaffingWorkSiteEnvironmentTypeEnvironmentId()
        {
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                if ((this.idField != null))
                {
                    if ((idField.Equals(value) != true))
                    {
                        this.idField = value;
                        this.OnPropertyChanged("Id");
                    }
                }
                else
                {
                    this.idField = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaffingWorkSiteEnvironmentTypeEnvironmentIdDomain Domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                if ((this.domainField != null))
                {
                    if ((domainField.Equals(value) != true))
                    {
                        this.domainField = value;
                        this.OnPropertyChanged("Domain");
                    }
                }
                else
                {
                    this.domainField = value;
                    this.OnPropertyChanged("Domain");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingWorkSiteEnvironmentTypeEnvironmentIdDomain", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingWorkSiteEnvironmentTypeEnvironmentIdDomain : EntityBase<StaffingWorkSiteEnvironmentTypeEnvironmentIdDomain>
    {

        private string idIssuerField;

        private string idTypeField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdIssuer
        {
            get
            {
                return this.idIssuerField;
            }
            set
            {
                if ((this.idIssuerField != null))
                {
                    if ((idIssuerField.Equals(value) != true))
                    {
                        this.idIssuerField = value;
                        this.OnPropertyChanged("IdIssuer");
                    }
                }
                else
                {
                    this.idIssuerField = value;
                    this.OnPropertyChanged("IdIssuer");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdType
        {
            get
            {
                return this.idTypeField;
            }
            set
            {
                if ((this.idTypeField != null))
                {
                    if ((idTypeField.Equals(value) != true))
                    {
                        this.idTypeField = value;
                        this.OnPropertyChanged("IdType");
                    }
                }
                else
                {
                    this.idTypeField = value;
                    this.OnPropertyChanged("IdType");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingWorkSiteEnvironmentTypeEnvironmentConsideration", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingWorkSiteEnvironmentTypeEnvironmentConsideration : EntityBase<StaffingWorkSiteEnvironmentTypeEnvironmentConsideration>
    {

        private bool suppliedByOrganizationField;

        private bool suppliedByOrganizationFieldSpecified;

        private StaffingWorkSiteEnvironmentTypeEnvironmentConsiderationTypeConsideration typeConsiderationField;

        private string valueField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool suppliedByOrganization
        {
            get
            {
                return this.suppliedByOrganizationField;
            }
            set
            {
                if ((suppliedByOrganizationField.Equals(value) != true))
                {
                    this.suppliedByOrganizationField = value;
                    this.OnPropertyChanged("suppliedByOrganization");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool suppliedByOrganizationSpecified
        {
            get
            {
                return this.suppliedByOrganizationFieldSpecified;
            }
            set
            {
                if ((suppliedByOrganizationFieldSpecified.Equals(value) != true))
                {
                    this.suppliedByOrganizationFieldSpecified = value;
                    this.OnPropertyChanged("suppliedByOrganizationSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaffingWorkSiteEnvironmentTypeEnvironmentConsiderationTypeConsideration typeConsideration
        {
            get
            {
                return this.typeConsiderationField;
            }
            set
            {
                if ((typeConsiderationField.Equals(value) != true))
                {
                    this.typeConsiderationField = value;
                    this.OnPropertyChanged("typeConsideration");
                }
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                if ((this.valueField != null))
                {
                    if ((valueField.Equals(value) != true))
                    {
                        this.valueField = value;
                        this.OnPropertyChanged("Value");
                    }
                }
                else
                {
                    this.valueField = value;
                    this.OnPropertyChanged("Value");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public enum StaffingWorkSiteEnvironmentTypeEnvironmentConsiderationTypeConsideration
    {

        /// <remarks/>
        General,

        /// <remarks/>
        Physical,

        /// <remarks/>
        SafetyEquipment,

        /// <remarks/>
        DressCode,

        /// <remarks/>
        SafetyAndHygiene,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute("StaffingWorkSite", Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingWorkSiteType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingWorkSiteType : EntityBase<StaffingWorkSiteType>
    {

        private StaffingWorkSiteTypeWorkSiteId workSiteIdField;

        private string workSiteNameField;

        private List<StaffingWorkSiteTypeWorkSiteDetail> workSiteDetailField;

        private PostalAddressType postalAddressField;

        private List<object> itemsField;

        private string parkingInstructionsField;

        /// <summary>
        /// StaffingWorkSiteType class constructor
        /// </summary>
        public StaffingWorkSiteType()
        {
            this.itemsField = new List<object>();
            this.workSiteDetailField = new List<StaffingWorkSiteTypeWorkSiteDetail>();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaffingWorkSiteTypeWorkSiteId WorkSiteId
        {
            get
            {
                return this.workSiteIdField;
            }
            set
            {
                if ((this.workSiteIdField != null))
                {
                    if ((workSiteIdField.Equals(value) != true))
                    {
                        this.workSiteIdField = value;
                        this.OnPropertyChanged("WorkSiteId");
                    }
                }
                else
                {
                    this.workSiteIdField = value;
                    this.OnPropertyChanged("WorkSiteId");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WorkSiteName
        {
            get
            {
                return this.workSiteNameField;
            }
            set
            {
                if ((this.workSiteNameField != null))
                {
                    if ((workSiteNameField.Equals(value) != true))
                    {
                        this.workSiteNameField = value;
                        this.OnPropertyChanged("WorkSiteName");
                    }
                }
                else
                {
                    this.workSiteNameField = value;
                    this.OnPropertyChanged("WorkSiteName");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("WorkSiteDetail")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<StaffingWorkSiteTypeWorkSiteDetail> WorkSiteDetail
        {
            get
            {
                return this.workSiteDetailField;
            }
            set
            {
                if ((this.workSiteDetailField != null))
                {
                    if ((workSiteDetailField.Equals(value) != true))
                    {
                        this.workSiteDetailField = value;
                        this.OnPropertyChanged("WorkSiteDetail");
                    }
                }
                else
                {
                    this.workSiteDetailField = value;
                    this.OnPropertyChanged("WorkSiteDetail");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public PostalAddressType PostalAddress
        {
            get
            {
                return this.postalAddressField;
            }
            set
            {
                if ((this.postalAddressField != null))
                {
                    if ((postalAddressField.Equals(value) != true))
                    {
                        this.postalAddressField = value;
                        this.OnPropertyChanged("PostalAddress");
                    }
                }
                else
                {
                    this.postalAddressField = value;
                    this.OnPropertyChanged("PostalAddress");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("StructuredTravelDirections", typeof(StaffingWorkSiteTypeStructuredTravelDirections))]
        [System.Xml.Serialization.XmlElementAttribute("TravelDirections", typeof(string))]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<object> Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                if ((this.itemsField != null))
                {
                    if ((itemsField.Equals(value) != true))
                    {
                        this.itemsField = value;
                        this.OnPropertyChanged("Items");
                    }
                }
                else
                {
                    this.itemsField = value;
                    this.OnPropertyChanged("Items");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ParkingInstructions
        {
            get
            {
                return this.parkingInstructionsField;
            }
            set
            {
                if ((this.parkingInstructionsField != null))
                {
                    if ((parkingInstructionsField.Equals(value) != true))
                    {
                        this.parkingInstructionsField = value;
                        this.OnPropertyChanged("ParkingInstructions");
                    }
                }
                else
                {
                    this.parkingInstructionsField = value;
                    this.OnPropertyChanged("ParkingInstructions");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingWorkSiteTypeWorkSiteId", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingWorkSiteTypeWorkSiteId : EntityBase<StaffingWorkSiteTypeWorkSiteId>
    {

        private string idField;

        private StaffingWorkSiteTypeWorkSiteIdDomain domainField;

        /// <summary>
        /// StaffingWorkSiteTypeWorkSiteId class constructor
        /// </summary>
        public StaffingWorkSiteTypeWorkSiteId()
        {
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                if ((this.idField != null))
                {
                    if ((idField.Equals(value) != true))
                    {
                        this.idField = value;
                        this.OnPropertyChanged("Id");
                    }
                }
                else
                {
                    this.idField = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaffingWorkSiteTypeWorkSiteIdDomain Domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                if ((this.domainField != null))
                {
                    if ((domainField.Equals(value) != true))
                    {
                        this.domainField = value;
                        this.OnPropertyChanged("Domain");
                    }
                }
                else
                {
                    this.domainField = value;
                    this.OnPropertyChanged("Domain");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingWorkSiteTypeWorkSiteIdDomain", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingWorkSiteTypeWorkSiteIdDomain : EntityBase<StaffingWorkSiteTypeWorkSiteIdDomain>
    {

        private string idIssuerField;

        private string idTypeField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdIssuer
        {
            get
            {
                return this.idIssuerField;
            }
            set
            {
                if ((this.idIssuerField != null))
                {
                    if ((idIssuerField.Equals(value) != true))
                    {
                        this.idIssuerField = value;
                        this.OnPropertyChanged("IdIssuer");
                    }
                }
                else
                {
                    this.idIssuerField = value;
                    this.OnPropertyChanged("IdIssuer");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdType
        {
            get
            {
                return this.idTypeField;
            }
            set
            {
                if ((this.idTypeField != null))
                {
                    if ((idTypeField.Equals(value) != true))
                    {
                        this.idTypeField = value;
                        this.OnPropertyChanged("IdType");
                    }
                }
                else
                {
                    this.idTypeField = value;
                    this.OnPropertyChanged("IdType");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingWorkSiteTypeWorkSiteDetail", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingWorkSiteTypeWorkSiteDetail : EntityBase<StaffingWorkSiteTypeWorkSiteDetail>
    {

        private string workSiteTypeField;

        private string valueField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string workSiteType
        {
            get
            {
                return this.workSiteTypeField;
            }
            set
            {
                if ((this.workSiteTypeField != null))
                {
                    if ((workSiteTypeField.Equals(value) != true))
                    {
                        this.workSiteTypeField = value;
                        this.OnPropertyChanged("workSiteType");
                    }
                }
                else
                {
                    this.workSiteTypeField = value;
                    this.OnPropertyChanged("workSiteType");
                }
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                if ((this.valueField != null))
                {
                    if ((valueField.Equals(value) != true))
                    {
                        this.valueField = value;
                        this.OnPropertyChanged("Value");
                    }
                }
                else
                {
                    this.valueField = value;
                    this.OnPropertyChanged("Value");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingWorkSiteTypeStructuredTravelDirections", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingWorkSiteTypeStructuredTravelDirections : EntityBase<StaffingWorkSiteTypeStructuredTravelDirections>
    {

        private string startPointField;

        private string endPointField;

        private string transportationField;

        private StaffingWorkSiteTypeStructuredTravelDirectionsTimeRequired timeRequiredField;

        private string mapLinkField;

        private string descriptionField;

        /// <summary>
        /// StaffingWorkSiteTypeStructuredTravelDirections class constructor
        /// </summary>
        public StaffingWorkSiteTypeStructuredTravelDirections()
        {
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StartPoint
        {
            get
            {
                return this.startPointField;
            }
            set
            {
                if ((this.startPointField != null))
                {
                    if ((startPointField.Equals(value) != true))
                    {
                        this.startPointField = value;
                        this.OnPropertyChanged("StartPoint");
                    }
                }
                else
                {
                    this.startPointField = value;
                    this.OnPropertyChanged("StartPoint");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EndPoint
        {
            get
            {
                return this.endPointField;
            }
            set
            {
                if ((this.endPointField != null))
                {
                    if ((endPointField.Equals(value) != true))
                    {
                        this.endPointField = value;
                        this.OnPropertyChanged("EndPoint");
                    }
                }
                else
                {
                    this.endPointField = value;
                    this.OnPropertyChanged("EndPoint");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Transportation
        {
            get
            {
                return this.transportationField;
            }
            set
            {
                if ((this.transportationField != null))
                {
                    if ((transportationField.Equals(value) != true))
                    {
                        this.transportationField = value;
                        this.OnPropertyChanged("Transportation");
                    }
                }
                else
                {
                    this.transportationField = value;
                    this.OnPropertyChanged("Transportation");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaffingWorkSiteTypeStructuredTravelDirectionsTimeRequired TimeRequired
        {
            get
            {
                return this.timeRequiredField;
            }
            set
            {
                if ((this.timeRequiredField != null))
                {
                    if ((timeRequiredField.Equals(value) != true))
                    {
                        this.timeRequiredField = value;
                        this.OnPropertyChanged("TimeRequired");
                    }
                }
                else
                {
                    this.timeRequiredField = value;
                    this.OnPropertyChanged("TimeRequired");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MapLink
        {
            get
            {
                return this.mapLinkField;
            }
            set
            {
                if ((this.mapLinkField != null))
                {
                    if ((mapLinkField.Equals(value) != true))
                    {
                        this.mapLinkField = value;
                        this.OnPropertyChanged("MapLink");
                    }
                }
                else
                {
                    this.mapLinkField = value;
                    this.OnPropertyChanged("MapLink");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                if ((this.descriptionField != null))
                {
                    if ((descriptionField.Equals(value) != true))
                    {
                        this.descriptionField = value;
                        this.OnPropertyChanged("Description");
                    }
                }
                else
                {
                    this.descriptionField = value;
                    this.OnPropertyChanged("Description");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingWorkSiteTypeStructuredTravelDirectionsTimeRequired", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingWorkSiteTypeStructuredTravelDirectionsTimeRequired
    {

        private string unitOfMeasureField;

        private decimal valueField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                if ((this.unitOfMeasureField != null))
                {
                    if ((unitOfMeasureField.Equals(value) != true))
                    {
                        this.unitOfMeasureField = value;
                    }
                }
                else
                {
                    this.unitOfMeasureField = value;
                }
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                if ((valueField.Equals(value) != true))
                {
                    this.valueField = value;
                }
            }
        }
    }


}
