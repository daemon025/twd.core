using System;
using System.Collections.Generic;
using NUnit.Framework;
using TWD.Core.DataTypes.Survivors;
using TWD.Core.DataTypes.Survivors.Traits.Common;

namespace TWD.Core.DataTypes.Tests
{
    [TestFixture]
    public class SurvivorTests
    {
        [Test]
        public void Should_Throw_Exception_When_Adding_Too_Much_Traits()
        {
            var traits = new List<SurvivorTrait>()
            {
                new SurvivorTrait(new MarksmanTrait(), 2),
                new SurvivorTrait(new RevengeTrait(), 2),
                new SurvivorTrait(new IronSkinTrait(), 2)
            }.ToArray();

            Assert.Throws<ArgumentOutOfRangeException>(() => new Survivor("Test", SurvivorClass.Assault, 10, SurvivorRarity.Uncommon, traits));
        }

        [Test]
        public void Should_Throw_Exception_When_Adding_The_Same_Trait()
        {
            var traits = new List<SurvivorTrait>()
            {
                new SurvivorTrait(new MarksmanTrait(), 2),
                new SurvivorTrait(new MarksmanTrait(), 2)
            }.ToArray();

            Assert.Throws<ArgumentException>(() => new Survivor("Test", SurvivorClass.Assault, 10, SurvivorRarity.Uncommon, traits));
        }

        [Test]
        public void Should_Throw_Exception_When_Level_Too_Low()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Survivor("Test", SurvivorClass.Assault, 10, SurvivorRarity.Uncommon, new List<SurvivorTrait>()
            {
                new SurvivorTrait(new MarksmanTrait(), 0),
                new SurvivorTrait(new IronSkinTrait(), 0)
            }.ToArray()));
        }

        [Test]
        public void Should_Throw_Exception_When_Level_Too_High()
        {
            var traits = new List<SurvivorTrait>()
            {
                new SurvivorTrait(new MarksmanTrait(), 3),
                new SurvivorTrait(new IronSkinTrait(), 3)
            }.ToArray();

            Assert.Throws<ArgumentOutOfRangeException>(() => new Survivor("Test", SurvivorClass.Assault, 10, SurvivorRarity.Uncommon, traits));
        }

        [Test]
        public void Should_Throw_Exception_When_Adding_Trait_From_Another_Class()
        {
            var traits = new List<SurvivorTrait>()
            {
                new SurvivorTrait(new MarksmanTrait(), 2),
                new SurvivorTrait(new PunishTrait(), 2)
            }.ToArray();

            Assert.Throws<ArgumentException>(() => new Survivor("Test", SurvivorClass.Assault, 10, SurvivorRarity.Uncommon, traits));
        }
    }
}
