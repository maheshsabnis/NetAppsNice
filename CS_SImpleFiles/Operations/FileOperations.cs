using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace CS_SImpleFiles.Operations
{
    internal class FileOperations
    {
        public void CreateFile(string fileName)
        {
			try
			{
                if (fileName == string.Empty)
                    throw new Exception("File Name cannot be empty");
                FileStream Fs = File.Create(fileName);
                Console.WriteLine($"File {fileName} is created successfully");
                // Close and Dispose
                Fs.Close();
                Fs.Dispose();
            }
			catch (Exception ex)
			{
                throw ex;
			}
        }

        public void WritFile(string fileName, string contents)
        {
            try
            {
                if (fileName == string.Empty)
                    throw new Exception("File Name cannot be empty");
                File.WriteAllText(fileName, contents);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void WritFile(string fileName, string [] contents)
        {
            try
            {
                if (fileName == string.Empty)
                    throw new Exception("File Name cannot be empty");
                File.WriteAllLines(fileName, contents);
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void AppendFile(string fileName, string contents)
        {
            try
            {
                if (fileName == string.Empty)
                    throw new Exception("File Name cannot be empty");
                File.AppendAllText(fileName, contents);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public string ReadFile(string fileName)
        {
            try
            {
                if (fileName == string.Empty)
                    throw new Exception("File Name cannot be empty");
                string contents =  File.ReadAllText(fileName);

                return contents;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
