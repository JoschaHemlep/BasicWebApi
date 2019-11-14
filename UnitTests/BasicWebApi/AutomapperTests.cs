using AutoMapper;
using BasicWebApi;
using NUnit.Framework;

namespace UnitTests.BasicWebApi
{
    public class AutomapperTests
    {
        [Test]
        public void AutomapperConfigurationValidation()
        {
            // Arrange
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(typeof(AutomapperProfile)));

            // Act/Assert
            configuration.AssertConfigurationIsValid();
        }
    }
}