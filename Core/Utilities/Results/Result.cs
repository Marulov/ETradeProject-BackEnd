using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //ctor sayesinde set etmeyi yapabildik. sadece ctor da set edilebilir olarak kodladık.
        public Result(bool success, string message):this(success)  // constructora iki değişken gelirse bu çalışır 
        {
            Message = message;
        }
        public Result(bool success) // bir tane gelirse bu
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
