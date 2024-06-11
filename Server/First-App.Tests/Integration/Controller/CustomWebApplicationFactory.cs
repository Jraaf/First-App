using Fisrt_App.DAL.Repository.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace First_App.Tests.Integration.Controller
{
    public class CustomWebApplicationFactory:WebApplicationFactory<Program>
    {
        public Mock<ICardRepository> CardRepositoryMock { get; set; }
        public CustomWebApplicationFactory()
        {
            CardRepositoryMock = new Mock<ICardRepository>();
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            base.ConfigureWebHost(builder);

            builder.ConfigureTestServices(services =>
            {
                services.AddSingleton(CardRepositoryMock.Object);
            });
        }
    }
}
