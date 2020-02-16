using System;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors.Traits.Common
{
    public class SureShotTrait : Trait
    {
        private readonly int[] _percents = { 20, 25, 30, 35, 40, 43, 45, 48, 50, 53 };
        public SureShotTrait() : base(TraitConstants.Survivor.SureShot, "Sure Shot")
        {
        }

        public override Guid[] SupportedClasses => SurvivorConstants.ClassTypes.Ranged;

        public override string GetDescription(int level) =>
            $"Attacks made on your turn have {_percents[level - 1]}% greater critical chance if you have not moved. Total critical change cannot exceed 90%.";
    }
}
