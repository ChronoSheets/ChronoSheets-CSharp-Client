/* 
 * The ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 5 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  Before starting, sign up for a ChronoSheets account at <a target='_BLANK' href='http://tsheets.xyz/signup'>http://tsheets.xyz/signup</a>.  </p></div><div id='cs-extra-info'></div>
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
    ///  Class for testing ClientsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ClientsApiTests
    {
        private ClientsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ClientsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ClientsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ClientsApi
            //Assert.IsInstanceOfType(typeof(ClientsApi), instance, "instance is a ClientsApi");
        }

        
        /// <summary>
        /// Test ClientsCreateClient
        /// </summary>
        [Test]
        public void ClientsCreateClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CSInsertClientRequest request = null;
            //string xChronosheetsAuth = null;
            //var response = instance.ClientsCreateClient(request, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseInt32> (response, "response is CSApiResponseInt32");
        }
        
        /// <summary>
        /// Test ClientsGetClient
        /// </summary>
        [Test]
        public void ClientsGetClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? clientId = null;
            //string xChronosheetsAuth = null;
            //var response = instance.ClientsGetClient(clientId, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseClient> (response, "response is CSApiResponseClient");
        }
        
        /// <summary>
        /// Test ClientsGetClients
        /// </summary>
        [Test]
        public void ClientsGetClientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xChronosheetsAuth = null;
            //var response = instance.ClientsGetClients(xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseListClient> (response, "response is CSApiResponseListClient");
        }
        
        /// <summary>
        /// Test ClientsUpdateClient
        /// </summary>
        [Test]
        public void ClientsUpdateClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CSSaveClientRequest request = null;
            //string xChronosheetsAuth = null;
            //var response = instance.ClientsUpdateClient(request, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseBoolean> (response, "response is CSApiResponseBoolean");
        }
        
    }

}
