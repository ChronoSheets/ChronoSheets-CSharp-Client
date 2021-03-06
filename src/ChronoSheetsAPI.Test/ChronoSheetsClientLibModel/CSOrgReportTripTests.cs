/* 
 * ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 3 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  Before starting, sign up for a ChronoSheets account at <a target='_BLANK' href='http://tsheets.xyz/signup'>http://tsheets.xyz/signup</a>.  </p></div><div id='cs-extra-info'></div>
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;
using ChronoSheetsAPI.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace ChronoSheetsAPI.Test
{
    /// <summary>
    ///  Class for testing CSOrgReportTrip
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CSOrgReportTripTests
    {
        // TODO uncomment below to declare an instance variable for CSOrgReportTrip
        //private CSOrgReportTrip instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CSOrgReportTrip
            //instance = new CSOrgReportTrip();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CSOrgReportTrip
        /// </summary>
        [Test]
        public void CSOrgReportTripInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CSOrgReportTrip
            //Assert.IsInstanceOfType<CSOrgReportTrip> (instance, "variable 'instance' is a CSOrgReportTrip");
        }


        /// <summary>
        /// Test the property 'Username'
        /// </summary>
        [Test]
        public void UsernameTest()
        {
            // TODO unit test for the property 'Username'
        }
        /// <summary>
        /// Test the property 'EmailAddress'
        /// </summary>
        [Test]
        public void EmailAddressTest()
        {
            // TODO unit test for the property 'EmailAddress'
        }
        /// <summary>
        /// Test the property 'FirstName'
        /// </summary>
        [Test]
        public void FirstNameTest()
        {
            // TODO unit test for the property 'FirstName'
        }
        /// <summary>
        /// Test the property 'LastName'
        /// </summary>
        [Test]
        public void LastNameTest()
        {
            // TODO unit test for the property 'LastName'
        }
        /// <summary>
        /// Test the property 'TripId'
        /// </summary>
        [Test]
        public void TripIdTest()
        {
            // TODO unit test for the property 'TripId'
        }
        /// <summary>
        /// Test the property 'TimesheetId'
        /// </summary>
        [Test]
        public void TimesheetIdTest()
        {
            // TODO unit test for the property 'TimesheetId'
        }
        /// <summary>
        /// Test the property 'VehicleId'
        /// </summary>
        [Test]
        public void VehicleIdTest()
        {
            // TODO unit test for the property 'VehicleId'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }
        /// <summary>
        /// Test the property 'OrgId'
        /// </summary>
        [Test]
        public void OrgIdTest()
        {
            // TODO unit test for the property 'OrgId'
        }
        /// <summary>
        /// Test the property 'MobilePlatform'
        /// </summary>
        [Test]
        public void MobilePlatformTest()
        {
            // TODO unit test for the property 'MobilePlatform'
        }
        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Test]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'EndDate'
        /// </summary>
        [Test]
        public void EndDateTest()
        {
            // TODO unit test for the property 'EndDate'
        }
        /// <summary>
        /// Test the property 'VehicleName'
        /// </summary>
        [Test]
        public void VehicleNameTest()
        {
            // TODO unit test for the property 'VehicleName'
        }
        /// <summary>
        /// Test the property 'VehicleMake'
        /// </summary>
        [Test]
        public void VehicleMakeTest()
        {
            // TODO unit test for the property 'VehicleMake'
        }
        /// <summary>
        /// Test the property 'VehicleModel'
        /// </summary>
        [Test]
        public void VehicleModelTest()
        {
            // TODO unit test for the property 'VehicleModel'
        }
        /// <summary>
        /// Test the property 'VehicleYear'
        /// </summary>
        [Test]
        public void VehicleYearTest()
        {
            // TODO unit test for the property 'VehicleYear'
        }
        /// <summary>
        /// Test the property 'CostPerKilometer'
        /// </summary>
        [Test]
        public void CostPerKilometerTest()
        {
            // TODO unit test for the property 'CostPerKilometer'
        }
        /// <summary>
        /// Test the property 'TripTotalCost'
        /// </summary>
        [Test]
        public void TripTotalCostTest()
        {
            // TODO unit test for the property 'TripTotalCost'
        }
        /// <summary>
        /// Test the property 'TotalTripDistanceMeters'
        /// </summary>
        [Test]
        public void TotalTripDistanceMetersTest()
        {
            // TODO unit test for the property 'TotalTripDistanceMeters'
        }
        /// <summary>
        /// Test the property 'StartAddress'
        /// </summary>
        [Test]
        public void StartAddressTest()
        {
            // TODO unit test for the property 'StartAddress'
        }
        /// <summary>
        /// Test the property 'EndAddress'
        /// </summary>
        [Test]
        public void EndAddressTest()
        {
            // TODO unit test for the property 'EndAddress'
        }
        /// <summary>
        /// Test the property 'PathCoordinates'
        /// </summary>
        [Test]
        public void PathCoordinatesTest()
        {
            // TODO unit test for the property 'PathCoordinates'
        }
        /// <summary>
        /// Test the property 'CacheExpiryDate'
        /// </summary>
        [Test]
        public void CacheExpiryDateTest()
        {
            // TODO unit test for the property 'CacheExpiryDate'
        }

    }

}
