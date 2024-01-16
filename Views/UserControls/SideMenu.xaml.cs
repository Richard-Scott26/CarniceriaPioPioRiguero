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

namespace DemoBasic.Views.UserControls
{
    /// <summary>
    /// Lógica de interacción para SideMenu.xaml
    /// </summary>
    public partial class SideMenu : UserControl
    {
        public SideMenu()
        {
            InitializeComponent();
        }

        private void Navigate(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender is Button clickedButton)
                {
                    switch (clickedButton.Name)
                    {
                        case "btnSalesView":
                            SalesView vv = new SalesView();
                            vv.Show();
                            var window = Window.GetWindow(this);
                            window.Hide();
                            break;
                        default:
                            OptionsContainer oc = new OptionsContainer(clickedButton.Name);
                            oc.Show();
                            var window1 = Window.GetWindow(this);
                            window1.Hide();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                throw;
            }
        }
    }
}
