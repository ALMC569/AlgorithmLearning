using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPackage.Common
{
    public abstract class Algorithm
    {
        public abstract Output GetSolution(Input input);
    }

    public abstract class Output
    {
        public virtual void Result2Console() { throw new NotImplementedException(); }
    }

    public abstract class Input
    { }
}
