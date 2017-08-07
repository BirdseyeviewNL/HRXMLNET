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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DateChoiceType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class DateChoiceType : EntityBase<DateChoiceType>
    {

        private object itemField;

        [System.Xml.Serialization.XmlElementAttribute("Date", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("DateString", typeof(string))]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                if ((this.itemField != null))
                {
                    if ((itemField.Equals(value) != true))
                    {
                        this.itemField = value;
                        this.OnPropertyChanged("Item");
                    }
                }
                else
                {
                    this.itemField = value;
                    this.OnPropertyChanged("Item");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute("StaffingPosition", Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingPositionType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingPositionType : EntityBase<StaffingPositionType>
    {

        private StaffingPositionHeaderType positionHeaderField;

        private CustomerReportingRequirementsType customerReportingRequirementsField;

        private string departmentNameField;

        private string positionReasonField;

        private StaffingPositionTypePositionDateRange positionDateRangeField;

        private StaffingPositionTypeReportToPerson reportToPersonField;

        private List<StaffingPositionTypePositionContact> positionContactField;

        private List<RatesType> ratesField;

        private StaffingWorkSiteType workSiteField;

        private List<StaffingWorkSiteEnvironmentType> workSiteEnvironmentField;

        private List<StaffingShiftType> staffingShiftField;

        private StaffingPositionTypePositionRequirements positionRequirementsField;

        private StaffingPositionTypeInvoiceInfo invoiceInfoField;

        private string langField;

        /// <summary>
        /// StaffingPositionType class constructor
        /// </summary>
        public StaffingPositionType()
        {
            this.staffingShiftField = new List<StaffingShiftType>();
            this.workSiteEnvironmentField = new List<StaffingWorkSiteEnvironmentType>();
            this.ratesField = new List<RatesType>();
            this.positionContactField = new List<StaffingPositionTypePositionContact>();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaffingPositionHeaderType PositionHeader
        {
            get
            {
                return this.positionHeaderField;
            }
            set
            {
                if ((this.positionHeaderField != null))
                {
                    if ((positionHeaderField.Equals(value) != true))
                    {
                        this.positionHeaderField = value;
                        this.OnPropertyChanged("PositionHeader");
                    }
                }
                else
                {
                    this.positionHeaderField = value;
                    this.OnPropertyChanged("PositionHeader");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public CustomerReportingRequirementsType CustomerReportingRequirements
        {
            get
            {
                return this.customerReportingRequirementsField;
            }
            set
            {
                if ((this.customerReportingRequirementsField != null))
                {
                    if ((customerReportingRequirementsField.Equals(value) != true))
                    {
                        this.customerReportingRequirementsField = value;
                        this.OnPropertyChanged("CustomerReportingRequirements");
                    }
                }
                else
                {
                    this.customerReportingRequirementsField = value;
                    this.OnPropertyChanged("CustomerReportingRequirements");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DepartmentName
        {
            get
            {
                return this.departmentNameField;
            }
            set
            {
                if ((this.departmentNameField != null))
                {
                    if ((departmentNameField.Equals(value) != true))
                    {
                        this.departmentNameField = value;
                        this.OnPropertyChanged("DepartmentName");
                    }
                }
                else
                {
                    this.departmentNameField = value;
                    this.OnPropertyChanged("DepartmentName");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PositionReason
        {
            get
            {
                return this.positionReasonField;
            }
            set
            {
                if ((this.positionReasonField != null))
                {
                    if ((positionReasonField.Equals(value) != true))
                    {
                        this.positionReasonField = value;
                        this.OnPropertyChanged("PositionReason");
                    }
                }
                else
                {
                    this.positionReasonField = value;
                    this.OnPropertyChanged("PositionReason");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaffingPositionTypePositionDateRange PositionDateRange
        {
            get
            {
                return this.positionDateRangeField;
            }
            set
            {
                if ((this.positionDateRangeField != null))
                {
                    if ((positionDateRangeField.Equals(value) != true))
                    {
                        this.positionDateRangeField = value;
                        this.OnPropertyChanged("PositionDateRange");
                    }
                }
                else
                {
                    this.positionDateRangeField = value;
                    this.OnPropertyChanged("PositionDateRange");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaffingPositionTypeReportToPerson ReportToPerson
        {
            get
            {
                return this.reportToPersonField;
            }
            set
            {
                if ((this.reportToPersonField != null))
                {
                    if ((reportToPersonField.Equals(value) != true))
                    {
                        this.reportToPersonField = value;
                        this.OnPropertyChanged("ReportToPerson");
                    }
                }
                else
                {
                    this.reportToPersonField = value;
                    this.OnPropertyChanged("ReportToPerson");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("PositionContact")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<StaffingPositionTypePositionContact> PositionContact
        {
            get
            {
                return this.positionContactField;
            }
            set
            {
                if ((this.positionContactField != null))
                {
                    if ((positionContactField.Equals(value) != true))
                    {
                        this.positionContactField = value;
                        this.OnPropertyChanged("PositionContact");
                    }
                }
                else
                {
                    this.positionContactField = value;
                    this.OnPropertyChanged("PositionContact");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Rates")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<RatesType> Rates
        {
            get
            {
                return this.ratesField;
            }
            set
            {
                if ((this.ratesField != null))
                {
                    if ((ratesField.Equals(value) != true))
                    {
                        this.ratesField = value;
                        this.OnPropertyChanged("Rates");
                    }
                }
                else
                {
                    this.ratesField = value;
                    this.OnPropertyChanged("Rates");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaffingWorkSiteType WorkSite
        {
            get
            {
                return this.workSiteField;
            }
            set
            {
                if ((this.workSiteField != null))
                {
                    if ((workSiteField.Equals(value) != true))
                    {
                        this.workSiteField = value;
                        this.OnPropertyChanged("WorkSite");
                    }
                }
                else
                {
                    this.workSiteField = value;
                    this.OnPropertyChanged("WorkSite");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("WorkSiteEnvironment")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<StaffingWorkSiteEnvironmentType> WorkSiteEnvironment
        {
            get
            {
                return this.workSiteEnvironmentField;
            }
            set
            {
                if ((this.workSiteEnvironmentField != null))
                {
                    if ((workSiteEnvironmentField.Equals(value) != true))
                    {
                        this.workSiteEnvironmentField = value;
                        this.OnPropertyChanged("WorkSiteEnvironment");
                    }
                }
                else
                {
                    this.workSiteEnvironmentField = value;
                    this.OnPropertyChanged("WorkSiteEnvironment");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("StaffingShift")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<StaffingShiftType> StaffingShift
        {
            get
            {
                return this.staffingShiftField;
            }
            set
            {
                if ((this.staffingShiftField != null))
                {
                    if ((staffingShiftField.Equals(value) != true))
                    {
                        this.staffingShiftField = value;
                        this.OnPropertyChanged("StaffingShift");
                    }
                }
                else
                {
                    this.staffingShiftField = value;
                    this.OnPropertyChanged("StaffingShift");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaffingPositionTypePositionRequirements PositionRequirements
        {
            get
            {
                return this.positionRequirementsField;
            }
            set
            {
                if ((this.positionRequirementsField != null))
                {
                    if ((positionRequirementsField.Equals(value) != true))
                    {
                        this.positionRequirementsField = value;
                        this.OnPropertyChanged("PositionRequirements");
                    }
                }
                else
                {
                    this.positionRequirementsField = value;
                    this.OnPropertyChanged("PositionRequirements");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaffingPositionTypeInvoiceInfo InvoiceInfo
        {
            get
            {
                return this.invoiceInfoField;
            }
            set
            {
                if ((this.invoiceInfoField != null))
                {
                    if ((invoiceInfoField.Equals(value) != true))
                    {
                        this.invoiceInfoField = value;
                        this.OnPropertyChanged("InvoiceInfo");
                    }
                }
                else
                {
                    this.invoiceInfoField = value;
                    this.OnPropertyChanged("InvoiceInfo");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                if ((this.langField != null))
                {
                    if ((langField.Equals(value) != true))
                    {
                        this.langField = value;
                        this.OnPropertyChanged("lang");
                    }
                }
                else
                {
                    this.langField = value;
                    this.OnPropertyChanged("lang");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingPositionTypePositionDateRange", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingPositionTypePositionDateRange : EntityBase<StaffingPositionTypePositionDateRange>
    {

        private string startDateField;

        private string expectedEndDateField;

        private string actualEndDateField;

        private FlexibleDatesType maxStartDateField;

        private bool startAsSoonAsPossibleField;

        private bool startAsSoonAsPossibleFieldSpecified;

        private FlexibleDatesType maxNeedEndDateField;

        private StaffingPositionTypePositionDateRangePositionDuration positionDurationField;

        private StaffingPositionTypePositionDateRangeExtensionParameters extensionParametersField;

        /// <summary>
        /// StaffingPositionTypePositionDateRange class constructor
        /// </summary>
        public StaffingPositionTypePositionDateRange()
        {
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                if ((this.startDateField != null))
                {
                    if ((startDateField.Equals(value) != true))
                    {
                        this.startDateField = value;
                        this.OnPropertyChanged("StartDate");
                    }
                }
                else
                {
                    this.startDateField = value;
                    this.OnPropertyChanged("StartDate");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExpectedEndDate
        {
            get
            {
                return this.expectedEndDateField;
            }
            set
            {
                if ((this.expectedEndDateField != null))
                {
                    if ((expectedEndDateField.Equals(value) != true))
                    {
                        this.expectedEndDateField = value;
                        this.OnPropertyChanged("ExpectedEndDate");
                    }
                }
                else
                {
                    this.expectedEndDateField = value;
                    this.OnPropertyChanged("ExpectedEndDate");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ActualEndDate
        {
            get
            {
                return this.actualEndDateField;
            }
            set
            {
                if ((this.actualEndDateField != null))
                {
                    if ((actualEndDateField.Equals(value) != true))
                    {
                        this.actualEndDateField = value;
                        this.OnPropertyChanged("ActualEndDate");
                    }
                }
                else
                {
                    this.actualEndDateField = value;
                    this.OnPropertyChanged("ActualEndDate");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public FlexibleDatesType MaxStartDate
        {
            get
            {
                return this.maxStartDateField;
            }
            set
            {
                if ((this.maxStartDateField != null))
                {
                    if ((maxStartDateField.Equals(value) != true))
                    {
                        this.maxStartDateField = value;
                        this.OnPropertyChanged("MaxStartDate");
                    }
                }
                else
                {
                    this.maxStartDateField = value;
                    this.OnPropertyChanged("MaxStartDate");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool StartAsSoonAsPossible
        {
            get
            {
                return this.startAsSoonAsPossibleField;
            }
            set
            {
                if ((startAsSoonAsPossibleField.Equals(value) != true))
                {
                    this.startAsSoonAsPossibleField = value;
                    this.OnPropertyChanged("StartAsSoonAsPossible");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool StartAsSoonAsPossibleSpecified
        {
            get
            {
                return this.startAsSoonAsPossibleFieldSpecified;
            }
            set
            {
                if ((startAsSoonAsPossibleFieldSpecified.Equals(value) != true))
                {
                    this.startAsSoonAsPossibleFieldSpecified = value;
                    this.OnPropertyChanged("StartAsSoonAsPossibleSpecified");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public FlexibleDatesType MaxNeedEndDate
        {
            get
            {
                return this.maxNeedEndDateField;
            }
            set
            {
                if ((this.maxNeedEndDateField != null))
                {
                    if ((maxNeedEndDateField.Equals(value) != true))
                    {
                        this.maxNeedEndDateField = value;
                        this.OnPropertyChanged("MaxNeedEndDate");
                    }
                }
                else
                {
                    this.maxNeedEndDateField = value;
                    this.OnPropertyChanged("MaxNeedEndDate");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaffingPositionTypePositionDateRangePositionDuration PositionDuration
        {
            get
            {
                return this.positionDurationField;
            }
            set
            {
                if ((this.positionDurationField != null))
                {
                    if ((positionDurationField.Equals(value) != true))
                    {
                        this.positionDurationField = value;
                        this.OnPropertyChanged("PositionDuration");
                    }
                }
                else
                {
                    this.positionDurationField = value;
                    this.OnPropertyChanged("PositionDuration");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaffingPositionTypePositionDateRangeExtensionParameters ExtensionParameters
        {
            get
            {
                return this.extensionParametersField;
            }
            set
            {
                if ((this.extensionParametersField != null))
                {
                    if ((extensionParametersField.Equals(value) != true))
                    {
                        this.extensionParametersField = value;
                        this.OnPropertyChanged("ExtensionParameters");
                    }
                }
                else
                {
                    this.extensionParametersField = value;
                    this.OnPropertyChanged("ExtensionParameters");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingPositionTypePositionDateRangePositionDuration", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingPositionTypePositionDateRangePositionDuration : EntityBase<StaffingPositionTypePositionDateRangePositionDuration>
    {

        private string unitOfTimeField;

        private decimal valueField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string unitOfTime
        {
            get
            {
                return this.unitOfTimeField;
            }
            set
            {
                if ((this.unitOfTimeField != null))
                {
                    if ((unitOfTimeField.Equals(value) != true))
                    {
                        this.unitOfTimeField = value;
                        this.OnPropertyChanged("unitOfTime");
                    }
                }
                else
                {
                    this.unitOfTimeField = value;
                    this.OnPropertyChanged("unitOfTime");
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
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingPositionTypePositionDateRangeExtensionParameters", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingPositionTypePositionDateRangeExtensionParameters : EntityBase<StaffingPositionTypePositionDateRangeExtensionParameters>
    {

        private bool allowExtensionField;

        private bool allowExtensionFieldSpecified;

        private StaffingPositionTypePositionDateRangeExtensionParametersExtensionPeriod extensionPeriodField;

        private string descriptionField;

        /// <summary>
        /// StaffingPositionTypePositionDateRangeExtensionParameters class constructor
        /// </summary>
        public StaffingPositionTypePositionDateRangeExtensionParameters()
        {
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AllowExtension
        {
            get
            {
                return this.allowExtensionField;
            }
            set
            {
                if ((allowExtensionField.Equals(value) != true))
                {
                    this.allowExtensionField = value;
                    this.OnPropertyChanged("AllowExtension");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AllowExtensionSpecified
        {
            get
            {
                return this.allowExtensionFieldSpecified;
            }
            set
            {
                if ((allowExtensionFieldSpecified.Equals(value) != true))
                {
                    this.allowExtensionFieldSpecified = value;
                    this.OnPropertyChanged("AllowExtensionSpecified");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaffingPositionTypePositionDateRangeExtensionParametersExtensionPeriod ExtensionPeriod
        {
            get
            {
                return this.extensionPeriodField;
            }
            set
            {
                if ((this.extensionPeriodField != null))
                {
                    if ((extensionPeriodField.Equals(value) != true))
                    {
                        this.extensionPeriodField = value;
                        this.OnPropertyChanged("ExtensionPeriod");
                    }
                }
                else
                {
                    this.extensionPeriodField = value;
                    this.OnPropertyChanged("ExtensionPeriod");
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
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingPositionTypePositionDateRangeExtensionParametersExtensionPeriod", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingPositionTypePositionDateRangeExtensionParametersExtensionPeriod : EntityBase<StaffingPositionTypePositionDateRangeExtensionParametersExtensionPeriod>
    {

        private string unitOfTimeField;

        private decimal valueField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string unitOfTime
        {
            get
            {
                return this.unitOfTimeField;
            }
            set
            {
                if ((this.unitOfTimeField != null))
                {
                    if ((unitOfTimeField.Equals(value) != true))
                    {
                        this.unitOfTimeField = value;
                        this.OnPropertyChanged("unitOfTime");
                    }
                }
                else
                {
                    this.unitOfTimeField = value;
                    this.OnPropertyChanged("unitOfTime");
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
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingPositionTypeReportToPerson", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingPositionTypeReportToPerson : EntityBase<StaffingPositionTypeReportToPerson>
    {

        private ContactInfoType contactInfoField;

        /// <summary>
        /// StaffingPositionTypeReportToPerson class constructor
        /// </summary>
        public StaffingPositionTypeReportToPerson()
        {
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public ContactInfoType ContactInfo
        {
            get
            {
                return this.contactInfoField;
            }
            set
            {
                if ((this.contactInfoField != null))
                {
                    if ((contactInfoField.Equals(value) != true))
                    {
                        this.contactInfoField = value;
                        this.OnPropertyChanged("ContactInfo");
                    }
                }
                else
                {
                    this.contactInfoField = value;
                    this.OnPropertyChanged("ContactInfo");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingPositionTypePositionContact", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingPositionTypePositionContact : EntityBase<StaffingPositionTypePositionContact>
    {

        private ContactInfoType contactInfoField;

        private string contactTypeField;

        /// <summary>
        /// StaffingPositionTypePositionContact class constructor
        /// </summary>
        public StaffingPositionTypePositionContact()
        {
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public ContactInfoType ContactInfo
        {
            get
            {
                return this.contactInfoField;
            }
            set
            {
                if ((this.contactInfoField != null))
                {
                    if ((contactInfoField.Equals(value) != true))
                    {
                        this.contactInfoField = value;
                        this.OnPropertyChanged("ContactInfo");
                    }
                }
                else
                {
                    this.contactInfoField = value;
                    this.OnPropertyChanged("ContactInfo");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string contactType
        {
            get
            {
                return this.contactTypeField;
            }
            set
            {
                if ((this.contactTypeField != null))
                {
                    if ((contactTypeField.Equals(value) != true))
                    {
                        this.contactTypeField = value;
                        this.OnPropertyChanged("contactType");
                    }
                }
                else
                {
                    this.contactTypeField = value;
                    this.OnPropertyChanged("contactType");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingPositionTypePositionRequirements", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingPositionTypePositionRequirements : EntityBase<StaffingPositionTypePositionRequirements>
    {

        private List<CompetencyType> competencyField;

        private List<StaffingPositionTypePositionRequirementsScreeningRequirements> screeningRequirementsField;

        private bool resumeRequiredField;

        private bool interviewRequiredField;

        /// <summary>
        /// StaffingPositionTypePositionRequirements class constructor
        /// </summary>
        public StaffingPositionTypePositionRequirements()
        {
            this.screeningRequirementsField = new List<StaffingPositionTypePositionRequirementsScreeningRequirements>();
            this.competencyField = new List<CompetencyType>();
        }

        [System.Xml.Serialization.XmlElementAttribute("Competency")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<CompetencyType> Competency
        {
            get
            {
                return this.competencyField;
            }
            set
            {
                if ((this.competencyField != null))
                {
                    if ((competencyField.Equals(value) != true))
                    {
                        this.competencyField = value;
                        this.OnPropertyChanged("Competency");
                    }
                }
                else
                {
                    this.competencyField = value;
                    this.OnPropertyChanged("Competency");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ScreeningRequirements")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<StaffingPositionTypePositionRequirementsScreeningRequirements> ScreeningRequirements
        {
            get
            {
                return this.screeningRequirementsField;
            }
            set
            {
                if ((this.screeningRequirementsField != null))
                {
                    if ((screeningRequirementsField.Equals(value) != true))
                    {
                        this.screeningRequirementsField = value;
                        this.OnPropertyChanged("ScreeningRequirements");
                    }
                }
                else
                {
                    this.screeningRequirementsField = value;
                    this.OnPropertyChanged("ScreeningRequirements");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool resumeRequired
        {
            get
            {
                return this.resumeRequiredField;
            }
            set
            {
                if ((resumeRequiredField.Equals(value) != true))
                {
                    this.resumeRequiredField = value;
                    this.OnPropertyChanged("resumeRequired");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool interviewRequired
        {
            get
            {
                return this.interviewRequiredField;
            }
            set
            {
                if ((interviewRequiredField.Equals(value) != true))
                {
                    this.interviewRequiredField = value;
                    this.OnPropertyChanged("interviewRequired");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingPositionTypePositionRequirementsScreeningRequirements", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingPositionTypePositionRequirementsScreeningRequirements : EntityBase<StaffingPositionTypePositionRequirementsScreeningRequirements>
    {

        private string screeningTypeField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string screeningType
        {
            get
            {
                return this.screeningTypeField;
            }
            set
            {
                if ((this.screeningTypeField != null))
                {
                    if ((screeningTypeField.Equals(value) != true))
                    {
                        this.screeningTypeField = value;
                        this.OnPropertyChanged("screeningType");
                    }
                }
                else
                {
                    this.screeningTypeField = value;
                    this.OnPropertyChanged("screeningType");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StaffingPositionTypeInvoiceInfo", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class StaffingPositionTypeInvoiceInfo : EntityBase<StaffingPositionTypeInvoiceInfo>
    {

        private string descriptionField;

        private bool fourHourMinimumField;

        private bool fourHourMinimumFieldSpecified;

        private bool expenseReimbursedField;

        private bool expenseReimbursedFieldSpecified;

        private List<string> invoiceFrequencyField;

        private List<DateChoiceType> timePeriodClosingDateInfoField;

        private List<DateChoiceType> closingDateInfoField;

        private List<DateChoiceType> arrivalDateInfoField;

        private List<DateChoiceType> paymentDateInfoField;

        /// <summary>
        /// StaffingPositionTypeInvoiceInfo class constructor
        /// </summary>
        public StaffingPositionTypeInvoiceInfo()
        {
            this.paymentDateInfoField = new List<DateChoiceType>();
            this.arrivalDateInfoField = new List<DateChoiceType>();
            this.closingDateInfoField = new List<DateChoiceType>();
            this.timePeriodClosingDateInfoField = new List<DateChoiceType>();
            this.invoiceFrequencyField = new List<string>();
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

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool FourHourMinimum
        {
            get
            {
                return this.fourHourMinimumField;
            }
            set
            {
                if ((fourHourMinimumField.Equals(value) != true))
                {
                    this.fourHourMinimumField = value;
                    this.OnPropertyChanged("FourHourMinimum");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool FourHourMinimumSpecified
        {
            get
            {
                return this.fourHourMinimumFieldSpecified;
            }
            set
            {
                if ((fourHourMinimumFieldSpecified.Equals(value) != true))
                {
                    this.fourHourMinimumFieldSpecified = value;
                    this.OnPropertyChanged("FourHourMinimumSpecified");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ExpenseReimbursed
        {
            get
            {
                return this.expenseReimbursedField;
            }
            set
            {
                if ((expenseReimbursedField.Equals(value) != true))
                {
                    this.expenseReimbursedField = value;
                    this.OnPropertyChanged("ExpenseReimbursed");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ExpenseReimbursedSpecified
        {
            get
            {
                return this.expenseReimbursedFieldSpecified;
            }
            set
            {
                if ((expenseReimbursedFieldSpecified.Equals(value) != true))
                {
                    this.expenseReimbursedFieldSpecified = value;
                    this.OnPropertyChanged("ExpenseReimbursedSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("InvoiceFrequency")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<string> InvoiceFrequency
        {
            get
            {
                return this.invoiceFrequencyField;
            }
            set
            {
                if ((this.invoiceFrequencyField != null))
                {
                    if ((invoiceFrequencyField.Equals(value) != true))
                    {
                        this.invoiceFrequencyField = value;
                        this.OnPropertyChanged("InvoiceFrequency");
                    }
                }
                else
                {
                    this.invoiceFrequencyField = value;
                    this.OnPropertyChanged("InvoiceFrequency");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("TimePeriodClosingDateInfo")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<DateChoiceType> TimePeriodClosingDateInfo
        {
            get
            {
                return this.timePeriodClosingDateInfoField;
            }
            set
            {
                if ((this.timePeriodClosingDateInfoField != null))
                {
                    if ((timePeriodClosingDateInfoField.Equals(value) != true))
                    {
                        this.timePeriodClosingDateInfoField = value;
                        this.OnPropertyChanged("TimePeriodClosingDateInfo");
                    }
                }
                else
                {
                    this.timePeriodClosingDateInfoField = value;
                    this.OnPropertyChanged("TimePeriodClosingDateInfo");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ClosingDateInfo")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<DateChoiceType> ClosingDateInfo
        {
            get
            {
                return this.closingDateInfoField;
            }
            set
            {
                if ((this.closingDateInfoField != null))
                {
                    if ((closingDateInfoField.Equals(value) != true))
                    {
                        this.closingDateInfoField = value;
                        this.OnPropertyChanged("ClosingDateInfo");
                    }
                }
                else
                {
                    this.closingDateInfoField = value;
                    this.OnPropertyChanged("ClosingDateInfo");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ArrivalDateInfo")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<DateChoiceType> ArrivalDateInfo
        {
            get
            {
                return this.arrivalDateInfoField;
            }
            set
            {
                if ((this.arrivalDateInfoField != null))
                {
                    if ((arrivalDateInfoField.Equals(value) != true))
                    {
                        this.arrivalDateInfoField = value;
                        this.OnPropertyChanged("ArrivalDateInfo");
                    }
                }
                else
                {
                    this.arrivalDateInfoField = value;
                    this.OnPropertyChanged("ArrivalDateInfo");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("PaymentDateInfo")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<DateChoiceType> PaymentDateInfo
        {
            get
            {
                return this.paymentDateInfoField;
            }
            set
            {
                if ((this.paymentDateInfoField != null))
                {
                    if ((paymentDateInfoField.Equals(value) != true))
                    {
                        this.paymentDateInfoField = value;
                        this.OnPropertyChanged("PaymentDateInfo");
                    }
                }
                else
                {
                    this.paymentDateInfoField = value;
                    this.OnPropertyChanged("PaymentDateInfo");
                }
            }
        }
    }

}
