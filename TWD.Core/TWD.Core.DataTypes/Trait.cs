using System;
using EnsureThat;

namespace TWD.Core.DataTypes
{
    public class Trait
    {
        public Trait(Guid id, string name)
        {
            Id = Ensure.Guid.IsNotEmpty(id, nameof(id));
            Name = Ensure.String.IsNotNullOrWhiteSpace(name, nameof(name));
        }

        public Guid Id { get; }
        public string Name { get; }

        // TODO: make abstract later
        public string GetDescription(int level)
        {
            return $"{level}";
        }

        // TODO: make protected abstract supported classes
        public bool BelongsToClass(Guid classId)
        {
            return true;
        }
    }
}
