using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRXML.Net;
using System.Globalization;

namespace Birdseyeview.HRXML.SampleNocore
{
    partial class Program
    {
        private static void DoCV()
        {
            ResumeType r = new ResumeType();

            //r.DistributionGuidelines = new DistributionGuidelinesType();
            //r.DistributionGuidelines.DistributeTo = new List<DistributionGuidelinesTypeDistributeTo>();

            //DistributionGuidelinesTypeDistributeTo dis = new DistributionGuidelinesTypeDistributeTo();
            //dis.Id = CreateEntityIdType();

            //dis.ContactMethod = new List<ContactMethodType>();

            //ContactMethodType m = CreateContactMethodType();
            //dis.ContactMethod.Add(m);

            //dis.Name = "Bert Zingemans";
            //dis.validFrom = GetDateTime();
            //dis.validTo = "2011-12-31";

            //r.DistributionGuidelines.DistributeTo.Add(dis);

            r.lang = "nl";
            r.ResumeId = CreateEntityIdType();

            r.StructuredXMLResume = new StructuredXMLResumeType();

            //r.StructuredXMLResume.Achievements = new List<AchievementType>();
            //r.StructuredXMLResume.Achievements.Add(CreateAchievementType());

            //r.StructuredXMLResume.Associations = new List<Association>();
            //r.StructuredXMLResume.Associations.Add(CreateAssociation());

            r.StructuredXMLResume.Comments = "Commentaar";
            r.StructuredXMLResume.ContactInfo = CreateSEPContactInfoType();

            r.StructuredXMLResume.EducationHistory = new List<EducationHistoryTypeSchoolOrInstitution>();
            EducationHistoryTypeSchoolOrInstitution e = CreateEducationHistoryTypeSchoolOrInstitution();
            r.StructuredXMLResume.EducationHistory.Add(e);

            r.StructuredXMLResume.EmploymentHistory = new List<EmployerOrgDataType>();
            EmployerOrgDataType eh = CreateEmployerOrgDataType();
            r.StructuredXMLResume.EmploymentHistory.Add(eh);

            r.StructuredXMLResume.ExecutiveSummary = "ExecutiveSummary";

            r.StructuredXMLResume.Languages = new List<Language>();
            Language l = CreateLanguage("nl", "Nederlands");
            r.StructuredXMLResume.Languages.Add(l);
            l = CreateLanguage("de", "Duits");
            r.StructuredXMLResume.Languages.Add(l);

            //r.StructuredXMLResume.LicensesAndCertifications = new List<CredentialType>();
            //CredentialType ct = CreateCredentialType();
            //r.StructuredXMLResume.LicensesAndCertifications.Add(ct);

            //r.StructuredXMLResume.MilitaryHistory = new MilitaryHistoryType();
            //r.StructuredXMLResume.MilitaryHistory.Comments = "Commentaar";
            //r.StructuredXMLResume.MilitaryHistory.CountryServed = "NL";
            //r.StructuredXMLResume.MilitaryHistory.ServiceDetail = new List<MilitaryHistoryTypeServiceDetail>();
            //MilitaryHistoryTypeServiceDetail mt = CreateMilitaryHistoryTypeServiceDetail();
            //r.StructuredXMLResume.MilitaryHistory.ServiceDetail.Add(mt);

            //r.StructuredXMLResume.PatentHistory = new List<PatentDescriptionType>();
            //PatentDescriptionType pdt = CreatePatentDescriptionType();
            //r.StructuredXMLResume.PatentHistory.Add(pdt);

            //r.StructuredXMLResume.ProfessionalAssociations = new List<string>();
            //r.StructuredXMLResume.ProfessionalAssociations.Add("ProfessionalAssociations1");
            //r.StructuredXMLResume.ProfessionalAssociations.Add("ProfessionalAssociations2");

            //PublicationHistoryType pht = CreatePublicationHistoryType();

            r.StructuredXMLResume.Qualifications = new StructuredXMLResumeTypeQualifications();
            r.StructuredXMLResume.Qualifications.Competency = new List<CompetencyType>();
            CompetencyType ct2 = CreateCompetencyType();
            r.StructuredXMLResume.Qualifications.Competency.Add(ct2);
            r.StructuredXMLResume.Qualifications.QualificationSummary = "QualificationSummary";


            //r.StructuredXMLResume.References = new List<ReferenceType>();
            //ReferenceType rt = CreateReferenceType();
            //r.StructuredXMLResume.References.Add(rt);

            //r.StructuredXMLResume.SpeakingEventsHistory = new List<SpeakingEventType>();
            //SpeakingEventType set = CreateSpeakingEventType();
            //r.StructuredXMLResume.SpeakingEventsHistory.Add(set);

            //r.StructuredXMLResume.SecurityCredentials = new List<CredentialType>();
            //CredentialType cdt = new CredentialType();

            //cdt.Description = "Omschrijving";

            //cdt.EffectiveDate = new CredentialTypeEffectiveDate();
            //cdt.EffectiveDate.FirstIssuedDate = CreateFlexibleDatesType();
            //cdt.EffectiveDate.ValidFrom = CreateFlexibleDatesType(); ;
            //cdt.EffectiveDate.ValidTo = CreateFlexibleDatesType();

            //cdt.Id = "Id";
            //cdt.IssuingAuthority = new IssuingAuthorityType();
            //cdt.IssuingAuthority.countryCode = "NL";
            //cdt.IssuingAuthority.Value = "value";
            //cdt.Name = "Name";

            //r.StructuredXMLResume.SecurityCredentials.Add(cdt);

            //r.StructuredXMLResume.ResumeAdditionalItems = new List<AdditionalItemType>();
            //AdditionalItemType a = CreateAdditionalItemType();
            //r.StructuredXMLResume.ResumeAdditionalItems.Add(a);

            r.StructuredXMLResume.RevisionDate = GetDateTime();

            r.UserArea = new UserAreaType();
            r.UserArea.NocoreResume = CreateNocoreResume();
            r.UserArea.NocoreResumeSpecified = true;


            r.SaveToFile("resume.xml");
        }

        private static NocoreResumeType CreateNocoreResume()
        {
            NocoreResumeType n = new NocoreResumeType();

            n.Availability = new List<AvailibilityType>();
            AvailibilityType a = new AvailibilityType();
            a.AvailabilityStatus = AvailabilityStatusType.Available;
            a.DayOfWeek = DayOfWeekType.Monday;
            a.PartOfDay = PartOfDayType.Afternoon;
            n.Availability.Add(a);
            a = new AvailibilityType();
            a.AvailabilityStatus = AvailabilityStatusType.Available;
            a.DayOfWeek = DayOfWeekType.Wednesday;
            a.PartOfDay = PartOfDayType.Morning;
            n.Availability.Add(a);


            n.DesiredWork = new DesiredWorkType();
            n.DesiredWork.Description = "Putjesschepper";
            n.DesiredWork.Items = new List<StructuredDesiredWorkType>();
            StructuredDesiredWorkType s = new StructuredDesiredWorkType();
            s.DesiredWork = "DesiredWork";

            EntityIdType desiredWorkId = CreateEntityIdType();

            s.DesiredWorkId.Add(desiredWorkId);
            n.DesiredWork.Items.Add(s);

            return n;
        }

        private static SpeakingEventType CreateSpeakingEventType()
        {
            SpeakingEventType set = new SpeakingEventType();
            set.AffiliatedOrganization = new List<string>();
            set.AffiliatedOrganization.Add("NoCore");
            set.Description = "Omschrijving";
            set.EndDate = CreateFlexibleDatesType();
            set.EventName = "Eventname";

            //<xsd:enumeration value="convention"/>
            //<xsd:enumeration value="rally"/>
            //<xsd:enumeration value="conference"/>
            //<xsd:enumeration value="sales meeting"/>
            //<xsd:enumeration value="television show"/>
            //<xsd:enumeration value="radio show"/>
            //<xsd:enumeration value="web-based"/>

            set.EventType = "convention";
            set.Link = "http://www.nocore.nl";
            set.Location = "Uden";
            set.Role = "Speaker";
            set.StartDate = CreateFlexibleDatesType();
            set.Title = "title";

            //<xsd:enumeration value="speech"/>
            //<xsd:enumeration value="presentation"/>
            //<xsd:enumeration value="demonstration"/>
            //<xsd:enumeration value="interview"/>
            //<xsd:enumeration value="debate"/>
            //<xsd:enumeration value="panel discussion"/>

            set.type = "debate";
            return set;
        }

        private static CredentialType CreateCredentialType()
        {
            CredentialType ct = new CredentialType();
            ct.Description = "Omschrijving";

            ct.EffectiveDate = new CredentialTypeEffectiveDate();
            ct.EffectiveDate.FirstIssuedDate = CreateFlexibleDatesType();
            ct.EffectiveDate.ValidFrom = CreateFlexibleDatesType();
            ct.EffectiveDate.ValidTo = CreateFlexibleDatesType();

            ct.Id = "id";
            ct.IssuingAuthority = new IssuingAuthorityType();
            ct.IssuingAuthority.countryCode = "NL";
            ct.IssuingAuthority.Value = "NoCore";

            ct.Name = "Name";
            return ct;
        }

        private static MilitaryHistoryTypeServiceDetail CreateMilitaryHistoryTypeServiceDetail()
        {
            MilitaryHistoryTypeServiceDetail mt = new MilitaryHistoryTypeServiceDetail();
            mt.AreaOfExpertise = new List<string>();
            mt.AreaOfExpertise.Add("Putjes scheppen");
            mt.AreaOfExpertise.Add("Putjes dichtmaken");
            mt.branch = "Branch";
            mt.Campaign = new List<string>();
            mt.Campaign.Add("Campaign1");
            mt.Campaign.Add("Campaign2");
            mt.DatesOfService = new DatesOfServiceType();
            mt.DatesOfService.EndDate = CreateFlexibleDatesType();
            mt.DatesOfService.StartDate = CreateFlexibleDatesType();

            mt.DischargeStatus = "Kuil gegraven voor een ander";
            mt.DisciplinaryAction = new List<string>();
            mt.DisciplinaryAction.Add("Slaan");
            mt.DisciplinaryAction.Add("vierendelen");

            mt.RankAchieved = new RankAchievedType();
            mt.RankAchieved.CurrentOrEndRank = "Kolonel";
            mt.RankAchieved.StartRank = "hopeloos geval";

            mt.RecognitionAchieved = new List<string>();
            mt.RecognitionAchieved.Add("Niets");
            mt.RecognitionAchieved.Add("Noppes");

            mt.UnitOrDivision = "UnitOrDivision";

            return mt;
        }

        private static AdditionalItemType CreateAdditionalItemType()
        {
            AdditionalItemType a = new AdditionalItemType();

            a.Description = new List<string>();
            a.Description.Add("Omschrijving");

            a.EffectiveDate = new AdditionalItemTypeEffectiveDate();
            a.EffectiveDate.EndDate = CreateFlexibleDatesType();
            a.EffectiveDate.StartDate = CreateFlexibleDatesType();

            //<xsd:enumeration value="Activities"/>
            //<xsd:enumeration value="Interests"/>
            //<xsd:enumeration value="Personal"/>
            //<xsd:enumeration value="Community"/>
            //<xsd:enumeration value="Hobbies"/>
            //<xsd:enumeration value="Volunteer"/>


            a.type = "Personal";

            return a;
        }

        private static ReferenceType CreateReferenceType()
        {
            ReferenceType r = new ReferenceType();

            r.Comments = "Commentaar";

            r.ContactMethod = new List<ContactMethodType>();
            ContactMethodType m = CreateContactMethodType();
            r.ContactMethod.Add(m);

            var personName = new PersonNameType();
            SetName(personName, "", "Jansen", "Jan", "Jan");

            r.PersonName = personName;

            r.PositionTitle = "PositionTitle";

            //<xsd:enumeration value="Professional"/>
            //<xsd:enumeration value="Personal"/>
            //<xsd:enumeration value="Verification"/>

            r.type = "Personal";
            return r;
        }

        private static Language CreateLanguage(string code, string comments)
        {
            Language l = new Language();
            l.LanguageCode = code;
            l.Read = true;
            l.ReadSpecified = true;
            l.Write = true;
            l.WriteSpecified = true;
            l.Speak = true;
            l.SpeakSpecified = true;
            l.Comments = comments;
            return l;
        }

        private static StructuredXMLResumeTypeQualifications CreateStructuredXMLResumeTypeQualifications()
        {
            StructuredXMLResumeTypeQualifications q = new StructuredXMLResumeTypeQualifications();

            q.Competency = new List<CompetencyType>();
            CompetencyType c = CreateCompetencyType();
            q.Competency.Add(c);

            q.QualificationSummary = "QualificationSummary";
            return q;
        }

        private static PublicationHistoryType CreatePublicationHistoryType()
        {
            PublicationHistoryType pht = new PublicationHistoryType();

            pht.Article = new List<ArticleType>();
            ArticleType at = new ArticleType();
            at.Abstract = "Abstract";
            at.Comments = "Commentaar";

            at.Copyright = new CopyrightType();
            at.Copyright.CopyrightDates = new CopyrightTypeCopyrightDates();
            at.Copyright.CopyrightDates.MostRecentDate = CreateFlexibleDatesType();
            at.Copyright.CopyrightDates.OriginalDate = CreateFlexibleDatesType();
            at.Copyright.CopyrightText = "Copyright";

            at.ISSN = "ISSN";
            at.Issue = "Issue";
            at.JournalOrSerialName = "Journal";
            at.Link = new List<string>();
            at.Link.Add("http://www.nocore.nl");
            at.Name = new List<BasicBibliographicRecordTypeName>();

            BasicBibliographicRecordTypeName bn = new BasicBibliographicRecordTypeName();

            bn.Affix = new List<PersonNameTypeAffix>();
            PersonNameTypeAffix af = new PersonNameTypeAffix();
            af.type = PersonNameTypeAffixType.aristocraticTitle;
            af.Value = "Koning";
            bn.Affix.Add(af);

            bn.AlternateScript = new List<PersonNameTypeAlternateScript>();

            PersonNameTypeAlternateScript ps = new PersonNameTypeAlternateScript();
            ps.Affix = new List<PersonNameTypeAlternateScriptAffix>();
            PersonNameTypeAlternateScriptAffix afa = new PersonNameTypeAlternateScriptAffix();
            afa.type = PersonNameTypeAlternateScriptAffixType.generation;
            afa.Value = "Oud geld";
            ps.Affix.Add(afa);

            ps.FamilyName = new List<PersonNameTypeAlternateScriptFamilyName>();
            PersonNameTypeAlternateScriptFamilyName fam = new PersonNameTypeAlternateScriptFamilyName();
            fam.prefix = "prefix";
            fam.primary = PersonNameTypeAlternateScriptFamilyNamePrimary.@true;
            fam.primarySpecified = true;
            fam.Value = "value";
            ps.FamilyName.Add(fam);

            ps.FormattedName = "Formatted name";
            ps.GivenName = new List<string>();
            ps.GivenName.Add("Givenname1");
            ps.GivenName.Add("Givenname2");
            ps.LegalName = "LegalName";
            ps.MiddleName = "MiddleName";
            ps.PreferredGivenName = "Givenname1";
            ps.script = "script";

            bn.AlternateScript.Add(ps);

            bn.FamilyName = new List<PersonNameTypeFamilyName>();
            PersonNameTypeFamilyName ptfm = new PersonNameTypeFamilyName();

            ptfm.prefix = "prefix";
            ptfm.primary = PersonNameTypeFamilyNamePrimary.@true;
            ptfm.primarySpecified = true;
            ptfm.Value = "Value";
            bn.FamilyName.Add(ptfm);

            bn.FormattedName = "Formatted name";
            bn.GivenName = new List<string>();
            bn.GivenName.Add("Givenname1");
            bn.GivenName.Add("Givenname2");
            bn.LegalName = "legalname";
            bn.MiddleName = "middlename";
            bn.PreferredGivenName = "Givenname1";
            bn.role = "role";
            bn.script = "script";

            at.Name.Add(bn);

            at.PageNumber = "1";
            at.PublicationDate = CreateFlexibleDatesType();
            at.PublicationLanguage = "nl";
            at.Title = "Title";
            at.Volume = "Volume";

            pht.Article.Add(at);

            return pht;
        }

        private static PatentDescriptionType CreatePatentDescriptionType()
        {
            PatentDescriptionType pdt = new PatentDescriptionType();
            pdt.Description = "Omschrijving";
            pdt.Inventors = new List<string>();
            pdt.Inventors.Add("iets1");
            pdt.Inventors.Add("iets2");

            pdt.Link = "http://www.nocore.nl";

            pdt.PatentDetail = new List<PatentDescriptionTypePatentDetail>();
            PatentDescriptionTypePatentDetail pdpd = new PatentDescriptionTypePatentDetail();
            pdpd.IssuingAuthority = new PatentDescriptionTypePatentDetailIssuingAuthority();
            pdpd.IssuingAuthority.countryCode = "NL";
            pdpd.IssuingAuthority.Value = "value";
            pdt.PatentDetail.Add(pdpd);

            pdpd.PatentMilestone = new List<PatentDescriptionTypePatentDetailPatentMilestone>();
            PatentDescriptionTypePatentDetailPatentMilestone pdh = new PatentDescriptionTypePatentDetailPatentMilestone();
            pdh.Date = GetDateTime();
            pdh.Id = "id";

            //<xsd:enumeration value="PatentIssued"/>
            //<xsd:enumeration value="PatentPending"/>
            //<xsd:enumeration value="PatentFiled"/>

            pdh.Status = "PatentIssued";
            pdpd.PatentMilestone.Add(pdh);

            pdt.PatentTitle = "Title";
            return pdt;
        }

        private static EmployerOrgDataType CreateEmployerOrgDataType()
        {
            EmployerOrgDataType e = new EmployerOrgDataType();

            // e.EmployerContactInfo = CreateEmpContactInfoType();
            e.EmployerOrgName = "Werkgever A";

            //<xsd:enumeration value="soleEmployer"/>
            //<xsd:enumeration value="agent"/>
            //<xsd:enumeration value="broker"/>
            //<xsd:enumeration value="self"/>

            e.employerOrgType = "soleEmployer";
            e.PositionHistory = new List<EmployerOrgDataTypePositionHistory>();
            EmployerOrgDataTypePositionHistory eh = CreateEmployerOrgDataTypePositionHistory();
            e.PositionHistory.Add(eh);

            return e;
        }

        private static EmployerOrgDataTypePositionHistory CreateEmployerOrgDataTypePositionHistory()
        {
            EmployerOrgDataTypePositionHistory e = new EmployerOrgDataTypePositionHistory();

            // e.Comments = "Commentaar";
            //e.Compensation = CreatePositionCompensationType();

            //e.Competency = new List<CompetencyType>();
            //CompetencyType ct = CreateCompetencyType();
            //e.Competency.Add(ct);

            //e.currentEmployer = true;
            //e.currentEmployerSpecified = true;

            //<xsd:enumeration value="directHire"/>
            //<xsd:enumeration value="contract"/>
            //<xsd:enumeration value="temp"/>
            //<xsd:enumeration value="contractToHire"/>
            //<xsd:enumeration value="tempToHire"/>
            //<xsd:enumeration value="volunteer"/>
            //<xsd:enumeration value="internship"/>


            // e.positionType = "contract";
            e.StartDate = CreateFlexibleDatesType();

            e.Description = "Omschrijving";
            e.EndDate = CreateFlexibleDatesType();


            //e.JobCategory = new List<OccupationalCategoryType>();
            //OccupationalCategoryType oct = new OccupationalCategoryType();
            //oct.CategoryCode = "1";
            //oct.CategoryDescription = "Omschrijving";
            //oct.Comments = "Commentaar";
            //oct.TaxonomyName = new OccupationalCategoryTypeTaxonomyName();
            //oct.TaxonomyName.Value = "Value";
            //oct.TaxonomyName.version = "version";

            //e.JobCategory.Add(oct);

            //e.JobLevelInfo = new List<JobLevelInfoType>();
            //JobLevelInfoType jlt = new JobLevelInfoType();
            //jlt.Comments = "Commentaar";
            //jlt.JobGrade = "JobGrade";
            //jlt.JobPlan = "JobPlan";
            //jlt.JobStep = "JobStep";
            //e.JobLevelInfo.Add(jlt);

            //e.OrgIndustry = new List<PositionOrgIndustryType>();
            //PositionOrgIndustryType pt = new PositionOrgIndustryType();
            //pt.IndustryCode = new PositionOrgIndustryTypeIndustryCode();
            //pt.IndustryCode.classificationName = "classificationName";
            //pt.IndustryCode.Value = "value";
            //pt.IndustryDescription = "Omschrijving";
            //pt.primaryIndicator = true;
            //e.OrgIndustry.Add(pt);

            //e.OrgInfo = new List<PositionOrgInfoType>();
            //PositionOrgInfoType poit = new PositionOrgInfoType();
            //poit.LocationSummary = CreateEmploymentLocationSummaryType();
            //poit.PositionLocation = CreatePostalAddressType();
            //poit.WebSite = "http://www.nocore.nl";
            //e.OrgInfo.Add(poit);

            e.OrgName = new PositionOrgNameType();
            e.OrgName.OrganizationName = "Circus";
            e.OrgName.organizationType = "soleEmployer";

            //e.OrgSize = "100";
            //e.Title = "Title";

            //e.Verification = new VerificationType();

            //e.Verification.AttendanceRating = new RatingType();
            //RatingTypeStringValue r2 = new RatingTypeStringValue();
            //r2.description = "Bad";
            //r2.Value = "Bad";
            //e.Verification.AttendanceRating.Item = r2;


            //e.Verification.ContactInfo = new VerificationTypeContactInfo();
            //e.Verification.ContactInfo.ContactMethod = new List<ContactMethodType>();
            //ContactMethodType m = CreateContactMethodType();
            //e.Verification.ContactInfo.ContactMethod.Add(m);

            //var personName = new PersonNameType();
            //SetName(personName, "", "Jansen", "Jan", "Jan");
            //e.Verification.ContactInfo.PersonName = personName;

            //e.Verification.EligibleForRehire = true;
            //e.Verification.EligibleForRehireSpecified = true;

            //e.Verification.OverallPerformanceRating = new RatingType();
            //e.Verification.OverallPerformanceRating.Item = new RatingTypeStringValue();
            //RatingTypeStringValue r = new RatingTypeStringValue();
            //r.description = "Bad";
            //r.Value = "Bad";
            //e.Verification.OverallPerformanceRating.Item = r;


            //e.Verification.PermissionToContact = true;
            //e.Verification.PermissionToContactSpecified = true;

            //e.Verification.QuestionAnswerPair = new List<EmploymentQuestionAnswerPairType>();
            //EmploymentQuestionAnswerPairType eq = new EmploymentQuestionAnswerPairType();
            //eq.Answer = "Ja";
            //eq.Question = "Lust je een hamburger";
            //e.Verification.QuestionAnswerPair.Add(eq);

            //e.Verification.ReasonForLeaving = "Was het zat";

            //e.Verification.VerifyEmployment = true;
            //e.Verification.VerifyEmploymentSpecified = true;

            return e;
        }

        private static CompetencyType CreateCompetencyType()
        {
            CompetencyType c = new CompetencyType();

            //c.Competency = new List<CompetencyType>();
            //CompetencyType ct = CreateSubCompetencyType();
            //c.Competency.Add(ct);

            //c.CompetencyEvidence = new List<CompetencyTypeCompetencyEvidence>();
            //CompetencyTypeCompetencyEvidence ctce = CreateCompetencyTypeCompetencyEvidence();
            //c.CompetencyEvidence.Add(ctce);

            c.CompetencyId = CreateCompetencyTypeCompetencyId();

            c.CompetencyWeight = new List<CompetencyTypeCompetencyWeight>();
            CompetencyTypeCompetencyWeight cw = CreateCompetencyTypeCompetencyWeight();
            c.CompetencyWeight.Add(cw);

            c.description = "Omschrijving";
            c.name = "CompetencyType Naam";
            c.required = true;
            c.requiredSpecified = true;

            //c.TaxonomyId = new List<CompetencyTypeTaxonomyId>();
            //CompetencyTypeTaxonomyId ctt = CreateCompetencyTypeTaxonomyId();
            //c.TaxonomyId.Add(ctt);


            return c;
        }

        private static CompetencyTypeTaxonomyId CreateCompetencyTypeTaxonomyId()
        {
            CompetencyTypeTaxonomyId c = new CompetencyTypeTaxonomyId();

            c.description = "Omschrijving";
            c.id = "id";
            c.idOwner = "Owner";

            return c;
        }

        private static CompetencyTypeCompetencyWeight CreateCompetencyTypeCompetencyWeight()
        {
            CompetencyTypeCompetencyWeight c = new CompetencyTypeCompetencyWeight();

            StringValue s = new StringValue();
            s.description = "Omschrijving";
            s.Value = "Item";

            NumericValueType n = new NumericValueType();
            n.Value = 1.8;
            c.Item = n;

            //c.SupportingInformation = new List<string>();
            //c.SupportingInformation.Add("SupportingInformation1");
            //c.SupportingInformation.Add("SupportingInformation2");

            // levelOfInterest
            // skillLevel

            c.type = "skillLevel";

            return c;
        }

        private static CompetencyTypeCompetencyId CreateCompetencyTypeCompetencyId()
        {
            CompetencyTypeCompetencyId c = new CompetencyTypeCompetencyId();

            c.description = "Omschrijving";
            c.id = "Id";
            c.idOwner = "Owner";

            return c;
        }

        private static CompetencyTypeCompetencyEvidence CreateCompetencyTypeCompetencyEvidence()
        {
            CompetencyTypeCompetencyEvidence c = new CompetencyTypeCompetencyEvidence();

            c.dateOfIncident = GetDateTime();

            c.EvidenceId = new CompetencyTypeCompetencyEvidenceEvidenceId();
            c.EvidenceId.description = "Omschrijving";
            c.EvidenceId.id = "id";
            c.EvidenceId.idOwner = "Owner";

            c.expirationDate = GetDateTime();
            c.expirationDate = "2011-12-31";

            StringValue s = new StringValue();
            s.description = "Omschrijving";
            s.Value = "Item";
            c.Item = s;
            c.lastUsed = GetDateTime();
            c.name = "Name";
            c.required = true;
            c.requiredSpecified = true;
            c.SupportingInformation = new List<string>();
            c.SupportingInformation.Add("SupportingInformation1");
            c.SupportingInformation.Add("SupportingInformation2");
            c.typeDescription = "typeDescription";
            c.typeId = "typeid";


            return c;
        }

        private static CompetencyType CreateSubCompetencyType()
        {
            CompetencyType c = new CompetencyType();

            c.CompetencyEvidence = new List<CompetencyTypeCompetencyEvidence>();
            CompetencyTypeCompetencyEvidence ctce = CreateCompetencyTypeCompetencyEvidence();
            c.CompetencyEvidence.Add(ctce);

            c.CompetencyId = CreateCompetencyTypeCompetencyId();

            c.CompetencyWeight = new List<CompetencyTypeCompetencyWeight>();
            CompetencyTypeCompetencyWeight cw = CreateCompetencyTypeCompetencyWeight();
            c.CompetencyWeight.Add(cw);

            c.description = "Omschrijving";
            c.name = "CompetencyType Naam";
            c.required = true;
            c.requiredSpecified = true;

            c.TaxonomyId = new List<CompetencyTypeTaxonomyId>();
            CompetencyTypeTaxonomyId ctt = CreateCompetencyTypeTaxonomyId();
            c.TaxonomyId.Add(ctt);

            return c;
        }

        private static PositionCompensationType CreatePositionCompensationType()
        {
            PositionCompensationType p = new PositionCompensationType();

            p.Comments = "Commentaar";
            p.EndingCompensation = new PositionCompensationTypeEndingCompensation();
            p.EndingCompensation.currency = "EUR";
            p.EndingCompensation.intervalType = "monthly";
            p.EndingCompensation.validFrom = "2011-01-01";
            p.EndingCompensation.validTo = "2011-12-31";
            p.EndingCompensation.Value = "1000,00";

            p.OtherCompensation = new List<PositionCompensationTypeOtherCompensation>();
            PositionCompensationTypeOtherCompensation po = new PositionCompensationTypeOtherCompensation();
            po.type = "Reis";
            po.validFrom = "2011-01-01";
            po.validTo = "2011-12-31";
            po.Value = "100,00";
            p.OtherCompensation.Add(po);

            p.StartingCompensation = new PositionCompensationTypeStartingCompensation();
            p.StartingCompensation.currency = "EUR";
            p.StartingCompensation.intervalType = "monthly";
            p.StartingCompensation.validFrom = "2011-01-01";
            p.StartingCompensation.validTo = "2011-12-31";
            p.StartingCompensation.Value = "800,00";

            return p;
        }

        private static EmpContactInfoType CreateEmpContactInfoType()
        {
            EmpContactInfoType e = new EmpContactInfoType();

            e.ContactMethod = new List<ContactMethodType>();
            ContactMethodType m = CreateContactMethodType();
            e.ContactMethod.Add(m);

            e.contactType = "Contacttype";

            e.InternetDomainName = new List<InternetDomainNameType>();
            InternetDomainNameType i = CreateInternetDomainNameType();
            e.InternetDomainName.Add(i);

            e.LocationSummary = CreateEmploymentLocationSummaryType();

            var personName = new PersonNameType();
            SetName(personName, "", "Jansen", "Jan", "Jan");
            e.PersonName = personName;

            return e;
        }

        private static EmploymentLocationSummaryType CreateEmploymentLocationSummaryType()
        {
            EmploymentLocationSummaryType e = new EmploymentLocationSummaryType();

            e.CountryCode = "NL";
            e.Municipality = "Uden";
            e.PostalCode = "1111 AA";

            e.Region = new List<string>();
            e.Region.Add("Region 1");

            return e;
        }

        private static EducationHistoryTypeSchoolOrInstitution CreateEducationHistoryTypeSchoolOrInstitution()
        {
            EducationHistoryTypeSchoolOrInstitution e = new EducationHistoryTypeSchoolOrInstitution();

            //e.Comments = "Commentaar";
            e.DatesOfAttendance = CreateDeprecatedDatesOfAttendanceType();

            //e.Degree = new List<SchoolOrInstitutionTypeDegree>();
            //SchoolOrInstitutionTypeDegree s = CreateSchoolOrInstitutionTypeDegree();
            //e.Degree.Add(s);

            //e.ISCEDInstitutionClassification = ISCEDInstitutionClassificationType.Item0;
            //e.ISCEDInstitutionClassificationSpecified = true;

            //e.LocalInstitutionClassification = new List<ClassificationType>();
            //ClassificationType ct = CreateClassificationType();
            //e.LocalInstitutionClassification.Add(ct);

            //e.LocationSummary = new SchoolOrInstitutionTypeLocationSummary();
            //e.LocationSummary.CountryCode = "NL";
            //e.LocationSummary.Municipality = "Uden";

            e.Major = new List<string>();
            e.Major.Add("HBO Electro");

            //e.Measure = CreateEduMeasureType();

            //e.OrganizationUnit = new List<SchoolOrInstitutionTypeOrganizationUnit>();
            //SchoolOrInstitutionTypeOrganizationUnit s2 = CreateSchoolOrInstitutionTypeOrganizationUnit();
            //e.OrganizationUnit.Add(s2);

            //e.PostalAddress = CreatePostalAddressType();

            //e.School = new List<SchoolDataType>();
            //SchoolDataType s3 = CreateSchoolDataType();
            //e.School.Add(s3);

            //e.SchoolName = "SchoolName";

            //<xsd:enumeration value="highschool"/>
            //<xsd:enumeration value="secondary"/>
            //<xsd:enumeration value="trade"/>
            //<xsd:enumeration value="community"/>
            //<xsd:enumeration value="college"/>
            //<xsd:enumeration value="university"/>

            e.schoolType = "university";

            return e;
        }

        private static InternetDomainNameType CreateInternetDomainNameType()
        {
            InternetDomainNameType i = new InternetDomainNameType();
            i.primaryIndicator = true;
            i.primaryIndicatorSpecified = true;
            i.Value = "Value";
            return i;
        }

        private static SchoolDataType CreateSchoolDataType()
        {
            SchoolDataType s = new SchoolDataType();

            s.InternetDomainName = new List<InternetDomainNameType>();
            InternetDomainNameType i = CreateInternetDomainNameType();
            s.InternetDomainName.Add(i);

            s.SchoolId = new List<EntityIdType>();
            EntityIdType id = CreateEntityIdType();
            s.SchoolId.Add(id);

            s.SchoolName = "School";

            s.type = SchoolTypeType.prior;
            s.typeSpecified = true;

            return s;
        }

        private static PostalAddressType CreatePostalAddressType()
        {
            PostalAddressType postalAddress = new PostalAddressType();
            // landcode van Nederland in ISO2
            postalAddress.CountryCode = "NL";

            // nieuw HR-XML PostalAddressTypeDeliveryAddress object

            PostalAddressTypeDeliveryAddress deliveryAddress = new PostalAddressTypeDeliveryAddress();
            // eigenschappen op object plakken
            deliveryAddress.StreetName = "Groeneweg";
            deliveryAddress.BuildingNumber = "21";
            deliveryAddress.Unit = "Z";
            deliveryAddress.AddressLine.Add("Groeneweg 21Z");
            postalAddress.DeliveryAddress = deliveryAddress;
            postalAddress.PostalCode = "3981 CK";
            // type = streetAddress = Huisadres
            postalAddress.type = PostalAddressTypeType.streetAddress;
            postalAddress.typeSpecified = true;
            return postalAddress;
        }

        private static SchoolOrInstitutionTypeOrganizationUnit CreateSchoolOrInstitutionTypeOrganizationUnit()
        {
            SchoolOrInstitutionTypeOrganizationUnit s = new SchoolOrInstitutionTypeOrganizationUnit();

            s.attendanceStatus = SchoolOrInstitutionTypeOrganizationUnitAttendanceStatus.prior;
            s.attendanceStatusSpecified = true;

            s.organizationType = "organizationType";
            s.Value = "Value";

            return s;
        }

        private static EduMeasureType CreateEduMeasureType()
        {
            EduMeasureType e = new EduMeasureType();

            e.MeasureSystem = "MeasureSystem";
            e.measureType = "measureType";
            e.MeasureValue = "MeasureValue";

            return e;
        }

        private static SchoolOrInstitutionTypeDegree CreateSchoolOrInstitutionTypeDegree()
        {
            SchoolOrInstitutionTypeDegree s = new SchoolOrInstitutionTypeDegree();

            s.Comments = "Commentaar";

            s.DatesOfAttendance = new List<DatesOfAttendanceType>();
            DatesOfAttendanceType d = CreateDatesOfAttendanceType();
            s.DatesOfAttendance.Add(d);

            s.DegreeClassification = new List<ClassificationType>();
            ClassificationType c = CreateClassificationType();
            s.DegreeClassification.Add(c);

            s.DegreeDate = CreateFlexibleDatesType();

            s.DegreeMajor = new List<MajorType>();
            MajorType ma = CreateMajorType();
            s.DegreeMajor.Add(ma);

            s.DegreeMeasure = CreateEducationalMeasureType();
            s.DegreeMinor = new List<MinorType>();
            MinorType mi = CreateMinorType();
            s.DegreeMinor.Add(mi);

            s.DegreeName = CreateEduDegreeTypeDegreeName();

            s.degreeType = "DegreeType";
            s.examPassed = false;
            s.examPassedSpecified = true;

            s.graduatingDegree = GraduatingDegreeType.graduating;
            s.graduatingDegreeSpecified = true;

            s.OtherHonors = new List<EduDegreeTypeOtherHonors>();
            EduDegreeTypeOtherHonors eo = CreateEduDegreeTypeOtherHonors();
            s.OtherHonors.Add(eo);

            return s;
        }

        private static EduDegreeTypeOtherHonors CreateEduDegreeTypeOtherHonors()
        {
            EduDegreeTypeOtherHonors eo = new EduDegreeTypeOtherHonors();
            eo.type = "Type";
            eo.Value = "Value";
            return eo;
        }

        private static EduDegreeTypeDegreeName CreateEduDegreeTypeDegreeName()
        {
            EduDegreeTypeDegreeName e = new EduDegreeTypeDegreeName();

            e.academicHonors = "academicHonors";
            e.honorsProgram = "honorsProgram";
            e.Value = "value";
            return e;
        }

        private static EducationalMeasureType CreateEducationalMeasureType()
        {
            EducationalMeasureType e = new EducationalMeasureType();

            e.AcademicCreditCode = AcademicCreditCodeType.A;
            e.AcademicCreditCodeSpecified = true;

            e.AcademicCreditHoursAttempted = new Decimal(10.0);
            e.AcademicCreditHoursAttemptedSpecified = true;

            e.AcademicCreditHoursEarned = new Decimal(10.0);
            e.AcademicCreditHoursEarnedSpecified = true;

            e.AcademicCreditHoursIncluded = new Decimal(10.0);
            e.AcademicCreditHoursIncludedSpecified = true;

            e.ClassRank = new EducationalMeasureTypeClassRank();
            e.ClassRank.numberOfStudents = "10";
            e.ClassRank.Value = "20";

            e.CourseLevelCode = CourseLevelCodeType.A;
            e.CourseLevelCodeSpecified = true;

            e.CumulativeSummaryIndicator = true;
            e.CumulativeSummaryIndicatorSpecified = true;

            e.EducationalMeasure = CreateEducationMeasureType();

            e.measureType = "Measuretype";

            return e;
        }

        private static EducationMeasureType CreateEducationMeasureType()
        {
            EducationMeasureType e = new EducationMeasureType();

            e.ExcessiveValueIndicator = true;
            e.ExcessiveValueIndicatorSpecified = true;

            e.GoodStudentIndicator = true;
            e.GoodStudentIndicatorSpecified = true;

            e.HighestPossibleValue = new MeasureValueType();
            StringValue s = new StringValue();
            s.description = "Omschrijving";
            s.Value = "1";
            e.HighestPossibleValue.Item = s;

            e.LowestPossibleValue = new MeasureValueType();
            e.LowestPossibleValue.Item = s;

            e.MeasureSystem = "Measuresystem";
            e.MeasureValue = new MeasureValueType();
            e.MeasureValue.Item = s;

            return e;
        }

        private static MajorType CreateMajorType()
        {
            MajorType m = new MajorType();

            m.DegreeConcentration = new List<string>();
            m.DegreeConcentration.Add("DegreeConcentration");

            m.Name = new List<string>();
            m.Name.Add("MajorTypeName");

            m.ProgramId = new List<EntityIdType>();
            EntityIdType id = CreateEntityIdType();
            m.ProgramId.Add(id);

            return m;

        }

        private static MinorType CreateMinorType()
        {
            MinorType m = new MinorType();

            m.Name = new List<string>();
            m.Name.Add("MajorTypeName");

            m.ProgramId = new List<EntityIdType>();
            EntityIdType id = CreateEntityIdType();
            m.ProgramId.Add(id);

            return m;

        }

        private static ClassificationType CreateClassificationType()
        {
            ClassificationType c = new ClassificationType();

            c.Description = "Omschrijving";
            c.Id = CreateEntityIdType();
            return c;
        }

        private static DatesOfAttendanceType CreateDatesOfAttendanceType()
        {
            DatesOfAttendanceType d = new DatesOfAttendanceType();

            d.currentlyEnrolled = false;
            d.currentlyEnrolledSpecified = true;

            d.EndDate = CreateFlexibleDatesType();

            d.enrollmentStatus = "Van school verwijderd";
            d.StartDate = CreateFlexibleDatesType();

            d.studentInGoodStanding = false;
            d.studentInGoodStandingSpecified = true;

            return d;
        }

        private static DeprecatedDatesOfAttendanceType CreateDeprecatedDatesOfAttendanceType()
        {
            DeprecatedDatesOfAttendanceType d = new DeprecatedDatesOfAttendanceType();

            //d.currentlyEnrolled = false;
            //d.currentlyEnrolledSpecified = true;

            d.EndDate = new List<FlexibleDatesType>();
            FlexibleDatesType dt = CreateFlexibleDatesType();
            d.EndDate.Add(dt);

            d.enrollmentStatus = "Van school verwijderd";

            d.StartDate = new List<FlexibleDatesType>();
            FlexibleDatesType dt2 = CreateFlexibleDatesType();
            d.StartDate.Add(dt2);

            //d.studentInGoodStanding = false;
            //d.studentInGoodStandingSpecified = true;

            return d;
        }

        private static ContactMethodType CreateContactMethodType()
        {
            ContactMethodType m = new ContactMethodType();

            m.Mobile = CreateMobileNumber("0612312452", TelcomItemsChoiceType.FormattedNumber);
            m.Telephone = CreateNumber("0306561563", TelcomItemsChoiceType.FormattedNumber);
            m.Fax = CreateNumber("0306561563", TelcomItemsChoiceType.FormattedNumber);

            m.InternetEmailAddress = "email@domain.com";
            m.InternetWebAddress = "http://www.nocore.nl";

            m.PostalAddress = new PostalAddressType();
            m.PostalAddress.CountryCode = "NL";
            m.PostalAddress.DeliveryAddress = new PostalAddressTypeDeliveryAddress();
            m.PostalAddress.DeliveryAddress.AddressLine.Add("straat 1");
            m.PostalAddress.DeliveryAddress.AddressLine.Add("1111 AA");
            m.PostalAddress.DeliveryAddress.AddressLine.Add("Uden");
            m.PostalAddress.DeliveryAddress.BuildingNumber = "1";
            m.PostalAddress.DeliveryAddress.PostOfficeBox = "1234 BB";
            m.PostalAddress.DeliveryAddress.StreetName = "Straat 1";
            m.PostalAddress.DeliveryAddress.Unit = "Unit";
            m.PostalAddress.Municipality = "Uden";
            m.PostalAddress.PostalCode = "1111 AA";
            m.PostalAddress.type = PostalAddressTypeType.streetAddress;
            m.PostalAddress.typeSpecified = true;

            return m;

        }

        private static SEPContactInfoType CreateSEPContactInfoType()
        {
            SEPContactInfoType c = new SEPContactInfoType();

            c.ContactMethod = new List<ContactMethodType>();
            ContactMethodType m = CreateContactMethodType();
            c.ContactMethod.Add(m);

            var personName = new PersonNameType();
            SetName(personName, "", "Jansen", "Jan", "Jan");
            c.PersonName = personName;

            return c;
        }

        private static EntityIdType CreateEntityIdType()
        {
            EntityIdType Id = new EntityIdType();
            Id.idOwner = "NoCore";
            Id.IdValue = new List<EntityIdTypeIdValue>();
            EntityIdTypeIdValue val = new EntityIdTypeIdValue();
            val.name = "Id";
            val.Value = "12345";
            Id.IdValue.Add(val);
            return Id;
        }

        private static AchievementType CreateAchievementType()
        {
            AchievementType a = new AchievementType();

            a.Description = "Diploma";
            a.Date = CreateFlexibleDatesType();
            a.IssuingAuthority = "Dealer op de hoek";

            return a;
        }

        private static FlexibleDatesType CreateFlexibleDatesType()
        {
            FlexibleDatesType fd = new FlexibleDatesType();

            // fd.dateDescription = "NL";
            fd.Item = GetDateTime();
            fd.ItemElementName = FlexibleDatesChoiceType.AnyDate;

            return fd;
        }

        private static Association CreateAssociation()
        {
            Association a = new Association();

            a.Comments = "Commentaar";
            a.EndDate = CreateFlexibleDatesType();
            a.Id = CreateEntityIdType();
            a.Link = "http://www.AssosOnline.nl";
            a.Name = "Assos Online";
            a.Role = new List<AssociationTypeRole>();
            a.Role.Add(CreateAssociationTypeRole());

            a.StartDate = CreateFlexibleDatesType();

            //<xsd:enumeration value="Professional"/>
            //<xsd:enumeration value="Social"/>
            //<xsd:enumeration value="Community"/>
            //<xsd:enumeration value="Non-Profit"/>
            //<xsd:enumeration value="Religious"/>
            //<xsd:enumeration value="Political"/>

            a.type = "Social";
            return a;
        }

        private static AssociationTypeRole CreateAssociationTypeRole()
        {
            AssociationTypeRole a = new AssociationTypeRole();

            a.Comments = "Commentaar";
            a.Deliverable = new List<string>();
            a.Deliverable.Add("Deliver 1");
            a.Deliverable.Add("Deliver 2");
            a.EndDate = CreateFlexibleDatesType();
            a.Name = "AssociationTypeRole";
            a.StartDate = CreateFlexibleDatesType();
            return a;
        }
    }
}
