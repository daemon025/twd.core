using System;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors.Traits.Common
{
    public class IronSkinTrait : Trait
    {
        private readonly int[] _percents = { 5, 7, 10, 12, 15, 16, 17, 18, 19, 20 };
        public IronSkinTrait() : base(TraitConstants.Survivor.IronSkin, "Iron Skin") { }

        public override Guid[] SupportedClasses => SurvivorConstants.ClassTypes.All;

        public override string GetDescription(int level) =>
            $"This survivor takes {_percents[level - 1]}% less damage from attacks. Total damage resistance cannot exceed 80%";
    }
}
