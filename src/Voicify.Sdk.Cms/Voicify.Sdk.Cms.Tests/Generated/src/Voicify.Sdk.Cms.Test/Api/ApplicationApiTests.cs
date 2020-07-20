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
    ///  Class for testing ApplicationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ApplicationApiTests
    {
        private ApplicationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ApplicationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ApplicationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ApplicationApi
            //Assert.IsInstanceOfType(typeof(ApplicationApi), instance, "instance is a ApplicationApi");
        }

        
        /// <summary>
        /// Test AddMemberAsync
        /// </summary>
        [Test]
        public void AddMemberAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //NewApplicationMemberRequest model = null;
            //var response = instance.AddMemberAsync(applicationId, model);
            //Assert.IsInstanceOf<ApplicationMemberModel> (response, "response is ApplicationMemberModel");
        }
        
        /// <summary>
        /// Test AddWebhook
        /// </summary>
        [Test]
        public void AddWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //string webhookId = null;
            //WebhookParametersRequest parameters = null;
            //var response = instance.AddWebhook(applicationId, webhookId, parameters);
            //Assert.IsInstanceOf<ApplicationWebhookModel> (response, "response is ApplicationWebhookModel");
        }
        
        /// <summary>
        /// Test BulkAddMemberAsync
        /// </summary>
        [Test]
        public void BulkAddMemberAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //NewBulkApplicationMemberRequest model = null;
            //var response = instance.BulkAddMemberAsync(applicationId, model);
            //Assert.IsInstanceOf<List<ApplicationMemberModel>> (response, "response is List<ApplicationMemberModel>");
        }
        
        /// <summary>
        /// Test CreateApplicationWithSampleContent
        /// </summary>
        [Test]
        public void CreateApplicationWithSampleContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //NewApplicationRequest model = null;
            //var response = instance.CreateApplicationWithSampleContent(organizationId, model);
            //Assert.IsInstanceOf<ApplicationModel> (response, "response is ApplicationModel");
        }
        
        /// <summary>
        /// Test CreateEmptyApplication
        /// </summary>
        [Test]
        public void CreateEmptyApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //NewApplicationRequest model = null;
            //var response = instance.CreateEmptyApplication(organizationId, model);
            //Assert.IsInstanceOf<ApplicationModel> (response, "response is ApplicationModel");
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
        /// Test DeleteApplication
        /// </summary>
        [Test]
        public void DeleteApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //var response = instance.DeleteApplication(applicationId);
            //Assert.IsInstanceOf<ApplicationModel> (response, "response is ApplicationModel");
        }
        
        /// <summary>
        /// Test DisableApplication
        /// </summary>
        [Test]
        public void DisableApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //var response = instance.DisableApplication(applicationId);
            //Assert.IsInstanceOf<ApplicationModel> (response, "response is ApplicationModel");
        }
        
        /// <summary>
        /// Test EnableApplication
        /// </summary>
        [Test]
        public void EnableApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //var response = instance.EnableApplication(applicationId);
            //Assert.IsInstanceOf<ApplicationModel> (response, "response is ApplicationModel");
        }
        
        /// <summary>
        /// Test FindApplication
        /// </summary>
        [Test]
        public void FindApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //var response = instance.FindApplication(applicationId);
            //Assert.IsInstanceOf<ApplicationModel> (response, "response is ApplicationModel");
        }
        
        /// <summary>
        /// Test FindApplicationWithFeatures
        /// </summary>
        [Test]
        public void FindApplicationWithFeaturesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //var response = instance.FindApplicationWithFeatures(applicationId);
            //Assert.IsInstanceOf<ApplicationWithFeaturesModel> (response, "response is ApplicationWithFeaturesModel");
        }
        
        /// <summary>
        /// Test GetAppConversationCount
        /// </summary>
        [Test]
        public void GetAppConversationCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //var response = instance.GetAppConversationCount(applicationId);
            //Assert.IsInstanceOf<ApplicationConversationCountModel> (response, "response is ApplicationConversationCountModel");
        }
        
        /// <summary>
        /// Test GetAppConversationCounts
        /// </summary>
        [Test]
        public void GetAppConversationCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //var response = instance.GetAppConversationCounts(organizationId);
            //Assert.IsInstanceOf<List<ApplicationConversationCountModel>> (response, "response is List<ApplicationConversationCountModel>");
        }
        
        /// <summary>
        /// Test GetAppMembers
        /// </summary>
        [Test]
        public void GetAppMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //var response = instance.GetAppMembers(applicationId);
            //Assert.IsInstanceOf<List<ApplicationMemberModel>> (response, "response is List<ApplicationMemberModel>");
        }
        
        /// <summary>
        /// Test GetApplicationsForOrganization
        /// </summary>
        [Test]
        public void GetApplicationsForOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //var response = instance.GetApplicationsForOrganization(organizationId);
            //Assert.IsInstanceOf<List<ApplicationModel>> (response, "response is List<ApplicationModel>");
        }
        
        /// <summary>
        /// Test GetApplicationsWithFeaturesForOrganization
        /// </summary>
        [Test]
        public void GetApplicationsWithFeaturesForOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //var response = instance.GetApplicationsWithFeaturesForOrganization(organizationId);
            //Assert.IsInstanceOf<List<ApplicationWithFeaturesModel>> (response, "response is List<ApplicationWithFeaturesModel>");
        }
        
        /// <summary>
        /// Test GetFulfillmentEndpoints
        /// </summary>
        [Test]
        public void GetFulfillmentEndpointsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //var response = instance.GetFulfillmentEndpoints(applicationId);
            //Assert.IsInstanceOf<ApplicationFulfillmentEndpoints> (response, "response is ApplicationFulfillmentEndpoints");
        }
        
        /// <summary>
        /// Test GetWebhooks
        /// </summary>
        [Test]
        public void GetWebhooksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //var response = instance.GetWebhooks(applicationId);
            //Assert.IsInstanceOf<List<ApplicationWebhookModel>> (response, "response is List<ApplicationWebhookModel>");
        }
        
        /// <summary>
        /// Test RemoveMember
        /// </summary>
        [Test]
        public void RemoveMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationMemberId = null;
            //var response = instance.RemoveMember(applicationMemberId);
            //Assert.IsInstanceOf<ApplicationMemberModel> (response, "response is ApplicationMemberModel");
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
            //string applicationWebhookId = null;
            //var response = instance.RemoveWebhook(applicationWebhookId);
            //Assert.IsInstanceOf<ApplicationWebhookModel> (response, "response is ApplicationWebhookModel");
        }
        
        /// <summary>
        /// Test SetImage
        /// </summary>
        [Test]
        public void SetImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //string imageItemId = null;
            //var response = instance.SetImage(applicationId, imageItemId);
            //Assert.IsInstanceOf<ApplicationModel> (response, "response is ApplicationModel");
        }
        
        /// <summary>
        /// Test SetInitialPriority
        /// </summary>
        [Test]
        public void SetInitialPriorityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SetInitialPriority();
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test ToggleAllowsTemplate
        /// </summary>
        [Test]
        public void ToggleAllowsTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //ToggleTemplateRequest request = null;
            //var response = instance.ToggleAllowsTemplate(applicationId, request);
            //Assert.IsInstanceOf<ApplicationModel> (response, "response is ApplicationModel");
        }
        
        /// <summary>
        /// Test UpdateAlexaFallbackSensitivity
        /// </summary>
        [Test]
        public void UpdateAlexaFallbackSensitivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //string sensitivityLevel = null;
            //var response = instance.UpdateAlexaFallbackSensitivity(applicationId, sensitivityLevel);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test UpdateApplicationInformation
        /// </summary>
        [Test]
        public void UpdateApplicationInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //UpdateApplicationRequest model = null;
            //var response = instance.UpdateApplicationInformation(applicationId, model);
            //Assert.IsInstanceOf<ApplicationModel> (response, "response is ApplicationModel");
        }
        
        /// <summary>
        /// Test UpdateAttachedWebhook
        /// </summary>
        [Test]
        public void UpdateAttachedWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //string webhookInstanceId = null;
            //WebhookParametersRequest parameters = null;
            //var response = instance.UpdateAttachedWebhook(applicationId, webhookInstanceId, parameters);
            //Assert.IsInstanceOf<ApplicationWebhookModel> (response, "response is ApplicationWebhookModel");
        }
        
        /// <summary>
        /// Test UpdateDefaultLangauge
        /// </summary>
        [Test]
        public void UpdateDefaultLangaugeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //string languageId = null;
            //var response = instance.UpdateDefaultLangauge(applicationId, languageId);
            //Assert.IsInstanceOf<ApplicationModel> (response, "response is ApplicationModel");
        }
        
        /// <summary>
        /// Test UpdateLangauges
        /// </summary>
        [Test]
        public void UpdateLangaugesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationId = null;
            //List<string> languageIds = null;
            //var response = instance.UpdateLangauges(applicationId, languageIds);
            //Assert.IsInstanceOf<ApplicationModel> (response, "response is ApplicationModel");
        }
        
        /// <summary>
        /// Test UpdateMemberRole
        /// </summary>
        [Test]
        public void UpdateMemberRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationMemberId = null;
            //MemberRoleUpdateRequest model = null;
            //var response = instance.UpdateMemberRole(applicationMemberId, model);
            //Assert.IsInstanceOf<ApplicationMemberModel> (response, "response is ApplicationMemberModel");
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
