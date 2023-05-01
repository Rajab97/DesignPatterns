using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class TextEditorWithGrammerCheckDecorator : TextEditorDecorator
    {
        public TextEditorWithGrammerCheckDecorator(ITextEditor textEditor):base(textEditor) { }

        public override void WriteText(string text)
        {
            GrammerCheck(text);
            TextEditor.WriteText(text);
        }

        private void GrammerCheck(string text)
        {
            Console.WriteLine("Start to check grammer rules");
            Thread.Sleep(1000);
        }
    }
}
