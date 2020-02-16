using System;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors.Traits.Common
{
    public class CriticalAimTrait : Trait
    {
        private readonly int[] _normalAtkPercents = { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        private readonly int[] _criticalAtkPercents = { 18, 21, 24, 27, 30, 33, 36, 39, 42,45 };

        public CriticalAimTrait() : base(TraitConstants.Survivor.CriticalAim, $"Critical Aim") { }

        public override Guid[] SupportedClasses => new[]
            {SurvivorConstants.ClassIds.Hunter, SurvivorConstants.ClassIds.Shooter};

        public override string GetDescription(int level) =>
            $"Normal attacks have {_normalAtkPercents[level - 1]}% chance to stun a target regardless of Body Shots, and Critical Hits have {_criticalAtkPercents[level - 1]}% chance to stun a target. The stun lasts for 1 turn.";

    }
}
