using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeTongji.Api.Request;

namespace WeTongji.Api
{
    public class DefaultWTClient : IWTClient
    {
        #region [CONST STRING]

        public const String METHOD = "M";
        public const String HASH = "H";
        public const String DEVICE = "D";
        public const String UID = "U";
        public const String PAGE = "P";
        public const String VERSION = "V";
        public const String SESSION = "S";
        
        #endregion

        #region [CONSTRUCTOR]

        public DefaultWTClient() { }

        #endregion

        #region [IMPLEMENTATION]

        public T Execute<T>(IWTRequest<T> request) where T : WTResponse { return null; }

        public T Execute<T>(IWTRequest<T> request, String session) where T : WTResponse { return null; }

        public T Execute<T>(IWTRequest<T> request, String session, DateTime timestamp) where T : WTResponse { return null; }

        #endregion

        #region [PUBLIC FUNCTION]

        public void SetSystemParameters(IDictionary<String, String> systemParameters) { }
        public void SetTimeOut(int timeout) { }
        public void SetWTLogger(IWTLogger wtLogger) { }
#endregion

    }
}
