using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EnsureThat;

namespace TWD.Core.DataTypes.Badges
{
    public class BadgeContainer
    {
        public const int MaxBadgeLimitForSurvivor = 6;

        private readonly Badge[] _badges;

        public BadgeContainer()
        {
            _badges = new Badge[MaxBadgeLimitForSurvivor];
        }

        public BadgeContainer(Badge[] badges) : this()
        {
            _badges = Ensure.Collection.SizeIs(badges, MaxBadgeLimitForSurvivor, nameof(badges));
        }

        public ReadOnlyCollection<Badge> Badges => _badges.ToList().AsReadOnly();

        public void EquipBadge(Badge badge)
        {
            Ensure.Any.IsNotNull(badge, nameof(badge));
            Ensure.Bool.IsTrue(_badges[(int)badge.Slot] == null, nameof(badge.Slot),
                options => options.WithMessage("Can not equip badge on non free slot. Remove the old one first."));
            Ensure.Bool.IsTrue(_badges.Count(x => x != null && x.Effect == badge.Effect) < 3, null, opts => opts.WithMessage("Can not add more than 3 badges of the same effect."));

            _badges[(int)badge.Slot] = badge;
        }

        public void UnEquipBadge(BadgeSlot slot)
        {
            _badges[(int)slot] = null;
        }

        public IEnumerable<BadgeSlot> GetAvailableBadgeSlots()
        {
            for (var i = 0; i < 6; i++)
                if (_badges[i] == null)
                    yield return (BadgeSlot)i;
        }
    }
}
