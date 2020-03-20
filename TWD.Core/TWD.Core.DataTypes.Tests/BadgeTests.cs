﻿using System;
using NUnit.Framework;
using TWD.Core.DataTypes.Badges;
using TWD.Core.DataTypes.Badges.Conditions;
using TWD.Core.DataTypes.Survivors;

namespace TWD.Core.DataTypes.Tests
{
    [TestFixture]
    public class BadgeTests
    {
        private Survivor _survivor;

        [SetUp]
        public void SetUp()
        {
            _survivor = new Survivor("Test", SurvivorClass.Assault, 10, SurvivorRarity.Rare);
        }

        [Test]
        public void Should_Not_Allow_To_Add_4_Or_More_With_The_Same_Effect()
        {
            var badge1 = new Badge(Guid.NewGuid(), BadgeRarity.Rare, BadgeSet.A, BadgeEffect.CriticalChance, 1, new NoCondition());
            var badge2 = new Badge(Guid.NewGuid(), BadgeRarity.Rare, BadgeSet.A, BadgeEffect.CriticalChance, 2, new NoCondition());
            var badge3 = new Badge(Guid.NewGuid(), BadgeRarity.Rare, BadgeSet.A, BadgeEffect.CriticalChance, 3, new NoCondition());
            var badge4 = new Badge(Guid.NewGuid(), BadgeRarity.Rare, BadgeSet.A, BadgeEffect.CriticalChance, 4, new NoCondition());

            _survivor.EquipBadge(badge1);
            _survivor.EquipBadge(badge2);
            _survivor.EquipBadge(badge3);

            Assert.Throws<Exception>(() => _survivor.EquipBadge(badge4));
        }

        [Test]
        public void Should_Not_Allow_To_Equip_On_Not_Free_Slot()
        {
            var badge1 = new Badge(Guid.NewGuid(), BadgeRarity.Rare, BadgeSet.A, BadgeEffect.CriticalChance, 1, new NoCondition());
            var badge2 = new Badge(Guid.NewGuid(), BadgeRarity.Rare, BadgeSet.A, BadgeEffect.CriticalChance, 1, new NoCondition());

            _survivor.EquipBadge(badge1);

            Assert.Throws<Exception>(() => _survivor.EquipBadge(badge2));
        }
    }
}