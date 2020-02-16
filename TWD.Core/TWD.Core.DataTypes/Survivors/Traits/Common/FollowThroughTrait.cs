using System;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors.Traits.Common
{
    public class FollowThroughTrait : Trait
    {
        private readonly int[] _percents = { 25, 30, 35, 40, 45, 50, 55, 60, 65, 70 };

        public FollowThroughTrait() : base(TraitConstants.Survivor.FollowThrough, "Follow Through") { }

        public override Guid[] SupportedClasses => SurvivorConstants.ClassTypes.Melee;

        public override string GetDescription(int level) =>
            $"When defeating an enemy by dealing more damage than necessary, there is a {_percents[level - 1]}% chance that 50% of the extra damage will be dealt to a random adjacent enemy.";
    }
}
