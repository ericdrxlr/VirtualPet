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
             myCat.FeedPet();

            // Assert - assess if property is equal to initialized variable
            Assert.Equal(currentHunger - 1, myCat.Hunger);
        }
        [Fact]
        public void TakePetToDr_Should_Increase_Health()
        {
            // Arrange
            var myCat = new VirtualPet();
            var currentHealth = myCat.HealthLevel;
            
            // Act
            myCat.TakePetToDr();

            // Assert
            Assert.Equal(currentHealth + 1, myCat.HealthLevel);
        }

        [Fact]
        public void PlayWithPet_Does_Boredom_Decrease()
        {
            //Arrange
            var myCat = new VirtualPet();
            var currentBoredom = myCat.Boredom;
            //Act
            myCat.PlayWithPet();

            //Assert
            Assert.Equal(currentBoredom - 1, myCat.Boredom);
        }
        [Fact]
        public void PlayWithPet_Does_Hunger_Increase()
        {
            // Arrange
            var testCat = new VirtualPet();
            var currentHunger = testCat.Hunger;
            // Act
            testCat.PlayWithPet();

            // Assert
            Assert.Equal(currentHunger + 1,testCat.Hunger);

        
        
        
        
        }

    }
}
