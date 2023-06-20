using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SimpleClass
{
    internal class StringOperations
    {
        public int GetStatementCount(string code)
        {
             
            string[] statements = code.Split('.');

           
            for (int i = 0; i < statements.Length; i++)
            {
                statements[i] = statements[i].Trim();
            }

            int statementCount = 0;
            foreach (string statement in statements) 
            {
                if (!IsSalutation(statement))
                {
                    statementCount++;
                }
            }
             
          

            return statementCount;
        }


        public int GetWordCount(string text)
        {
            // Split the string into an array of words based on whitespace characters
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Return the number of words
            return words.Length;
        }

        private bool IsSalutation(string statement)
        {
            string[] s = { "Dr",  "Mr", "Mrs", "Mast", "Miss" };
            string firstWord = statement.Split(' ').FirstOrDefault();
            return s.Contains(firstWord);
        }
    }
}
