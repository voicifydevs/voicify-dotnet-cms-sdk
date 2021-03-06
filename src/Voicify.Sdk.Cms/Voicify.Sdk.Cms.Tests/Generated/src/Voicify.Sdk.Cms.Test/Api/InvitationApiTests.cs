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
    ///  Class for testing InvitationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InvitationApiTests
    {
        private InvitationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InvitationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvitationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InvitationApi
            //Assert.IsInstanceOfType(typeof(InvitationApi), instance, "instance is a InvitationApi");
        }

        
        /// <summary>
        /// Test AcceptInvite
        /// </summary>
        [Test]
        public void AcceptInviteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invitationId = null;
            //var response = instance.AcceptInvite(invitationId);
            //Assert.IsInstanceOf<OrganizationMemberModel> (response, "response is OrganizationMemberModel");
        }
        
        /// <summary>
        /// Test DeclineInvite
        /// </summary>
        [Test]
        public void DeclineInviteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invitationId = null;
            //var response = instance.DeclineInvite(invitationId);
            //Assert.IsInstanceOf<InvitationModel> (response, "response is InvitationModel");
        }
        
        /// <summary>
        /// Test GetInvitations
        /// </summary>
        [Test]
        public void GetInvitationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetInvitations();
            //Assert.IsInstanceOf<List<InvitationModel>> (response, "response is List<InvitationModel>");
        }
        
        /// <summary>
        /// Test RevokeInvite
        /// </summary>
        [Test]
        public void RevokeInviteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invitationId = null;
            //var response = instance.RevokeInvite(invitationId);
            //Assert.IsInstanceOf<InvitationModel> (response, "response is InvitationModel");
        }
        
        /// <summary>
        /// Test SendInvite
        /// </summary>
        [Test]
        public void SendInviteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //NewInvitationRequest model = null;
            //var response = instance.SendInvite(organizationId, model);
            //Assert.IsInstanceOf<InvitationModel> (response, "response is InvitationModel");
        }
        
        /// <summary>
        /// Test SendInvite_0
        /// </summary>
        [Test]
        public void SendInvite_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //BasicInvitationRequest model = null;
            //var response = instance.SendInvite_0(organizationId, model);
            //Assert.IsInstanceOf<InvitationModel> (response, "response is InvitationModel");
        }
        
    }

}
