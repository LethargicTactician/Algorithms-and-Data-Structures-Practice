using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class PhoneDir
    {
        public static string Phone(string strng, string num)
        {
            string[] records = strng.Split('\n');
            string result = "";
            int count = 0;
            foreach (string record in records)
            {
                if (record.IndexOf(num) >= 0)
                {
                    string name = Regex.Match(record, "<(.+)>").Groups[1].Value;

                    //first off I hate this, second, this is where I replace any UNWANTED variables in the address
                    string address = Regex.Replace(record, "<.+>", "").Replace(num, "")
                      .Replace("_", " ")
                      .Replace(".", "")
                      .Replace("+", "")
                      .Replace(";", "")
                      .Replace("  ", " ")
                      .Replace("St ", "St.")
                      .Replace("/ ", "")
                      .Replace("$ ", "")
                      .Replace("Av ", "Av. ")
                      .Replace("!! ", "")
                      .Replace("* ", "")
                      .Replace(": ", "")
                      .Replace(" ?", "")
                      .Replace("Pk ", "Pk. ")
                      .Replace(", , ", " ")
                      .Replace("   ", " ")
                      .Replace(" !", "")
                      .Replace(", ", " ")
                      .Replace(",", "")
                      .Replace("Rd ", "Rd. ")
                      .Replace("Alphandria Street", "Alphandria Street.")
                      .Replace(" Av", " Av.")
                      .Replace(" Bd", " Bd.")
                      .Replace(" /", " ")
                      .Replace(".. ", ". ")
                      .Trim();
                    if (address.Length > 0)
                    {
                        result += $"Phone => {num}, Name => {name}, Address => {address}";
                    }
                    else
                    {
                        result += $"Error => No address found for phone number: {num}";
                    }
                    count++;
                }
            }
            if (count == 0)
            {
                result = $"Error => Not found: {num}";
            }
            else if (count > 1)
            {
                result = $"Error => Too many people: {num}";
            }
            return result;
        }

        public static string Phone2(string strng, string num)
        {
            string[] lines = strng.Split('\n');
            string[] findLines = Array.FindAll(lines, (line) => line.Contains(num));

            if (findLines.Length == 0)
            {
                return $"Error => Not found: {num}";
            }
            else if (findLines.Length > 1)
            {
                string names = string.Join(", ", findLines.Select(line => Regex.Match(line, "<(.+)>").Groups[1].Value));
                return $"Error => Too many people: {num} ({names})";
               // return $"Phone => {num}, Name => {names}, Address => ...";
            }
            else
            {
                string line = findLines[0];
                System.Text.RegularExpressions.Regex userRegex = new System.Text.RegularExpressions.Regex("<([a-zA-Z0-9_\\s'-]+)>");

                var matchArr = userRegex.Matches(line);
                string wordWithBrackets = matchArr[0].Value;

                //same thing with the othr part, replaceing things that Idont want in my address
                line = line.Replace(wordWithBrackets, "").Replace(num, "").Replace("_", " ").Replace(".", "").Replace("+", "").Replace("Street", "Street.").Replace("Av ", "Av. ").Replace(" Bd", " Bd.").Replace(" /", " ").Trim();

                string userName = wordWithBrackets[1..^1];

                return $"Phone => {num}, Name => {userName}, Address => {System.Text.RegularExpressions.Regex.Replace(line, @"[^a-zA-Z\d\s-.]", " ").Replace("\\s+", " ").Trim()}";
            }
        }



        //put everything together

    }
}
