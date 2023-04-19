using System;
using System.Collections.Generic;
using System.Text;
using Wrapper;
using CLI;

namespace ExecFile
{
    public class ExecWrapper
    {
        public int UseWrapperMethod()
        {
            var wrap = new CPlusPlusWraper();
            return wrap.UseAddNumbers(10, 20);
        }

        public float UseCPPWrapperMethod()
        {
            Entity wrap = new Entity();
            return wrap.add(10, 20);

        }

    }
}
