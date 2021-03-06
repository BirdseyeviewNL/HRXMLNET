// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.3.0.36516
//    <NameSpace>HRXML.Net</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLasyLoading>False</EnableLasyLoading><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><AutomaticProperties>False</AutomaticProperties><DisableDebug>False</DisableDebug><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace HRXML.Net
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Collections.Generic;
    using System.Runtime.Serialization;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nocore.nl/2010-10")]
    [System.Xml.Serialization.XmlRootAttribute("NocorePositionOpening", Namespace = "http://www.nocore.nl/2010-10", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "NocorePositionOpeningType", Namespace = "http://www.nocore.nl/2010-10")]
    public partial class NocorePositionOpeningType : EntityBase<NocorePositionOpeningType>
    {

        private string urgenceField;

        private string educationLevelField;

        private string professionalIntellectualAbilityField;

        private int requiredExperienceField;

        private bool requiredExperienceFieldSpecified;

        private decimal hoursPerWeekField;

        private bool hoursPerWeekFieldSpecified;

        private decimal daysPerWeekField;

        private bool daysPerWeekFieldSpecified;

        private decimal minRateField;

        private bool minRateFieldSpecified;

        private decimal maxRateField;

        private bool maxRateFieldSpecified;

        private string customerReferenceField;

        private List<AvailibilityType> availabilityField;

        private NocorePositionOpeningTypeQualifications qualificationsField;

        private List<Language> languagesField;

        private List<CredentialType> licensesAndCertificationsField;

        private List<NocorePositionOpeningTypeSchoolOrInstitution> requiredEducationField;

        private bool availabilityFieldSpecified;

        private bool qualificationsFieldSpecified;

        private bool languagesFieldSpecified;

        private bool licensesAndCertificationsFieldSpecified;

        private bool requiredEducationFieldSpecified;

        private NocoreLocationType locationField;

        private string statusField;

        private List<NocorePositionOpeningTypeRepliesType> repliesField;

        private bool repliesFieldSpecified;


        /// <summary>
        /// NocorePositionOpeningType class constructor
        /// </summary>
        public NocorePositionOpeningType()
        {
            this.locationField = new NocoreLocationType();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Urgence
        {
            get
            {
                return this.urgenceField;
            }
            set
            {
                if ((this.urgenceField != null))
                {
                    if ((urgenceField.Equals(value) != true))
                    {
                        this.urgenceField = value;
                        this.OnPropertyChanged("Urgence");
                    }
                }
                else
                {
                    this.urgenceField = value;
                    this.OnPropertyChanged("Urgence");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EducationLevel
        {
            get
            {
                return this.educationLevelField;
            }
            set
            {
                if ((this.educationLevelField != null))
                {
                    if ((educationLevelField.Equals(value) != true))
                    {
                        this.educationLevelField = value;
                        this.OnPropertyChanged("EducationLevel");
                    }
                }
                else
                {
                    this.educationLevelField = value;
                    this.OnPropertyChanged("EducationLevel");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProfessionalIntellectualAbility
        {
            get
            {
                return this.professionalIntellectualAbilityField;
            }
            set
            {
                if ((this.professionalIntellectualAbilityField != null))
                {
                    if ((professionalIntellectualAbilityField.Equals(value) != true))
                    {
                        this.professionalIntellectualAbilityField = value;
                        this.OnPropertyChanged("ProfessionalIntellectualAbility");
                    }
                }
                else
                {
                    this.professionalIntellectualAbilityField = value;
                    this.OnPropertyChanged("ProfessionalIntellectualAbility");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RequiredExperience
        {
            get
            {
                return this.requiredExperienceField;
            }
            set
            {
                if ((requiredExperienceField.Equals(value) != true))
                {
                    this.requiredExperienceField = value;
                    this.OnPropertyChanged("RequiredExperience");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool RequiredExperienceSpecified
        {
            get
            {
                return this.requiredExperienceFieldSpecified;
            }
            set
            {
                if ((requiredExperienceFieldSpecified.Equals(value) != true))
                {
                    this.requiredExperienceFieldSpecified = value;
                    this.OnPropertyChanged("RequiredExperienceSpecified");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal HoursPerWeek
        {
            get
            {
                return this.hoursPerWeekField;
            }
            set
            {
                if ((hoursPerWeekField.Equals(value) != true))
                {
                    this.hoursPerWeekField = value;
                    this.OnPropertyChanged("HoursPerWeek");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool HoursPerWeekSpecified
        {
            get
            {
                return this.hoursPerWeekFieldSpecified;
            }
            set
            {
                if ((hoursPerWeekFieldSpecified.Equals(value) != true))
                {
                    this.hoursPerWeekFieldSpecified = value;
                    this.OnPropertyChanged("HoursPerWeekSpecified");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal DaysPerWeek
        {
            get
            {
                return this.daysPerWeekField;
            }
            set
            {
                if ((daysPerWeekField.Equals(value) != true))
                {
                    this.daysPerWeekField = value;
                    this.OnPropertyChanged("DaysPerWeek");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool DaysPerWeekSpecified
        {
            get
            {
                return this.daysPerWeekFieldSpecified;
            }
            set
            {
                if ((daysPerWeekFieldSpecified.Equals(value) != true))
                {
                    this.daysPerWeekFieldSpecified = value;
                    this.OnPropertyChanged("DaysPerWeekSpecified");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal MinRate
        {
            get
            {
                return this.minRateField;
            }
            set
            {
                if ((minRateField.Equals(value) != true))
                {
                    this.minRateField = value;
                    this.OnPropertyChanged("MinRate");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool MinRateSpecified
        {
            get
            {
                return this.minRateFieldSpecified;
            }
            set
            {
                if ((minRateFieldSpecified.Equals(value) != true))
                {
                    this.minRateFieldSpecified = value;
                    this.OnPropertyChanged("MinRateSpecified");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal MaxRate
        {
            get
            {
                return this.maxRateField;
            }
            set
            {
                if ((maxRateField.Equals(value) != true))
                {
                    this.maxRateField = value;
                    this.OnPropertyChanged("MaxRate");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool MaxRateSpecified
        {
            get
            {
                return this.maxRateFieldSpecified;
            }
            set
            {
                if ((maxRateFieldSpecified.Equals(value) != true))
                {
                    this.maxRateFieldSpecified = value;
                    this.OnPropertyChanged("MaxRateSpecified");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerReference
        {
            get
            {
                return this.customerReferenceField;
            }
            set
            {
                if ((this.customerReferenceField != null))
                {
                    if ((customerReferenceField.Equals(value) != true))
                    {
                        this.customerReferenceField = value;
                        this.OnPropertyChanged("CustomerReference");
                    }
                }
                else
                {
                    this.customerReferenceField = value;
                    this.OnPropertyChanged("CustomerReference");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Availability")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<AvailibilityType> Availability
        {
            get
            {
                return this.availabilityField;
            }
            set
            {
                if ((this.availabilityField != null))
                {
                    if ((availabilityField.Equals(value) != true))
                    {
                        this.availabilityField = value;
                        this.OnPropertyChanged("Availability");
                    }
                }
                else
                {
                    this.availabilityField = value;
                    this.OnPropertyChanged("Availability");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AvailabilitySpecified
        {
            get
            {
                return this.availabilityFieldSpecified;
            }
            set
            {
                if ((availabilityFieldSpecified.Equals(value) != true))
                {
                    this.availabilityFieldSpecified = value;
                    this.OnPropertyChanged("AvailabilitySpecified");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public NocorePositionOpeningTypeQualifications Qualifications
        {
            get
            {
                return this.qualificationsField;
            }
            set
            {
                if ((this.qualificationsField != null))
                {
                    if ((qualificationsField.Equals(value) != true))
                    {
                        this.qualificationsField = value;
                        this.OnPropertyChanged("Qualifications");
                    }
                }
                else
                {
                    this.qualificationsField = value;
                    this.OnPropertyChanged("Qualifications");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool QualificationsSpecified
        {
            get
            {
                return this.qualificationsFieldSpecified;
            }
            set
            {
                if ((qualificationsFieldSpecified.Equals(value) != true))
                {
                    this.qualificationsFieldSpecified = value;
                    this.OnPropertyChanged("QualificationsSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("Language", Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<Language> Languages
        {
            get
            {
                return this.languagesField;
            }
            set
            {
                if ((this.languagesField != null))
                {
                    if ((languagesField.Equals(value) != true))
                    {
                        this.languagesField = value;
                        this.OnPropertyChanged("Languages");
                    }
                }
                else
                {
                    this.languagesField = value;
                    this.OnPropertyChanged("Languages");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool LanguagesSpecified
        {
            get
            {
                return this.languagesFieldSpecified;
            }
            set
            {
                if ((languagesFieldSpecified.Equals(value) != true))
                {
                    this.languagesFieldSpecified = value;
                    this.OnPropertyChanged("LanguagesSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
        [System.Xml.Serialization.XmlArrayItemAttribute("LicenseOrCertification", IsNullable = false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<CredentialType> LicensesAndCertifications
        {
            get
            {
                return this.licensesAndCertificationsField;
            }
            set
            {
                if ((this.licensesAndCertificationsField != null))
                {
                    if ((licensesAndCertificationsField.Equals(value) != true))
                    {
                        this.licensesAndCertificationsField = value;
                        this.OnPropertyChanged("LicensesAndCertifications");
                    }
                }
                else
                {
                    this.licensesAndCertificationsField = value;
                    this.OnPropertyChanged("LicensesAndCertifications");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool LicensesAndCertificationsSpecified
        {
            get
            {
                return this.licensesAndCertificationsFieldSpecified;
            }
            set
            {
                if ((licensesAndCertificationsFieldSpecified.Equals(value) != true))
                {
                    this.licensesAndCertificationsFieldSpecified = value;
                    this.OnPropertyChanged("LicensesAndCertificationsSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("SchoolOrInstitution", IsNullable = false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<NocorePositionOpeningTypeSchoolOrInstitution> RequiredEducation
        {
            get
            {
                return this.requiredEducationField;
            }
            set
            {
                if ((this.requiredEducationField != null))
                {
                    if ((requiredEducationField.Equals(value) != true))
                    {
                        this.requiredEducationField = value;
                        this.OnPropertyChanged("RequiredEducation");
                    }
                }
                else
                {
                    this.requiredEducationField = value;
                    this.OnPropertyChanged("RequiredEducation");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool RequiredEducationSpecified
        {
            get
            {
                return this.requiredEducationFieldSpecified;
            }
            set
            {
                if ((requiredEducationFieldSpecified.Equals(value) != true))
                {
                    this.requiredEducationFieldSpecified = value;
                    this.OnPropertyChanged("RequiredEducationSpecified");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public NocoreLocationType Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                if ((this.locationField != null))
                {
                    if ((locationField.Equals(value) != true))
                    {
                        this.locationField = value;
                        this.OnPropertyChanged("Location");
                    }
                }
                else
                {
                    this.locationField = value;
                    this.OnPropertyChanged("Location");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                if ((this.statusField != null))
                {
                    if ((statusField.Equals(value) != true))
                    {
                        this.statusField = value;
                        this.OnPropertyChanged("Status");
                    }
                }
                else
                {
                    this.statusField = value;
                    this.OnPropertyChanged("Status");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Replies")]
        public List<NocorePositionOpeningTypeRepliesType> Replies
        {
            get
            {
                return this.repliesField;
            }
            set
            {
                if ((this.repliesField != null))
                {
                    if ((repliesField.Equals(value) != true))
                    {
                        this.repliesField = value;
                        this.OnPropertyChanged("Replies");
                    }
                }
                else
                {
                    this.repliesField = value;
                    this.OnPropertyChanged("Replies");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool RepliesSpecified
        {
            get
            {
                return this.repliesFieldSpecified;
            }
            set
            {
                if ((repliesFieldSpecified.Equals(value) != true))
                {
                    this.repliesFieldSpecified = value;
                    this.OnPropertyChanged("RepliesSpecified");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nocore.nl/2010-10")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "NocorePositionOpeningTypeQualifications", Namespace = "http://www.nocore.nl/2010-10")]
    public partial class NocorePositionOpeningTypeQualifications : EntityBase<NocorePositionOpeningTypeQualifications>
    {

        private string qualificationSummaryField;

        private List<CompetencyType> competencyField;

        /// <summary>
        /// NocorePositionOpeningTypeQualifications class constructor
        /// </summary>
        public NocorePositionOpeningTypeQualifications()
        {
            this.competencyField = new List<CompetencyType>();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string QualificationSummary
        {
            get
            {
                return this.qualificationSummaryField;
            }
            set
            {
                if ((this.qualificationSummaryField != null))
                {
                    if ((qualificationSummaryField.Equals(value) != true))
                    {
                        this.qualificationSummaryField = value;
                        this.OnPropertyChanged("QualificationSummary");
                    }
                }
                else
                {
                    this.qualificationSummaryField = value;
                    this.OnPropertyChanged("QualificationSummary");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Competency", Namespace = "http://ns.hr-xml.org/2007-04-15")]
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.nocore.nl/2010-10")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "NocorePositionOpeningTypeSchoolOrInstitution", Namespace = "http://www.nocore.nl/2010-10")]
    public partial class NocorePositionOpeningTypeSchoolOrInstitution : SchoolOrInstitutionType
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nocore.nl/2010-10")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.nocore.nl/2010-10", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "NocorePositionOpeningTypeReplies", Namespace = "http://www.nocore.nl/2010-10")]
    public partial class NocorePositionOpeningTypeRepliesType : EntityBase<NocorePositionOpeningTypeRepliesType>
    {

        private List<EntityIdType> humanResourceIdField;
        private string statusField;
        private string remarkField;
        private string replyField;
        private System.DateTime dateField;
        private string sourceField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("HumanResourceId")]
        public List<EntityIdType> HumanResourceId
        {
            get
            {
                return this.humanResourceIdField;
            }
            set
            {
                if ((this.humanResourceIdField != null))
                {
                    if ((humanResourceIdField.Equals(value) != true))
                    {
                        this.humanResourceIdField = value;
                        this.OnPropertyChanged("HumanResourceId");
                    }
                }
                else
                {
                    this.humanResourceIdField = value;
                    this.OnPropertyChanged("HumanResourceId");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                if ((this.statusField != null))
                {
                    if ((statusField.Equals(value) != true))
                    {
                        this.statusField = value;
                        this.OnPropertyChanged("Status");
                    }
                }
                else
                {
                    this.statusField = value;
                    this.OnPropertyChanged("Status");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Remark
        {
            get
            {
                return this.remarkField;
            }
            set
            {
                if ((this.remarkField != null))
                {
                    if ((remarkField.Equals(value) != true))
                    {
                        this.remarkField = value;
                        this.OnPropertyChanged("Remark");
                    }
                }
                else
                {
                    this.remarkField = value;
                    this.OnPropertyChanged("Remark");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reply
        {
            get
            {
                return this.replyField;
            }
            set
            {
                if ((this.replyField != null))
                {
                    if ((replyField.Equals(value) != true))
                    {
                        this.replyField = value;
                        this.OnPropertyChanged("Reply");
                    }
                }
                else
                {
                    this.replyField = value;
                    this.OnPropertyChanged("Reply");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                if ((dateField.Equals(value) != true))
                {
                    this.dateField = value;
                    this.OnPropertyChanged("Date");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                if ((this.sourceField != null))
                {
                    if ((sourceField.Equals(value) != true))
                    {
                        this.sourceField = value;
                        this.OnPropertyChanged("Source");
                    }
                }
                else
                {
                    this.sourceField = value;
                    this.OnPropertyChanged("Source");
                }
            }
        }
    }
}
