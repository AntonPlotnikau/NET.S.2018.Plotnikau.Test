using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    public static class DocumentPartsExtensions
    {
        public static string ToHtml(this DocumentPart part)
        {
            var visitor = new HtmlVisitor();
            visitor.Visit(part);
            return visitor.Result;
        }

        public static string ToPlainText(this DocumentPart part)
        {
            var visitor = new PlainTextVisitor();
            visitor.Visit(part);
            return visitor.Result;
        }

        public static string ToLaTeX(this DocumentPart part)
        {
            var visitor = new LatexVisitor();
            visitor.Visit(part);
            return visitor.Result;
        }
    }
}
