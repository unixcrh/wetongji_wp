using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeTongji
{
    public sealed class WTClient
    {
        #region [Field]

        private static WTClient _instance = null;

        private Dictionary<String, object> param;

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

        public String Version
        {
            get { return "2.0.0"; }
        }

        public String Platform
        {
            get { return "iphone"; }
        }

        #endregion

    }
}
