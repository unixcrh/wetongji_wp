using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeTongji.ParameterDictionary;

namespace WeTongji
{
    public sealed class WTClient
    {
        #region [Field]

        private static WTClient _instance = null;

        #endregion

        #region [Construction]
        private WTClient() { }
        #endregion

        #region [Property]

        #region [Instance]

        public static WTClient Instance
        {
            get
            {
                return _instance == null ? (_instance = new WTClient()) : _instance;
            }
        }

        #endregion

        private String UrlHead
        {
            get { return "http://we.tongji.edu.cn/api/call?"; }
        }

        private String Version
        {
            get { return "2.0.0"; }
        }

        private String Platform
        {
            get { return "iphone"; }
        }

        #endregion

        #region [Public Functions]

        public String BuildURL(Dictionary<String, object> param)
        {
            String result = String.Empty;
            Dictionary<String, object> dict = new Dictionary<String, object>(param);

            if (param.ContainsKey(Request.Method))
            {
                dict[Request.Device] = Platform;
                dict[Request.Version] = Version;
                dict[Request.Hash] = GetChecksum(dict);
            }
            else
            {
                throw new ArgumentException("Parameter doesn't contains method.");
            }

            result = UrlHead + Dictionary2String(dict);

            return result;
        }

        #endregion

        #region [Private Functions]

        private String GetChecksum(Dictionary<String, object> dict)
        {
            return JeffWilcox.Utilities.Silverlight.MD5Core.GetHashString(Dictionary2String(dict)).ToLower();
        }

        private String Dictionary2String(Dictionary<String, object> dict)
        {
            String[] tmp = new String[dict.Count];

            var q = dict.OrderBy(p => p.Key);

            for (int i = 0; i < dict.Count; ++i)
            {
                tmp[i] = String.Format("{0}={1}", q.ElementAt(i).Key, q.ElementAt(i).Value.ToString());
            }

            return tmp.Aggregate((s1, s2) => s1 + "&" + s2);
        }

        #endregion

    }
}
