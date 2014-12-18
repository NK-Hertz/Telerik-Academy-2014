namespace WarMachines.Machines
{
    using System;
    using Interfaces;
    using System.Text;
    using System.Collections.Generic;

    public class Pilot : IPilot, IComparable
    {
        private string name;
        private IList<IMachine> machinesEnagaged;

        public Pilot()
        { }

        public Pilot(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }

        public void AddMachine(IMachine machine)
        {
            this.machinesEnagaged.Add(machine);
            // to sort
            
        }

        public string Report()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0} - ", this, name);
            if (machinesEnagaged.Count == 0)
            {
                output.AppendLine("no machines");
            }
            else
            {
                string.Concat("{0} ", this.machinesEnagaged.Count);
                if (machinesEnagaged.Count == 1)
                {
                    output.AppendLine("machine");
                }
                else
                {
                    output.AppendLine("mashines");
                }
            }
            // more to do 
            return output.ToString();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
