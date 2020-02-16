using System;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors.Traits.Common
{
    public class MarksmanTrait : Trait
    {
        private readonly int[] _percents = { 5, 7, 10, 12, 15, 16, 17, 18, 19, 20 };

        public MarksmanTrait() : base(TraitConstants.Survivor.Marksman, "Marksman") { }

        public override Guid[] SupportedClasses => SurvivorConstants.ClassTypes.Ranged;

        public override string GetDescription(int level) =>
            $"Attacks deal {_percents[level - 1]}% more weapon damage.";
    }
}
