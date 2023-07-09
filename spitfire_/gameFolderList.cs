using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace spitfire_
{
    internal class gameFolderList
    {
        ListBox gameListBox = new ListBox();

        string[] gameNames;


        string[] returnGames()
        {
            string[] gameNames = {
                                "Black Ops Multiplayer",
                                "Black Ops Zombies",
                                "Black Ops II Multiplayer",
                                "Black Ops II Zombies",
                                "World At War Multiplayer",
                                "World At War Zombies",
                                "Modern Warfare III"
                        };

            return gameNames;
        }
        public void makeGameList()
        {
            /*
            string [] gameNames= {
                                "Black Ops Multiplayer",
                                "Black Ops Zombies",
                                "Black Ops II Multiplayer",
                                "Black Ops II Zombies",
                                "World At War Multiplayer",
                                "World At War Zombies",
                                "Modern Warfare III"
                        };

            */

            //let's get the gamelist and assign its values to listbox
            string[] temporary = returnGames();
            gameListBox.ItemsSource = temporary;


            //debug stuff
            //lets see if we have populated the list and print em out with msg box
            for ( int i = 0; i < gameListBox.Items.Count;i++)
            {
                
                MessageBox.Show(gameListBox.Items[i].ToString());

            }
            MessageBox.Show("List done thru. Total amount of games: " + gameListBox.Items.Count.ToString());

            

        }
    }
}
