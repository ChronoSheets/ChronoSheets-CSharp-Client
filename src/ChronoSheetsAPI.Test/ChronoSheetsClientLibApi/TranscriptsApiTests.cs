/* 
 * ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 3 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  Before starting, sign up for a ChronoSheets account at <a target='_BLANK' href='http://tsheets.xyz/signup'>http://tsheets.xyz/signup</a>.  </p></div><div id='cs-extra-info'></div>
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
    ///  Class for testing TranscriptsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TranscriptsApiTests
    {
        private TranscriptsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TranscriptsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TranscriptsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TranscriptsApi
            //Assert.IsInstanceOfType(typeof(TranscriptsApi), instance, "instance is a TranscriptsApi");
        }

        
        /// <summary>
        /// Test TranscriptsGetMyTranscript
        /// </summary>
        [Test]
        public void TranscriptsGetMyTranscriptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fileAttachmentId = null;
            //string xChronosheetsAuth = null;
            //var response = instance.TranscriptsGetMyTranscript(fileAttachmentId, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseTranscription> (response, "response is CSApiResponseTranscription");
        }
        
        /// <summary>
        /// Test TranscriptsGetMyTranscripts
        /// </summary>
        [Test]
        public void TranscriptsGetMyTranscriptsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string xChronosheetsAuth = null;
            //int? skip = null;
            //int? take = null;
            //string keyword = null;
            //var response = instance.TranscriptsGetMyTranscripts(startDate, endDate, xChronosheetsAuth, skip, take, keyword);
            //Assert.IsInstanceOf<CSApiResponseForPaginatedListOrgReportTranscript> (response, "response is CSApiResponseForPaginatedListOrgReportTranscript");
        }
        
    }

}
