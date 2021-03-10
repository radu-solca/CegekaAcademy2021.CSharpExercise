using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;
using System.Threading.Tasks;

namespace GenericsExercise.Tests
{
    [TestClass]
    public class PersistenceTests
    {
        private Persistence sut;

        [TestInitialize]
        public void Initialize()
        {
            sut = new Persistence();
        }


        [TestMethod]
        public async Task When_InsertIsCalledCorrectly_Then_EntityShouldBeStored()
        {
            // Arrange
            var entity = new TestEntity() { Id = "validId" };

            // Act
            await sut.InsertAsync(entity);
            var storedEntities = await sut.GetAllAsync<TestEntity>();

            // Assert
            storedEntities.Should().HaveCount(1).And.OnlyContain(e => e.Id == entity.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public async Task When_InsertIsCalledWithInvalidId_Then_ShouldThrowException()
        {
            // Arrange
            var entity = new TestEntity() { Id = "%invalidId%" };

            // Act
            await sut.InsertAsync(entity);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task When_InsertIsCalledWithFourthItem_Then_ShouldThrowException()
        {
            // Arrange
            var entity1 = new TestEntity() { Id = "validId1" };
            await sut.InsertAsync(entity1);

            var entity2 = new TestEntity() { Id = "validId2" };
            await sut.InsertAsync(entity2);

            var entity3 = new TestEntity() { Id = "validId3" };
            await sut.InsertAsync(entity3);

            var entity4 = new TestEntity() { Id = "validId4" };

            // Act
            await sut.InsertAsync(entity4);
        }

        [TestCleanup]
        public void Cleanup()
        {
            sut = null;
        }
    }


    public class TestEntity : IEntity
    {
        public string Id { get; set; }
    }

}
