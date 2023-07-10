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


namespace spitfire_
{
    /// <summary>
    /// Interaction logic for pageHome.xaml
    /// </summary>
    public partial class pageHome : Page
    {
        pageGameSettings gameSettings = new pageGameSettings();
        public pageHome()
        {
            InitializeComponent();
        }

        //change to red upon hover
        private void txtHome_MouseEnter(object sender, MouseEventArgs e)
        {
            //txtHome.Foreground = Brushes.Red;
            txtHome.Foreground = Brushes.Red;
        }
        //change to white upon hover
        private void txtHome_MouseLeave(object sender, MouseEventArgs e)
        {
            txtHome.Foreground = Brushes.AntiqueWhite;
        }

        private void txtMods_MouseEnter(object sender, MouseEventArgs e)
        {
            txtMods.Foreground = Brushes.Red;
        }

        private void txtMods_MouseLeave(object sender, MouseEventArgs e)
        {
            txtMods.Foreground = Brushes.AntiqueWhite;
        }

        private void txtSettings_MouseEnter(object sender, MouseEventArgs e)
        {
            txtSettings.Foreground = Brushes.Red;
        }

        private void txtSettings_MouseLeave(object sender, MouseEventArgs e)
        {
            txtSettings.Foreground = Brushes.AntiqueWhite;
        }

        private void txtServers_MouseEnter(object sender, MouseEventArgs e)
        {
            txtServers.Foreground = Brushes.Red;
        }

        private void txtServers_MouseLeave(object sender, MouseEventArgs e)
        {
            txtServers.Foreground = Brushes.AntiqueWhite;
        }

        private void txtHome_MouseDown(object sender, MouseButtonEventArgs e)
        {
            framePageView.Content = null;
        }

        private void txtMods_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void txtSettings_MouseDown(object sender, MouseButtonEventArgs e)
        {
            framePageView.Content = gameSettings.pageGaneSettingsView;
        }

        private void txtServers_MouseDown(object sender, MouseButtonEventArgs e)
        {
            framePageView.Content = null;
        }
    }
}
