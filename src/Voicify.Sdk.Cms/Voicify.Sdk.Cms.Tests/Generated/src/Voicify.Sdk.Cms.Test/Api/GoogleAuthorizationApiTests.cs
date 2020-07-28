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
    ///  Class for testing GoogleAuthorizationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GoogleAuthorizationApiTests
    {
        private GoogleAuthorizationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GoogleAuthorizationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GoogleAuthorizationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GoogleAuthorizationApi
            //Assert.IsInstanceOfType(typeof(GoogleAuthorizationApi), instance, "instance is a GoogleAuthorizationApi");
        }

        
        /// <summary>
        /// Test GetAvailableGoogleCredentialsAsync
        /// </summary>
        [Test]
        public void GetAvailableGoogleCredentialsAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //var response = instance.GetAvailableGoogleCredentialsAsync(organizationId);
            //Assert.IsInstanceOf<List<TokenResponse>> (response, "response is List<TokenResponse>");
        }
        
        /// <summary>
        /// Test GoogleAuthCallbackAsync
        /// </summary>
        [Test]
        public void GoogleAuthCallbackAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string code = null;
            //string state = null;
            //string error = null;
            //var response = instance.GoogleAuthCallbackAsync(code, state, error);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
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