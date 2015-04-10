using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SBCalc
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            if ((txtCPUID.Text != null) && (txtCPUID.Text.Length >= 15) && (txtCPUID.Text.Length <= 16))
            {
                string SBKCodeResult = "";
                int l_sbkResult = SBKLibrary.GetEncoder(this.txtCPUID.Text, ref SBKCodeResult);
                if (SBKCodeResult != null && SBKCodeResult != "")
                {
                    char[] rmChar = { '\\', '0' };
                    this.txtSBK.Text = SBKCodeResult.Remove((SBKCodeResult.Length - 1), 1);
                }
            }
            else
                MessageBox.Show("Please, check your CPUID.", "CPUID Error");
        }
    }
}
