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
        private static void DoHumanResource()
        {
            HumanResourceType humanResource;
            EntityIdType entityIDFlex2GO;
            EntityIdTypeIdValue entityIdTypeIdFlex2GO;
            EntityIdType entityIDNocore;
            EntityIdTypeIdValue entityIdTypeIdNocore;

            // aanmaken hoofdelement.
            humanResource = new HumanResourceType();
            // referenceInformation hebben we zo ook nodig
            humanResource.ReferenceInformation = new HumanResourceTypeReferenceInformation();
            // resourceInformation hebben we zo ook nodig.
            humanResource.ResourceInformation = new HumanResourceTypeResourceInformation();
            // profielinformatie zoals beschikbaarheden hebben we zo ook nodig
            humanResource.Profile = new HumanResourceTypeProfile();
            // userArea, die we gaan gebruiken voor eigen gegevens en setu aanvullingen
            humanResource.UserArea = new UserAreaType();
            // voorkeuren, leeg element.
            humanResource.Preferences = new HumanResourceTypePreferences();

            #region Status

            humanResource.HumanResourceStatus = new HumanResourceTypeHumanResourceStatus();
            // nieuwe medewerker
            humanResource.HumanResourceStatus.status = KnownStatusType.New;
            #endregion

            #region Identifier van HumanResource in Flex2GO

            // maken van eigen identifier Flex2GO
            entityIDFlex2GO = new EntityIdType();
            // wij zijn eigenaar
            entityIDFlex2GO.idOwner = "Flex2GO";
            // waardeobject
            entityIdTypeIdFlex2GO = new EntityIdTypeIdValue();
            // Flex2GO gebruikt guids
            entityIdTypeIdFlex2GO.Value = "F020D955-A2A8-4371-A57F-BB9E5012CEDD";
            // toevoegen waarde object aan entityId object
            entityIDFlex2GO.IdValue.Add(entityIdTypeIdFlex2GO);
            // toevoegen van EntityId object aan de lijst met HumanResourceId's, dit is die van Flex2GO
            humanResource.HumanResourceId.Add(entityIDFlex2GO);

            #endregion

            #region Identifier van HumanResource in Nocore
            // maken van eigen identifier Nocore
            entityIDNocore = new EntityIdType();
            // wij zijn eigenaar
            entityIDNocore.idOwner = "SEDIS";
            // waardeobject
            entityIdTypeIdNocore = new EntityIdTypeIdValue();
            // Nocore gebruikt integers, personeelsnummer
            entityIdTypeIdNocore.Value = "12345";
            // toevoegen waarde object aan entityId object
            entityIDNocore.IdValue.Add(entityIdTypeIdNocore);
            // toevoegen van EntityId object aan de lijst met HumanResourceId's, dit is die van Nocore
            humanResource.HumanResourceId.Add(entityIDNocore);

            #endregion

            #region Identifier Bedrijf Flex2GO = StaffingSupplier indien van Flex2GO naar Nocore

            // maken van eigen identifier Flex2GO
            EntityIdType entityIDBedrijfFlex2GO = new EntityIdType();
            // waardeobject
            EntityIdTypeIdValue entityIdTypeIdBedrijfFlex2GO = new EntityIdTypeIdValue();
            // Flex2GO gebruikt guids, guid van het Bedrijf in Flex2GO
            entityIdTypeIdBedrijfFlex2GO.Value = "0F14A513-BC2A-4F44-9EBC-5EDA5CF58BDC";
            // toevoegen waarde object aan entityId object
            entityIDBedrijfFlex2GO.IdValue.Add(entityIdTypeIdBedrijfFlex2GO);
            // toevoegen van EntityId object aan de lijst met HumanResourceId's, dit is die van Flex2GO
            humanResource.ReferenceInformation.StaffingSupplierId.Add(entityIDBedrijfFlex2GO);

            #endregion

            #region Identifier Administratie Nocore = StaffingCustomer indien van Flex2GO naar Nocore
            // maken van eigen identifier Nocore
            EntityIdType entityIDAdministratieNocore = new EntityIdType();
            // waardeobject
            EntityIdTypeIdValue entityIdTypeIdAdministratieNocore = new EntityIdTypeIdValue();
            // Nocore gebruikt integers, administratienummer
            entityIdTypeIdAdministratieNocore.Value = "1";
            // toevoegen waarde object aan entityId object
            entityIDAdministratieNocore.IdValue.Add(entityIdTypeIdAdministratieNocore);
            // toevoegen van EntityId object aan de lijst met HumanResourceId's, dit is die van Nocore
            humanResource.ReferenceInformation.StaffingCustomerId.Add(entityIDAdministratieNocore);

            #endregion

            #region PersonName structuur
            // nieuw HR-XML naam object
            PersonNameType name = new PersonNameType();
            // zet de naam op het HR-XML object in subroutine
            SetName(name, "de", "Vries", "Jan de Vries", "Jan");
            // stop de personname op de resourceInformation
            humanResource.ResourceInformation.PersonName = name;

            #endregion

            #region ContactInfo

            // nieuw HR-XML contactInfo object
            EntityContactInfoType entityContactInfo = new EntityContactInfoType();
            // gelijk aan formattedname bij ons
            entityContactInfo.EntityName = "Jan de Vries";

            // zet contactinformatie en voeg die toe aan contactInfo object
            ContactMethodType contactInfo = new ContactMethodType();
            contactInfo.Mobile = CreateMobileNumber("0612332230", TelcomItemsChoiceType.FormattedNumber);
            contactInfo.Telephone = CreateNumber("0306561563", TelcomItemsChoiceType.FormattedNumber);
            contactInfo.InternetEmailAddress = "jandevries@geelmeel.not";
            entityContactInfo.ContactMethod.Add(contactInfo);

            humanResource.ResourceInformation.EntityContactInfo = entityContactInfo;

            #endregion

            #region Adres

            // nieuw HR-XML adres object
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

            // zet adres op ResourceInformation object
            humanResource.ResourceInformation.PostalAddress = postalAddress;

            #endregion

            #region Profile

            // reisafstand in kilometers
            HumanResourceTypePreferencesCommute commute = new HumanResourceTypePreferencesCommute();
            commute.DistanceMax = "100";
            humanResource.Preferences.Commute = commute;

            #endregion

            #region HumanResourceAdditionalNL

            HumanResourceAdditionalNLType humanResourceAdditionalNL = new HumanResourceAdditionalNLType();

            //geslacht
            humanResourceAdditionalNL.Sex = SexType.male;
            humanResourceAdditionalNL.SexSpecified = true;

            // geboortedatum
            humanResourceAdditionalNL.BirthDate = new DateTime(1981, 07, 24);
            humanResourceAdditionalNL.BirthDateSpecified = true;

            // aanmaken idDocument en vervaldatum
            IdentificationDocumentType idDocument = new IdentificationDocumentType();
            EffectiveDateType effictiveDate = new EffectiveDateType();

            // vervaldatum
            effictiveDate.ValidTo = new DateTime(2015, 01, 10);
            effictiveDate.ValidToSpecified = true;
            idDocument.EffectiveDate = effictiveDate;

            // formaat en nummer
            idDocument.Format = "Paspoort";
            idDocument.Id = "123456789";
            humanResourceAdditionalNL.IdentificationDocument = idDocument;

            // toewijzen humanresourceAdditionalNL deel aan de humanResource
            humanResource.UserArea.HumanResourceAdditionalNL = humanResourceAdditionalNL;
            humanResource.UserArea.HumanResourceAdditionalNLSpecified = true;

            #endregion

            #region Nocore specifieke data

            NocoreHumanResourceType nocoreHumanResource = new NocoreHumanResourceType();

            // intercedent
            nocoreHumanResource.AccountManager = "Piet Intercedent";

            nocoreHumanResource.BankAccountInfo = new BankAccountInfoType();
            nocoreHumanResource.BankAccountInfo.BankAccountForeign = "569759943";

            nocoreHumanResource.Status = "Uit dienst";

            // twee fase periodes, fase 1 en fase 2A
            FasePeriodType periode1 = new FasePeriodType();
            periode1.Fase = "1";
            periode1.From = new DateTime(2008, 01, 01);
            periode1.To = new DateTime(2008, 06, 30);
            periode1.ToSpecified = true;
            nocoreHumanResource.FaseHistorie.Add(periode1);
            FasePeriodType periode2 = new FasePeriodType();
            periode2.Fase = "2A";
            periode2.From = new DateTime(2008, 07, 01);
            periode2.ToSpecified = false;
            nocoreHumanResource.FaseHistorie.Add(periode2);
            // initialen, met puntjes ertussen
            nocoreHumanResource.Initials = "J.";

            // nocore vestiging
            nocoreHumanResource.Location = new NocoreLocationType();
            nocoreHumanResource.Location.Code = "1";
            nocoreHumanResource.Location.Name = "Hoofdvestiging";

            // samenwonend
            nocoreHumanResource.MaritalStatus = "Gehuwd";

            // nationaliteit
            nocoreHumanResource.Nationality = new NationalityType();
            nocoreHumanResource.Nationality.GBACode = "1";
            nocoreHumanResource.Nationality.Name = "Nederlandse";

            // mutatiedatum
            nocoreHumanResource.Modified = DateTime.Now;
            humanResource.UserArea.NocoreHumanResource = nocoreHumanResource;
            humanResource.UserArea.NocoreHumanResourceSpecified = true;

            #endregion

            // serializen, valideren, en opslaan in bestand. Zie EntityBase voor meer informatie van de basisklasse

            humanResource.SaveToFile("HumanResource.xml");

            // En weer laden uit bestand.

            HumanResourceType loadedHumanResource = EntityBase<HumanResourceType>.LoadFromFile("HumanResource.xml");

            // druk naam af in de console.

            Console.WriteLine(loadedHumanResource.ResourceInformation.PersonName.FormattedName);
        }


    }
}
