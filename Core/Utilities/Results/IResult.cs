using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için 
    public interface IResult
    {
        // işlem başarılı mı başarısız mı diye kontrol edeceğiz business katmanında(true-false)
        bool Success { get; }  //sadece okunabilir yaptık.
        // kullanıcıya mesajı göstereceğiz başarısızsa başarısız mesajı başarılıysa başarrılı mesajı
        string Message { get; } // sadece okunabilir yaptık
    }
}
