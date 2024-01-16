using DemoBasic.Models;
using DemoBasic.Views.SelectionUserControls;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
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

namespace DemoBasic.Views
{
    /// <summary>
    /// Lógica de interacción para SalesView.xaml
    /// </summary>
    public partial class SalesView : Window
    {
        public SalesView()
        {
            InitializeComponent();
        }

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

        private void NavigateTo(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender is Button buttonClicked)
                {
                    var nav = buttonClicked.Name;

                    if (!string.IsNullOrEmpty(nav))
                    {
                        if (nav == "Sales")
                        {
                            MessageBox.Show("Estas en ventas", "Advertisement", MessageBoxButton.OK);
                        }
                        else
                        {
                            SalesViewOptions option = new SalesViewOptions(buttonClicked.Name);
                            option.Owner = this;
                            option.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SaleOff(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    MainWindow main = new MainWindow();
                    this.Hide();
                    main.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
