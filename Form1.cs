using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weight_on_Mercury__Venus__and_Mars
{
    public partial class Form1 : Form
    {
        SortedList<string, double> WeightConversionFactors = new SortedList<string, double>();
        public Form1()
        {
            InitializeComponent();

            //Initialize the sortedList
            WeightConversionFactors.Add("Mercury", 0.3772);
            WeightConversionFactors.Add("Venus", 0.9042);
            WeightConversionFactors.Add("Mars", 0.3783);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double earthWeight = Convert.ToDouble(txtEarthWeight.Text);

            double mercuryWeight = earthWeight * WeightConversionFactors["Mercury"];
            txtMercuryWeight.Text = mercuryWeight.ToString();

            double VenusConvertsionFactor = WeightConversionFactors["Venus"];
            double venusWeight = earthWeight * VenusConvertsionFactor;
            txtVenusWeight.Text = venusWeight.ToString();

            double MarsConvertsionFactor = WeightConversionFactors["Mars"];
            double MarsWeight = earthWeight * MarsConvertsionFactor;
            txtMarsWeight.Text = MarsWeight.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
