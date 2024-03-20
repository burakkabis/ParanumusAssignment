using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{


    //Result yapilanmasi genel olarak is sinifinda veri donerken ekstra bir seylerin eklenip donmesini saglar.
    //Mesela ekleme operasyonu yapildiginda void Add(Product product) yazip geriye hicbirsey dondurmeye bilirim.
    //Ama result yapilanmasi sayesinde IResul Add(Product product) diye methodu degistirdigimde IResult; icinde bool success , string message tuttugu icin geriye ,
    //islem dogruysa ; islem dogru bilgisi yani true ve Urun basariyla eklendi diye veri donusu saglayabilirim.



    //DataResult<T>   Result I inherit ediyor.(Ayni zamanda resultsin diyor.)
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
