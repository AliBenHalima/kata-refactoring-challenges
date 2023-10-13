using Decorator_Pattern_Kata;
using System.Reflection.PortableExecutable;

namespace Decorator_Pattern_Kata_Tests
{
    public class DecoratorPatternTests
    {
        [Fact]
        public void Upgrading_Weapon_Increases_Damage_By_One()
        {
            //Arrange
            IMarine marine = new Marine(10, 1);
            //Act
            var UpgradeWeaponDecorator = new UpgradeWeaponDecorator(marine);
            var UpgradeArmorDecorator = new UpgradeArmorDecorator(marine);

            //Assert
            Assert.Equal(11, UpgradeWeaponDecorator.Damage);
        }

        [Fact]
        public void Upgrading_Armor_Increases_Armor_By_One()
        {
            //Arrange
            IMarine marine = new Marine(10, 1);
            //Act
            var UpgradeArmorDecorator = new UpgradeArmorDecorator(marine);

            //Assert
            Assert.Equal(2, UpgradeArmorDecorator.Armor);
        }

        [Fact]
        public void Upgrading_Damage_By_Three_And_Armor_By_Two_Increases_Values()
        {
            //Arrange
            IMarine marine = new Marine(10, 0);
            //Act
            var UpgradeDamageDecorator = new UpgradeWeaponDecorator(marine);
                UpgradeDamageDecorator = new UpgradeWeaponDecorator(marine);
                UpgradeDamageDecorator = new UpgradeWeaponDecorator(marine);

            var UpgradeArmorDecorator = new UpgradeArmorDecorator(marine);
                UpgradeArmorDecorator = new UpgradeArmorDecorator(marine);


            //Assert
            Assert.Equal(13, UpgradeDamageDecorator.Damage);

            Assert.Equal(2, UpgradeArmorDecorator.Armor);

        }

        [Fact]
        public void Upgrading_Damage_And_Armor_Increases_Values_By_One()
        {
            //Arrange
            IMarine marine = new Marine(10, 1);
            //Act
            var UpgradeDamageDecorator = new UpgradeWeaponDecorator(marine);
            var UpgradeArmorDecorator = new UpgradeArmorDecorator(marine);

            //Assert
            Assert.Equal(11, UpgradeDamageDecorator.Damage);
            Assert.Equal(2, UpgradeArmorDecorator.Armor);

        }

    }
}