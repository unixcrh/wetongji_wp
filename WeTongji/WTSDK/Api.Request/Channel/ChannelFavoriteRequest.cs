using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace WeTongji.Api.Request
{
    public class ChannelFavoriteRequest : IWTRequest<WeTongji.Api.WTResponse>
    {
        #region [Constructor]

        public ChannelFavoriteRequest() 
        {
            Id = -1;
        }

        #endregion

        #region [Property]

        public int Id { get; set; }

        #endregion

        #region [Implementation]

        public String GetApiName()
        {
            return "Channel.Favorite";
        }

        public IDictionary<String, String> GetParameters()
        {
            var result = new Dictionary<String, String>();
            result["Id"] = JsonConvert.SerializeObject(Id);
            return result;
        }

        public void Validate()
        {
            if (0 > Id)
                throw new ArgumentOutOfRangeException("Id");
        }


        #endregion


    }
}
