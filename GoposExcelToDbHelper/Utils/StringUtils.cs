using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoposExcelToDbHelper.Utils
{
    public static class StringUtils
    {
        // HI_IM_SAMPLE => hiImSample
        public static string ToCamelCase(this string value)
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

        // HI_IM_SAMPLE => HiImSample
        public static string ToCamelCase(this string value, string prefix)
        {
            value = $"{prefix}_{value}";
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

        public static string StartLowerCase(this string value)
        {
            return value.Substring(0, 1).ToLower() + value.Substring(1);
        }
    }
}
