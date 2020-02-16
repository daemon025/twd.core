using System;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors.Traits.Common
{
    public class RuthlessTrait : Trait
    {
        private readonly int[] _percents = { 10, 13, 17, 21, 25, 29, 33, 37, 41, 45 };
        public RuthlessTrait() : base(TraitConstants.Survivor.Ruthless, "Ruthless") { }

        public override Guid[] SupportedClasses => SurvivorConstants.ClassTypes.All;

        public override string GetDescription(int level) =>
            $"Ruthless: Your charge attacks  deal {_percents[level - 1]}% total damage.";
    }
}
