using mshtml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace NewEva.Ui.ObjectOfEvaluation.Flat
{
    /// <summary>
    /// Логика взаимодействия для FlatLocationUC.xaml
    /// </summary>
    public partial class FlatLocationUC : UserControl
    {
        public FlatLocationUC()
        {
            InitializeComponent();
            try
            {
                string directory = AppDomain.CurrentDomain.BaseDirectory;
                MyWebBrowser.Source = new Uri("file:///" + directory + "index.html");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                MyWebBrowser.Source = new Uri("https://football.ua/");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MyBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MyWebBrowser.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MyForward_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MyWebBrowser.GoForward();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //private void MyGo_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        MyWebBrowser.Source = new Uri("http://" + MyTextBox.Text);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        private void MyWebBrowser_LoadCompleted(object sender, NavigationEventArgs e)
        {
            MessageBox.Show("Completed.");
        }
    }
}
