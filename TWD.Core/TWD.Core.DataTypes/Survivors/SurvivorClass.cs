using System;
using EnsureThat;
using TWD.Core.DataTypes.Constants;

namespace TWD.Core.DataTypes.Survivors
{
    public class SurvivorClass
    {
        public SurvivorClass(Guid id, string name)
        {
            Id = Ensure.Guid.IsNotEmpty(id, nameof(id));
            Name = Ensure.String.IsNotNullOrWhiteSpace(name, nameof(name));
        }

        public Guid Id { get; }
        public string Name { get; }

        public static SurvivorClass Assault => new SurvivorClass(SurvivorConstants.ClassIds.Assault, nameof(Assault));
        public static SurvivorClass Bruiser => new SurvivorClass(SurvivorConstants.ClassIds.Bruiser, nameof(Bruiser));
        public static SurvivorClass Hunter => new SurvivorClass(SurvivorConstants.ClassIds.Hunter, nameof(Hunter));
        public static SurvivorClass Scout => new SurvivorClass(SurvivorConstants.ClassIds.Scout, nameof(Scout));
        public static SurvivorClass Shooter => new SurvivorClass(SurvivorConstants.ClassIds.Shooter, nameof(Shooter));
        public static SurvivorClass Warrior => new SurvivorClass(SurvivorConstants.ClassIds.Warrior, nameof(Warrior));
    }
}
