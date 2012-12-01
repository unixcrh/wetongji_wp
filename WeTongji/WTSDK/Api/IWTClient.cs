using System;
using WeTongji.Api.Request;

namespace WeTongji.Api
{
    public interface IWTClient
    {
        T Execute<T>(IWTRequest<T> request) where T : WTResponse;
        T Execute<T>(IWTRequest<T> request, String session) where T : WTResponse;
        T Execute<T>(IWTRequest<T> request, String session, DateTime timestamp) where T : WTResponse;
    }
}
