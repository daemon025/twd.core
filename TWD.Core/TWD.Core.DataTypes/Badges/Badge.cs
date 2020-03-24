using System;
using EnsureThat;
using TWD.Core.DataTypes.Badges.Conditions;

namespace TWD.Core.DataTypes.Badges
{
    public class Badge
    {
        public Badge(Guid id, BadgeRarity rarity, BadgeSet set, BadgeEffect effect, BadgeSlot slot, ICondition condition)
        {
            Id = Ensure.Guid.IsNotEmpty(id, nameof(id));
            Rarity = rarity;
            Set = set;
            Effect = effect;
            Slot = slot;
            Condition = condition;
        }

        public Guid Id { get; }
        public BadgeRarity Rarity { get; }
        public BadgeSet Set { get; }
        public BadgeEffect Effect { get; }
        public BadgeSlot Slot { get; }
        public ICondition Condition { get; }
    }
}
