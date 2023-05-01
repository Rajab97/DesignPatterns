using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class TextEditorDecorator : ITextEditor
    {
        public TextEditorDecorator(ITextEditor textEditor)
        {
            TextEditor = textEditor;
        }

        protected ITextEditor TextEditor { get; }

        public abstract void WriteText(string text);
    }
}
