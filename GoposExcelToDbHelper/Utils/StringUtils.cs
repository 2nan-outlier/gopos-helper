using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoposExcelToDbHelper.Utils
{
    public static class StringUtils
    {
        public static string ToSnakeCase(this string value)
        {
            string[] words = value.ToLower().Split('_');

            StringBuilder camelCaseBuilder = new StringBuilder();
            camelCaseBuilder.Append(words[0]);

            for (int i = 1; i < words.Length; i++)
            {
                string word = words[i];
                string capitalizedWord = char.ToUpper(word[0]) + word.Substring(1);
                camelCaseBuilder.Append(capitalizedWord);
            }

            return camelCaseBuilder.ToString();
        }
    }
}
