﻿using AutoMapper;
using Lykke.Service.NotificationSystemBroker.Profiles;
using Xunit;

namespace Lykke.Service.NotificationSystemBroker.Tests
{
    public class AutoMapperProfileTests
    {
        [Fact]
        public void Mapping_Configuration_Is_Correct()
        {
            // arrange
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile());
                cfg.AddProfile(new MsSqlRepositories.AutoMapperProfile());
            });
            var mapper = mockMapper.CreateMapper();

            // act
            mapper.ConfigurationProvider.AssertConfigurationIsValid();

            // assert
            Assert.True(true);
        }
    }
}
