using System;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors.Traits.Common
{
    public class PunishTrait : Trait
    {
        private readonly int[] _percents = { 50, 55, 60, 65, 70, 80, 85, 90, 95, 100 };
        public PunishTrait() : base(TraitConstants.Survivor.Punish, "Punish") { }

        public override Guid[] SupportedClasses => new[] { SurvivorConstants.ClassIds.Bruiser };

        public override string GetDescription(int level) =>
            $"Free attack at the end of the turn to a random adjacent enemy that deals {_percents[level - 1]}% of total damage.";
    }
}
