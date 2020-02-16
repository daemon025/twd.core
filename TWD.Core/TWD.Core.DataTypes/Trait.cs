using System;
using System.Linq;
using EnsureThat;

namespace TWD.Core.DataTypes
{
    public abstract class Trait
    {
        protected Trait(Guid id, string name)
        {
            Id = Ensure.Guid.IsNotEmpty(id, nameof(id));
            Name = Ensure.String.IsNotNullOrWhiteSpace(name, nameof(name));
        }

        public Guid Id { get; }
        public string Name { get; }
        public abstract Guid[] SupportedClasses { get; }

        public abstract string GetDescription(int level);

        public bool BelongsToClass(Guid classId) =>
            SupportedClasses.Contains(classId);
    }
}
