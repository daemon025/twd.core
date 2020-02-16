using System;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors.Traits.Common
{
    public class BulletDodgeTrait : Trait
    {
        private readonly int[] _percents = { 5, 7, 10, 12, 15, 16, 17, 18, 19, 20 };
        public BulletDodgeTrait() : base(TraitConstants.Survivor.BulletDodge, "Bullet Dodge") { }

        public override Guid[] SupportedClasses => SurvivorConstants.ClassTypes.All;

        public override string GetDescription(int level) =>
            $"{_percents[level - 1]}% to dodge a ranged attack except while stunned or struggling.";
    }
}
