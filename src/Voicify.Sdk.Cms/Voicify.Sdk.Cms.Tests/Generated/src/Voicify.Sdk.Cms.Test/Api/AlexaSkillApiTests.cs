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
    ///  Class for testing AlexaSkillApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AlexaSkillApiTests
    {
        private AlexaSkillApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AlexaSkillApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AlexaSkillApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AlexaSkillApi
            //Assert.IsInstanceOfType(typeof(AlexaSkillApi), instance, "instance is a AlexaSkillApi");
        }

        
        /// <summary>
        /// Test ListAlexaSkills
        /// </summary>
        [Test]
        public void ListAlexaSkillsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tokenId = null;
            //string vendorId = null;
            //var response = instance.ListAlexaSkills(tokenId, vendorId);
            //Assert.IsInstanceOf<List<SkillSummary>> (response, "response is List<SkillSummary>");
        }
        
    }

}