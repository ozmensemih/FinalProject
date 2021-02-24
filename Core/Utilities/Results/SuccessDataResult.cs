using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        //data ve mesaj ver
        public SuccessDataResult(T data,string message):base(data,true,message)
        {
                
        }
        //sadece data ver
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        // sadece mesaj ver
        public SuccessDataResult(string message):base(default,true,message)
        {

        }

        // hiçbirşey sonuç ver // default dataya karşılık gelir.
        public SuccessDataResult():base(default,true)
        {
                
        }

    }
}
