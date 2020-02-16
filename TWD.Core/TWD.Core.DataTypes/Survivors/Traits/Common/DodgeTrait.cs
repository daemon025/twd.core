using System;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors.Traits.Common
{
    public class DodgeTrait : Trait
    {
        private readonly int[] _percents = { 5, 7, 10, 12, 15, 16, 17, 18, 19, 20 };

        public DodgeTrait() : base(TraitConstants.Survivor.Dodge, "Dodge") { }

        public override Guid[] SupportedClasses => SurvivorConstants.ClassTypes.All;

        public override string GetDescription(int level) =>
            $"Has a {_percents[level - 1]}% chance of dodging a melee attack except while stunned or struggling.";
    }
}
