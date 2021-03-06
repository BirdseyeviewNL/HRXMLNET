// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.33213
//    <NameSpace>HRXML.Net</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>ASCII</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace HRXML.Net {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute("TimeCardConfiguration", Namespace="http://ns.hr-xml.org/2007-04-15", IsNullable=false)]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeCardConfigurationType", Namespace="http://ns.hr-xml.org/2007-04-15")]
    public partial class TimeCardConfigurationType : EntityBase<TimeCardConfigurationType> {
        
        private TimeCardConfigurationTypeResources resourcesField;
        
        private List<NamedEntityType> timeIntervalTypesField;
        
        private List<NamedEntityType> timeEventTypesField;
        
        private List<NamedEntityType> timeExpenseTypesField;
        
        private List<TimeCardConfigurationTypeAdditionalDataTypesAndValues> additionalDataTypesAndValuesField;
        
        /// <summary>
        /// TimeCardConfigurationType class constructor
        /// </summary>
        public TimeCardConfigurationType() {
            this.additionalDataTypesAndValuesField = new List<TimeCardConfigurationTypeAdditionalDataTypesAndValues>();
            this.timeExpenseTypesField = new List<NamedEntityType>();
            this.timeEventTypesField = new List<NamedEntityType>();
            this.timeIntervalTypesField = new List<NamedEntityType>();
            this.resourcesField = new TimeCardConfigurationTypeResources();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TimeCardConfigurationTypeResources Resources {
            get {
                return this.resourcesField;
            }
            set {
                if ((this.resourcesField != null)) {
                    if ((resourcesField.Equals(value) != true)) {
                        this.resourcesField = value;
                        this.OnPropertyChanged("Resources");
                    }
                }
                else {
                    this.resourcesField = value;
                    this.OnPropertyChanged("Resources");
                }
            }
        }
        
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Type", IsNullable=false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<NamedEntityType> TimeIntervalTypes {
            get {
                return this.timeIntervalTypesField;
            }
            set {
                if ((this.timeIntervalTypesField != null)) {
                    if ((timeIntervalTypesField.Equals(value) != true)) {
                        this.timeIntervalTypesField = value;
                        this.OnPropertyChanged("TimeIntervalTypes");
                    }
                }
                else {
                    this.timeIntervalTypesField = value;
                    this.OnPropertyChanged("TimeIntervalTypes");
                }
            }
        }
        
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Type", IsNullable=false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<NamedEntityType> TimeEventTypes {
            get {
                return this.timeEventTypesField;
            }
            set {
                if ((this.timeEventTypesField != null)) {
                    if ((timeEventTypesField.Equals(value) != true)) {
                        this.timeEventTypesField = value;
                        this.OnPropertyChanged("TimeEventTypes");
                    }
                }
                else {
                    this.timeEventTypesField = value;
                    this.OnPropertyChanged("TimeEventTypes");
                }
            }
        }
        
        [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Type", IsNullable=false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<NamedEntityType> TimeExpenseTypes {
            get {
                return this.timeExpenseTypesField;
            }
            set {
                if ((this.timeExpenseTypesField != null)) {
                    if ((timeExpenseTypesField.Equals(value) != true)) {
                        this.timeExpenseTypesField = value;
                        this.OnPropertyChanged("TimeExpenseTypes");
                    }
                }
                else {
                    this.timeExpenseTypesField = value;
                    this.OnPropertyChanged("TimeExpenseTypes");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDataTypesAndValues", Order=4)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<TimeCardConfigurationTypeAdditionalDataTypesAndValues> AdditionalDataTypesAndValues {
            get {
                return this.additionalDataTypesAndValuesField;
            }
            set {
                if ((this.additionalDataTypesAndValuesField != null)) {
                    if ((additionalDataTypesAndValuesField.Equals(value) != true)) {
                        this.additionalDataTypesAndValuesField = value;
                        this.OnPropertyChanged("AdditionalDataTypesAndValues");
                    }
                }
                else {
                    this.additionalDataTypesAndValuesField = value;
                    this.OnPropertyChanged("AdditionalDataTypesAndValues");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeCardConfigurationTypeResources", Namespace="http://ns.hr-xml.org/2007-04-15")]
    public partial class TimeCardConfigurationTypeResources : EntityBase<TimeCardConfigurationTypeResources> {
        
        private List<TimeCardConfigurationTypeResourcesPerson> personField;
        
        private List<TimeCardConfigurationTypeResourcesResource> resourceField;
        
        /// <summary>
        /// TimeCardConfigurationTypeResources class constructor
        /// </summary>
        public TimeCardConfigurationTypeResources() {
            this.resourceField = new List<TimeCardConfigurationTypeResourcesResource>();
            this.personField = new List<TimeCardConfigurationTypeResourcesPerson>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Person", Order=0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<TimeCardConfigurationTypeResourcesPerson> Person {
            get {
                return this.personField;
            }
            set {
                if ((this.personField != null)) {
                    if ((personField.Equals(value) != true)) {
                        this.personField = value;
                        this.OnPropertyChanged("Person");
                    }
                }
                else {
                    this.personField = value;
                    this.OnPropertyChanged("Person");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Resource", Order=1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<TimeCardConfigurationTypeResourcesResource> Resource {
            get {
                return this.resourceField;
            }
            set {
                if ((this.resourceField != null)) {
                    if ((resourceField.Equals(value) != true)) {
                        this.resourceField = value;
                        this.OnPropertyChanged("Resource");
                    }
                }
                else {
                    this.resourceField = value;
                    this.OnPropertyChanged("Resource");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeCardConfigurationTypeResourcesPerson", Namespace="http://ns.hr-xml.org/2007-04-15")]
    public partial class TimeCardConfigurationTypeResourcesPerson : EntityBase<TimeCardConfigurationTypeResourcesPerson> {
        
        private string idField;
        
        private PersonNameType personNameField;
        
        private List<string> assignmentField;
        
        private string validFromField;
        
        private string validToField;
        
        private string preferredLanguageField;
        
        /// <summary>
        /// TimeCardConfigurationTypeResourcesPerson class constructor
        /// </summary>
        public TimeCardConfigurationTypeResourcesPerson() {
            this.assignmentField = new List<string>();
            this.personNameField = new PersonNameType();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField != null)) {
                    if ((idField.Equals(value) != true)) {
                        this.idField = value;
                        this.OnPropertyChanged("Id");
                    }
                }
                else {
                    this.idField = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PersonNameType PersonName {
            get {
                return this.personNameField;
            }
            set {
                if ((this.personNameField != null)) {
                    if ((personNameField.Equals(value) != true)) {
                        this.personNameField = value;
                        this.OnPropertyChanged("PersonName");
                    }
                }
                else {
                    this.personNameField = value;
                    this.OnPropertyChanged("PersonName");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Assignment", Order=2)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<string> Assignment {
            get {
                return this.assignmentField;
            }
            set {
                if ((this.assignmentField != null)) {
                    if ((assignmentField.Equals(value) != true)) {
                        this.assignmentField = value;
                        this.OnPropertyChanged("Assignment");
                    }
                }
                else {
                    this.assignmentField = value;
                    this.OnPropertyChanged("Assignment");
                }
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string validFrom {
            get {
                return this.validFromField;
            }
            set {
                if ((this.validFromField != null)) {
                    if ((validFromField.Equals(value) != true)) {
                        this.validFromField = value;
                        this.OnPropertyChanged("validFrom");
                    }
                }
                else {
                    this.validFromField = value;
                    this.OnPropertyChanged("validFrom");
                }
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string validTo {
            get {
                return this.validToField;
            }
            set {
                if ((this.validToField != null)) {
                    if ((validToField.Equals(value) != true)) {
                        this.validToField = value;
                        this.OnPropertyChanged("validTo");
                    }
                }
                else {
                    this.validToField = value;
                    this.OnPropertyChanged("validTo");
                }
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string preferredLanguage {
            get {
                return this.preferredLanguageField;
            }
            set {
                if ((this.preferredLanguageField != null)) {
                    if ((preferredLanguageField.Equals(value) != true)) {
                        this.preferredLanguageField = value;
                        this.OnPropertyChanged("preferredLanguage");
                    }
                }
                else {
                    this.preferredLanguageField = value;
                    this.OnPropertyChanged("preferredLanguage");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeCardConfigurationTypeResourcesResource", Namespace="http://ns.hr-xml.org/2007-04-15")]
    public partial class TimeCardConfigurationTypeResourcesResource : EntityBase<TimeCardConfigurationTypeResourcesResource> {
        
        private string idField;
        
        private string resourceNameField;
        
        private string validFromField;
        
        private string validToField;
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField != null)) {
                    if ((idField.Equals(value) != true)) {
                        this.idField = value;
                        this.OnPropertyChanged("Id");
                    }
                }
                else {
                    this.idField = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResourceName {
            get {
                return this.resourceNameField;
            }
            set {
                if ((this.resourceNameField != null)) {
                    if ((resourceNameField.Equals(value) != true)) {
                        this.resourceNameField = value;
                        this.OnPropertyChanged("ResourceName");
                    }
                }
                else {
                    this.resourceNameField = value;
                    this.OnPropertyChanged("ResourceName");
                }
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string validFrom {
            get {
                return this.validFromField;
            }
            set {
                if ((this.validFromField != null)) {
                    if ((validFromField.Equals(value) != true)) {
                        this.validFromField = value;
                        this.OnPropertyChanged("validFrom");
                    }
                }
                else {
                    this.validFromField = value;
                    this.OnPropertyChanged("validFrom");
                }
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string validTo {
            get {
                return this.validToField;
            }
            set {
                if ((this.validToField != null)) {
                    if ((validToField.Equals(value) != true)) {
                        this.validToField = value;
                        this.OnPropertyChanged("validTo");
                    }
                }
                else {
                    this.validToField = value;
                    this.OnPropertyChanged("validTo");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ns.hr-xml.org/2007-04-15", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="NamedEntityType", Namespace="http://ns.hr-xml.org/2007-04-15")]
    public partial class NamedEntityType : EntityBase<NamedEntityType> {
        
        private string idField;
        
        private List<NamedEntityTypeShortDescription> shortDescriptionField;
        
        private List<NamedEntityTypeDescription> descriptionField;
        
        private string validFromField;
        
        private string validToField;
        
        /// <summary>
        /// NamedEntityType class constructor
        /// </summary>
        public NamedEntityType() {
            this.descriptionField = new List<NamedEntityTypeDescription>();
            this.shortDescriptionField = new List<NamedEntityTypeShortDescription>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField != null)) {
                    if ((idField.Equals(value) != true)) {
                        this.idField = value;
                        this.OnPropertyChanged("Id");
                    }
                }
                else {
                    this.idField = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ShortDescription", Order=1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<NamedEntityTypeShortDescription> ShortDescription {
            get {
                return this.shortDescriptionField;
            }
            set {
                if ((this.shortDescriptionField != null)) {
                    if ((shortDescriptionField.Equals(value) != true)) {
                        this.shortDescriptionField = value;
                        this.OnPropertyChanged("ShortDescription");
                    }
                }
                else {
                    this.shortDescriptionField = value;
                    this.OnPropertyChanged("ShortDescription");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Description", Order=2)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<NamedEntityTypeDescription> Description {
            get {
                return this.descriptionField;
            }
            set {
                if ((this.descriptionField != null)) {
                    if ((descriptionField.Equals(value) != true)) {
                        this.descriptionField = value;
                        this.OnPropertyChanged("Description");
                    }
                }
                else {
                    this.descriptionField = value;
                    this.OnPropertyChanged("Description");
                }
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string validFrom {
            get {
                return this.validFromField;
            }
            set {
                if ((this.validFromField != null)) {
                    if ((validFromField.Equals(value) != true)) {
                        this.validFromField = value;
                        this.OnPropertyChanged("validFrom");
                    }
                }
                else {
                    this.validFromField = value;
                    this.OnPropertyChanged("validFrom");
                }
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string validTo {
            get {
                return this.validToField;
            }
            set {
                if ((this.validToField != null)) {
                    if ((validToField.Equals(value) != true)) {
                        this.validToField = value;
                        this.OnPropertyChanged("validTo");
                    }
                }
                else {
                    this.validToField = value;
                    this.OnPropertyChanged("validTo");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NamedEntityTypeShortDescription", Namespace="http://ns.hr-xml.org/2007-04-15")]
    public partial class NamedEntityTypeShortDescription : EntityBase<NamedEntityTypeShortDescription> {
        
        private string langField;
        
        private string valueField;
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lang {
            get {
                return this.langField;
            }
            set {
                if ((this.langField != null)) {
                    if ((langField.Equals(value) != true)) {
                        this.langField = value;
                        this.OnPropertyChanged("lang");
                    }
                }
                else {
                    this.langField = value;
                    this.OnPropertyChanged("lang");
                }
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                if ((this.valueField != null)) {
                    if ((valueField.Equals(value) != true)) {
                        this.valueField = value;
                        this.OnPropertyChanged("Value");
                    }
                }
                else {
                    this.valueField = value;
                    this.OnPropertyChanged("Value");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NamedEntityTypeDescription", Namespace="http://ns.hr-xml.org/2007-04-15")]
    public partial class NamedEntityTypeDescription : EntityBase<NamedEntityTypeDescription> {
        
        private string langField;
        
        private string valueField;
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lang {
            get {
                return this.langField;
            }
            set {
                if ((this.langField != null)) {
                    if ((langField.Equals(value) != true)) {
                        this.langField = value;
                        this.OnPropertyChanged("lang");
                    }
                }
                else {
                    this.langField = value;
                    this.OnPropertyChanged("lang");
                }
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                if ((this.valueField != null)) {
                    if ((valueField.Equals(value) != true)) {
                        this.valueField = value;
                        this.OnPropertyChanged("Value");
                    }
                }
                else {
                    this.valueField = value;
                    this.OnPropertyChanged("Value");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeCardConfigurationTypeAdditionalDataTypesAndValues", Namespace="http://ns.hr-xml.org/2007-04-15")]
    public partial class TimeCardConfigurationTypeAdditionalDataTypesAndValues : EntityBase<TimeCardConfigurationTypeAdditionalDataTypesAndValues> {
        
        private NamedEntityType typeField;
        
        private List<NamedEntityType> valueField;
        
        private TimeCardConfigurationTypeAdditionalDataTypesAndValuesScope scopeField;
        
        private bool scopeFieldSpecified;
        
        /// <summary>
        /// TimeCardConfigurationTypeAdditionalDataTypesAndValues class constructor
        /// </summary>
        public TimeCardConfigurationTypeAdditionalDataTypesAndValues() {
            this.valueField = new List<NamedEntityType>();
            this.typeField = new NamedEntityType();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public NamedEntityType Type {
            get {
                return this.typeField;
            }
            set {
                if ((this.typeField != null)) {
                    if ((typeField.Equals(value) != true)) {
                        this.typeField = value;
                        this.OnPropertyChanged("Type");
                    }
                }
                else {
                    this.typeField = value;
                    this.OnPropertyChanged("Type");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Value", Order=1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<NamedEntityType> Value {
            get {
                return this.valueField;
            }
            set {
                if ((this.valueField != null)) {
                    if ((valueField.Equals(value) != true)) {
                        this.valueField = value;
                        this.OnPropertyChanged("Value");
                    }
                }
                else {
                    this.valueField = value;
                    this.OnPropertyChanged("Value");
                }
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TimeCardConfigurationTypeAdditionalDataTypesAndValuesScope scope {
            get {
                return this.scopeField;
            }
            set {
                if ((scopeField.Equals(value) != true)) {
                    this.scopeField = value;
                    this.OnPropertyChanged("scope");
                }
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool scopeSpecified {
            get {
                return this.scopeFieldSpecified;
            }
            set {
                if ((scopeFieldSpecified.Equals(value) != true)) {
                    this.scopeFieldSpecified = value;
                    this.OnPropertyChanged("scopeSpecified");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ns.hr-xml.org/2007-04-15")]
    public enum TimeCardConfigurationTypeAdditionalDataTypesAndValuesScope {
        
        /// <remarks/>
        TimeInterval,
        
        /// <remarks/>
        TimeEvent,
        
        /// <remarks/>
        TimeExpense,
        
        /// <remarks/>
        TimeIntervalAndTimeEvent,
        
        /// <remarks/>
        TimeIntervalAndTimeExpense,
        
        /// <remarks/>
        TimeEventAndTimeExpense,
        
        /// <remarks/>
        TimeIntervalAndTimeEventAndTimeExpense,
    }
}
