using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeTongji.Api.Request
{
    public class UserGetRequest : IWTRequest<WeTongji.Api.Response.UserGetResponse>
    {
        #region [Constructor]

        public UserGetRequest() { }

        #endregion

        #region [Implementation]

        public String GetApiName()
        {
            return "User.Get";
        }

        public IDictionary<String, String> GetParameters()
        {
            return new Dictionary<String, String>();
        }

        public void Validate() { }

        #endregion
    }
}
