using System;
using NUnit.Framework;
using TWD.Core.DataTypes.Survivors;
using TWD.Core.DataTypes.Survivors.Traits.Common;

namespace TWD.Core.DataTypes.Tests
{
    [TestFixture]
    public class SurvivorTests
    {
        private Survivor _survivor;

        [SetUp]
        public void SetUp()
        {
            _survivor = new Survivor("Test", SurvivorClass.Assault, 10, SurvivorRarity.Uncommon);
        }

        [Test]
        public void Should_Throw_Exception_When_Adding_Too_Much_Traits()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _survivor
                .AddTrait<MarksmanTrait>(2)
                .AddTrait<RevengeTrait>(2)
                .AddTrait<IronSkinTrait>(2));
        }

        [Test]
        public void Should_Throw_Exception_When_Adding_The_Same_Trait()
        {
            Assert.Throws<ArgumentException>(() => _survivor
                .AddTrait<MarksmanTrait>(2)
                .AddTrait<MarksmanTrait>(2));
        }

        [Test]
        public void Should_Throw_Exception_When_Level_Too_Low()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _survivor
                .AddTrait<MarksmanTrait>(0)
                .AddTrait<IronSkinTrait>(0));
        }

        [Test]
        public void Should_Throw_Exception_When_Level_Too_High()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _survivor
                .AddTrait<MarksmanTrait>(3)
                .AddTrait<IronSkinTrait>(3));
        }

        [Test]
        [Ignore("Not implemented yet")]
        public void Should_Throw_Exception_When_Adding_Trait_From_Another_Class()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _survivor
                .AddTrait<MarksmanTrait>(2)
                .AddTrait<PunishTrait>(2));
        }
    }
}
