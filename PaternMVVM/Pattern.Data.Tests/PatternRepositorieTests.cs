using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Autofac;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Pattern.Data.Factories;
using Pattern.Data.Repositories;
using Pattern.Entities;
using Xunit;

namespace Pattern.Data.Tests
{
    public class PatternRepositorieTests
    {
        private readonly IPatternRepository _patternRepository;

        private readonly IDbContextFactory _patternRepositoryFactory;

        public  PatternRepositorieTests()
        {
            var dbContext = MockApplicationDbContext();
            _patternRepositoryFactory = Substitute.For<IDbContextFactory>();
            _patternRepositoryFactory.CreateContext().Returns(dbContext);

            var builder = new ContainerBuilder();

            builder.RegisterInstance(_patternRepositoryFactory).As<IDbContextFactory>();

            Di.DiContainer.Container = builder.Build();

            _patternRepository = new PatternRepositorie();
          
        }

        [Theory]
        [ClassData(typeof(PatternRepositorieTestsData))]
        public void Given_NumberId_Expected_NumberEntity(int id, Number expectedNumber)
        {
            var number = _patternRepository.Get(id);
            number.Should().BeEquivalentTo(expectedNumber);
        }

        private static ApplicationDbContext MockApplicationDbContext()
        {
            var numbersList = new List<Number>
            {
                NumberData.Number1,
                NumberData.Number2
            };

            var mockApplicationDbContext = Substitute.For<ApplicationDbContext>();
            mockApplicationDbContext.Numbers = numbersList.CreateMockDbSet();

            return mockApplicationDbContext;
        }
    }

    public static class NumberData
    {
        public static Number Number1 = new Number
        {
            Id = 1,
            Notes = "Notes",
            Number1 = 1,
            Number2 = 2
        };

        public static Number Number2 = new Number
        {
            Id = 2,
            Notes = "Notes22",
            Number1 = 1,
            Number2 = 22
        };
    }

    public class PatternRepositorieTestsData: List<object[]>
    {
        public PatternRepositorieTestsData()
        {
            AddRange(new List<object[]>
            {
                new object[]
                {
                    1,
                    NumberData.Number1
                },
                new object[]
                {
                    2,
                    NumberData.Number2
                },
            });
        }

    }
}
