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
    ///  Class for testing CustomRequestApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CustomRequestApiTests
    {
        private CustomRequestApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CustomRequestApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CustomRequestApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CustomRequestApi
            //Assert.IsInstanceOfType(typeof(CustomRequestApi), instance, "instance is a CustomRequestApi");
        }

        
        /// <summary>
        /// Test AddAudioFile
        /// </summary>
        [Test]
        public void AddAudioFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestResponseId = null;
            //string mediaItemId = null;
            //var response = instance.AddAudioFile(customRequestResponseId, mediaItemId);
            //Assert.IsInstanceOf<CustomRequestResponseModel> (response, "response is CustomRequestResponseModel");
        }
        
        /// <summary>
        /// Test AddLargeImage
        /// </summary>
        [Test]
        public void AddLargeImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestResponseId = null;
            //string mediaItemId = null;
            //var response = instance.AddLargeImage(customRequestResponseId, mediaItemId);
            //Assert.IsInstanceOf<CustomRequestResponseModel> (response, "response is CustomRequestResponseModel");
        }
        
        /// <summary>
        /// Test AddSmallImage
        /// </summary>
        [Test]
        public void AddSmallImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestResponseId = null;
            //string mediaItemId = null;
            //var response = instance.AddSmallImage(customRequestResponseId, mediaItemId);
            //Assert.IsInstanceOf<CustomRequestResponseModel> (response, "response is CustomRequestResponseModel");
        }
        
        /// <summary>
        /// Test AddVideoFile
        /// </summary>
        [Test]
        public void AddVideoFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestResponseId = null;
            //string mediaItemId = null;
            //var response = instance.AddVideoFile(customRequestResponseId, mediaItemId);
            //Assert.IsInstanceOf<CustomRequestResponseModel> (response, "response is CustomRequestResponseModel");
        }
        
        /// <summary>
        /// Test AddWebhook
        /// </summary>
        [Test]
        public void AddWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestId = null;
            //string webhookId = null;
            //WebhookParametersRequest parameters = null;
            //var response = instance.AddWebhook(customRequestId, webhookId, parameters);
            //Assert.IsInstanceOf<CustomRequestWebhookModel> (response, "response is CustomRequestWebhookModel");
        }
        
        /// <summary>
        /// Test BulkUpdateCustomRequest
        /// </summary>
        [Test]
        public void BulkUpdateCustomRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestId = null;
            //BulkUpdateCustomRequestRequest model = null;
            //var response = instance.BulkUpdateCustomRequest(customRequestId, model);
            //Assert.IsInstanceOf<CustomRequestModel> (response, "response is CustomRequestModel");
        }
        
        /// <summary>
        /// Test BulkUpdateCustomRequestStub
        /// </summary>
        [Test]
        public void BulkUpdateCustomRequestStubTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestId = null;
            //BulkUpdateCustomRequestStubRequest model = null;
            //var response = instance.BulkUpdateCustomRequestStub(customRequestId, model);
            //Assert.IsInstanceOf<CustomRequestModel> (response, "response is CustomRequestModel");
        }
        
        /// <summary>
        /// Test CopyContentItem
        /// </summary>
        [Test]
        public void CopyContentItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestId = null;
            //var response = instance.CopyContentItem(customRequestId);
            //Assert.IsInstanceOf<CustomRequestModel> (response, "response is CustomRequestModel");
        }
        
        /// <summary>
        /// Test CreateCustomRequest
        /// </summary>
        [Test]
        public void CreateCustomRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NewCustomRequestRequest model = null;
            //var response = instance.CreateCustomRequest(model);
            //Assert.IsInstanceOf<CustomRequestModel> (response, "response is CustomRequestModel");
        }
        
        /// <summary>
        /// Test CreateCustomRequestStub
        /// </summary>
        [Test]
        public void CreateCustomRequestStubTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NewCustomRequestStubRequest model = null;
            //var response = instance.CreateCustomRequestStub(model);
            //Assert.IsInstanceOf<CustomRequestModel> (response, "response is CustomRequestModel");
        }
        
        /// <summary>
        /// Test CreateFullContentItem
        /// </summary>
        [Test]
        public void CreateFullContentItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CustomRequestModel model = null;
            //var response = instance.CreateFullContentItem(model);
            //Assert.IsInstanceOf<CustomRequestModel> (response, "response is CustomRequestModel");
        }
        
        /// <summary>
        /// Test CreateResponse
        /// </summary>
        [Test]
        public void CreateResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestId = null;
            //NewCustomRequestResponseRequest model = null;
            //var response = instance.CreateResponse(customRequestId, model);
            //Assert.IsInstanceOf<CustomRequestResponseModel> (response, "response is CustomRequestResponseModel");
        }
        
        /// <summary>
        /// Test DeleteCustomRequest
        /// </summary>
        [Test]
        public void DeleteCustomRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestId = null;
            //var response = instance.DeleteCustomRequest(customRequestId);
            //Assert.IsInstanceOf<CustomRequestModel> (response, "response is CustomRequestModel");
        }
        
        /// <summary>
        /// Test DeleteResponse
        /// </summary>
        [Test]
        public void DeleteResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestResponseId = null;
            //var response = instance.DeleteResponse(customRequestResponseId);
            //Assert.IsInstanceOf<CustomRequestResponseModel> (response, "response is CustomRequestResponseModel");
        }
        
        /// <summary>
        /// Test FindFullById
        /// </summary>
        [Test]
        public void FindFullByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.FindFullById(id);
            //Assert.IsInstanceOf<CustomRequestModel> (response, "response is CustomRequestModel");
        }
        
        /// <summary>
        /// Test GetByApplicationFeature
        /// </summary>
        [Test]
        public void GetByApplicationFeatureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationFeatureId = null;
            //var response = instance.GetByApplicationFeature(applicationFeatureId);
            //Assert.IsInstanceOf<List<CustomRequestModel>> (response, "response is List<CustomRequestModel>");
        }
        
        /// <summary>
        /// Test GetMediaItemsForCustomRequest
        /// </summary>
        [Test]
        public void GetMediaItemsForCustomRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestResponseId = null;
            //var response = instance.GetMediaItemsForCustomRequest(customRequestResponseId);
            //Assert.IsInstanceOf<List<MediaItemModel>> (response, "response is List<MediaItemModel>");
        }
        
        /// <summary>
        /// Test GetMessagesForApplication
        /// </summary>
        [Test]
        public void GetMessagesForApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //var response = instance.GetMessagesForApplication(applicationId);
            //Assert.IsInstanceOf<List<CustomRequestModel>> (response, "response is List<CustomRequestModel>");
        }
        
        /// <summary>
        /// Test GetMessagesForModule
        /// </summary>
        [Test]
        public void GetMessagesForModuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationModuleId = null;
            //var response = instance.GetMessagesForModule(applicationModuleId);
            //Assert.IsInstanceOf<List<CustomRequestModel>> (response, "response is List<CustomRequestModel>");
        }
        
        /// <summary>
        /// Test GetWebhooks
        /// </summary>
        [Test]
        public void GetWebhooksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestId = null;
            //var response = instance.GetWebhooks(customRequestId);
            //Assert.IsInstanceOf<List<CustomRequestWebhookModel>> (response, "response is List<CustomRequestWebhookModel>");
        }
        
        /// <summary>
        /// Test MoveContentItemToApplicationFeature
        /// </summary>
        [Test]
        public void MoveContentItemToApplicationFeatureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentItemId = null;
            //string applicationFeatureId = null;
            //var response = instance.MoveContentItemToApplicationFeature(contentItemId, applicationFeatureId);
            //Assert.IsInstanceOf<CustomRequestModel> (response, "response is CustomRequestModel");
        }
        
        /// <summary>
        /// Test RemoveWebhook
        /// </summary>
        [Test]
        public void RemoveWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestWebhookId = null;
            //var response = instance.RemoveWebhook(customRequestWebhookId);
            //Assert.IsInstanceOf<CustomRequestWebhookModel> (response, "response is CustomRequestWebhookModel");
        }
        
        /// <summary>
        /// Test ToggleLive
        /// </summary>
        [Test]
        public void ToggleLiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestId = null;
            //ToggleLiveRequest model = null;
            //var response = instance.ToggleLive(customRequestId, model);
            //Assert.IsInstanceOf<CustomRequestModel> (response, "response is CustomRequestModel");
        }
        
        /// <summary>
        /// Test UpdateAttachedWebhook
        /// </summary>
        [Test]
        public void UpdateAttachedWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestId = null;
            //string webhookInstanceId = null;
            //WebhookParametersRequest parameters = null;
            //var response = instance.UpdateAttachedWebhook(customRequestId, webhookInstanceId, parameters);
            //Assert.IsInstanceOf<CustomRequestWebhookModel> (response, "response is CustomRequestWebhookModel");
        }
        
        /// <summary>
        /// Test UpdateFullContentItem
        /// </summary>
        [Test]
        public void UpdateFullContentItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentItemId = null;
            //CustomRequestModel model = null;
            //var response = instance.UpdateFullContentItem(contentItemId, model);
            //Assert.IsInstanceOf<CustomRequestModel> (response, "response is CustomRequestModel");
        }
        
        /// <summary>
        /// Test UpdateMessage
        /// </summary>
        [Test]
        public void UpdateMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestId = null;
            //UpdateCustomRequestRequest model = null;
            //var response = instance.UpdateMessage(customRequestId, model);
            //Assert.IsInstanceOf<CustomRequestModel> (response, "response is CustomRequestModel");
        }
        
        /// <summary>
        /// Test UpdateResponse
        /// </summary>
        [Test]
        public void UpdateResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customRequestResponseId = null;
            //UpdateCustomRequestResponseRequest model = null;
            //var response = instance.UpdateResponse(customRequestResponseId, model);
            //Assert.IsInstanceOf<CustomRequestResponseModel> (response, "response is CustomRequestResponseModel");
        }
        
    }

}
