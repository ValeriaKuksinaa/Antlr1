using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using static Antlr.SimpleParser;

namespace Antlr;

internal class Program
{
    static void Main(string[] args)
    {
        //string code = "Bob says \"hello\" \r\n Alice says \"hi\"";

        string code = File.ReadAllText("code.txt");

        AntlrInputStream inputStream = new(code);

        SimpleLexer lexer = new(inputStream);

        CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
        SimpleParser speakParser = new SimpleParser(commonTokenStream);
        SimpleParser.StartContext chatContext = speakParser.start();
        SimpleVisitor visitor = new SimpleVisitor();
        string pythonCode = visitor.Visit(chatContext);
        File.WriteAllText("code.py", pythonCode);

        Console.WriteLine("Hello, world!");
    }
}

public class SimpleVisitor : SimpleBaseVisitor<string>
{
    //public List<SpeakLine> Lines = new List<SpeakLine>();

    int contextLevel = 0;

    private string GetIndentation(int contextLevel)
    {
        return string.Join("", Enumerable.Range(0, contextLevel * 4).Select(i => " "));
    }

    public override string VisitStart([NotNull] StartContext context) => Visit(context.methodDeclarations());

    public override string VisitMethodDeclarations([NotNull] MethodDeclarationsContext context)
    {
        List<string> pythonMethods = new();
        for (int i = 0; i < context.methodDeclaration().Count(); i++)
        {
            pythonMethods.Add(GetIndentation(contextLevel) + Visit(context.methodDeclaration(i)));
        }

        return string.Join("\r\n", pythonMethods); ;
    }

    public override string VisitMethodDeclaration([NotNull] MethodDeclarationContext context)
    {
        string pythonMethodHeader = GetIndentation(contextLevel) + Visit(context.methodHeader());
        contextLevel++;
        string pythonMethodBody = Visit(context.methodBody());
        return $"{pythonMethodHeader}{Environment.NewLine}{pythonMethodBody}";
    }

    public override string VisitMethodBody([NotNull] MethodBodyContext context)
    {
        List<string> pythonLines = new();
        for(int i = 0; i < context.statement().Count(); i++)
        {
            pythonLines.Add(GetIndentation(contextLevel) + Visit(context.statement(i)));
        }

        contextLevel--;

        return string.Join("\r\n", pythonLines);
    }

    public override string VisitStatement([NotNull] StatementContext context)
    {
        return Visit(context.embeddedStatement());
    }




    public override string VisitLocalVariableDeclaration([NotNull] LocalVariableDeclarationContext context)
    {
        string varName = context.variableName().GetText();
        string varType = context.variableType().GetText();

        string result = $"{varName} : {varType}";

        VariableValueContext variableValueContext = context.variableValue();
        if (variableValueContext != null)
        {
            string temp = Visit(variableValueContext);

            result += $" = {temp}";
        }

        return result;
    }

    public override string VisitPBooleanLiteral([NotNull] PBooleanLiteralContext context)
    {
        string boolString = context.GetText();

        return boolString;
    }

    public override string VisitPIntegerLiteral([NotNull] PIntegerLiteralContext context) => context.GetText();

    public override string VisitPStringLiteral([NotNull] PStringLiteralContext context) => context.GetText();
    


    public override string VisitMethodCall([NotNull] MethodCallContext context)
    {
        string methodName = context.methodName().GetText();

        return $"{methodName.ToLower()}()";
    }


    public override string VisitMethodHeader([NotNull] MethodHeaderContext context)
    {
        return $"def {context.methodName().GetText().ToLower()}():";
    }
    
}