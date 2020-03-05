using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            var expression = new SequenceExpression(new Constant("dog"), new AlternationExpression(
                new Constant("cat"), new RepetitionExpression(
                    new Constant("a"), 6)));
            var result = expression.Interpret(context);
            Console.WriteLine(result);
        }
    }
}
