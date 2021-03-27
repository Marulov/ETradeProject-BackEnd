using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        // iki tane ctor içeren
        public SuccessResult(string message) : base(true, message)
        {

        }

        // tek ctor içeren
        public SuccessResult() : base(true)
        {

        }
    }
}
