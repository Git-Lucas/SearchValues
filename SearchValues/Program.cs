using System.Buffers;

string stringToBeAnalyzed = "example@email.com";
Console.WriteLine(IsValidEmail(stringToBeAnalyzed));

stringToBeAnalyzed = "!nvalid#@ email.com";
Console.WriteLine(IsValidEmail(stringToBeAnalyzed));

static bool IsValidEmail(string stringToBeAnalyzed)
{
    string allowedCharsEmailString = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@._-";
    SearchValues<char> allowedCharsEmailSearchValues = SearchValues.Create(allowedCharsEmailString);

    return stringToBeAnalyzed
        .AsSpan()
        .IndexOfAnyExcept(allowedCharsEmailSearchValues) == -1;
}