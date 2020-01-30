using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class VirtualPetShelterTest
    {
        [Fact]
        public void Can_Creat_VirtualPetShelter_Instance()
        {
            new VirtualPetShelter();
        }
        [Fact]
        public void TakeAllPetsToDr_Increases_Health()
        {
            // Arrange
            var myShelter = new VirtualPetShelter();
            var myCat = new VirtualPet();
            var myCat1 = new VirtualPet();
            var allCurrentHealthPets = myCat.HealthLevel;

            // Act
            //create list
            myShelter.AddPetToShelter(myCat);
            myShelter.AddPetToShelter(myCat);
            myShelter.TakeAllPetsToDoctor();

            // Assert
        
        
        
        }
  



    }
}
