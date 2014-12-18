namespace WarMachines.Machines
{
    using System;
    using Interfaces;

    public class Tank : Machine, ITank, IMachine
    {
        private bool defenseMode = true;
        
        public const int DefModeDefPoints = 30;
        public const int DefModeAttPoints = 40;

        public Tank(string name, IPilot pilot, double healthPoints, double attackPoints, double defensePoints)
            : base(name, pilot, 100, attackPoints - DefModeAttPoints, defensePoints + DefModeDefPoints)
        {
        }

        public bool DefenseMode
        {
            get { return defenseMode; }
        }

        public void ToggleDefenseMode()
        {
            if (defenseMode == true)
            {
                this.defenseMode = false;
            }
            else
            {
                this.defenseMode = true;
            }
        }


    }
}
