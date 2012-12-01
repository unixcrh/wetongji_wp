using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeTongji.Api.Request
{
    public interface IWTRequest<T> where T : WeTongji.Api.WTResponse
    {
        String GetApiName();
        IDictionary<String, String> GetParameters();
        void Validate();
    }
}
