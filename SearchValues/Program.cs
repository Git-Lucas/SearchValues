using SearchValuesNamespace;

string stringToBeAnalyzed = "example@email.com";
Console.WriteLine(EmailValidator.IsValidEmail(stringToBeAnalyzed));

stringToBeAnalyzed = "!nvalid#@ email.com";
Console.WriteLine(EmailValidator.IsValidEmail(stringToBeAnalyzed));