using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL
{
    public class Logger : ILogger
    {

        /// <summary>
        /// Function to log result in a text file.
        /// </summary>
        /// <param name="probability1"></param>
        /// <param name="probability2"></param>
        /// <param name="result"></param>
        /// <param name="calType"></param>
        public void LogResult(string probability1, string probability2, string result, string calType)
        {
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName + @"\Logfile.txt"; 

            using (StreamWriter w = File.AppendText(_filePath))
            {
                w.WriteLine("We performed " + calType + " calculation for " + probability1 + " and " + probability2 + " at " + DateTime.Now + ". The result is " +  result + ".");
            }

            
        }
    }
}
