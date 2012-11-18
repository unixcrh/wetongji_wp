using System;

namespace WeTongji.ParameterDictionary
{
    /// <summary>
    /// Activities
    /// </summary>
    public static class Activities
    {
        /// <summary>
        /// Activities.Get
        /// </summary>
        public static class Get
        {
            #region [Method Name]

            /// <summary>
            /// Activities.Get
            /// </summary>
            public static String Method
            {
                get { return "Activities.Get"; }
            }

            #endregion

            #region [Request]

            /// <summary>
            /// (Request)Channel_Ids
            /// </summary>
            public static String Channels
            {
                get { return "Channel_Ids"; }
            }

            /// <summary>
            /// (Request)Sort
            /// </summary>
            public static String Sort
            {
                get { return "Sort"; }
            }

            /// <summary>
            /// (Request)Expire
            /// </summary>
            public static String Expire
            {
                get { return "Expire"; }
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

            public static String NextPager
            {
                get { return "NextPager"; }
            }

            #endregion
        }

        /// <summary>
        /// Activity.Like
        /// </summary>
        public static class Like
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Activity.Like"; }
            }

            #endregion

            #region [Request]

            public static String Id
            {
                get { return "Id"; }
            }

            #endregion
        }

        /// <summary>
        /// Activity.UnLike
        /// </summary>
        public static class UnLike
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Activity.UnLike"; }
            }

            #endregion

            #region [Request]

            public static String Id
            {
                get { return "Id"; }
            }

            #endregion
        }

        /// <summary>
        /// Activity.Schedule
        /// </summary>
        public static class Schedule
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Activity.Schedule"; }
            }

            #endregion

            #region [Request]

            public static String Id
            {
                get { return "Id"; }
            }

            #endregion
        }

        /// <summary>
        /// Activity.UnSchedule
        /// </summary>
        public static class UnSchedule
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Activity.UnSchedule"; }
            }

            #endregion

            #region [Request]

            public static String Id
            {
                get { return "Id"; }
            }

            #endregion
        }

        /// <summary>
        /// Activity.Favorite
        /// </summary>
        public static class Favorite
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Activity.Favorite"; }
            }

            #endregion

            #region [Request]

            public static String Id
            {
                get { return "Id"; }
            }

            #endregion
        }

        /// <summary>
        /// Activity.UnFavorite
        /// </summary>
        public static class UnFavorite
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Activity.UnFavorite"; }
            }

            #endregion

            #region [Request]

            public static String Id
            {
                get { return "Id"; }
            }

            #endregion
        }
    }
}
