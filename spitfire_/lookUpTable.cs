using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spitfire_
{
    internal class lookUpTable
    {

        public void populateLookUpTable()
        {
            //Dictionary int is for look up key & Dictionary string is for stored data.
            var spitfireLookUpTable = new Dictionary<int, string>();

            spitfireLookUpTable.Add(0, "Test_00");
            spitfireLookUpTable.Add(1, "Test_01");
            spitfireLookUpTable.Add(2, "Test_02");
            spitfireLookUpTable.Add(3, "Test_03");
            spitfireLookUpTable.Add(4, "Test_04");

            //Console.WriteLine(spitfireLookUpTable.ToString());

           

        }
        
        public string lol(string passing)
        {
            
            return passing;
        }
        public string returnLookUpTableKey( int tableKey)
        {
            string l_name = "";

          

            return l_name;
        }
    }
}
