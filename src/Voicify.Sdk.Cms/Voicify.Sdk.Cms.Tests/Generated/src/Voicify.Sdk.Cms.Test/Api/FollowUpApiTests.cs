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
    ///  Class for testing FollowUpApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FollowUpApiTests
    {
        private FollowUpApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FollowUpApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FollowUpApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FollowUpApi
            //Assert.IsInstanceOfType(typeof(FollowUpApi), instance, "instance is a FollowUpApi");
        }

        
        /// <summary>
        /// Test CreateFollowUp
        /// </summary>
        [Test]
        public void CreateFollowUpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //CreateFollowUpRequest model = null;
            //var response = instance.CreateFollowUp(applicationId, model);
            //Assert.IsInstanceOf<FollowUpModel> (response, "response is FollowUpModel");
        }
        
        /// <summary>
        /// Test DeleteFollowUp
        /// </summary>
        [Test]
        public void DeleteFollowUpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string followUpId = null;
            //var response = instance.DeleteFollowUp(followUpId);
            //Assert.IsInstanceOf<FollowUpModel> (response, "response is FollowUpModel");
        }
        
        /// <summary>
        /// Test FindChildContentContainer
        /// </summary>
        [Test]
        public void FindChildContentContainerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string followUpId = null;
            //var response = instance.FindChildContentContainer(followUpId);
            //Assert.IsInstanceOf<ChildContentContainerModel> (response, "response is ChildContentContainerModel");
        }
        
        /// <summary>
        /// Test FindFollowUp
        /// </summary>
        [Test]
        public void FindFollowUpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string followUpId = null;
            //var response = instance.FindFollowUp(followUpId);
            //Assert.IsInstanceOf<FollowUpModel> (response, "response is FollowUpModel");
        }
        
        /// <summary>
        /// Test GetForApplication
        /// </summary>
        [Test]
        public void GetForApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //var response = instance.GetForApplication(applicationId);
            //Assert.IsInstanceOf<List<FollowUpModel>> (response, "response is List<FollowUpModel>");
        }
        
        /// <summary>
        /// Test GetParentContentItems
        /// </summary>
        [Test]
        public void GetParentContentItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string featureTypeId = null;
            //string contentId = null;
            //var response = instance.GetParentContentItems(featureTypeId, contentId);
            //Assert.IsInstanceOf<ParentContentContainerModel> (response, "response is ParentContentContainerModel");
        }
        
        /// <summary>
        /// Test GetParentsOfContent
        /// </summary>
        [Test]
        public void GetParentsOfContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string featureTypeId = null;
            //string contentId = null;
            //var response = instance.GetParentsOfContent(featureTypeId, contentId);
            //Assert.IsInstanceOf<List<FollowUpModel>> (response, "response is List<FollowUpModel>");
        }
        
        /// <summary>
        /// Test UpdateFollowUp
        /// </summary>
        [Test]
        public void UpdateFollowUpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateFollowUpRequest model = null;
            //var response = instance.UpdateFollowUp(model);
            //Assert.IsInstanceOf<FollowUpModel> (response, "response is FollowUpModel");
        }
        
    }

}
