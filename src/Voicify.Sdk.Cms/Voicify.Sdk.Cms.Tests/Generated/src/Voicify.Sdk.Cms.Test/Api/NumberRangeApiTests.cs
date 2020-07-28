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
    ///  Class for testing NumberRangeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class NumberRangeApiTests
    {
        private NumberRangeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new NumberRangeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NumberRangeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' NumberRangeApi
            //Assert.IsInstanceOfType(typeof(NumberRangeApi), instance, "instance is a NumberRangeApi");
        }

        
        /// <summary>
        /// Test AddAudioFile
        /// </summary>
        [Test]
        public void AddAudioFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string numberRangeResponseId = null;
            //string mediaItemId = null;
            //var response = instance.AddAudioFile(numberRangeResponseId, mediaItemId);
            //Assert.IsInstanceOf<NumberRangeResponseModel> (response, "response is NumberRangeResponseModel");
        }
        
        /// <summary>
        /// Test AddLargeImage
        /// </summary>
        [Test]
        public void AddLargeImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string numberRangeResponseId = null;
            //string mediaItemId = null;
            //var response = instance.AddLargeImage(numberRangeResponseId, mediaItemId);
            //Assert.IsInstanceOf<NumberRangeResponseModel> (response, "response is NumberRangeResponseModel");
        }
        
        /// <summary>
        /// Test AddSmallImage
        /// </summary>
        [Test]
        public void AddSmallImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string numberRangeResponseId = null;
            //string mediaItemId = null;
            //var response = instance.AddSmallImage(numberRangeResponseId, mediaItemId);
            //Assert.IsInstanceOf<NumberRangeResponseModel> (response, "response is NumberRangeResponseModel");
        }
        
        /// <summary>
        /// Test AddVideoFile
        /// </summary>
        [Test]
        public void AddVideoFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string numberRangeResponseId = null;
            //string mediaItemId = null;
            //var response = instance.AddVideoFile(numberRangeResponseId, mediaItemId);
            //Assert.IsInstanceOf<NumberRangeResponseModel> (response, "response is NumberRangeResponseModel");
        }
        
        /// <summary>
        /// Test AddWebhook
        /// </summary>
        [Test]
        public void AddWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string numberRangeId = null;
            //string webhookId = null;
            //WebhookParametersRequest parameters = null;
            //var response = instance.AddWebhook(numberRangeId, webhookId, parameters);
            //Assert.IsInstanceOf<NumberRangeWebhookModel> (response, "response is NumberRangeWebhookModel");
        }
        
        /// <summary>
        /// Test BulkUpdateNumberRange
        /// </summary>
        [Test]
        public void BulkUpdateNumberRangeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string numberRangeId = null;
            //BulkUpdateNumberRangeRequest model = null;
            //var response = instance.BulkUpdateNumberRange(numberRangeId, model);
            //Assert.IsInstanceOf<NumberRangeModel> (response, "response is NumberRangeModel");
        }
        
        /// <summary>
        /// Test BulkUpdateNumberRangeStub
        /// </summary>
        [Test]
        public void BulkUpdateNumberRangeStubTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string numberRangeId = null;
            //BulkUpdateNumberRangeStubRequest model = null;
            //var response = instance.BulkUpdateNumberRangeStub(numberRangeId, model);
            //Assert.IsInstanceOf<NumberRangeModel> (response, "response is NumberRangeModel");
        }
        
        /// <summary>
        /// Test CopyContentItem
        /// </summary>
        [Test]
        public void CopyContentItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string numberRangeId = null;
            //var response = instance.CopyContentItem(numberRangeId);
            //Assert.IsInstanceOf<NumberRangeModel> (response, "response is NumberRangeModel");
        }
        
        /// <summary>
        /// Test CreateFullContentItem
        /// </summary>
        [Test]
        public void CreateFullContentItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NumberRangeModel model = null;
            //var response = instance.CreateFullContentItem(model);
            //Assert.IsInstanceOf<NumberRangeModel> (response, "response is NumberRangeModel");
        }
        
        /// <summary>
        /// Test CreateNumberRange
        /// </summary>
        [Test]
        public void CreateNumberRangeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NewNumberRangeRequest model = null;
            //var response = instance.CreateNumberRange(model);
            //Assert.IsInstanceOf<NumberRangeModel> (response, "response is NumberRangeModel");
        }
        
        /// <summary>
        /// Test CreateNumberRangeStub
        /// </summary>
        [Test]
        public void CreateNumberRangeStubTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NewNumberRangeStubRequest model = null;
            //var response = instance.CreateNumberRangeStub(model);
            //Assert.IsInstanceOf<NumberRangeModel> (response, "response is NumberRangeModel");
        }
        
        /// <summary>
        /// Test CreateResponse
        /// </summary>
        [Test]
        public void CreateResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string numberRangeId = null;
            //NewNumberRangeResponseRequest model = null;
            //var response = instance.CreateResponse(numberRangeId, model);
            //Assert.IsInstanceOf<NumberRangeResponseModel> (response, "response is NumberRangeResponseModel");
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
        /// Test DeleteNumberRange
        /// </summary>
        [Test]
        public void DeleteNumberRangeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string numberRangeId = null;
            //var response = instance.DeleteNumberRange(numberRangeId);
            //Assert.IsInstanceOf<NumberRangeModel> (response, "response is NumberRangeModel");
        }
        
        /// <summary>
        /// Test DeleteResponse
        /// </summary>
        [Test]
        public void DeleteResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string numberRangeResponseId = null;
            //var response = instance.DeleteResponse(numberRangeResponseId);
            //Assert.IsInstanceOf<NumberRangeResponseModel> (response, "response is NumberRangeResponseModel");
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
            //Assert.IsInstanceOf<NumberRangeModel> (response, "response is NumberRangeModel");
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
            //Assert.IsInstanceOf<List<NumberRangeModel>> (response, "response is List<NumberRangeModel>");
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
            //Assert.IsInstanceOf<List<NumberRangeModel>> (response, "response is List<NumberRangeModel>");
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
            //Assert.IsInstanceOf<List<NumberRangeModel>> (response, "response is List<NumberRangeModel>");
        }
        
        /// <summary>
        /// Test GetWebhooks
        /// </summary>
        [Test]
        public void GetWebhooksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string numberRangeId = null;
            //var response = instance.GetWebhooks(numberRangeId);
            //Assert.IsInstanceOf<List<NumberRangeWebhookModel>> (response, "response is List<NumberRangeWebhookModel>");
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
            //Assert.IsInstanceOf<NumberRangeModel> (response, "response is NumberRangeModel");
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
            //string numberRangeWebhookId = null;
            //var response = instance.RemoveWebhook(numberRangeWebhookId);
            //Assert.IsInstanceOf<NumberRangeWebhookModel> (response, "response is NumberRangeWebhookModel");
        }
        
        /// <summary>
        /// Test ToggleLive
        /// </summary>
        [Test]
        public void ToggleLiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string numberRangeId = null;
            //ToggleLiveRequest model = null;
            //var response = instance.ToggleLive(numberRangeId, model);
            //Assert.IsInstanceOf<NumberRangeModel> (response, "response is NumberRangeModel");
        }
        
        /// <summary>
        /// Test UpdateAttachedWebhook
        /// </summary>
        [Test]
        public void UpdateAttachedWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string numberRangeId = null;
            //string webhookInstanceId = null;
            //WebhookParametersRequest parameters = null;
            //var response = instance.UpdateAttachedWebhook(numberRangeId, webhookInstanceId, parameters);
            //Assert.IsInstanceOf<NumberRangeWebhookModel> (response, "response is NumberRangeWebhookModel");
        }
        
        /// <summary>
        /// Test UpdateFullContentItem
        /// </summary>
        [Test]
        public void UpdateFullContentItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentItemId = null;
            //NumberRangeModel model = null;
            //var response = instance.UpdateFullContentItem(contentItemId, model);
            //Assert.IsInstanceOf<NumberRangeModel> (response, "response is NumberRangeModel");
        }
        
        /// <summary>
        /// Test UpdateMessage
        /// </summary>
        [Test]
        public void UpdateMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string numberRangeId = null;
            //UpdateNumberRangeRequest model = null;
            //var response = instance.UpdateMessage(numberRangeId, model);
            //Assert.IsInstanceOf<NumberRangeModel> (response, "response is NumberRangeModel");
        }
        
        /// <summary>
        /// Test UpdateResponse
        /// </summary>
        [Test]
        public void UpdateResponseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string numberRangeResponseId = null;
            //UpdateNumberRangeResponseRequest model = null;
            //var response = instance.UpdateResponse(numberRangeResponseId, model);
            //Assert.IsInstanceOf<NumberRangeResponseModel> (response, "response is NumberRangeResponseModel");
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
