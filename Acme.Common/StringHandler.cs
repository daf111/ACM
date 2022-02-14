using System;

namespace Acme.Common
{
    /// <summary>
    /// Inserts spaces before each capital letter in a string
    /// </summary>
    /// <param name="source"></param>
    /// <returns></returns>
    public class StringHandler
    {
        public string InsertSpaces(string source)
        {
            string result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        // Trim any spaces already there
                        //result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            //result = result.Trim();
            return result;
        }
    }
}
