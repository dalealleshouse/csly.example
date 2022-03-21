using sly.lexer;
using sly.parser.generator;
using sly.parser.parser;

namespace Example
{
    public class SimpleParser
    {
        [Production("widget: IDENTIFIER")]
        public string Widget(Token<SimpleTokens> widget)
        {
            return widget.Value;
        }

        [Production("expression: widget (OR [d] widget)+")]
        public string Expression(string widget, List<Group<SimpleTokens, string>> ors)
        {
            return ors.Aggregate($"{widget}", (acc, a) => $"{acc} | {a.Value(0)}");
        }
    }
}
