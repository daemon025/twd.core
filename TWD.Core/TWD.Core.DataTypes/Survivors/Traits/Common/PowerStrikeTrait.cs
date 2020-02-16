using System;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors.Traits.Common
{
    public class PowerStrikeTrait : Trait
    {
        private readonly int[] _damagePercents = { 20, 25, 30, 35, 40, 43, 45, 48, 50, 53 };
        private readonly int[] _criticalAtkChancePercents = { 20, 25, 30, 35, 40, 43, 45, 48, 50, 53 };

        public PowerStrikeTrait() : base(TraitConstants.Survivor.PowerStrike, "Power Strike") { }

        public override Guid[] SupportedClasses => SurvivorConstants.ClassTypes.Melee;

        public override string GetDescription(int level) =>
            $"Attacks made on your turn gain {_damagePercents[level - 1]}% final damage and have {_criticalAtkChancePercents[level - 1]}% better critical chance if you have not moved. Total critical chance cannot exceed 90%.";
    }
}
