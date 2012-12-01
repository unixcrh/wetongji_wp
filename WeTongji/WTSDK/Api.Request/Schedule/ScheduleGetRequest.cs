using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace WeTongji.Api.Request
{
    public class ScheduleGetRequest : IWTRequest<WeTongji.Api.Response.ScheduleGetResponse>
    {
        #region [Constructor]

        public ScheduleGetRequest() 
        {
            Begin = DateTime.MinValue;
            End = DateTime.MinValue;
        }

        #endregion

        #region [Property]

        public DateTime Begin { get; set; }
        public DateTime End { get; set; }

        #endregion

        #region [Implementation]

        public String GetApiName()
        {
            return "Schedule.Get";
        }

        public IDictionary<String, String> GetParameters()
        {
            var result = new Dictionary<String, String>();
            result["Begin"] = JsonConvert.SerializeObject(Begin);
            result["End"] = JsonConvert.SerializeObject(End);
            return result;
        }

        public void Validate()
        {
            if (Begin == DateTime.MinValue)
                throw new ArgumentOutOfRangeException("Begin");
            if (End < Begin)
                throw new ArgumentOutOfRangeException("End");
        }

        #endregion
    }
}
