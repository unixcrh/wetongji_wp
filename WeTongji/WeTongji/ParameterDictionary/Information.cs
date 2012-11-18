using System;

namespace WeTongji.ParameterDictionary
{
    /// <summary>
    /// Information
    /// </summary>
    public static class Information
    {
        /// <summary>
        /// Information.GetList
        /// </summary>
        public static class GetList
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Information.GetList"; }
            }

            #endregion

            #region [Request]

            /// <summary>
            /// (Request)Sort
            /// </summary>
            public static String Sort
            {
                get { return "Sort"; }
            }

            #endregion

            #region [Response]

            /// <summary>
            /// (Response)Information
            /// </summary>
            public static String Information
            {
                get { return "Information"; }
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

        /// <summary>
        /// Information.Get
        /// </summary>
        public static class Get
        {
            #region [Method Name]
            public static String Method
            {
                get { return "Information.Get"; }
            }
            #endregion

            #region [Request]

            /// <summary>
            /// (Request)Id
            /// </summary>
            public static String Id
            {
                get { return "Id"; }
            }

            #endregion

            #region [Response]

            /// <summary>
            /// (Response)Information
            /// </summary>
            public static String Information
            {
                get { return "Information"; }
            }

            #endregion
        }

        /// <summary>
        /// Information.Read
        /// </summary>
        public static class Read
        {
            #region [Method Name]
            public static String Method
            {
                get { return "Information.Read"; }
            }
            #endregion

            #region [Request]

            /// <summary>
            /// (Request)Id
            /// </summary>
            public static String Id
            {
                get { return "Id"; }
            }

            #endregion
        }

        /// <summary>
        /// Information.Favorite
        /// </summary>
        public static class Favorite
        {
            #region [Method Name]
            public static String Method
            {
                get { return "Information.Favorite"; }
            }
            #endregion

            #region [Request]

            /// <summary>
            /// (Request)Id
            /// </summary>
            public static String Id
            {
                get { return "Id"; }
            }

            #endregion
        }

        /// <summary>
        /// Information.UnFavorite
        /// </summary>
        public static class UnFavorite
        {
            #region [Method Name]
            public static String Method
            {
                get { return "Information.UnFavorite"; }
            }
            #endregion

            #region [Request]

            /// <summary>
            /// (Request)Id
            /// </summary>
            public static String Id
            {
                get { return "Id"; }
            }

            #endregion
        }


        /// <summary>
        /// Information.Like
        /// </summary>
        public static class Like
        {
            #region [Method Name]
            public static String Method
            {
                get { return "Information.Like"; }
            }
            #endregion

            #region [Request]

            /// <summary>
            /// (Request)Id
            /// </summary>
            public static String Id
            {
                get { return "Id"; }
            }

            #endregion
        }

        /// <summary>
        /// Information.UnLike
        /// </summary>
        public static class UnLike
        {
            #region [Method Name]
            public static String Method
            {
                get { return "Information.UnLike"; }
            }
            #endregion

            #region [Request]

            /// <summary>
            /// (Request)Id
            /// </summary>
            public static String Id
            {
                get { return "Id"; }
            }

            #endregion
        }
    }
}
