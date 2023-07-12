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


            //let's populate the table with some information
            spitfireLookUpTable[0] = "Test_00";
            spitfireLookUpTable[1] = "Test_01";
            spitfireLookUpTable[2] = "Test_02";
            spitfireLookUpTable[3] = "Test_03";
            spitfireLookUpTable[4] = "Test_04";



        }
    }
}
