using System;

namespace WeTongji.ParameterDictionary
{
    /// <summary>
    /// Person(JiRen)
    /// </summary>
    public static class Person
    {
        /// <summary>
        /// Person.GetLatest
        /// </summary>
        public static class GetLatest
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Person.GetLatest"; }
            }

            #endregion

            #region [Response]

            //...No Key

            #endregion
        }

        /// <summary>
        /// Person.Get
        /// </summary>
        public static class Get
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Person.Get"; }
            }

            #endregion

            #region [Response]

            /// <summary>
            /// (Response)People
            /// </summary>
            public static String People
            {
                get { return "People"; }
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
        /// Person.Read
        /// </summary>
        public static class Read
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Person.Read"; }
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
        /// Person.Favorite
        /// </summary>
        public static class Favorite
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Person.Favorite"; }
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
        /// Person.UnFavorite
        /// </summary>
        public static class UnFavorite
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Person.UnFavorite"; }
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
        /// Person.Like
        /// </summary>
        public static class Like
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Person.Like"; }
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
        /// Person.UnLike
        /// </summary>
        public static class UnLike
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Person.UnLike"; }
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
