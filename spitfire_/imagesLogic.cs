using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spitfire_
{
    internal class imagesLogic
    {
        gameFolderList gamefolders = new gameFolderList();
        public void weImages()
        {
            string[] games = gamefolders.returnGames();

            int s;

            for( s = 0; s < games.Length; s++ )
            {

            }

        }
    }
}
