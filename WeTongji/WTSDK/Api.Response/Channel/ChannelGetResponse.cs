using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeTongji.Api.Response
{
    public class ChannelsGetResponse : WTResponse
    {
        public ChannelsGetResponse() { Channels = null; }

        public WeTongji.Api.Domain.Channel[] Channels { get; set; }
    }
}
