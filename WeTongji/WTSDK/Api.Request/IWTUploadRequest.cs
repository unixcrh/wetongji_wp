using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeTongji.Api.Request
{
    public interface IWTUploadRequest<T> : IWTRequest<T> where T : WeTongji.Api.WTResponse
    {
        IDictionary<String, WeTongji.Api.Util.FileItem> GetFileParameters();
    }
}
