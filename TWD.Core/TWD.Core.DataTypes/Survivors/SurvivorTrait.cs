using EnsureThat;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors
{
    public class SurvivorTrait
    {
        public SurvivorTrait(Trait trait, int level)
        {
            Trait = Ensure.Any.IsNotNull(trait,nameof(trait));
            Level = Ensure.Comparable.IsInRange(level, 1, SurvivorConstants.MaxTraitLevel, nameof(level));
        }

        public Trait Trait { get; }
        public int Level { get;  }

        public string Description => Trait.GetDescription(Level);
    }
}
