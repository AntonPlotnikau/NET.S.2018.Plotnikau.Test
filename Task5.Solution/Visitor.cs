using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    public abstract class Visitor
    {
        public void Visit(DocumentPart document) => Visit((dynamic)document);
        protected abstract void Visit(BoldText bold);
        protected abstract void Visit(Hyperlink hyperlink);
        protected abstract void Visit(PlainText plain);
    }
}
