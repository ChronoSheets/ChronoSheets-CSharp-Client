/* 
 * The ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 5 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  </p>  <p>      First Steps:       <ol>          <li>Make sure you've <a href='/HomeV2/App/sign-up'>signed up to ChronoSheets</a> to get yourself a user account</li>          <li>Confirm your account by following the link sent to your email address.  This will activate your account</li>          <li>Use your username and password to obtain an Auth Token by using the DoLogin method inside the UserProfile section below.  Use the Auth Token as an argument to the other methods</li>          <li>Try different methods in the API Playground to learn about the API</li>          <li>If you're stuck, try the full getting started guide on the <a href='/Home/ApiDocs'>API Toolkit</a> page.</li>      </ol>  </p>  <p>      Further Steps:       <ul>          <li>Create a mobile app (iOS, Android or Windows) using one of the ChronoSheets Mobile SDKs</li>          <li>Create a custom integration with your app using one of the ChronoSheets API Client Libraries.</li>      </ul>      Read more about the API Toolkit on the <a href='/Home/ApiDocs'>API Toolkit</a> page.  </p></div>
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
    ///  Class for testing CSInsertTaskRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CSInsertTaskRequestTests
    {
        // TODO uncomment below to declare an instance variable for CSInsertTaskRequest
        //private CSInsertTaskRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CSInsertTaskRequest
            //instance = new CSInsertTaskRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CSInsertTaskRequest
        /// </summary>
        [Test]
        public void CSInsertTaskRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CSInsertTaskRequest
            //Assert.IsInstanceOfType<CSInsertTaskRequest> (instance, "variable 'instance' is a CSInsertTaskRequest");
        }


        /// <summary>
        /// Test the property 'TaskName'
        /// </summary>
        [Test]
        public void TaskNameTest()
        {
            // TODO unit test for the property 'TaskName'
        }
        /// <summary>
        /// Test the property 'TripEnabled'
        /// </summary>
        [Test]
        public void TripEnabledTest()
        {
            // TODO unit test for the property 'TripEnabled'
        }

    }

}
