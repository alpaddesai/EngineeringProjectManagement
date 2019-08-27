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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Developing_Products_in_Half_the_Time
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string AgileDays { get; set; }
        public string WaterFallDays { get; set; }

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Maximize_Shareholder_Wealth_Click(object sender, RoutedEventArgs e)
        {

                int NPDSchedule = 10;
                int AgileNPDSchedule = 10;

                double FreeCashFlowYear1 = 0;
                double FreeCashFlowYear2 = 0;
                double FreeCashFlowYear3 = 0;
                double FreeCashFlowYear4 = 0;
                double FreeCashFlowYear5 = 0;
                string Name;

            NPDSchedule = Int32.Parse(Waterfall_NPD.Text);
            AgileNPDSchedule = Int32.Parse(Agile_NPD.Text);

            if (NPDSchedule <= 90 && NPDSchedule > 0)
                {
 

                    FreeCashFlowYear1 = 51000;
                    FreeCashFlowYear2 = 115480;
                    FreeCashFlowYear3 = 201824;
                    FreeCashFlowYear4 = 325235;
                    FreeCashFlowYear5 = 493896;
                    Name = "Waterfall NPD Model ";

                    MainWindow.ExecuteAnalysis(FreeCashFlowYear1, FreeCashFlowYear2, FreeCashFlowYear3, FreeCashFlowYear4, FreeCashFlowYear5, NPDSchedule, Name);

                }

                if (AgileNPDSchedule <= 90 && AgileNPDSchedule > 0)
                {
                    FreeCashFlowYear1 = 119400;
                    FreeCashFlowYear2 = 204976;
                    FreeCashFlowYear3 = 317609;
                    FreeCashFlowYear4 = 530771;
                    FreeCashFlowYear5 = 688932;
                    Name = "Agile NPD Model ";


                    MainWindow.ExecuteAnalysis(FreeCashFlowYear1, FreeCashFlowYear2, FreeCashFlowYear3, FreeCashFlowYear4, FreeCashFlowYear5, AgileNPDSchedule, Name);
                }

                if (NPDSchedule <= 120 && NPDSchedule > 90)
                {
                    FreeCashFlowYear1 = 16800;
                    FreeCashFlowYear2 = 69742;
                    FreeCashFlowYear3 = 141590;
                    FreeCashFlowYear4 = 245880;
                    FreeCashFlowYear5 = 389799;
                    Name = "Waterfall NPD Model ";

                    MainWindow.ExecuteAnalysis(FreeCashFlowYear1, FreeCashFlowYear2, FreeCashFlowYear3, FreeCashFlowYear4, FreeCashFlowYear5, NPDSchedule, Name);

                }

                if (AgileNPDSchedule <= 120 && AgileNPDSchedule > 90)
                {
                    FreeCashFlowYear1 = 77160;
                    FreeCashFlowYear2 = 148770;
                    FreeCashFlowYear3 = 243876;
                    FreeCashFlowYear4 = 428434;
                    FreeCashFlowYear5 = 562258;
                    Name = "Agile NPD Model ";

                    MainWindow.ExecuteAnalysis(FreeCashFlowYear1, FreeCashFlowYear2, FreeCashFlowYear3, FreeCashFlowYear4, FreeCashFlowYear5, AgileNPDSchedule, Name);
                }


                if (NPDSchedule <= 180 && NPDSchedule > 120)
                {
                    FreeCashFlowYear1 = -300;
                    FreeCashFlowYear2 = 46873;
                    FreeCashFlowYear3 = 111473;
                    FreeCashFlowYear4 = 206203;
                    FreeCashFlowYear5 = 337750;
                    Name = "Waterfall NPD Model ";

                    MainWindow.ExecuteAnalysis(FreeCashFlowYear1, FreeCashFlowYear2, FreeCashFlowYear3, FreeCashFlowYear4, FreeCashFlowYear5, NPDSchedule, Name);
                }

                if (AgileNPDSchedule <= 180 && AgileNPDSchedule > 120)
                {
                    FreeCashFlowYear1 = 56040;
                    FreeCashFlowYear2 = 120667;
                    FreeCashFlowYear3 = 207010;
                    FreeCashFlowYear4 = 377265;
                    FreeCashFlowYear5 = 498921;
                    Name = "Agile NPD Model ";

                    MainWindow.ExecuteAnalysis(FreeCashFlowYear1, FreeCashFlowYear2, FreeCashFlowYear3, FreeCashFlowYear4, FreeCashFlowYear5, AgileNPDSchedule, Name);
                }

          

        }

        private void Agile_NPD_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Waterfall_NPD_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void ProjectSchedule_Click(object sender, RoutedEventArgs e)
        {
            ProjectSchedule ObjectSchedule = new ProjectSchedule();
            ObjectSchedule.Show();
        }

        private void CashFlows_Click(object sender, RoutedEventArgs e)
        {
            DeploymentChart deploymentChartObject = new DeploymentChart();
            deploymentChartObject.Show();
        }

        public static void ExecuteAnalysis( double FreeCashFlowYear1, double FreeCashFlowYear2, double FreeCashFlowYear3, double FreeCashFlowYear4, double FreeCashFlowYear5, int NPDSchedule, string Name)
        {
            double OutstandingShares = 10000;
            double StockPrice = 0;
            double FreeCashFlow;
            double discountRate = .1197;

            FreeCashFlow = Math.Round(FreeCashFlowYear1 / (Math.Pow((1 + discountRate), 1)) +
                        FreeCashFlowYear2 / (Math.Pow((1 + discountRate), 2)) +
                        FreeCashFlowYear3 / (Math.Pow((1 + discountRate), 3)) +
                        FreeCashFlowYear4 / (Math.Pow((1 + discountRate), 4)) +
                        FreeCashFlowYear5 / (Math.Pow((1 + discountRate), 5)), 2);

            StockPrice = Math.Round((FreeCashFlow / OutstandingShares),2);
            FreeCashFlow = Math.Round((FreeCashFlow / 1000000), 2);


            MessageBox.Show($" {Name} \n Estimation on Valuation (NPV analysis)  ${FreeCashFlow} million \n Stock Price ${StockPrice} for \n A new product development schedule of {NPDSchedule} days","NPV Analysis");

        }

        private void FinancialAnalysis_Click(object sender, RoutedEventArgs e)
        {
            FinancialAnalysis FinancialAnalysisObject = new FinancialAnalysis();
            FinancialAnalysisObject.Show();
        }
    }
}
