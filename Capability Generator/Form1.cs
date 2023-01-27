using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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
            double values = (random.NextDouble() * (maximum - minimum) + minimum);
            return values;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double maximum = double.Parse(Max_texbox_text.Text);
            double minimum = double.Parse(Min_textbox.Text);
            double maximumTOL = double.Parse(plus_tol_textbox.Text);
            double minimumTOL = double.Parse(tol_minus_textbox.Text);

            double resultCPK = 0;
            double resultCP = 0;
            int nrOfLoops =0;
            while ((resultCP < 1.75) && (resultCPK < 1.5)&&(nrOfLoops!=10000))
            {
                int numberOfValues = 30;
                double[] values = new double[numberOfValues];
                for (int i = 0; i < 30; i++)
                {
                    double random = GetRandomNumber(maximum, minimum);
                    values[i] = random;
                }
                // Sum up values and squares.
                double USL = maximumTOL;
                double LSL = minimumTOL;

                double sumOfRandomnumbers = -1;
                Array.ForEach(values, i => sumOfRandomnumbers += i);
                double sumsq = Math.Pow(sumOfRandomnumbers, 2);

                double delta = USL - LSL;
                sumOfRandomnumbers += delta;
                sumsq += delta * delta;


                // Compute standard deviation.

                double mean = sumOfRandomnumbers / 30;
                var minusAvarage = new double[values.Length];
                var square = new double[values.Length];
                for (int i = 0, j = values.Length; i < j; i++)
                { minusAvarage[i] = values[i] - mean; }
                for (int i = 0, j = values.Length; i < j; i++)
                { square[i] = Math.Pow(minusAvarage[i], 2); }
                double summOfSquare = square.Sum();
                double divideByCountOfValues = summOfSquare / 30;
                double standardDev = Math.Sqrt(divideByCountOfValues);


                // Compute Cp and Cpk.


                double usl = USL;
                double lsl = LSL;
                double Cp = (usl - lsl) / (6 * standardDev);
                double Cpk = Math.Min(
                    (usl - mean) / (3 * standardDev),
                    (mean - lsl) / (3 * standardDev));
                resultCPK = Cpk;
                resultCP = Cp;
                
                if ((resultCPK > 1.5)&& (resultCP > 1.75))
                {
                    MessageBox.Show("Cpk este:"+resultCPK.ToString()+ "si Cp este:" + resultCP.ToString());
                    int printDatagridwiev = 30;
                    int loopsDatagridwiev = 0;
                    while (printDatagridwiev > loopsDatagridwiev)
                    {
                        DataTable dt = new DataTable();
                        dataGridView1.Rows[0].Cells[loopsDatagridwiev].Value = values[loopsDatagridwiev];
                        loopsDatagridwiev++;
                    }
                    
                        
                        
                    Clipboard.Clear();
                    dataGridView1.SelectAll();
                    dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
                    DataObject dataObj = dataGridView1.GetClipboardContent();
                    Clipboard.SetDataObject(dataObj, true);
                }

                //Clipboard.Clear();
                //Clipboard.SetText(string.Join("' '", values.Select(t => t.ToString())));
                if (nrOfLoops == 10000 - 2)
                {
                    MessageBox.Show("Nu am gasit te rog schimba minimum si maximum");
                }
                nrOfLoops++;
            }

        }

        private void generate_no_formulas_Click(object sender, EventArgs e)
        {
            double maximum = double.Parse(Max_texbox_text.Text);
            double minimum = double.Parse(Min_textbox.Text);

            int numberOfValues = 30;
            double[] values = new double[numberOfValues];
            for (int i = 0; i < 30; i++)
            {
                double random = GetRandomNumber(maximum, minimum);
                values[i] = random;
            }
            int printDatagridwiev = 30;
            int loopsDatagridwiev = 0;
            while (printDatagridwiev > loopsDatagridwiev)
            {
                DataTable dt = new DataTable();
                dataGridView1.Rows[0].Cells[loopsDatagridwiev].Value = values[loopsDatagridwiev];
                loopsDatagridwiev++;
            }
            Clipboard.Clear();
            dataGridView1.SelectAll();
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            DataObject dataObj = dataGridView1.GetClipboardContent();
            Clipboard.SetDataObject(dataObj, true);
        }
    }

}


