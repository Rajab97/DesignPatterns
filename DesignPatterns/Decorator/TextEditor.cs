using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class TextEditor : ITextEditor
    {
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
    }
}
