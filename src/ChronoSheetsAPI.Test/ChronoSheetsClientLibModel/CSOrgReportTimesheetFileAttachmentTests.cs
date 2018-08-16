/* 
 * ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 5 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  Before starting, sign up for a ChronoSheets account at <a target='_BLANK' href='http://tsheets.xyz/signup'>http://tsheets.xyz/signup</a>.  </p></div><div id='cs-extra-info'></div>
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
    ///  Class for testing CSOrgReportTimesheetFileAttachment
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CSOrgReportTimesheetFileAttachmentTests
    {
        // TODO uncomment below to declare an instance variable for CSOrgReportTimesheetFileAttachment
        //private CSOrgReportTimesheetFileAttachment instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CSOrgReportTimesheetFileAttachment
            //instance = new CSOrgReportTimesheetFileAttachment();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CSOrgReportTimesheetFileAttachment
        /// </summary>
        [Test]
        public void CSOrgReportTimesheetFileAttachmentInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CSOrgReportTimesheetFileAttachment
            //Assert.IsInstanceOfType<CSOrgReportTimesheetFileAttachment> (instance, "variable 'instance' is a CSOrgReportTimesheetFileAttachment");
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
        /// Test the property 'TimesheetId'
        /// </summary>
        [Test]
        public void TimesheetIdTest()
        {
            // TODO unit test for the property 'TimesheetId'
        }
        /// <summary>
        /// Test the property 'DocumentS3SignedUrl'
        /// </summary>
        [Test]
        public void DocumentS3SignedUrlTest()
        {
            // TODO unit test for the property 'DocumentS3SignedUrl'
        }
        /// <summary>
        /// Test the property 'ImageLargeS3SignedUrl'
        /// </summary>
        [Test]
        public void ImageLargeS3SignedUrlTest()
        {
            // TODO unit test for the property 'ImageLargeS3SignedUrl'
        }
        /// <summary>
        /// Test the property 'ImageMediumS3SignedUrl'
        /// </summary>
        [Test]
        public void ImageMediumS3SignedUrlTest()
        {
            // TODO unit test for the property 'ImageMediumS3SignedUrl'
        }
        /// <summary>
        /// Test the property 'ImageSmallS3SignedUrl'
        /// </summary>
        [Test]
        public void ImageSmallS3SignedUrlTest()
        {
            // TODO unit test for the property 'ImageSmallS3SignedUrl'
        }
        /// <summary>
        /// Test the property 'TimesheetStart'
        /// </summary>
        [Test]
        public void TimesheetStartTest()
        {
            // TODO unit test for the property 'TimesheetStart'
        }
        /// <summary>
        /// Test the property 'TimesheetEnd'
        /// </summary>
        [Test]
        public void TimesheetEndTest()
        {
            // TODO unit test for the property 'TimesheetEnd'
        }
        /// <summary>
        /// Test the property 'FileAttachmentId'
        /// </summary>
        [Test]
        public void FileAttachmentIdTest()
        {
            // TODO unit test for the property 'FileAttachmentId'
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
        /// Test the property 'AttachmentType'
        /// </summary>
        [Test]
        public void AttachmentTypeTest()
        {
            // TODO unit test for the property 'AttachmentType'
        }
        /// <summary>
        /// Test the property 'Notes'
        /// </summary>
        [Test]
        public void NotesTest()
        {
            // TODO unit test for the property 'Notes'
        }
        /// <summary>
        /// Test the property 'NonImageFilePath'
        /// </summary>
        [Test]
        public void NonImageFilePathTest()
        {
            // TODO unit test for the property 'NonImageFilePath'
        }
        /// <summary>
        /// Test the property 'ImageLargeFilePath'
        /// </summary>
        [Test]
        public void ImageLargeFilePathTest()
        {
            // TODO unit test for the property 'ImageLargeFilePath'
        }
        /// <summary>
        /// Test the property 'ImageMediumFilePath'
        /// </summary>
        [Test]
        public void ImageMediumFilePathTest()
        {
            // TODO unit test for the property 'ImageMediumFilePath'
        }
        /// <summary>
        /// Test the property 'ImageSmallFilePath'
        /// </summary>
        [Test]
        public void ImageSmallFilePathTest()
        {
            // TODO unit test for the property 'ImageSmallFilePath'
        }
        /// <summary>
        /// Test the property 'OriginalFileName'
        /// </summary>
        [Test]
        public void OriginalFileNameTest()
        {
            // TODO unit test for the property 'OriginalFileName'
        }
        /// <summary>
        /// Test the property 'Latitude'
        /// </summary>
        [Test]
        public void LatitudeTest()
        {
            // TODO unit test for the property 'Latitude'
        }
        /// <summary>
        /// Test the property 'Longitude'
        /// </summary>
        [Test]
        public void LongitudeTest()
        {
            // TODO unit test for the property 'Longitude'
        }
        /// <summary>
        /// Test the property 'DateUploaded'
        /// </summary>
        [Test]
        public void DateUploadedTest()
        {
            // TODO unit test for the property 'DateUploaded'
        }
        /// <summary>
        /// Test the property 'DateImageCaptured'
        /// </summary>
        [Test]
        public void DateImageCapturedTest()
        {
            // TODO unit test for the property 'DateImageCaptured'
        }
        /// <summary>
        /// Test the property 'StorageAllocationBytes'
        /// </summary>
        [Test]
        public void StorageAllocationBytesTest()
        {
            // TODO unit test for the property 'StorageAllocationBytes'
        }
        /// <summary>
        /// Test the property 'AudioDurationSeconds'
        /// </summary>
        [Test]
        public void AudioDurationSecondsTest()
        {
            // TODO unit test for the property 'AudioDurationSeconds'
        }

    }

}
