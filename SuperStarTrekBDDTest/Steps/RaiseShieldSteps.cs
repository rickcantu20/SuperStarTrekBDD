using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SuperStarTrekBDDTest.Steps
{
    [Binding]
    public class RaiseShieldSteps
    {
        private Shield shield = new Shield();
        
        [Given(@"Shield maximum is (.*) units")]
        public void GivenShieldMaximumIsUnits(int p0)
        {
            Assert.AreEqual(shield.GetMaxShieldStrength(), p0);
        }
        
        [Given(@"Shield is currently at (.*) units")]
        public void GivenShieldIsCurrentlyAtUnits(int p0)
        {
            shield.SetCurrentStrength(p0);
            Assert.AreEqual(shield.GetCurrentStrength(),p0);
        }

        [Given(@"Shield is currently down")]
        public void GivenShieldIsCurrentlyDown()
        {
            Assert.IsFalse(shield.GetShieldStatus());
        }

        [When(@"I raise the shield")]
        public void WhenIRaiseTheShield()
        {
            shield.RaiseShield();
        }

        [Then(@"the shield should be raised")]
        public void ThenTheShieldShouldBeRaised()
        {
            Assert.IsTrue(shield.GetShieldStatus());
        }

        [When(@"I transfer (.*) to the Shield")]
        public void WhenITransferToTheShield(int p0)
        {
            shield.TransferEnergy(p0);
        }
        
        [Then(@"Shield should be at (.*)")]
        public void ThenShieldShouldBeAt(int p0)
        {
            Assert.AreEqual(shield.GetCurrentStrength(),p0);
        }

        [Given(@"Shield is not currently at (.*) units")]
        public void GivenShieldIsNotCurrentlyAtUnits(int p0)
        {
            Assert.AreNotEqual(shield.GetCurrentStrength(), p0);
        }

    }
}
