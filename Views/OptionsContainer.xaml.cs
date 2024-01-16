using DemoBasic.Views.SelectionUserControls;
using System;
using System.Windows;
using System.Windows.Input;

namespace DemoBasic.Views
{
    public partial class OptionsContainer : Window
    {
        public string controlName;

        public OptionsContainer(String ControlName)
        {
            InitializeComponent();
            this.controlName = ControlName;
            SelectWindow();
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

        public void SelectWindow()
        {
            try
            {
                if (!string.IsNullOrEmpty(controlName))
                {
                    switch (controlName)
                    {
                        case ("btnProducts"):
                            var win = new Products();
                            mainFrame.Navigate(win);
                            break;
                        case ("btnSuppliers"):
                            var win1 = new Suppliers();
                            mainFrame.Navigate(win1);
                            break;
                        case ("btnSalesStats"):
                            var win2 = new SalesStatistics();
                            mainFrame.Navigate(win2);
                            break;
                        case ("btnHistory"):
                            var win3 = new SalesHistory();
                            mainFrame.Navigate(win3);
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
