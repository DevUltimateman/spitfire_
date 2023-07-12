using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Collections;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;

namespace spitfire_
{
    internal class directoryImages
    {
        //add a public lstImages that can be accessed thru modifier
        public List<string> imglist = new List<string>();


        public void populateImageList()
        {
            //generate a debug listview
            
            /*
            lstImages.Height = 200;
            lstImages.RenderSize = new System.Windows.Size(200, 200);
            */
            //load images from file
            string[] paths = { };
            
            paths = Directory.GetFiles( Directory.GetCurrentDirectory() + "\\images\\logos\\" );

            try
            {
                foreach ( string path in paths )
                {
                    imglist.Add(path.ToString());
                    MessageBox.Show(path.ToString() + "\n\n" +
                                imglist.Count.ToString() + " / 4 ");
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        













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

        /*

        public void populateImageList()
        {
            //let's assign the imagesfolder
            string str_imagef = @".\Images\logos";
            //string ahah = "";
            for( int i = 0; i < 4; i++)
            {
                var populate = Directory.GetFiles(str_imagef,
                    "*.png", SearchOption.AllDirectories).Select(Image.FromFile).ToList();
            }
            


            MessageBox.Show(imageL.ToString());
        }
        */
    }

    
}
