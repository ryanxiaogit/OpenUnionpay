using Infrastructure.WebClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Infrastructure.CommonTest;
using ShouldBeAssertions;

namespace Test.Infrastructure
{
    [TestClass]
    public class WebClientServiceTest
    {

        [TestMethod]
        public void ExecuteAsync_ShouldBe_working()
        {
            var client = new RestClient();
            WebClientService clientService = new WebClientService(client);
            var testModel = new TestJSonModel();
            var result = clientService.ExecuteAsync<TestResponseModel>(testModel, "post", "http://wwww.google.com")?.Result;
        }
    }
}
