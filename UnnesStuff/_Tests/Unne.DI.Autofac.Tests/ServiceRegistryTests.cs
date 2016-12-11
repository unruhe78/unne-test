namespace Unne.DI.Autofac.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using FluentAssertions;

    [TestClass]
    public class ServiceRegistryTests
    {
        [TestMethod]
        public void RegisterType_bothTypeParametersAreNull_ShouldThrowArgumentNullException()
        {
            IServiceRegistry registry = Autofac.GetRegistry();

            registry.Invoking(r => r.RegisterType(null, null))
                    .ShouldThrow<ArgumentNullException>("because both parameter is null").And
                    .ParamName.ShouldBeEquivalentTo("serviceType", "because validation of the first parameter should fail");
        }

        [TestMethod]
        public void RegisterType_serviceTypeParameterIsNull_ShouldThrowArgumentNullException()
        {
            IServiceRegistry registry = Autofac.GetRegistry();

            registry.Invoking(r => r.RegisterType(null, typeof(string)))
                    .ShouldThrow<ArgumentNullException>("because serviceType parameter is null").And
                    .ParamName.ShouldBeEquivalentTo("serviceType", "because validation of the first parameter should fail");
        }

        [TestMethod]
        public void RegisterType_implementationTypeParameterIsNull_ShouldThrowArgumentNullException()
        {
            IServiceRegistry registry = Autofac.GetRegistry();

            registry.Invoking(r => r.RegisterType(typeof(Data.ITest), null))
                    .ShouldThrow<ArgumentNullException>("because implementationType parameter is null").And
                    .ParamName.ShouldBeEquivalentTo("implementationType", "because validation of the second parameter should fail");
        }

        [TestMethod]
        public void RegisterType_implementationTypeDoesntImplementServiceType_ShouldThrowArgumentOutOfRangeException()
        {
            IServiceRegistry registry = Autofac.GetRegistry();

            var assertion = registry.Invoking(r => r.RegisterType(typeof(Data.ITest), typeof(string)))
                                    .ShouldThrow<ArgumentOutOfRangeException>("because implementationType doesn't implement service type");
            assertion.And.ParamName.ShouldBeEquivalentTo("implementationType", "because validation of the second parameter should fail");
            assertion.And.Message.Should().Contain("doesn't implement", "because validation of the second parameter should fail");
        }

        [TestMethod]
        public void RegisterTypeFactory_bothTypeParametersAreNull_ShouldThrowArgumentNullException()
        {
            IServiceRegistry registry = Autofac.GetRegistry();

            registry.Invoking(r => r.RegisterTypeFactory(null, null))
                    .ShouldThrow<ArgumentNullException>("because both parameter is null").And
                    .ParamName.ShouldBeEquivalentTo("serviceType", "because validation of the first parameter should fail");
        }

        [TestMethod]
        public void RegisterTypeFactory_serviceTypeParameterIsNull_ShouldThrowArgumentNullException()
        {
            IServiceRegistry registry = Autofac.GetRegistry();

            registry.Invoking(r => r.RegisterTypeFactory(null, () => "Hallo Welt"))
                    .ShouldThrow<ArgumentNullException>("because serviceType parameter is null").And
                    .ParamName.ShouldBeEquivalentTo("serviceType", "because validation of the first parameter should fail");
        }

        [TestMethod]
        public void RegisterTypeFactory_implementationTypeParameterIsNull_ShouldThrowArgumentNullException()
        {
            IServiceRegistry registry = Autofac.GetRegistry();

            registry.Invoking(r => r.RegisterTypeFactory(typeof(Data.ITest), null))
                    .ShouldThrow<ArgumentNullException>("because factoryMethod parameter is null").And
                    .ParamName.ShouldBeEquivalentTo("factoryMethod", "because validation of the second parameter should fail");
        }

        [TestMethod]
        public void RegisterTypeFactory_implementationTypeDoesntImplementServiceType_ShouldThrowArgumentOutOfRangeException()
        {
            IServiceRegistry registry = Autofac.GetRegistry();

            var assertion = registry.Invoking(r => r.RegisterTypeFactory(typeof(Data.ITest), () => "Hallo Welt"))
                                    .ShouldThrow<ArgumentOutOfRangeException>("because return value of factoryMethod doesn't implement service type");
            assertion.And.ParamName.ShouldBeEquivalentTo("factoryMethod", "because validation of the second parameter should fail");
            assertion.And.Message.Should().Contain("doesn't implement", "because validation of the second parameter should fail");
        }
    }
}
