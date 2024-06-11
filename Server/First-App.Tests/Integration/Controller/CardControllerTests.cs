using First_App.Common.DTO;
using Fisrt_App.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace First_App.Tests.Integration.Controller
{
    public class CardControllerTests : IDisposable
    {
        private CustomWebApplicationFactory _factory;
        private HttpClient _client;
        public CardControllerTests()
        {
            _factory = new CustomWebApplicationFactory();
            _client = _factory.CreateClient();
        }
        [Fact]
        public async void Can_Post()
        {
            var MockCard = new CreateCardDTO
            {
                Title = "Test",
            };
            var response = await _client.PostAsync("/Cards",
                new StringContent(JsonConvert.SerializeObject(MockCard)));
            Assert.True(response.IsSuccessStatusCode);
        }
        [Fact]
        public async void Can_Delete()
        {
            var MockCard = new CreateCardDTO
            {
                Title = "Test",
            };
            await _client.PostAsync("/Cards",
                new StringContent(JsonConvert.SerializeObject(MockCard)));
            int id = 1;
            var response = await _client.DeleteAsync($"/Cards/{id}");

            Assert.True(response.IsSuccessStatusCode);
        }
        public void Dispose()
        {
            _factory.Dispose();
            _client.Dispose();
        }
    }
}
