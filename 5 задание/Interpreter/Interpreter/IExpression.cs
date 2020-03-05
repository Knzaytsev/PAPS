using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    interface IExpression
    {
        public string Interpret(Context context);
    }
}
