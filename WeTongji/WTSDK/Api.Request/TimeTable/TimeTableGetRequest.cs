using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeTongji.Api.Request
{
    class TimeTableGetRequest : IWTRequest<WeTongji.Api.Response.TimeTableGetResponse>
    {
        #region [Constructor]
        public TimeTableGetRequest() { }
        #endregion

        #region [Implementation]

        public String GetApiName()
        {
            return "TimeTable.Get";
        }

        public IDictionary<String, String> GetParameters()
        {
            return new Dictionary<String, String>();
        }

        public void Validate() { }
        
        #endregion

    }
}
