using System;

namespace WeTongji.ParameterDictionary
{
    /// <summary>
    /// Channel
    /// </summary>
    public static class Channel
    {
        /// <summary>
        /// Channel.Favorite
        /// </summary>
        public static class Favorite
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Channel.Favorite"; }
            }

            #endregion
        }

        /// <summary>
        /// Channel.UnFavorite
        /// </summary>
        public static class UnFavorite
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Channel.UnFavorite"; }
            }

            #endregion
        }

        public static class Get
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Channel.Get"; }
            }

            #endregion

            #region [Response]

            public static String Channels
            {
                get { return "Channels"; }
            }

            #endregion
        }
    }
}
