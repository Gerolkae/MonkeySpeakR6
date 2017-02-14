using System.Collections.Generic;

namespace Monkeyspeak
{
    internal interface ILexer
    {
        void AddDefinition(TokenDefinition tokenDefinition);

        IEnumerable<Token> Tokenize(string source);
    }
}