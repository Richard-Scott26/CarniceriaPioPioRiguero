using DemoBasic.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
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

namespace DemoBasic
{
    public partial class MainWindow : Window
    {
        #region Variables

        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        // Apartado para configurar la opcion de drag del form
        #region DragMode
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                this.WindowState = WindowState.Normal;
            }
        }
        #endregion

        private void Navigate(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender is Button clickedButton)
                {
                    if (clickedButton.Name != "btnAbrirCaja")
                    {
                        OptionsContainer vv = new OptionsContainer(clickedButton.Name);
                        vv.Show();
                        this.Hide();
                    }
                    else
                    {
                        SalesView sales = new SalesView();
                        sales.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se jodio esta vaina: {ex.Message}");
                throw;
            }
        }
    }
}
