using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Developing_Products_in_Half_the_Time
{
    /// <summary>
    /// Interaction logic for EarnedValueAnalysis.xaml
    /// </summary>
    public partial class EarnedValueAnalysis : Window
    {
        int schedulevariance { get; set;  }
        int costVariance { get; set; }
        public EarnedValueAnalysis()
        {
            InitializeComponent();
        }

    
        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            schedulevariance = Int32.Parse(TextBox1.Text) - Int32.Parse(TextBox2.Text);
            decimal scheduleperformanceindex = Math.Round(decimal.Parse(TextBox2.Text) / decimal.Parse(TextBox1.Text),2);

            MessageBox.Show($"Schedule Variance is {schedulevariance}");
            MessageBox.Show($"Schedule Performance Index is {scheduleperformanceindex}");
        }

        private void Cost_Variance_Click(object sender, RoutedEventArgs e)
        {
            costVariance = Int32.Parse(TextBox3.Text) - Int32.Parse(TextBox4.Text);
            decimal costperformanceindex = Math.Round(decimal.Parse(TextBox3.Text) / decimal.Parse(TextBox4.Text), 2);

            MessageBox.Show($"Cost Varaince is {costVariance}");
            MessageBox.Show($"Cost Performance Index is {costperformanceindex}");
        }

        // planned value
        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // expected value
        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // expected  cost value
        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // actual cost
        private void TextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Estimate_Click(object sender, RoutedEventArgs e)
        {
            int EstimateCostPerformance = Int32.Parse(ForecastEAC.Text) + Int32.Parse(TextBox4.Text);
            MessageBox.Show($"EAC Forecast is {EstimateCostPerformance}");
        }

        private void ForecastEAC_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void EACForecastBudgetRate_Click(object sender, RoutedEventArgs e)
        {
            int EstimateCostPeformance = Int32.Parse(TextBox4.Text) + ( Int32.Parse(TextBox1.Text) - Int32.Parse(TextBox2.Text));  // actual cost + planned value - earned value
            MessageBox.Show($"EAC Forecast Budgeted Rate is {EstimateCostPeformance}");
        }

        private void EACForecastPerformedPresentCPI_Click(object sender, RoutedEventArgs e)
        {
            decimal EstimateCostPeformance = Math.Round((decimal.Parse(TextBox1.Text) / costVariance),2);  
            MessageBox.Show($"EAC Forecast present CPI Rate is {EstimateCostPeformance}");
        }

        private void EACForecastForETCWork_Click(object sender, RoutedEventArgs e)
        {
            int EstimateCostPeformance = Int32.Parse(TextBox4.Text) + (Int32.Parse(TextBox1.Text) - Int32.Parse(TextBox2.Text)) / (schedulevariance * costVariance);
            MessageBox.Show($"EAC Forecast present SPI and CPI Rate {EstimateCostPeformance}");
        }

        private void TCPI_Click(object sender, RoutedEventArgs e)
        {
            decimal EstimateCostPeformance = Int32.Parse(TextBox4.Text) + (Int32.Parse(TextBox1.Text) - Int32.Parse(TextBox2.Text));  // actual cost + planned value - earned value

            decimal TCPI = Math.Round((decimal.Parse(TextBox1.Text) - decimal.Parse(TextBox2.Text)) / (EstimateCostPeformance - decimal.Parse(TextBox4.Text))  ,2);
            MessageBox.Show($"To-Complete Performance Index {TCPI}");
        }
    }
}
