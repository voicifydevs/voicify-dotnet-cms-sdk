/* 
 * Voicify CMS API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: V1
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

using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Core.Models.Model;

namespace Voicify.Sdk.Cms.Test
{
    /// <summary>
    ///  Class for testing ImportExportApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ImportExportApiTests
    {
        private ImportExportApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ImportExportApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ImportExportApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ImportExportApi
            //Assert.IsInstanceOfType(typeof(ImportExportApi), instance, "instance is a ImportExportApi");
        }

        
        /// <summary>
        /// Test ExportApplication
        /// </summary>
        [Test]
        public void ExportApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //var response = instance.ExportApplication(applicationId);
            //Assert.IsInstanceOf<ExportModel> (response, "response is ExportModel");
        }
        
        /// <summary>
        /// Test ExportApplicationFile
        /// </summary>
        [Test]
        public void ExportApplicationFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //var response = instance.ExportApplicationFile(applicationId);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ExportApplicationInteractionModel
        /// </summary>
        [Test]
        public void ExportApplicationInteractionModelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //var response = instance.ExportApplicationInteractionModel(applicationId);
            //Assert.IsInstanceOf<ExportModel> (response, "response is ExportModel");
        }
        
        /// <summary>
        /// Test ExportApplicationInteractionModelFile
        /// </summary>
        [Test]
        public void ExportApplicationInteractionModelFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //var response = instance.ExportApplicationInteractionModelFile(applicationId);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ExportContent
        /// </summary>
        [Test]
        public void ExportContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BulkContentRequest request = null;
            //var response = instance.ExportContent(request);
            //Assert.IsInstanceOf<ExportModel> (response, "response is ExportModel");
        }
        
        /// <summary>
        /// Test ExportContentToFile
        /// </summary>
        [Test]
        public void ExportContentToFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BulkContentRequest request = null;
            //var response = instance.ExportContentToFile(request);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ImportIntoApplication
        /// </summary>
        [Test]
        public void ImportIntoApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //ExportModel exportModel = null;
            //var response = instance.ImportIntoApplication(applicationId, exportModel);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ImportIntoApplicationFeature
        /// </summary>
        [Test]
        public void ImportIntoApplicationFeatureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationFeatureId = null;
            //ExportModel exportModel = null;
            //var response = instance.ImportIntoApplicationFeature(applicationFeatureId, exportModel);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ImportIntoApplicationFeatureFromFile
        /// </summary>
        [Test]
        public void ImportIntoApplicationFeatureFromFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationFeatureId = null;
            //System.IO.Stream _file = null;
            //var response = instance.ImportIntoApplicationFeatureFromFile(applicationFeatureId, _file);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ImportIntoApplicationFromFile
        /// </summary>
        [Test]
        public void ImportIntoApplicationFromFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //System.IO.Stream _file = null;
            //var response = instance.ImportIntoApplicationFromFile(applicationId, _file);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
