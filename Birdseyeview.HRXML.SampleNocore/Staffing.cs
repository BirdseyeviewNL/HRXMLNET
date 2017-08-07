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
        private static void DoStaffingOrganization()
        {
            StaffingOrganizationType staffingOrganization = new StaffingOrganizationType();
            // type organisatie, pattern extensie dus vrij, maar Customer, Intermediary en Supplier zijn gedefinieerd.
            staffingOrganization.typeOfOrganization = "Customer";

            #region Organization

            // nieuwe organisatie, toevoegen. Maar één per bericht, dat is wat setu aanbeveelt.
            var organization = new Organization();
            staffingOrganization.Organization.Add(organization);

            // nieuw referenceIDType

            var referenceIDType = new StaffingReferenceIdType();
            staffingOrganization.ReferenceIdInfo.Add(referenceIDType);

            #region Identifier van StaffingOrganization in Flex2GO

            // maken van eigen identifier Flex2GO
            var entityIDFlex2GO = new EntityIdType();
            // wij zijn eigenaar
            entityIDFlex2GO.idOwner = "Flex2GO";
            // waardeobject
            var entityIdTypeIdFlex2GO = new EntityIdTypeIdValue();
            // Flex2GO gebruikt guids
            entityIdTypeIdFlex2GO.Value = "F020D955-A2A8-4371-A57F-BB9E5012CEDD";
            // toevoegen waarde object aan entityId object
            entityIDFlex2GO.IdValue.Add(entityIdTypeIdFlex2GO);
            // toevoegen van EntityId object aan de lijst met HumanResourceId's, dit is die van Flex2GO

            organization.OrganizationId.Add(entityIDFlex2GO);
            #endregion

            #region Identifier van StaffingOrganization in Nocore

            // maken van eigen identifier Nocore
            var entityIDNocore = new EntityIdType();
            // wij zijn eigenaar
            entityIDNocore.idOwner = "SEDIS";
            // waardeobject
            var entityIdTypeIdNocore = new EntityIdTypeIdValue();
            // Nocore gebruikt integers, personeelsnummer
            entityIdTypeIdNocore.Value = "12345";
            // toevoegen waarde object aan entityId object
            entityIDNocore.IdValue.Add(entityIdTypeIdNocore);
            // toevoegen van EntityId object aan de lijst met HumanResourceId's, dit is die van Nocore
            organization.OrganizationId.Add(entityIDNocore);

            #endregion
            // naam organisatie
            organization.OrganizationName = "Birdseyeview B.V.";
            // omschrijving organisatie
            organization.Description = "Makers van Flex2GO, internetplatform voor de uitzend- en payrollbranche";
            // kvk
            var dunsNumber = new DunsNumberDataType();
            dunsNumber.dunsNumberType = DunsNumberDataTypeDunsNumberType.standardDuns;
            dunsNumber.Value = "039087461";
            organization.DunsNumber.Add(dunsNumber);

            // SBI-code 2008 voor VPO marktmonitor
            var industryCode = new IndustryCodeType();
            industryCode.Value = "62.01";
            organization.IndustryCode.Add(industryCode);

            var internetAdres = new InternetDomainNameType();
            internetAdres.Value = "http://www.birdseyeview.nl/";
            organization.InternetDomainName.Add(internetAdres);

            #endregion

            #region contactpersonen

            var organizationContactInfo = new OrganizationContactType();

            // id van de contactpersoon in Flex2GO en/of NoCore

            #region Identifier van OrganizationContactType in Flex2GO

            // maken van eigen identifier Flex2GO
            EntityIdType entityIDContactFlex2GO = new EntityIdType();
            // wij zijn eigenaar
            entityIDContactFlex2GO.idOwner = "Flex2GO";
            // waardeobject
            EntityIdTypeIdValue entityIdContactTypeIdFlex2GO = new EntityIdTypeIdValue();
            // Flex2GO gebruikt guids
            entityIdContactTypeIdFlex2GO.Value = "F020D955-A2A8-4371-A57F-BB9E5012CEDD";
            // toevoegen waarde object aan entityId object
            entityIDContactFlex2GO.IdValue.Add(entityIdTypeIdFlex2GO);
            // toevoegen van EntityId object aan de lijst met HumanResourceId's, dit is die van Flex2GO
            organizationContactInfo.ContactId = entityIDContactFlex2GO;

            #endregion

            // Soort contactpersoon, met x: zelf te definieren, of één van de standaardwaarden
            organizationContactInfo.purpose = "x:Ontwikkelaar";
            // Naam
            var personName = new PersonNameType();
            SetName(personName, "", "Jansen", "Jan", "Jan");
            organizationContactInfo.ContactName = personName;
            // ContactMethodes

            ContactMethodType contactInfo = new ContactMethodType();
            contactInfo.Mobile = CreateMobileNumber("0612341234", TelcomItemsChoiceType.FormattedNumber);
            contactInfo.Telephone = CreateNumber("0306561563", TelcomItemsChoiceType.FormattedNumber);
            contactInfo.InternetEmailAddress = "info@sdlkjh2kd.ne";

            organizationContactInfo.ContactMethod = contactInfo;

            organization.ContactInfo.Add(organizationContactInfo);

            #endregion

            #region Adres

            var workSite = new WorkSiteType();

            // nieuw HR-XML adres object
            PostalAddressType postalAddress = new PostalAddressType();
            // landcode van Nederland in ISO2
            postalAddress.CountryCode = "NL";

            // nieuw HR-XML PostalAddressTypeDeliveryAddress object

            PostalAddressTypeDeliveryAddress deliveryAddress = new PostalAddressTypeDeliveryAddress();
            // eigenschappen op object plakken
            deliveryAddress.StreetName = "Groeneweg";
            deliveryAddress.BuildingNumber = "21";
            deliveryAddress.Unit = "G";
            deliveryAddress.AddressLine.Add("Groeneweg 21G");
            postalAddress.DeliveryAddress = deliveryAddress;
            postalAddress.PostalCode = "3981 CK";
            // type = streetAddress = Huisadres
            postalAddress.type = PostalAddressTypeType.streetAddress;
            postalAddress.typeSpecified = true;

            // zet adres op ResourceInformation object
            workSite.PostalAddress = postalAddress;

            organization.WorkSite.Add(workSite);

            #endregion

            #region NocoreSpecific

            staffingOrganization.UserArea = new UserAreaType();

            var nocoreStaffingOrganization = new NocoreStaffingOrganizationType();

            var cla = new CLAReferenceType();
            cla.CLAId = "1045";
            cla.Description = "THUISZORG";
            nocoreStaffingOrganization.CLA = cla;
            nocoreStaffingOrganization.AccountManager = "Gert Dingemans";
            nocoreStaffingOrganization.Location = new NocoreLocationType();
            nocoreStaffingOrganization.Location.Code = "1";
            nocoreStaffingOrganization.Location.Name = "Hoofdvestiging";
            nocoreStaffingOrganization.Status = "Actief";
            nocoreStaffingOrganization.Modified = DateTime.Now;

            staffingOrganization.UserArea.NocoreStaffingOrganization = nocoreStaffingOrganization;
            staffingOrganization.UserArea.NocoreStaffingOrganizationSpecified = true;

            #endregion

            var paymentInfo = new PaymentInfoType();

            paymentInfo.BankAccountInfo = new BankAccountInfoType();
            paymentInfo.BankAccountInfo.BankAccountForeign = "592177424";

            paymentInfo.PaymentCondition = new PaymentInfoTypePaymentCondition();
            paymentInfo.PaymentCondition.Description = "14 dagen";
            // 19 voor 19%, 0 VOOR btw Verlegd
            paymentInfo.VATRate = 19;
            paymentInfo.VATRateSpecified = true;
            staffingOrganization.PaymentInfo.Add(paymentInfo);

            staffingOrganization.SaveToFile("StaffingOrganization.xml");

            // Laad weer uit bestand

            StaffingOrganizationType loadedStaffingOrganization =
                EntityBase<StaffingOrganizationType>.LoadFromFile("StaffingOrganization.xml");

            // druk naam af.

            Console.WriteLine(loadedStaffingOrganization.Organization[0].OrganizationName);
        }

    }
}
