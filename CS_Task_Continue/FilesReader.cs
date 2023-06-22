using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Task_Continue
{
    internal class FilesReader
    {
        public string ReadHuntFile()
        {
            string huntDetails = string.Empty;
            try
            {
               

                if (huntDetails == string.Empty)
                    throw new Exception("dddddd");

                /*Implicit Displose Call in C# with the help of 'using' block
                  instead of calling Dispose() explicitly make use of using block

                THis is possible only for those classes which are implementing IDisposable interface 

                 */
                using (StreamReader reader = new StreamReader(@"C:\Nice\Hunt.txt"))
                {
                    huntDetails = reader.ReadToEnd();
                }
                /*reader is disposed */

            }
            catch (Exception ex)
            {

                Console.WriteLine($" File Read Filed {ex.Message}");
            }

            return huntDetails;
        }

        public string ReadBondFile()
        {
            string bondDetails = string.Empty;

            /*Implicit Displose Call in C# with the help of 'using' block
              instead of calling Dispose() explicitly make use of using block

            THis is possible only for those classes which are implementing IDisposable interface 

             */
            using (StreamReader reader = new StreamReader(@"C:\Nice\Bond.txt"))
            {
                bondDetails = reader.ReadToEnd();
            }
            /*reader is disposed */


            return bondDetails;
        }
    }
}
