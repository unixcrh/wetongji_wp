using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeTongji.Api.Response
{
    public class ActivitiesGetResponse : WTResponse
    {
        public ActivitiesGetResponse()
        {
            Activities = null;
            NextPager = -1;
        }

        public WeTongji.Api.Domain.Activity[] Activities { get; set; }
        public int NextPager { get; set; }

    }
}
