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

using System.IO;
using System.Collections;

namespace spitfire_
{
    
    public partial class MainWindow : Window
    {
        //global instances
        gameFolderList gameFoldersToList = new gameFolderList();
        pageGameSettings gamesettingspage = new pageGameSettings();
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

            directoryImages imagesBackdrop = new directoryImages();
            imagesBackdrop.populateImageList();
            //imagesBackdrop.mylogo();
           // MessageBox.Show(imagesBackdrop.mylogo().ToString());

           // MessageBox.Show(imagesBackdrop.ToString());
            //lets call a method
            //pass false to not show debug messages
            gameFoldersToList.makeGameList( false );
            
            gameFoldersToList.setAllGameLocationsAutomatically(gameFoldersToList.returnGames());
            framePageView.Content = new pageGameSettings().pageGameSettingsView;
            
        }
    }
}
