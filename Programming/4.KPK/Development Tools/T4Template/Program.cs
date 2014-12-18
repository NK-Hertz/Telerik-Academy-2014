[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace T4Template
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using log4net;

    /// <summary>
    /// Initial class created on starting a console app project
    /// </summary>
    public class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// Very simple and stupid sample of code to obfuscated although it doesn`t need 
        /// any obfuscation
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Log.Info("Application Starting");

            var myName = "Pesho";
            var egn = 13454646543;
            Console.WriteLine("{0} : {1}", myName, egn);

            int moneyInLevs = 1000;

            decimal usdCourse = 1.45m;
            int interestForUSD = 4;

            decimal euroCourse = 1.9556m;
            int interestForEuro = 5;

            // in order to deposit we have to change currency first because we have lev
            decimal valueOfInterestDepositInEuro = 
                    (moneyInLevs / euroCourse) * interestForEuro / 100;
            Console.WriteLine(valueOfInterestDepositInEuro);

            decimal valueOfInterestDepositInUSD = 
                    (moneyInLevs / usdCourse) * interestForUSD / 100;
            Console.WriteLine(valueOfInterestDepositInUSD);

            decimal euroDepositInterestInLevs = valueOfInterestDepositInEuro * euroCourse;
            decimal moneyPlusInterest = euroDepositInterestInLevs + moneyInLevs;
            Console.WriteLine(moneyPlusInterest);
        }
    }
}
