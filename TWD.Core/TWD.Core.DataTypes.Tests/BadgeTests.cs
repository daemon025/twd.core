using System;
using System.Collections.Generic;
using NUnit.Framework;
using TWD.Core.DataTypes.Badges;
using TWD.Core.DataTypes.Badges.Conditions;
using TWD.Core.DataTypes.Survivors;
using TWD.Core.DataTypes.Survivors.Traits.Common;

namespace TWD.Core.DataTypes.Tests
{
    [TestFixture]
    public class BadgeTests
    {
        private Survivor _survivor;

        [SetUp]
        public void SetUp()
        {
            var traits = new List<SurvivorTrait>
            {
                new SurvivorTrait(new MarksmanTrait(), 3),
                new SurvivorTrait(new LuckyTrait(), 3),
                new SurvivorTrait(new IronSkinTrait(), 3)
            };

            _survivor = new Survivor("Test", SurvivorClass.Assault, 10, SurvivorRarity.Rare, traits.ToArray());
        }

        [Test]
        public void Should_Not_Allow_To_Add_4_Or_More_With_The_Same_Effect()
        {
            var badge1 = new Badge(Guid.NewGuid(), BadgeRarity.Rare, BadgeSet.A, BadgeEffect.CriticalChance, BadgeSlot.Slot1, new NoCondition());
            var badge2 = new Badge(Guid.NewGuid(), BadgeRarity.Rare, BadgeSet.A, BadgeEffect.CriticalChance, BadgeSlot.Slot2, new NoCondition());
            var badge3 = new Badge(Guid.NewGuid(), BadgeRarity.Rare, BadgeSet.A, BadgeEffect.CriticalChance, BadgeSlot.Slot3, new NoCondition());
            var badge4 = new Badge(Guid.NewGuid(), BadgeRarity.Rare, BadgeSet.A, BadgeEffect.CriticalChance, BadgeSlot.Slot4, new NoCondition());

            _survivor.EquipBadge(badge1);
            _survivor.EquipBadge(badge2);
            _survivor.EquipBadge(badge3);

            Assert.Throws<ArgumentException>(() => _survivor.EquipBadge(badge4));
        }

        [Test]
        public void Should_Not_Allow_To_Equip_On_Not_Free_Slot()
        {
            var badge1 = new Badge(Guid.NewGuid(), BadgeRarity.Rare, BadgeSet.A, BadgeEffect.CriticalChance, BadgeSlot.Slot1, new NoCondition());
            var badge2 = new Badge(Guid.NewGuid(), BadgeRarity.Rare, BadgeSet.A, BadgeEffect.CriticalChance, BadgeSlot.Slot1, new NoCondition());

            _survivor.EquipBadge(badge1);

            Assert.Throws<ArgumentException>(() => _survivor.EquipBadge(badge2));
        }
    }
}
