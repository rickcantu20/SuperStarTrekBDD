using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStarTrekBDDTest
{
    class Shield
    {
        private int maxStrength = 10000;

        private int strength { get; set; }
        private bool shieldStatus { get; set; }
        public Shield()
        {
            shieldStatus = false;
            strength = maxStrength;
        }

        public int GetMaxShieldStrength()
        {
            return maxStrength;
        }
        public int GetCurrentStrength()
        {
            return strength;
        }

        public void SetCurrentStrength(int value)
        {
            strength = value;
        }

        public void TransferEnergy(int value)
        {
            if (strength + value > maxStrength)
            {
                strength = maxStrength;
            }
            else
            {
                strength = strength + value;
            }
        }

        public bool GetShieldStatus()
        {
            return shieldStatus;
        }

        public void RaiseShield()
        {
            shieldStatus = true;
        }
    }
}
