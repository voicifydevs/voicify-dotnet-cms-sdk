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
    ///  Class for testing SubscriptionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SubscriptionApiTests
    {
        private SubscriptionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SubscriptionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubscriptionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SubscriptionApi
            //Assert.IsInstanceOfType(typeof(SubscriptionApi), instance, "instance is a SubscriptionApi");
        }

        
        /// <summary>
        /// Test GetBuiltInTypes
        /// </summary>
        [Test]
        public void GetBuiltInTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetBuiltInTypes();
            //Assert.IsInstanceOf<List<SubscriptionTypeModel>> (response, "response is List<SubscriptionTypeModel>");
        }
        
        /// <summary>
        /// Test GetSubscriptionsForOrganization
        /// </summary>
        [Test]
        public void GetSubscriptionsForOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //var response = instance.GetSubscriptionsForOrganization(organizationId);
            //Assert.IsInstanceOf<List<SubscriptionModel>> (response, "response is List<SubscriptionModel>");
        }
        
    }

}