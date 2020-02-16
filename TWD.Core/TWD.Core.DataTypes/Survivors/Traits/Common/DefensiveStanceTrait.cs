using System;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors.Traits.Common
{
    public class DefensiveStanceTrait : Trait
    {
        private readonly int[] _percents = { 30, 34, 38, 42, 45, 48, 51, 54, 57, 60 };

        public DefensiveStanceTrait() : base(TraitConstants.Survivor.DefensiveStance, "Defensive Stance") { }

        public override Guid[] SupportedClasses => SurvivorConstants.ClassTypes.All;

        public override string GetDescription(int level) =>
            $"Increases damage resistance during Overwatch by {_percents[level - 1]}%.";
    }
}
