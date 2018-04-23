using System;
using System.Linq;

namespace Task1
{
    public class PasswordCheckerService
    {
        private IRepository repository;
        private IValidator validator;

        public PasswordCheckerService(IRepository repository, IValidator validator)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        public Tuple<bool, string> VerifyPassword(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            Tuple<bool, string> validateResult = validator.IsValid(password);

            if (validateResult.Item1)
            {
                repository.Create(password);
            }

            return validateResult;
        }
    }
}
