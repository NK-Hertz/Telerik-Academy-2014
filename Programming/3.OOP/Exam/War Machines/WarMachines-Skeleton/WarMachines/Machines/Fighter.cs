namespace WarMachines.Machines
{
    using System;
    using Interfaces;

    public class Fighter : Machine, IFighter, IMachine
    {
        private bool stealthMode;
        private string StealthOn;

        public Fighter(string name, IPilot pilot, double healthPoints, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, null, 200, attackPoints, defensePoints)
        {
            this.stealthMode = stealthMode;
        }

        public bool StealthMode
        {
            get { return this.stealthMode; }
        }

        public void ToggleStealthMode()
        {
            if (stealthMode == true)
            {
                this.stealthMode = false;
            }
            else
            {
                this.stealthMode = true;
            }

            Console.WriteLine("Fighter {0} toggled stealth mode",this.Name);
        }

    }
}
