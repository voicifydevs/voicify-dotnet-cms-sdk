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
    ///  Class for testing SimpleChoiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SimpleChoiceApiTests
    {
        private SimpleChoiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SimpleChoiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SimpleChoiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SimpleChoiceApi
            //Assert.IsInstanceOfType(typeof(SimpleChoiceApi), instance, "instance is a SimpleChoiceApi");
        }

        
        /// <summary>
        /// Test AddAudioFile
        /// </summary>
        [Test]
        public void AddAudioFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceResponseId = null;
            //string mediaItemId = null;
            //var response = instance.AddAudioFile(simpleChoiceResponseId, mediaItemId);
            //Assert.IsInstanceOf<SimpleChoiceResponseModel> (response, "response is SimpleChoiceResponseModel");
        }
        
        /// <summary>
        /// Test AddLargeImage
        /// </summary>
        [Test]
        public void AddLargeImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceResponseId = null;
            //string mediaItemId = null;
            //var response = instance.AddLargeImage(simpleChoiceResponseId, mediaItemId);
            //Assert.IsInstanceOf<SimpleChoiceResponseModel> (response, "response is SimpleChoiceResponseModel");
        }
        
        /// <summary>
        /// Test AddSmallImage
        /// </summary>
        [Test]
        public void AddSmallImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceResponseId = null;
            //string mediaItemId = null;
            //var response = instance.AddSmallImage(simpleChoiceResponseId, mediaItemId);
            //Assert.IsInstanceOf<SimpleChoiceResponseModel> (response, "response is SimpleChoiceResponseModel");
        }
        
        /// <summary>
        /// Test AddVideoFile
        /// </summary>
        [Test]
        public void AddVideoFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceResponseId = null;
            //string mediaItemId = null;
            //var response = instance.AddVideoFile(simpleChoiceResponseId, mediaItemId);
            //Assert.IsInstanceOf<SimpleChoiceResponseModel> (response, "response is SimpleChoiceResponseModel");
        }
        
        /// <summary>
        /// Test AddWebhook
        /// </summary>
        [Test]
        public void AddWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceId = null;
            //string webhookId = null;
            //WebhookParametersRequest parameters = null;
            //var response = instance.AddWebhook(simpleChoiceId, webhookId, parameters);
            //Assert.IsInstanceOf<SimpleChoiceWebhookModel> (response, "response is SimpleChoiceWebhookModel");
        }
        
        /// <summary>
        /// Test BulkUpdateSimpleChoice
        /// </summary>
        [Test]
        public void BulkUpdateSimpleChoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceId = null;
            //BulkUpdateSimpleChoiceRequest model = null;
            //var response = instance.BulkUpdateSimpleChoice(simpleChoiceId, model);
            //Assert.IsInstanceOf<SimpleChoiceModel> (response, "response is SimpleChoiceModel");
        }
        
        /// <summary>
        /// Test BulkUpdateSimpleChoiceStub
        /// </summary>
        [Test]
        public void BulkUpdateSimpleChoiceStubTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceId = null;
            //BulkUpdateSimpleChoiceStubRequest model = null;
            //var response = instance.BulkUpdateSimpleChoiceStub(simpleChoiceId, model);
            //Assert.IsInstanceOf<SimpleChoiceModel> (response, "response is SimpleChoiceModel");
        }
        
        /// <summary>
        /// Test CopyContentItem
        /// </summary>
        [Test]
        public void CopyContentItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceId = null;
            //var response = instance.CopyContentItem(simpleChoiceId);
            //Assert.IsInstanceOf<SimpleChoiceModel> (response, "response is SimpleChoiceModel");
        }
        
        /// <summary>
        /// Test CreateFullContentItem
        /// </summary>
        [Test]
        public void CreateFullContentItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SimpleChoiceModel model = null;
            //var response = instance.CreateFullContentItem(model);
            //Assert.IsInstanceOf<SimpleChoiceModel> (response, "response is SimpleChoiceModel");
        }
        
        /// <summary>
        /// Test CreateResponse
        /// </summary>
        [Test]
        public void CreateResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceId = null;
            //NewSimpleChoiceResponseRequest model = null;
            //var response = instance.CreateResponse(simpleChoiceId, model);
            //Assert.IsInstanceOf<SimpleChoiceResponseModel> (response, "response is SimpleChoiceResponseModel");
        }
        
        /// <summary>
        /// Test CreateSimpleChoice
        /// </summary>
        [Test]
        public void CreateSimpleChoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NewSimpleChoiceRequest model = null;
            //var response = instance.CreateSimpleChoice(model);
            //Assert.IsInstanceOf<SimpleChoiceModel> (response, "response is SimpleChoiceModel");
        }
        
        /// <summary>
        /// Test CreateSimpleChoiceStub
        /// </summary>
        [Test]
        public void CreateSimpleChoiceStubTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NewSimpleChoiceStubRequest model = null;
            //var response = instance.CreateSimpleChoiceStub(model);
            //Assert.IsInstanceOf<SimpleChoiceModel> (response, "response is SimpleChoiceModel");
        }
        
        /// <summary>
        /// Test CreateUserDefinedParameter
        /// </summary>
        [Test]
        public void CreateUserDefinedParameterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceWebhookId = null;
            //UserDefinedWebhookParameterCreateRequest request = null;
            //var response = instance.CreateUserDefinedParameter(instanceWebhookId, request);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test DeleteResponse
        /// </summary>
        [Test]
        public void DeleteResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceResponseId = null;
            //var response = instance.DeleteResponse(simpleChoiceResponseId);
            //Assert.IsInstanceOf<SimpleChoiceResponseModel> (response, "response is SimpleChoiceResponseModel");
        }
        
        /// <summary>
        /// Test DeleteSimpleChoice
        /// </summary>
        [Test]
        public void DeleteSimpleChoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceId = null;
            //var response = instance.DeleteSimpleChoice(simpleChoiceId);
            //Assert.IsInstanceOf<SimpleChoiceModel> (response, "response is SimpleChoiceModel");
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
            //Assert.IsInstanceOf<SimpleChoiceModel> (response, "response is SimpleChoiceModel");
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
            //Assert.IsInstanceOf<List<SimpleChoiceModel>> (response, "response is List<SimpleChoiceModel>");
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
            //Assert.IsInstanceOf<List<SimpleChoiceModel>> (response, "response is List<SimpleChoiceModel>");
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
            //Assert.IsInstanceOf<List<SimpleChoiceModel>> (response, "response is List<SimpleChoiceModel>");
        }
        
        /// <summary>
        /// Test GetWebhooks
        /// </summary>
        [Test]
        public void GetWebhooksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceId = null;
            //var response = instance.GetWebhooks(simpleChoiceId);
            //Assert.IsInstanceOf<List<SimpleChoiceWebhookModel>> (response, "response is List<SimpleChoiceWebhookModel>");
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
            //Assert.IsInstanceOf<SimpleChoiceModel> (response, "response is SimpleChoiceModel");
        }
        
        /// <summary>
        /// Test RemoveUserDefinedParameter
        /// </summary>
        [Test]
        public void RemoveUserDefinedParameterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceWebhookId = null;
            //string parameterName = null;
            //var response = instance.RemoveUserDefinedParameter(instanceWebhookId, parameterName);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test RemoveWebhook
        /// </summary>
        [Test]
        public void RemoveWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceWebhookId = null;
            //var response = instance.RemoveWebhook(simpleChoiceWebhookId);
            //Assert.IsInstanceOf<SimpleChoiceWebhookModel> (response, "response is SimpleChoiceWebhookModel");
        }
        
        /// <summary>
        /// Test ToggleLive
        /// </summary>
        [Test]
        public void ToggleLiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceId = null;
            //ToggleLiveRequest model = null;
            //var response = instance.ToggleLive(simpleChoiceId, model);
            //Assert.IsInstanceOf<SimpleChoiceModel> (response, "response is SimpleChoiceModel");
        }
        
        /// <summary>
        /// Test UpdateAttachedWebhook
        /// </summary>
        [Test]
        public void UpdateAttachedWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceId = null;
            //string webhookInstanceId = null;
            //WebhookParametersRequest parameters = null;
            //var response = instance.UpdateAttachedWebhook(simpleChoiceId, webhookInstanceId, parameters);
            //Assert.IsInstanceOf<SimpleChoiceWebhookModel> (response, "response is SimpleChoiceWebhookModel");
        }
        
        /// <summary>
        /// Test UpdateFullContentItem
        /// </summary>
        [Test]
        public void UpdateFullContentItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentItemId = null;
            //SimpleChoiceModel model = null;
            //var response = instance.UpdateFullContentItem(contentItemId, model);
            //Assert.IsInstanceOf<SimpleChoiceModel> (response, "response is SimpleChoiceModel");
        }
        
        /// <summary>
        /// Test UpdateMessage
        /// </summary>
        [Test]
        public void UpdateMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceId = null;
            //UpdateSimpleChoiceRequest model = null;
            //var response = instance.UpdateMessage(simpleChoiceId, model);
            //Assert.IsInstanceOf<SimpleChoiceModel> (response, "response is SimpleChoiceModel");
        }
        
        /// <summary>
        /// Test UpdateResponse
        /// </summary>
        [Test]
        public void UpdateResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string simpleChoiceResponseId = null;
            //UpdateSimpleChoiceResponseRequest model = null;
            //var response = instance.UpdateResponse(simpleChoiceResponseId, model);
            //Assert.IsInstanceOf<SimpleChoiceResponseModel> (response, "response is SimpleChoiceResponseModel");
        }
        
        /// <summary>
        /// Test UpdateUserDefinedParameter
        /// </summary>
        [Test]
        public void UpdateUserDefinedParameterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceWebhookId = null;
            //UserDefinedWebhookParameterUpdateRequest request = null;
            //var response = instance.UpdateUserDefinedParameter(instanceWebhookId, request);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test UpdateWebhookParameter
        /// </summary>
        [Test]
        public void UpdateWebhookParameterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceWebhookId = null;
            //WebhookParameterUpdateRequest request = null;
            //var response = instance.UpdateWebhookParameter(instanceWebhookId, request);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
    }

}
