using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class Constant : IExpression
    {
        private string constant;

        public Constant(string constant)
        {
            this.constant = constant;
        }

        public string Interpret(Context context)
        {
            return constant;
        }
    }
}
