using System;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors.Traits.Common
{
    public class RetaliateTrait : Trait
    {
        private readonly int[] _percents = { 25, 37, 50, 62, 75, 78, 80, 83, 85, 87 };

        public RetaliateTrait() : base(TraitConstants.Survivor.Retaliate, "Retaliate") { }

        public override Guid[] SupportedClasses => SurvivorConstants.ClassTypes.All;

        public override string GetDescription(int level) =>
            $"Retaliates after being attacked once per turn, dealing {_percents[level - 1]}% of total damage.";
    }
}
