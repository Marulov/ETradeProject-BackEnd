using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        // iki tane ctor içeren
        public ErrorResult(string message) : base(false, message)
        {

        }

        // tek ctor içeren
        public ErrorResult() : base(false)
        {

        }
    }
}
