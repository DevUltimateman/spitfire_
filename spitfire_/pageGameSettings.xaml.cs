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
        
        openFileGlobalClass test = new openFileGlobalClass();
        gameFolderList gameFolders = new gameFolderList();
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


            for( int s = 0; s < gdBig.RowDefinitions.Count; s++ )
            {
                if( s % 2 != 0 )
                {
                    //Rectangle rec = new Rectangle();
                    solidColorBlue.Color = Color.FromArgb(0, 0, 255, 0);
                    
                    //rec.Fill = solidColorBlue;
                    
                    rectTester.Fill = solidColorBlue;
                }
                else
                {
                    solidColorBlue.Color = Color.FromArgb(255, 100, 0, 0);
                    rectTester.Fill = solidColorBlue;
                }
            }

            
        }
    }
}
