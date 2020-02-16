using System;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors.Traits.Common
{
    public class StrongTrait : Trait
    {
        private readonly int[] _percents = { 5, 7, 10, 12, 15, 16, 17, 18, 19, 20 };

        public StrongTrait() : base(TraitConstants.Survivor.Strong, "Strong") { }

        public override Guid[] SupportedClasses => SurvivorConstants.ClassTypes.Melee;

        public override string GetDescription(int level) =>
            $"Attacks deal {_percents[level - 1]}% more weapon damage.";
    }
}
