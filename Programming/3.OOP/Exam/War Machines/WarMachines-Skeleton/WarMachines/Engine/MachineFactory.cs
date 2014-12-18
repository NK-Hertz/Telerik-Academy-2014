namespace WarMachines.Engine
{
    using System;
    using System.Collections.Generic;
    using WarMachines.Interfaces;
    using WarMachines.Machines;

    public class MachineFactory : IMachineFactory
    {
        public IList<string> allPilots;
        public IList<string> allTanks;
        public IList<string> allFighters;

        public IPilot HirePilot(string name)
        {
            if (allPilots.Contains(name))
            {
                return Pilot(name);
            }
            allPilots.Add(name);
            return new Pilot(name);
        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (allTanks.Contains(name))
            {
                return null;
            }
            allTanks.Add(name);
            return new Tank(name, null, 100, attackPoints, defensePoints);
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            if (allFighters.Contains(name))
            {
                return null;
            }
            allFighters.Add(name);
            return new Fighter(name, null, 200, attackPoints, defensePoints, stealthMode);
        }
    }
}
