// See https://aka.ms/new-console-template for more information
using Example;
using sly.parser;
using sly.parser.generator;

var expression = "foo or bar or baz";

var parser = GetParser();
var result = parser.Parse(expression);

if (result.IsError)
{
    foreach (var err in result.Errors)
    {
        Console.WriteLine(err);
    }
}

Console.WriteLine(result.Result);

static Parser<SimpleTokens, string> GetParser()
{
    var parserInstance = new SimpleParser();
    var builder = new ParserBuilder<SimpleTokens, string>();

    var result = builder
        .BuildParser(parserInstance, ParserType.EBNF_LL_RECURSIVE_DESCENT, "expression");

    if (result.IsError)
    {
        foreach (var err in result.Errors)
        {
            Console.WriteLine(err.Message);
        }
    }

    return result.Result;
}
