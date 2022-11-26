/**
 * Grading ID:       L8486
 * Lab number:       2
 * Due Date:         9/15/19
 * Course Section:   75
 * Description:      The user will enter the price of their meal and the application will calculate and display tips for 15%, 18%, and 20%.
**/

using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private const double TIP_LOW = 0.15;         // Define constant low tip rate (15%)
        private const double TIP_MED = 0.18;         // Define constant med tip rate (18%)
        private const double TIP_HIGH = 0.2;         // Define constant high tip rate (20%)

        public Form1()
        {
            InitializeComponent();
        }

        // On 'Calculate' button press event, calculate tips for meal price, and update labels
        private void CalcBtn_Click(object sender, EventArgs e)
        {
            double priceMeal = double.Parse(mealPriceText.Text);         // Get price of meal from textbox and parse as a double, then store in variable priceMeal
            tipLowLabel.Text = $"{(priceMeal * TIP_LOW):C2}";            // Meal price * Low Tip    = Low tip label  (Currency format with 2 decimal places)
            tipMedLabel.Text = $"{(priceMeal * TIP_MED):C2}";            // Meal price * Medium Tip = Med tip label  (Currency format with 2 decimal places)
            tipHighLabel.Text = $"{(priceMeal * TIP_HIGH):C2}";          // Meal price * High Tip   = High tip label (Currency format with 2 decimal places)
            mealPriceText.Focus();
        }
    }
}