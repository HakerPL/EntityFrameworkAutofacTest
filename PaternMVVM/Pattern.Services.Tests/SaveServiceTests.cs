using Autofac;
using FluentAssertions;
using NSubstitute;
using Pattern.Data.Repositories;
using Pattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Pattern.Services.Tests
{
    public class SaveServiceTests
    {
        private readonly ISaveServices _saveService;
        private readonly IPatternRepository _patternRepository;

        public SaveServiceTests()
        {
            _patternRepository = Substitute.For<IPatternRepository>();

            var builder = new ContainerBuilder();

            builder.RegisterInstance(_patternRepository).As<IPatternRepository>();

            Di.DiContainer.Container = builder.Build();

            _saveService = new SaveServices();
        }

      

        [Theory]
        [ClassData(typeof(SaveSrviceTestsData))]
        public void Given_Number_Expected_ProperNumberSaving(Number number, string testArg)
        {
            _saveService.Save(number);
            _patternRepository.Received(1).Save(Arg.Any<Number>());
        }

        class SaveSrviceTestsData : List<object[]>
        {
            public SaveSrviceTestsData()
            {
                AddRange(new List<object[]>
                {
                    new object[]
                    {
                        new Number
                        {
                            Id = 1,
                            Notes = "test data",
                            Number1 = 2,
                            Number2 = 4
                        },
                        "dfsdfdsfds"
                    },


                    new object[]
                    {
                        new Number
                        {
                            Id = 2,
                            Notes = "test data other",
                            Number1 = 112,
                            Number2 = 14
                        },
                        "test"
                    },
                    new object[]
                    {
                        new Number
                        {
                            Id = 3,
                            Notes = "test data .....",
                            Number1 = 4,
                            Number2 = 5
                        },
                        "test2"
                    }
                });
            }
        }
    }
}
