namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using System.Text;

    public class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;
        private IList<string> targets;

        public Machine(string name, IPilot pilot, double healthPoints, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.pilot = pilot;
            this.HealthPoints = healthPoints;
            this.attackPoints = attackPoints;
            this.defensePoints = defensePoints;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Machine name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return pilot;
            }
            set
            {
                pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentNullException("Health points cannot be zero or less!");
                }
                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get { return this.attackPoints; }
        }

        public double DefensePoints
        {
            get { return this.defensePoints; }
        }

        public IList<string> Targets
        {
            get { return targets; }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        }

        public override string ToString()
        { 
            StringBuilder output = new StringBuilder();
            output.AppendFormat("- {0}\n *Type: {1}\n *Health: {2}\n *Attack: {3}\n *Defense: \n",
                this.name, GetType(),this.healthPoints, attackPoints, this.defensePoints);
            if (this.targets.Count > 0)
            {
                output.AppendFormat(" *Targets: ");
                foreach (var target in targets)
                {
                    output.AppendFormat("{0}, ", target);
                }

                output.Length -= 2;
            }
            else
            {
                output.AppendLine("None");
            }

            //if ()
            //{
                
            //}

            return output.ToString();
        }
    }
}
