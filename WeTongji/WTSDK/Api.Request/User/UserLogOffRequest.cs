using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeTongji.Api.Request
{
    public class UserLogOffRequest : IWTRequest<WeTongji.Api.WTResponse>
    {
        #region [Constructor]

        public UserLogOffRequest() { }

        #endregion

        #region [Implementation]

        public String GetApiName()
        {
            return "User.LogOff";
        }

        public IDictionary<String, String> GetParameters()
        {
            return new Dictionary<String, String>();
        }

        public void Validate() { }

        #endregion

    }
}
