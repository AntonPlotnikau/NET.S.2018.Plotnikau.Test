using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    public class HtmlVisitor : Visitor
    {
        public string Result { get; private set; }

        protected override void Visit(BoldText bold)
        {
            Result = "<b>" + bold.Text + "</b>";
        }

        protected override void Visit(Hyperlink hyperlink)
        {
            Result = "<a href=\"" + hyperlink.Url + "\">" + hyperlink.Text + "</a>";
        }

        protected override void Visit(PlainText plain)
        {
            Result = plain.Text;
        }
    }
}
