using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capability_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static Random random = new Random();
        public double GetRandomNumber(double minimum, double maximum)
        {
         double values= (random.NextDouble() * (maximum - minimum) + minimum);
            return values;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double maximum = double.Parse(Max_texbox_text.Text);
            double minimum = double.Parse(Min_textbox.Text);
            double maximumTOL = double.Parse(plus_tol_textbox.Text);
            double minimumTOL = double.Parse(tol_minus_textbox.Text);
            int numberOfValues = 30;
            double[] values = new double[numberOfValues];
            for (int i = 0; i < 30; i++)
            {
              double random = GetRandomNumber(maximum, minimum);
                values[i] = random;
            }
            //calculatin the standard deviation, sequence is the 30 numbers
             //double standardDeviation(IEnumerable<double> sequence)
             //{
             //   double result = 0;

             //   if (sequence.Any())
             //   {
             //       double average = sequence.Average();
             //       double sum = sequence.Sum(d => Math.Pow(d - average, 2));
             //       result = Math.Sqrt((sum) / sequence.Count());
             //   }
             //   return result;
             //}

            //List<double> intList = new List<double> { 1, 2, 3, 4, 5 };
            //double standard_deviation = standardDeviation(intList);
            //MessageBox.Show(standard_deviation.ToString());
            //MessageBox.Show(values[0].ToString());

            // Sum up values and squares.
            double USL = maximumTOL;
            double LSL =minimumTOL;

            double sumOfRandomnumbers = -1;
            Array.ForEach(values, i => sumOfRandomnumbers += i);
            double sumsq = Math.Pow(sumOfRandomnumbers, 2);
            
            double delta = USL - LSL;
            sumOfRandomnumbers += delta;
            sumsq += delta * delta;
            

            // Compute standard deviation.

            double mean = sumOfRandomnumbers / 30;
            //https://www.winspc.com/what-is-a-standard-deviation-and-how-do-i-compute-it/#:~:text=Computing%20the%20Standard%20Deviation&text=Subtract%20the%20process%20average%20from,4%20by%20the%20sample%20size
            var array3 = new double[values.Length];
            for (int i = 0, j = values.Length; i < j; i++)
            { array3[i] = values[i] - mean; }
           //     
            

            double stdev = Math.Sqrt(sumsq / 30 - mean * mean);

            // Compute Cp and Cpk.

            
                double usl = USL;
                double lsl = LSL;
                double Cp = (usl - lsl) / (6 * stdev);
                double Cpk = Math.Min(
                    (usl - mean) / (3 * stdev),
                    (mean - lsl) / (3 * stdev));
            MessageBox.Show(Cpk.ToString());
            Clipboard.Clear();
            Clipboard.SetText(string.Join("\n", values.Select(t => t.ToString())));

        }
    }
}
