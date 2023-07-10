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
    
    public partial class MainWindow : Window
    {
        //global instances
        gameFolderList gameFoldersToList = new gameFolderList();
        public MainWindow()
        {
            InitializeComponent();

            //framePage.Content = new pageGameSettings().pageGaneSettingsView;
            frameWindow.Content = new pageHome().pageHomeView;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //lets call a method
            gameFoldersToList.makeGameList();
        }
    }
}
