using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class RepetitionExpression : IExpression
    {
        private IExpression expression;
        private int cnt = 0;

        public RepetitionExpression(IExpression expression, int cnt)
        {
            this.expression = expression;
            this.cnt = cnt;
        }

        public string Interpret(Context context)
        {
            var word = expression.Interpret(context);
            var result = "";
            for(var i = 0; i < cnt; ++i)
            {
                result += word;
            }
            return result;
        }
    }
}
