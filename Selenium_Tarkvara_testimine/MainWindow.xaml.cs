using Selenium_Tarkvara_testimine.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
using System.Management;

namespace Selenium_Tarkvara_testimine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Browser browser;
        public MainWindow()
        {
            InitializeComponent();
            browser = new Browser();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            browser.Load(txt_url.Text);
            txt_tree.Text = txt_url.Text;
        }

        void Window_Closing(object sender, CancelEventArgs e)
        {
            Process currentProcess = Process.GetCurrentProcess();
            ProcessUtilities.KillProcessAndChildren(currentProcess.Id);
            //e.Cancel = true;
        }
    }
}
