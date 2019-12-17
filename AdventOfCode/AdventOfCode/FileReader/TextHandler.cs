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
            return lines.Select(s => int.Parse(s)).ToList();
        }
        public void WriteToFileFromIntList(List<int> list,string Text)
        {
            List<string> Transform = list.Select(s => s.ToString()).ToList();
            System.IO.File.WriteAllLines(Text, Transform);
        }
    }
}
