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
    /// Lógica de interacción para Toolbar.xaml
    /// </summary>
    public partial class Toolbar : UserControl
    {
        public Toolbar()
        {
            InitializeComponent();

        }

        #region Configuracion de metodos de dimensiones de pantalla
        private void Minimize(object sender, RoutedEventArgs e)
        {
            try
            {
                var window = Window.GetWindow(this);
                window.WindowState = WindowState.Minimized;
            }
            catch
            {
                MessageBox.Show("No estas usando el toolbar en una ventana");
            }
        }
        private void Close(object sender, RoutedEventArgs e)
        {
            try
            {
                var window = Window.GetWindow(this);
                window.Close();
                Application.Current.Shutdown();
            }
            catch
            {
                MessageBox.Show("No estas usando el toolbar en una ventana");
            }
        }

        #endregion


    }
}
