using System.Buffers;

namespace SearchValuesNamespace;
internal static class EmailValidator
{
    private static readonly string _allowedCharsEmailString = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@._-";
    private static readonly SearchValues<char> _allowedCharsEmailSearchValues = SearchValues.Create(_allowedCharsEmailString);

    internal static bool IsValidEmail(string stringToBeAnalyzed)
    {
        return stringToBeAnalyzed
            .AsSpan()
            .IndexOfAnyExcept(_allowedCharsEmailSearchValues) == -1;
    }
}
