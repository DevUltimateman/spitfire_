using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for pageGameSettings.xaml
    /// </summary>
    public partial class pageGameSettings : Page
    {
        directoryImages temp = new directoryImages();
        openFileGlobalClass test = new openFileGlobalClass();
        gameFolderList gameFolders = new gameFolderList();
        pageHome homepage = new pageHome();

        //imageclass call
        directoryImages myimages = new directoryImages();
        public pageGameSettings()
        {

            InitializeComponent();
            

            lstMylist.ItemsSource = gameFolders.returnGames();
        }


        public void colorizeUneven()
        {
            //new instance of solidBrush
            SolidColorBrush solidColorBlue = new SolidColorBrush();
            /*
            Ellipse ellipse = new Ellipse();
            ellipse.Fill = solidColorBlue;            
            */

            /*
            for (int s = 0; s < gdBig.RowDefinitions.Count; s++)
            {
                if (s % 2 != 0)
                {
                    //Rectangle rec = new Rectangle();
                    solidColorBlue.Color = Color.FromArgb(0, 0, 255, 0);
                    
                    //rec.Fill = solidColorBlue;


                else
                    {
                        Console.WriteLine("This is a test ");
                        //solidColorBlue.Color = Color.FromArgb(255, 100, 0, 0);
                        //rectTester.Fill = solidColorBlue;
                    }
                }


            }
            */
            
        }
        private void lblSelectFromList_MouseEnter(object sender, MouseEventArgs e)
        {
            lblSelectFromList.FontSize = 12.5;
            lblSelectFromList.Foreground = Brushes.AntiqueWhite;
            lblSelectFromList.FontWeight = FontWeights.Light;
            lblSelectFromList.Text = "Choose the game you want to edit from the list";
        }

        private void lblSelectFromList_MouseLeave(object sender, MouseEventArgs e)
        {
            lblSelectFromList.Text = "Select Game";
            lblSelectFromList.Foreground = Brushes.AntiqueWhite;
            lblSelectFromList.FontWeight = FontWeights.Bold;
            lblSelectFromList.FontSize = 20;
        }

        private void lstMylist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //update later
        }

        private void testing()
        {
            homepage.framePageView.Content = pageGameSettingsView;
            
        }
    } 
}
