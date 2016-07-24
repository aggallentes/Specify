using NUnit.Framework;
using Shouldly;
using Specify.Mocks;
using Specify.Tests.Stubs;

namespace Specify.IntegrationTests.Mocks
{
    [TestFixture]
    public abstract class MockFactoryTestsFor<T> where T : IMockFactory, new()
    {
        public IMockFactory CreateSut()
        {
            return new T();
        }

        [Test]
        public void should_mock_interfaces()
        {
            var sut = this.CreateSut();
            var result = sut.CreateMock(typeof (IDependency1));

            result.ShouldNotBe(null);
            result.ShouldBeAssignableTo<IDependency1>();
        }

        [Test]
        public void should_mock_concrete()
        {
            var sut = this.CreateSut();
            var result = sut.CreateMock(typeof(Dependency1));

            result.ShouldNotBe(null);
            result.ShouldBeAssignableTo<Dependency1>();
        }
    }
}