using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace WeTongji.Api.Request
{
    public class ActivitiesGetRequest : IWTRequest<WeTongji.Api.Response.ActivitiesGetResponse>
    {
        #region [Const String]

        const String GetActivitySortMethodLikeDesc = @"'like' desc";
        const String GetActivitySortMethodBeginDesc = @"'begin' desc";
        const String GetActivitySortMethodScheduleDesc = @"'schedule' desc";

        #endregion

        #region [Constructor]

        public ActivitiesGetRequest()
        {
            Channel_Ids = String.Empty;
            Sort = String.Empty;
            Expire = false;
        }

        #endregion

        #region [Property]

        public String Channel_Ids { get; set; }
        public String Sort { get; set; }
        public Boolean Expire { get; set; }

        #endregion

        #region [Implementation]

        public String GetApiName()
        {
            return "Activities.Get";
        }

        public IDictionary<String, String> GetParameters()
        {
            var result = new Dictionary<String, String>();
            if (!String.IsNullOrEmpty(Channel_Ids))
                result["Channel_Ids"] = Channel_Ids;
            if (!String.IsNullOrEmpty(Sort))
                result["Sort"] = Sort;
            result["Expire"] = JsonConvert.SerializeObject(Expire);

            return result;
        }

        public void Validate()
        {
            if (!String.IsNullOrEmpty(Channel_Ids))
            {
                var channels = Channel_Ids.Split(',');
                int tmp;
                foreach (var channel in channels)
                {
                    if (String.IsNullOrEmpty(channel))
                    {
                        throw new ArgumentException("Channel_Ids");
                    }
                    if (!int.TryParse(channel, out tmp))
                    {
                        throw new ArgumentException("Channel_Ids");
                    }
                    if (tmp < 0)
                    {
                        throw new ArgumentOutOfRangeException("Channel_Ids");
                    }
                }
            }

            if (!String.IsNullOrEmpty(Sort)
                && Sort != GetActivitySortMethodBeginDesc
                && Sort != GetActivitySortMethodLikeDesc
                && Sort != GetActivitySortMethodScheduleDesc)
            {
                throw new ArgumentException("Sort");
            }
        }

        #endregion
    }
}
