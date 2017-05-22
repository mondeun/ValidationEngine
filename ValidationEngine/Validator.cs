using System.Text.RegularExpressions;

namespace ValidationEngine
{
    public class Validator
    {
        public bool ValidateEmailAddress(string email)
        {
            var regex = new Regex(@"[a-z]+\@[a-z]*\.[a-z]*", RegexOptions.Singleline);
            if (string.IsNullOrEmpty(email) || !regex.IsMatch(email))
                throw new MyDumbEmailException("Email is not valid");

            return true;
        }
    }
}