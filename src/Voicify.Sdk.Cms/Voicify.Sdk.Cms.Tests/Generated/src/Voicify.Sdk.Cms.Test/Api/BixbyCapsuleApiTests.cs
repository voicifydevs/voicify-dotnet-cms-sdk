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

namespace Voicify.Sdk.Cms.Test
{
    /// <summary>
    ///  Class for testing BixbyCapsuleApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BixbyCapsuleApiTests
    {
        private BixbyCapsuleApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BixbyCapsuleApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BixbyCapsuleApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BixbyCapsuleApi
            //Assert.IsInstanceOfType(typeof(BixbyCapsuleApi), instance, "instance is a BixbyCapsuleApi");
        }

        
        /// <summary>
        /// Test GetApplicationBixbyProperties
        /// </summary>
        [Test]
        public void GetApplicationBixbyPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //var response = instance.GetApplicationBixbyProperties(applicationId);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test GetBaseBixbyCapsuleTemplate
        /// </summary>
        [Test]
        public void GetBaseBixbyCapsuleTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetBaseBixbyCapsuleTemplate();
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
    }

}
