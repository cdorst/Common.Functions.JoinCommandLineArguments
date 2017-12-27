using System.Collections.Generic;
using static Common.Functions.JoinStringsWithSpace.StringsJoiner;
using static Common.Functions.PrependEnumerationElement.EnumerationElementPrepender;

namespace Common.Functions.JoinCommandLineArguments
{
    public static class CommandLineArgumentsJoiner
    {
        public static string Join(string firstArgument, IEnumerable<string> remainingArguments)
            => JoinWithSpace(
                Prepend(firstArgument, remainingArguments));
    }
}
