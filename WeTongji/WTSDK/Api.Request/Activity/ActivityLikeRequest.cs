﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeTongji.Api.Request
{
    public class ActivityLikeRequest : IWTRequest<WeTongji.Api.WTResponse>
    {
        public ActivityLikeRequest() { }

        public int Id { get; set; }

        public String GetApiName()
        {
            return "Activity.Like";
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
    }
}
