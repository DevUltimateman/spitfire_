using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Collections;

namespace spitfire_
{
    internal class directoryImages
    {

        public void makeImagesDirectory()
        {
            DirectoryInfo imagesDir = new DirectoryInfo("~/images/logos/");
            FileInfo[] imageNames = imagesDir.GetFiles();

            ArrayList imageArray = new ArrayList();

            foreach ( FileInfo img in imageNames)
            {
                imageArray.Add(img.FullName);   
            }
        }

        public object mylogo()
        {
            var bo1logo = Properties.Resources.ResourceManager.GetObject("bo1mplogo.png");
            return bo1logo;
        }
    }

    
}
