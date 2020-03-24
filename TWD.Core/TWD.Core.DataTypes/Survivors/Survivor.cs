using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EnsureThat;
using TWD.Core.DataTypes.Badges;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors
{
    public class Survivor
    {
        private readonly BadgeContainer _badgeContainer;

        public Survivor(string name, SurvivorClass @class, int level, SurvivorRarity rarity, SurvivorTrait[] traits)
        {
            Id = Guid.NewGuid();
            Name = Ensure.String.IsNotNullOrWhiteSpace(name, nameof(name));
            Class = Ensure.Any.IsNotNull(@class, nameof(@class));
            Level = Ensure.Comparable.IsInRange(level, 1, SurvivorConstants.MaxLevel, nameof(level));
            Rarity = rarity;

            _traits = new List<SurvivorTrait>();
            foreach (var survivorTrait in Ensure.Collection.HasItems(traits, nameof(traits)))
                AddTrait(survivorTrait);

            _badgeContainer = new BadgeContainer();
        }

        public Guid Id { get; }
        public string Name { get; }
        public SurvivorClass Class { get; }
        public int Level { get; }
        public SurvivorRarity Rarity { get; }

        private readonly List<SurvivorTrait> _traits;
        public IReadOnlyList<SurvivorTrait> Traits => _traits.AsReadOnly();

        public ReadOnlyCollection<Badge> Badges => _badgeContainer.Badges;

        public void EquipBadge(Badge badge)
        {
            _badgeContainer.EquipBadge(badge);
        }

        public void UnEquipBadge(BadgeSlot slot)
        {
            _badgeContainer.UnEquipBadge(slot);
        }

        private void AddTrait(SurvivorTrait survivorTrait)
        {
            Ensure.Any.IsNotNull(survivorTrait, nameof(survivorTrait));

            Ensure.Bool.IsTrue(survivorTrait.Trait.BelongsToClass(Class.Id), null,
                options => options.WithMessage($"{survivorTrait.Trait.Name} doesn't belong to {Class.Name}!"));
            Ensure.Bool.IsFalse(_traits.Any(x => x.Trait.Id == survivorTrait.Trait.Id), null,
                options => options.WithMessage("Traits must be unique"));
            Ensure.Comparable.IsLt(_traits.Count, (int)Rarity, null,
                options => options.WithMessage("Can't add more traits, maximum capacity reached."));
            Ensure.Comparable.IsInRange(survivorTrait.Level, (int)Rarity - 1, (int)Rarity, nameof(survivorTrait.Level));

            _traits.Add(survivorTrait);
        }
    }
}
