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
    ///  Class for testing SingleSignOnApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SingleSignOnApiTests
    {
        private SingleSignOnApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SingleSignOnApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SingleSignOnApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SingleSignOnApi
            //Assert.IsInstanceOfType(typeof(SingleSignOnApi), instance, "instance is a SingleSignOnApi");
        }

        
        /// <summary>
        /// Test SignInWithSingleSignOn
        /// </summary>
        [Test]
        public void SignInWithSingleSignOnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SingleSignOnRequest request = null;
            //var response = instance.SignInWithSingleSignOn(request);
            //Assert.IsInstanceOf<SingleSignOnResponse> (response, "response is SingleSignOnResponse");
        }
        
        /// <summary>
        /// Test SignUpWithSingleSignOn
        /// </summary>
        [Test]
        public void SignUpWithSingleSignOnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SingleSignOnRequest request = null;
            //var response = instance.SignUpWithSingleSignOn(request);
            //Assert.IsInstanceOf<SingleSignOnResponse> (response, "response is SingleSignOnResponse");
        }
        
    }

}
