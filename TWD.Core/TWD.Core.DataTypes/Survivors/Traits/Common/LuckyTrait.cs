using System;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors.Traits.Common
{
    public class LuckyTrait : Trait
    {
        private readonly int[] _percents = { 10, 12, 14, 16, 18, 20, 22, 23, 24, 25 };

        public LuckyTrait() : base(TraitConstants.Survivor.Lucky, "Lucky") { }

        public override Guid[] SupportedClasses => SurvivorConstants.ClassTypes.All;

        public override string GetDescription(int level) =>
            $"Improves the chances that other traits will take effect by {_percents[level - 1]}%.";
    }
}
