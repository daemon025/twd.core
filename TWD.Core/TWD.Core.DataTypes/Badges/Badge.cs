using System;
using EnsureThat;
using TWD.Core.DataTypes.Badges.Conditions;

namespace TWD.Core.DataTypes.Badges
{
    public class Badge
    {
        public Badge(Guid id, BadgeRarity rarity, BadgeSet set, BadgeEffect effect, int slot, ICondition condition)
        {
            Id = Ensure.Guid.IsNotEmpty(id, nameof(id));
            Rarity = rarity;
            Set = set;
            Effect = effect;
            Slot = Ensure.Comparable.IsInRange(slot, 1, 6, nameof(slot));
            Condition = condition;
        }

        public Guid Id { get; }
        public BadgeRarity Rarity { get; }
        public BadgeSet Set { get; }
        public BadgeEffect Effect { get; }
        public int Slot { get; }
        public ICondition Condition { get; }
    }
}
