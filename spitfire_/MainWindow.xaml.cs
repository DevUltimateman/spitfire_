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

            //set the main locked app view upon launching the app
            frameMainLocked.Content = new pageHome().pageHomeView;

            //must add a view later, but we don't have any view yet for boot up
            framePageView.Content = null;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            //lets call a method
            //pass false to not show debug messages
            gameFoldersToList.makeGameList( false );
            gameFoldersToList.imageList();
            gameFoldersToList.setAllGameLocationsAutomatically(gameFoldersToList.returnGames());
            framePageView.Content = new pageGameSettings().pageGaneSettingsView;
            
        }
    }
}
