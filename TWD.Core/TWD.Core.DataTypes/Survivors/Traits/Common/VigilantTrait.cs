using System;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors.Traits.Common
{
    public class VigilantTrait : Trait
    {
        private readonly int[] _percents = { 20, 24, 28, 32, 35, 38, 41, 44, 48, 50 };

        public VigilantTrait() : base(TraitConstants.Survivor.Vigilant, "Vigilant")
        {
        }

        public override Guid[] SupportedClasses => SurvivorConstants.ClassTypes.All;

        public override string GetDescription(int level) =>
            $"Overwatch attack total damage is increased by {_percents[level - 1]}%.";
    }
}
