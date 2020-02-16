using System;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors.Traits.Common
{
    public class RevengeTrait : Trait
    {
        private readonly int[] _percents = { 48, 52, 56, 60, 64, 68, 73, 78, 82, 86 };

        public RevengeTrait() : base(TraitConstants.Survivor.Revenge, "Revenge") { }

        public override Guid[] SupportedClasses => SurvivorConstants.ClassTypes.Ranged;

        public override string GetDescription(int level) =>
            $"When an ally is attacked by an enemy in range, make an attack against that enemy that deals  {_percents[level - 1]}% of total damage.";
    }
}
