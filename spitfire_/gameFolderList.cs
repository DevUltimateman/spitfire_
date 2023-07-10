using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;

namespace spitfire_
{
    public class gameFolderList
    {
        //let's grab user's appdata location to a variable
        public string myAppdataf = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        private string spit = "Spitfire_ ***debug";

        //folder extensions
        private string scriptsFolderPath_multi = "\\scripts\\mp";
        private string scriptsFolderPath_zombie = "\\scripts\\zm";
        private string imagesFolderPath = "\\images";



        //create a list box where we can store a list of all the available games
        public ListBox gameListBox = new ListBox();

        //this is a gamelist of all plutonium's games. method returns a list of games to a string
        public string[] returnGames() 
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

        //Let's populate the list box with our gamelist
        public void makeGameList( bool showMessage )
        {
            //let's get the gamelist and assign its values to listbox
            string[] temporary = returnGames();
            gameListBox.ItemsSource = temporary;


            //debug stuff
            //lets see if we have populated the list and print em out with msg box
            for ( int i = 0; i < gameListBox.Items.Count;i++)
            {
                if( showMessage )
                {
                    MessageBox.Show(gameListBox.Items[i].ToString(), spit);
                }
                

            }
            //don't include in final branch
            MessageBox.Show( "List done thru. Total number of games: " + gameListBox.Items.Count.ToString(), spit );
            if( showMessage )
            {
                MessageBox.Show("YOUR APPDATA = " + myAppdataf, spit);
            }
            
            
            
            //pass in the return values to temp
            string[] temp = returnAllModFolders();
            
            if( showMessage )
            {
                for (int v = 0; v < gameListBox.Items.Count; v++)
                {
                    MessageBox.Show(temp[v].ToString(), spit);
                }
            }
            //Debug 
            MessageBox.Show("List of all the game locations: " + temp.Count(), spit );
             
            
        }

        public string[] returnAllModFolders()
        {
            //ok big brain time..

            
            string pluto = "\\Plutonium\\storage\\";

            string bo1mp = myAppdataf + pluto + "t5";
            string bo1zm = myAppdataf + pluto + "t5";

            string bo2mp = myAppdataf + pluto + "t6";
            string bo2zm = myAppdataf + pluto + "t6";

            string wawmp = myAppdataf + pluto + "t4";
            string wawzm = myAppdataf + pluto + "t4";

            string mw = myAppdataf + pluto + "iw5";

            string[] mygamelocations = { bo1mp, bo1zm,
                                        bo2mp, bo2zm,
                                            wawmp, wawzm, mw };

           

            //lets return all
            return mygamelocations;
            
        }

        void setAllGameLocationsAutomatically()
        {
            

        }
    }
}
