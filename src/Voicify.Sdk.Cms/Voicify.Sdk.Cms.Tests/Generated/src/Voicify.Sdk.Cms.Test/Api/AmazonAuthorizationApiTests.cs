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
    ///  Class for testing AmazonAuthorizationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AmazonAuthorizationApiTests
    {
        private AmazonAuthorizationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AmazonAuthorizationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AmazonAuthorizationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AmazonAuthorizationApi
            //Assert.IsInstanceOfType(typeof(AmazonAuthorizationApi), instance, "instance is a AmazonAuthorizationApi");
        }

        
        /// <summary>
        /// Test AmazonAuthCallbackAsync
        /// </summary>
        [Test]
        public void AmazonAuthCallbackAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string code = null;
            //string state = null;
            //string error = null;
            //var response = instance.AmazonAuthCallbackAsync(code, state, error);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test GetAvailableCredentials
        /// </summary>
        [Test]
        public void GetAvailableCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //var response = instance.GetAvailableCredentials(organizationId);
            //Assert.IsInstanceOf<List<TokenResponse>> (response, "response is List<TokenResponse>");
        }
        
        /// <summary>
        /// Test RemoveCredential
        /// </summary>
        [Test]
        public void RemoveCredentialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tokenId = null;
            //var response = instance.RemoveCredential(tokenId);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test RequestAuthenticationUrl
        /// </summary>
        [Test]
        public void RequestAuthenticationUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //string applicationId = null;
            //string salt = null;
            //var response = instance.RequestAuthenticationUrl(organizationId, applicationId, salt);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
