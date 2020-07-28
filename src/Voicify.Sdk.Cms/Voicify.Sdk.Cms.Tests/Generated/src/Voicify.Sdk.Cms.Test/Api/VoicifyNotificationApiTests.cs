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
    ///  Class for testing VoicifyNotificationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class VoicifyNotificationApiTests
    {
        private VoicifyNotificationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VoicifyNotificationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VoicifyNotificationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VoicifyNotificationApi
            //Assert.IsInstanceOfType(typeof(VoicifyNotificationApi), instance, "instance is a VoicifyNotificationApi");
        }

        
        /// <summary>
        /// Test GetUnreadNotifications
        /// </summary>
        [Test]
        public void GetUnreadNotificationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUnreadNotifications();
            //Assert.IsInstanceOf<List<UserVoicifyNotificationModel>> (response, "response is List<UserVoicifyNotificationModel>");
        }
        
        /// <summary>
        /// Test GetUserNotifications
        /// </summary>
        [Test]
        public void GetUserNotificationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUserNotifications();
            //Assert.IsInstanceOf<List<UserVoicifyNotificationModel>> (response, "response is List<UserVoicifyNotificationModel>");
        }
        
        /// <summary>
        /// Test MarkAllAsRead
        /// </summary>
        [Test]
        public void MarkAllAsReadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.MarkAllAsRead();
            //Assert.IsInstanceOf<List<UserVoicifyNotificationModel>> (response, "response is List<UserVoicifyNotificationModel>");
        }
        
        /// <summary>
        /// Test MarkAsRead
        /// </summary>
        [Test]
        public void MarkAsReadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string notificationId = null;
            //var response = instance.MarkAsRead(notificationId);
            //Assert.IsInstanceOf<UserVoicifyNotificationModel> (response, "response is UserVoicifyNotificationModel");
        }
        
    }

}