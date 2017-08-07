// --------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Birdseyeview B.V.">
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
//
// - Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
// - Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer 
//   in the documentation and/or other materials provided with the distribution.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, 
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR 
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, 
// PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF 
// LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, 
// EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
// </copyright>
// <summary>
//   Sample program to generate HR-XML messages for exchange with the Nocore
//   system. Loading XML is also covered.
//   A vender specific (Nocore) userarea is included in every file.
//   The sample comments and variables are in Dutch. 
// </summary>
// --------------------------------------------------------------------------------

namespace Birdseyeview.HRXML.SampleNocore
{
    using System;
    using System.Globalization;

    using global::HRXML.Net;

    /// <summary>
    /// The program.
    /// </summary>
    partial class Program
    {
        // creert mobileTelcomNumberType
        #region Public Methods and Operators

        public static MobileTelcomNumberType CreateMobileNumber(string number, TelcomItemsChoiceType type)
        {
            var result = new MobileTelcomNumberType();
            result.Items = new[] { number };
            result.ItemsElementName = new[] { type };
            return result;
        }

        public static TelcomNumberType CreateNumber(string number, TelcomItemsChoiceType type)
        {
            var result = new TelcomNumberType();
            result.Items = new[] { number };
            result.ItemsElementName = new[] { type };
            return result;
        }

        public static void SetName(
            PersonNameType personName, string voorvoegsel, string achternaam, string volledigenaam, string roepnaam)
        {
            // preferredGivenName = voornaam
            personName.PreferredGivenName = roepnaam;

            var familyName = new PersonNameTypeFamilyName();

            familyName.primarySpecified = true;
            familyName.primary = PersonNameTypeFamilyNamePrimary.@true;
            familyName.Value = achternaam;
            familyName.prefix = voorvoegsel;
            personName.FamilyName.Add(familyName);

            personName.GivenName.Add(roepnaam);

            // volledige naam
            personName.FormattedName = volledigenaam;
        }

        #endregion

        #region Methods

        private static string GetDateTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
        }


        private static void Main(string[] args)
        {
            DoHumanResource();
            DoStaffingOrganization();
            DoCV();
        }

        #endregion
    }
}