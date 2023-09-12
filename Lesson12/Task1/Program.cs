using Task1;

string login = "login";
string password = "pass1";
string confirmPassword = "pass1";

bool isValid = AccountValidator.ValidateAccount(login, password, confirmPassword);
if (isValid)
{
    Console.WriteLine("Account is valid");
}
else
{
    Console.WriteLine("Incorrect account");
}