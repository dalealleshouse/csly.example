using sly.lexer;

namespace Example
{
    public enum SimpleTokens
    {
        [Lexeme(GenericToken.Identifier, IdentifierType.AlphaNumericDash)]
        IDENTIFIER,

        [Lexeme(GenericToken.KeyWord, "or")]
        OR,
    }
}
