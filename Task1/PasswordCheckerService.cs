using System;
using System.Linq;

namespace Task1
{
    public class PasswordCheckerService
    {
        private IRepository repository;
        private IValidator[]  validator;

        public PasswordCheckerService(IRepository repository, params IValidator[] validator)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        public Tuple<bool, string> VerifyPassword(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            foreach(var item in validator)
            {
                if(!item.IsValid(password).Item1)
                {
                    return item.IsValid(password);
                }
            }

            repository.Create(password);
            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
