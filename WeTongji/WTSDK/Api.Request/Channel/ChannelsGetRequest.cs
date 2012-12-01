using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeTongji.Api.Request
{
    public class ChannelsGetRequest : IWTRequest<WeTongji.Api.Response.ChannelsGetResponse>
    {
        #region [Constructor]

        public ChannelsGetRequest() { }

        #endregion

        #region [Implementation]

        public String GetApiName()
        {
            return "Channels.Get";
        }

        public IDictionary<String, String> GetParameters()
        {
            return new Dictionary<String, String>();
        }

        public void Validate() { }

        #endregion

    }
}
