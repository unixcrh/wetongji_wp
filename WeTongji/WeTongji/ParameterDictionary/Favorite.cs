using System;

namespace WeTongji.ParameterDictionary
{
    /// <summary>
    /// Favorite
    /// </summary>
    public static class Favorite
    {
        /// <summary>
        /// Favorite.Get
        /// </summary>
        public static class Get
        {
            #region  [Method Name]

            public static String Method
            {
                get { return "Favorite.Get"; }
            }
            
            #endregion

            #region [Response]

            /// <summary>
            /// (Response)Activities
            /// </summary>
            public static String Activities
            {
                get { return "Activities"; }
            }

            /// <summary>
            /// (Response)NextPager
            /// </summary>
            public static String NextPager
            {
                get { return "NextPager"; }
            }
            
            #endregion
        }
    }
}
