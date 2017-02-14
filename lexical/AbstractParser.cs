using System.Collections.Generic;

namespace Monkeyspeak.lexical
{
    internal abstract class AbstractParser
    {
        protected MonkeyspeakEngine Engine;
        protected ILexer Lexer;

        protected AbstractParser(MonkeyspeakEngine engine, ILexer lexer)
        {
            Engine = engine;
            Lexer = lexer;
        }

        public abstract List<TriggerList> Parse(string source);
    }
}