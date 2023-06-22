using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TaskBasics
{
    internal class FilesReaderAsync
    {
        public async Task<string> ReadHuntFileAsync()
        {
            string huntDetails = string.Empty;
            try
            {
               

            
                /*Implicit Displose Call in C# with the help of 'using' block
                  instead of calling Dispose() explicitly make use of using block

                THis is possible only for those classes which are implementing IDisposable interface 

                 */
                using (StreamReader reader = new StreamReader(@"C:\Nice\Hunt.txt"))
                {
                    huntDetails = await reader.ReadToEndAsync();
                }
                /*reader is disposed */

            }
            catch (Exception ex)
            {

                Console.WriteLine($" File Read Filed {ex.Message}");
            }

            return huntDetails;
        }

        public async Task<string> ReadBondFileAsync()
        {
            string bondDetails = string.Empty;

            /*Implicit Displose Call in C# with the help of 'using' block
              instead of calling Dispose() explicitly make use of using block

            THis is possible only for those classes which are implementing IDisposable interface 

             */
            using (StreamReader reader = new StreamReader(@"C:\Nice\Bond.txt"))
            {
                bondDetails = await reader.ReadToEndAsync();
            }
            /*reader is disposed */


            return bondDetails;
        }
    }
}
