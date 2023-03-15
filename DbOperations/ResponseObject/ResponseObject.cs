using DbObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbOperations.ResponseObject
{
    public class ResponseObject<T> 
    {
        public T _data;
        public ResultCode _code;
        public String _message;

        public ResponseObject()
        {

        }

        public ResponseObject(T data)
        {
            _data = data;
        }

        public T GetResponseData()
        {
            return _data;
        }

        ResultCode GetResultCode()
        {
            return _code;
        }

        public void SetResponeData(T data, ResultCode code, String message)
        {
            _code = code;
            _data = data;
            _message = message; 
        }

        
    }
}
