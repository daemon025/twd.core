using System;
using System.Linq;
using TWD.Core.DataTypes.Survivors;

namespace TWD.Core.DataTypes.Constants
{
    public class SurvivorConstants
    {
        public const int MaxLevel = 27;
        public static readonly int MaxTraitLevel = (int)SurvivorRarity.Elite5;

        public static class ClassIds
        {
            public static readonly Guid Assault = new Guid("97A376D4-02D3-48D2-BB1C-E4B72A2FDD7A");
            public static readonly Guid Bruiser = new Guid("E265A2FE-F584-421B-ABFF-B420031EC871");
            public static readonly Guid Hunter = new Guid("E976B337-218C-4375-8D32-5F59DEE84798");
            public static readonly Guid Scout = new Guid("068957B6-7F59-4638-A009-E88C18C87725");
            public static readonly Guid Shooter = new Guid("BF9AC26C-EF91-4823-AFF6-5CF4DB9ED5F6");
            public static readonly Guid Warrior = new Guid("980F3E53-2399-4839-9732-2DF51DCFF6ED");
        }

        public static class ClassTypes
        {
            public static readonly Guid[] Melee = { ClassIds.Bruiser, ClassIds.Scout, ClassIds.Warrior };
            public static readonly Guid[] Ranged = { ClassIds.Assault, ClassIds.Hunter, ClassIds.Shooter };
            public static readonly Guid[] All = Melee.ToList().Concat(Ranged).ToArray();
            public static readonly Guid[] None = new Guid[0];
        }
    }
}
