using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int choice = Convert.ToInt16(optionConvert.Text);
            double convertValue = Convert.ToDouble(valueConvert.Text);
            if (choice == 1)
            {
                double firstOption = InchesToCentimeter(convertValue);
                convertOutput.Text = $"{firstOption}";
            }
            else if (choice == 2)
            {
                double secondOption = FeetToCentimeter(convertValue);
                convertOutput.Text= $"{secondOption}";
            }
            else if (choice == 3)
            {
                double thirdOption = YardsToMeters(convertValue);
                convertOutput.Text = $"{thirdOption}";
            }
            else
            {
                double fourthOption = MilesToKilometers(convertValue);
                convertOutput.Text = $"{fourthOption}";
            }
        }


        private double InchesToCentimeter(double inches)
        {
            double cm = inches * 2.54;
            return cm;
        }

        private double FeetToCentimeter(double feet)
        {
            double cm = feet * 30.48;
            return cm;
        }

        private double YardsToMeters(double yards)
        {
            double meter = yards * 0.91;
            return meter;
        }

        private double MilesToKilometers(double miles)
        {
            double km = miles * 1.6;
            return km;
        }
    }

}
