/* 
 * The ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 5 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  </p>  <p>      First Steps:       <ol>          <li>Make sure you've <a href='/HomeV2/App/sign-up'>signed up to ChronoSheets</a> to get yourself a user account</li>          <li>Confirm your account by following the link sent to your email address.  This will activate your account</li>          <li>Use your username and password to obtain an Auth Token by using the DoLogin method inside the UserProfile section below.  Use the Auth Token as an argument to the other methods</li>          <li>Try different methods in the API Playground to learn about the API</li>          <li>If you're stuck, try the full getting started guide on the <a href='/Home/ApiDocs'>API Toolkit</a> page.</li>      </ol>  </p>  <p>      Further Steps:       <ul>          <li>Create a mobile app (iOS, Android or Windows) using one of the ChronoSheets Mobile SDKs</li>          <li>Create a custom integration with your app using one of the ChronoSheets API Client Libraries.</li>      </ul>      Read more about the API Toolkit on the <a href='/Home/ApiDocs'>API Toolkit</a> page.  </p></div>
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace ChronoSheetsAPI.Test
{
    /// <summary>
    ///  Class for testing TimesheetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TimesheetsApiTests
    {
        private TimesheetsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TimesheetsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TimesheetsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TimesheetsApi
            //Assert.IsInstanceOfType(typeof(TimesheetsApi), instance, "instance is a TimesheetsApi");
        }

        
        /// <summary>
        /// Test TimesheetsCreateSingleTimesheet
        /// </summary>
        [Test]
        public void TimesheetsCreateSingleTimesheetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CSTimesheet request = null;
            //string xChronosheetsAuth = null;
            //var response = instance.TimesheetsCreateSingleTimesheet(request, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseInt32> (response, "response is CSApiResponseInt32");
        }
        
        /// <summary>
        /// Test TimesheetsDeleteTimesheet
        /// </summary>
        [Test]
        public void TimesheetsDeleteTimesheetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? timesheetId = null;
            //string xChronosheetsAuth = null;
            //var response = instance.TimesheetsDeleteTimesheet(timesheetId, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseBoolean> (response, "response is CSApiResponseBoolean");
        }
        
        /// <summary>
        /// Test TimesheetsGetTimesheets
        /// </summary>
        [Test]
        public void TimesheetsGetTimesheetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string xChronosheetsAuth = null;
            //var response = instance.TimesheetsGetTimesheets(startDate, endDate, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseListTimesheet> (response, "response is CSApiResponseListTimesheet");
        }
        
        /// <summary>
        /// Test TimesheetsUpdateTimesheets
        /// </summary>
        [Test]
        public void TimesheetsUpdateTimesheetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CSBatchUpdateTimesheetRequest request = null;
            //string xChronosheetsAuth = null;
            //var response = instance.TimesheetsUpdateTimesheets(request, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseListInt32> (response, "response is CSApiResponseListInt32");
        }
        
    }

}
