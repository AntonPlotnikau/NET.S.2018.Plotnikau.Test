using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    public class LatexVisitor : Visitor
    {
        public string Result { get; private set; }

        protected override void Visit(BoldText bold)
        {
            Result = "\\textbf{" + bold.Text + "}";
        }

        protected override void Visit(Hyperlink hyperlink)
        {
            Result = hyperlink.Text + "\\href{" + hyperlink.Url + "}{" + hyperlink.Text + "}";
        }

        protected override void Visit(PlainText plain)
        {
            Result = plain.Text;
        }
    }
}
