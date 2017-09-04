using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Postal_Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        double shippingVolume = 0.0;
        double methodMultiplier = 0.0;

        public double getVolume()
        {
            shippingVolume = double.Parse(WidthTextBox.Text) *
                double.Parse(LengthTextBox.Text) *
                double.Parse(HeightTextBox.Text);
            return shippingVolume;
        }

        public void checkMethod()
        {
            if (GroundButton.Checked)
            {
                methodMultiplier = .15;
            }
            else if (AirButton.Checked)
            {
                methodMultiplier = .25;
            }
            else
            {
                methodMultiplier = .45;
            }
        }

        public double getCost(double shippingVolume, double methodMultiplier)
        {
            double totalCost = shippingVolume * methodMultiplier;
            return totalCost;
        }

        public void showResult()
        {
            checkMethod();
            double answer = getCost(getVolume(), methodMultiplier);
            resultLabel.Text = String.Format("It will cost {0:C} to ship your package", answer);
        }


        protected void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            showResult();
        }

        protected void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            showResult();
        }

        protected void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            showResult();
        }

        protected void GroundButton_CheckedChanged(object sender, EventArgs e)
        {
            showResult();
        }

        protected void AirButton_CheckedChanged(object sender, EventArgs e)
        {
            showResult();
        }

        protected void NextDayButton_CheckedChanged(object sender, EventArgs e)
        {
            showResult();
        }
    }
}