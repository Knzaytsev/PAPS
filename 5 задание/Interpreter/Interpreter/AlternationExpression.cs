using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class AlternationExpression : IExpression
    {
        private string name;
        private IExpression expression1;
        private IExpression expression2;

        public AlternationExpression(IExpression expression1, IExpression expression2)
        {
            this.expression1 = expression1;
            this.expression2 = expression2;
        }

        public string Interpret(Context context)
        {
            return expression1.Interpret(context) + " | " + expression2.Interpret(context);
        }
    }
}
