/*
 * TransPA Public API
 *
 * # This API exposes functionality in Visma TransPA. ## Authentication The API can be tested without authentication against the mock server in the **Servers** pulldown list. To test against the actual backend you have to register a user on the *Visma Developer Portal* and request access to the API along with the required scopes. The scopes required are documented under each endpoint. For more information about *Visma Developer Portal* see <https://developer.visma.com>. <br/> <br/>  Authentication uses OAuth tokens from *Visma Connect*. Authorization is done on tenant level, so one OAuth token is needed per tenant.<br/> <br/> The scope `transpaapi:api` grants basic access to the API and is required for all routes. Additional scopes might be required and are described inside each route description. <br/> ## Details All monetary amounts are in the organizations local currency unless otherwise specified. <br/> <br/> ```[Not Ready]``` This is an endpoint where development has not completed and is therefore subject to change. 
 *
 * The version of the OpenAPI document: 0.1.15
 * Contact: utveckling.transpa@visma.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using transpa.api.generated.Client;
using transpa.api.generated.Api;
// uncomment below to import models
//using transpa.api.generated.Model;

namespace transpa.api.generated.Test.Api
{
    /// <summary>
    ///  Class for testing StationPlacesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class StationPlacesApiTests : IDisposable
    {
        private StationPlacesApi instance;

        public StationPlacesApiTests()
        {
            instance = new StationPlacesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of StationPlacesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' StationPlacesApi
            //Assert.IsType<StationPlacesApi>(instance);
        }

        /// <summary>
        /// Test GetStationplaces
        /// </summary>
        [Fact]
        public void GetStationplacesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetStationplaces();
            //Assert.IsType<InlineResponse2002>(response);
        }
    }
}
