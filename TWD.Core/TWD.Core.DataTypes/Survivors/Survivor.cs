using System;
using System.Collections.Generic;
using System.Linq;
using EnsureThat;
using TWD.Core.DataTypes.Badges;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors
{
    public class Survivor
    {
        public Survivor(string name, SurvivorClass @class, int level, SurvivorRarity rarity)
        {
            Id = Guid.NewGuid();
            Name = Ensure.String.IsNotNullOrWhiteSpace(name, nameof(name));
            Class = Ensure.Any.IsNotNull(@class, nameof(@class));
            Level = Ensure.Comparable.IsInRange(level, 1, SurvivorConstants.MaxLevel, nameof(level));
            Rarity = rarity;
            _traits = new List<SurvivorTrait>();
            Badges = new Badge[6];
        }

        public Guid Id { get; }
        public string Name { get; }
        public SurvivorClass Class { get; }
        public int Level { get; }
        public SurvivorRarity Rarity { get; }

        private readonly List<SurvivorTrait> _traits;
        public IReadOnlyList<SurvivorTrait> Traits => _traits.AsReadOnly();

        public Badge[] Badges { get; }

        public Survivor AddTrait<T>(int level) where T : Trait, new()
        {
            var trait = new T();

            Ensure.Bool.IsTrue(trait.BelongsToClass(Class.Id), null,
                options => options.WithMessage($"{trait.Name} doesn't belong to {Class.Name}!"));
            Ensure.Bool.IsFalse(_traits.Any(x => x.Trait.Id == trait.Id), null,
                options => options.WithMessage("Traits must be unique"));
            Ensure.Comparable.IsLt(_traits.Count, (int)Rarity, null,
                options => options.WithMessage("Can't add more traits, maximum capacity reached."));
            Ensure.Comparable.IsInRange(level, (int)Rarity - 1, (int)Rarity, nameof(level));

            _traits.Add(new SurvivorTrait(trait, level));

            return this;
        }


        public void EquipBadge(int slot, Badge badge)
        {
            Ensure.Comparable.IsInRange(slot, 1, 6, nameof(slot));
            Ensure.Any.IsNotNull(badge, nameof(badge));

            Badges[slot] = badge;
        }

        public void UnEquipBadge(int slot)
        {
            Ensure.Comparable.IsInRange(slot, 1, 6, nameof(slot));
            Badges[slot] = null;
        }
    }
}
