using System;
using Xunit;

namespace VirtualPet.Tests
{
    public class VirtualPetTests
    {
        [Fact]
        public void Can_Create_Pet_Instance()
        {
            new VirtualPet();
        }

        [Fact]
        public void Pet_Has_Name()
        {
            //Arrange
            var myPet = new VirtualPet();

            //Act
            myPet.Name = "Carl";

            //Assert
            Assert.Equal("Carl", myPet.Name);
        }

        [Fact]
        public void Pet_Has_Hunger()
        {
            //Arrange
            var myPet = new VirtualPet();

            //Act
            myPet.Hunger = 5;

            //Assert
            Assert.Equal(5, myPet.Hunger);
        }
        [Fact]
        public void Pet_Has_Species()
        {

            // Arrange
            var myPet = new VirtualPet();


            // Act
            myPet.Species = "cat";

            // Assert
            Assert.Equal("cat", myPet.Species);
        }
        [Fact]
        public void Pet_Has_Boredom()
        {

            // Arrange
            var myPet = new VirtualPet();

            // Act
            myPet.Boredom = 5;

            // Assert
            Assert.Equal(5, myPet.Boredom);
        }
        [Fact]
        public void Pets_Health()
        {
            // Arrange
            var myCat = new VirtualPet();

            // Act
            myCat.HealthLevel = 5;

            // Assert
            Assert.Equal(5, myCat.HealthLevel);
        }
        [Fact]
        public void FeedPet_Does_Hunger_Decrease()
        {
            // Arrange
            var myCat = new VirtualPet();
            var currentHunger = myCat.Hunger;

            // Act - initialize variable
          //  var updatedHunger = myCat.FeedPet();

            // Assert - assess if property is equal to initialized variable
           // Assert.Equal(currentHunger - 1, updatedHunger);
        }
        [Fact]
        public void TakePetToDr_Should_Increase_Health()
        {
            // Arrange
            var myCat = new VirtualPet();
            var currentHealth = myCat.HealthLevel;
            // Act
            var updatedHealth = myCat.TakePetToDr();

            // Assert
            Assert.Equal(currentHealth+1, updatedHealth);

        }




    }
}
