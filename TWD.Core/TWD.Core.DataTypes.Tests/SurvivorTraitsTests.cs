using NUnit.Framework;
using TWD.Core.DataTypes.Survivors.Traits.Common;

namespace TWD.Core.DataTypes.Tests
{
    [TestFixture]
    public class SurvivorTraitsTests
    {
        [TestCase(4, 12)]
        [TestCase(5, 15)]
        [TestCase(6, 16)]
        public void Should_Return_Correct_Description_For_BulletDodge(int level, int percent)
        {
            var bulletDodge= new BulletDodgeTrait();
            var expectedDescription = $"{percent}% to dodge a ranged attack except while stunned or struggling.";

            Assert.AreEqual(expectedDescription, bulletDodge.GetDescription(level));
        }

        [TestCase(5, 7, 30)]
        [TestCase(6, 8, 33)]
        public void Should_Return_Correct_Description_For_CriticalAim(int level, int normalAtkPercent, int criticalAtkPercent)
        {
            var criticalAim = new CriticalAimTrait();
            var expectedDescription = $"Normal attacks have {normalAtkPercent}% chance to stun a target regardless of Body Shots, and Critical Hits have {criticalAtkPercent}% chance to stun a target. The stun lasts for 1 turn.";

            Assert.AreEqual(expectedDescription, criticalAim.GetDescription(level));
        }

        [TestCase(3, 38)]
        [TestCase(4, 42)]
        [TestCase(5, 45)]
        [TestCase(6, 48)]
        public void Should_Return_Correct_Description_For_DefensiveStance(int level, int percent)
        {
            var defensiveStance = new DefensiveStanceTrait();
            var expectedDescription = $"Increases damage resistance during Overwatch by {percent}%.";

            Assert.AreEqual(expectedDescription, defensiveStance.GetDescription(level));
        }

        [TestCase(4, 12)]
        [TestCase(5, 15)]
        [TestCase(6, 16)]
        public void Should_Return_Correct_Description_For_Dodge(int level, int percent)
        {
            var dodge = new DodgeTrait();
            var expectedDescription = $"Has a {percent}% chance of dodging a melee attack except while stunned or struggling.";

            Assert.AreEqual(expectedDescription, dodge.GetDescription(level));
        }

        [TestCase(4, 40)]
        public void Should_Return_Correct_Description_For_FollowThrough(int level, int percent)
        {
            var followThrough = new FollowThroughTrait();
            var expectedDescription = $"When defeating an enemy by dealing more damage than necessary, there is a {percent}% chance that 50% of the extra damage will be dealt to a random adjacent enemy.";

            Assert.AreEqual(expectedDescription, followThrough.GetDescription(level));
        }

        [TestCase(3, 10)]
        [TestCase(4, 12)]
        [TestCase(5, 15)]
        [TestCase(6, 16)]
        public void Should_Return_Correct_Description_For_IronSkin(int level, int percent)
        {
            var ironSkin = new IronSkinTrait();
            var expectedDescription = $"This survivor takes {percent}% less damage from attacks. Total damage resistance cannot exceed 80%";

            Assert.AreEqual(expectedDescription, ironSkin.GetDescription(level));
        }

        [TestCase(2, 12)]
        [TestCase(4, 16)]
        [TestCase(5, 18)]
        [TestCase(6, 20)]
        [TestCase(7, 22)]
        public void Should_Return_Correct_Description_For_Lucky(int level, int percent)
        {
            var lucky = new LuckyTrait();
            var expectedDescription = $"Improves the chances that other traits will take effect by {percent}%.";

            Assert.AreEqual(expectedDescription, lucky.GetDescription(level));
        }

        [TestCase(3, 10)]
        [TestCase(4, 12)]
        [TestCase(5, 15)]
        [TestCase(6, 16)]
        [TestCase(7, 17)]
        public void Should_Return_Correct_Description_For_Marksman(int level, int percent)
        {
            var marksman = new MarksmanTrait();
            var expectedDescription = $"Attacks deal {percent}% more weapon damage.";

            Assert.AreEqual(expectedDescription, marksman.GetDescription(level));
        }

        [TestCase(3, 30)]
        [TestCase(4, 35)]
        [TestCase(5, 40)]
        [TestCase(6, 43)]
        public void Should_Return_Correct_Description_For_PowerStrike(int level, int percent)
        {
            var powerStrike = new PowerStrikeTrait();
            var expectedDescription = $"Attacks made on your turn gain {percent}% final damage and have {percent}% better critical chance if you have not moved. Total critical chance cannot exceed 90%.";

            Assert.AreEqual(expectedDescription, powerStrike.GetDescription(level));
        }

        [TestCase(2, 55)]
        [TestCase(4, 65)]
        [TestCase(5, 70)]
        [TestCase(6, 80)]
        public void Should_Return_Correct_Description_For_Punish(int level, int percent)
        {
            var punish = new PunishTrait();
            var expectedDescription = $"Free attack at the end of the turn to a random adjacent enemy that deals {percent}% of total damage.";

            Assert.AreEqual(expectedDescription, punish.GetDescription(level));
        }

        [TestCase(2, 37)]
        [TestCase(4, 62)]
        [TestCase(5, 75)]
        [TestCase(6, 78)]
        public void Should_Return_Correct_Description_For_Retaliate(int level, int percent)
        {
            var retaliate = new RetaliateTrait();
            var expectedDescription = $"Retaliates after being attacked once per turn, dealing {percent}% of total damage.";

            Assert.AreEqual(expectedDescription, retaliate.GetDescription(level));
        }

        [TestCase(5, 64)]
        [TestCase(6, 68)]
        [TestCase(7, 73)]
        public void Should_Return_Correct_Description_For_Revenge(int level, int percent)
        {
            var revenge = new RevengeTrait();
            var expectedDescription = $"When an ally is attacked by an enemy in range, make an attack against that enemy that deals  {percent}% of total damage.";

            Assert.AreEqual(expectedDescription, revenge.GetDescription(level));
        }

        [TestCase(3, 17)]
        [TestCase(4, 21)]
        [TestCase(5, 25)]
        [TestCase(6, 29)]
        [TestCase(7, 33)]
        public void Should_Return_Correct_Description_For_Ruthless(int level, int percent)
        {
            var ruthless = new RuthlessTrait();
            var expectedDescription = $"Ruthless: Your charge attacks  deal {percent}% total damage.";

            Assert.AreEqual(expectedDescription, ruthless.GetDescription(level));
        }

        [TestCase(2, 7)]
        [TestCase(4, 12)]
        [TestCase(5, 15)]
        [TestCase(6, 16)]
        public void Should_Return_Correct_Description_For_Strong(int level, int percent)
        {
            var strong = new StrongTrait();
            var expectedDescription = $"Attacks deal {percent}% more weapon damage.";

            Assert.AreEqual(expectedDescription, strong.GetDescription(level));
        }

        [TestCase(3, 30)]
        [TestCase(4, 35)]
        [TestCase(5, 40)]
        [TestCase(6, 43)]
        [TestCase(7, 45)]
        public void Should_Return_Correct_Description_For_SureShot(int level, int percent)
        {
            var sureShot = new SureShotTrait();
            var expectedDescription = $"Attacks made on your turn have {percent}% greater critical chance if you have not moved. Total critical change cannot exceed 90%.";

            Assert.AreEqual(expectedDescription, sureShot.GetDescription(level));
        }

        [TestCase(3, 28)]
        [TestCase(4, 32)]
        [TestCase(5, 35)]
        public void Should_Return_Correct_Description_For_Vigilant(int level, int percent)
        {
            var vigilant = new VigilantTrait();
            var expectedDescription = $"Overwatch attack total damage is increased by {percent}%.";

            Assert.AreEqual(expectedDescription, vigilant.GetDescription(level));
        }
    }
}
