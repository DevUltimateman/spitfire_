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
        gameFolderList gmf = new gameFolderList();
        public pageGameSettings()
        {
           
            InitializeComponent();
            lstMylist.ItemsSource = gmf.returnGames();
        }
    }
}
