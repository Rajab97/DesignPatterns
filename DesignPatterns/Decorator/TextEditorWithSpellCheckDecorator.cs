using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class TextEditorWithSpellCheckDecorator : TextEditorDecorator
    {
        public TextEditorWithSpellCheckDecorator(ITextEditor textEditor) : base(textEditor) { }
        public override void WriteText(string text)
        {
            SpellCheck(text);
            TextEditor.WriteText(text);
        }

        private void SpellCheck(string text)
        {
            Console.WriteLine("Start to check spelling");
            Thread.Sleep(1000);

        }
    }
}
