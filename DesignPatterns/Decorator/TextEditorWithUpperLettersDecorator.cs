using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class TextEditorWithUpperLettersDecorator : TextEditorDecorator
    {
        public TextEditorWithUpperLettersDecorator(ITextEditor textEditor) : base(textEditor) { }
        public override void WriteText(string text)
        {
            var upperString = ToUpperLetters(text);
            TextEditor.WriteText(upperString);
        }

        private string ToUpperLetters(string text)
        {
            Console.WriteLine("Start to convert upper letters");
            Thread.Sleep(1000);
            return  text.ToUpper();
        }
    }
}
