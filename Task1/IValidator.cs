using System;

namespace Task1
{
    public interface IValidator
    {
        Tuple<bool, string> IsValid(string password);
    }
}
