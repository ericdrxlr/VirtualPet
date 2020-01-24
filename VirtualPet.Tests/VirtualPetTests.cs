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
        public void Took_Pet_To_Doctor()
        {
            // Arrange
            var myCat = new VirtualPet();

            // Act - initialize variable
            myCat.HealthLevel = 8;

            // Assert - assess if property is equal to initialized variable
            Assert.Equal(8, myCat.HealthLevel);


        }

            
    }
}
