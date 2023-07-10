using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace spitfire_
{
    
    internal class openFileGlobalClass
    {
        //handles the pop up window folder
        OpenFileDialog folderSelector = new OpenFileDialog();
        //lets sniff some logic
        gameFolderList helpMeAutomate = new gameFolderList();

        //this is a debug value
        public int debugCounting = 0;

        public void findAllGameFoldersAutomatically(string[] files)
        {
            //let's find users appdata
            string my_appdata = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);


            helpMeAutomate.makeGameList( false );

        }
    }
}

