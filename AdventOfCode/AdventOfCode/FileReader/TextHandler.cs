using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.FileReader
{
    class TextHandler
    {
        public List<int> ReadInputFileToListInt(string Text)
        {
            string[] lines = System.IO.File.ReadAllLines(Text);
            lines = LinesFix(lines);
            return lines.Select(s => int.Parse(s)).ToList();
        }

        private string[] LinesFix(string[] lines)
        {
            
            bool Fix = false;
            foreach (string line in lines)
            {
                if(line.Contains(','))
                {
                    Fix = true;
                }
            }
            if (Fix == false)
                return lines;

            List<string> StringList = new List<string>();
            foreach (string line in lines)
            {
                string value = "";
                for(int i = 0;i< line.Count();i++)
                {
                    if (line[i] != ',')
                        value += line[i].ToString();
                    else
                    { 
                        StringList.Add(value.ToString());
                        value = "";
                    }
                }
            }
            string[] fixedLine = StringList.ToArray();

                return fixedLine;
        }

        public void WriteToFileFromIntList(List<int> list,string Text)
        {
            List<string> Transform = list.Select(s => s.ToString()).ToList();
            System.IO.File.WriteAllLines(Text, Transform);
        }
    }
}
