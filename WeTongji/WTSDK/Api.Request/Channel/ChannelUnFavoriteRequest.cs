using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace WeTongji.Api.Request
{
    public class ChannelUnFavoriteRequest : IWTRequest<WeTongji.Api.WTResponse>
    {
        #region [Constructor]

        public ChannelUnFavoriteRequest()
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
            return "Channel.UnFavorite";
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
