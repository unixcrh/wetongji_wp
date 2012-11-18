using System;

namespace WeTongji.ParameterDictionary
{
    /// <summary>
    /// User
    /// </summary>
    public static class WTUser
    {
        /// <summary>
        /// User.Active
        /// </summary>
        public static class Active
        {
            #region [Method Name]
            public static String Method
            {
                get { return "User.Active"; }
            }
            #endregion

            #region [Request]
            /// <summary>
            /// (Request)NO
            /// </summary>
            public static String NO
            {
                get { return "NO"; }
            }

            /// <summary>
            /// (Request)Name
            /// </summary>
            public static String Name
            {
                get { return "Name"; }
            }

            /// <summary>
            /// (Request)Password
            /// </summary>
            public static String Password
            {
                get { return "Password"; }
            }

            #endregion
        }

        /// <summary>
        /// User.LogOn
        /// </summary>
        public static class LogOn
        {
            #region [Method Name]

            public static String Method
            {
                get { return "User.LogOn"; }
            }

            #endregion

            #region [Request]

            public static String NO
            {
                get { return "NO"; }
            }


            public static String Password
            {
                get { return "Password"; }
            }

            #endregion

            #region [Response]

            public static String Session
            {
                get { return "Session"; }
            }


            public static String User
            {
                get { return "User"; }
            }
            #endregion
        }

        /// <summary>
        /// User.LogOff
        /// </summary>
        public static class LogOff
        {
            #region [Method Name]

            public static String Method
            {
                get { return "User.LogOff"; }
            }

            #endregion
        }

        /// <summary>
        /// User.Get
        /// </summary>
        public static class Get
        {
            #region [Method Name]

            public static String Method
            {
                get { return "User.Get"; }
            }

            #endregion

            #region [Response]
            public static String User
            {
                get { return "User"; }
            }
            #endregion
        }

        /// <summary>
        /// User.Updates
        /// </summary>
        public static class Update
        {
            #region [Method Name]

            public static String Method
            {
                get { return "User.Update"; }
            }

            #endregion

            #region [Request]

            /// <summary>
            /// (Request)User, update DisplayName, Email, QQ, Phone, SinaWeibo ONLY
            /// </summary>
            /// <remarks>
            /// HttpWebRequest[Post]
            /// </remarks>
            public static String User
            {
                get { return "User"; }
            }

            #endregion
        }

        /// <summary>
        /// User.Update.Avatar
        /// </summary>
        public static class UpdateAvatar
        {
            #region [Method Name]

            public static String Method
            {
                get { return "User.Update.Avatar"; }
            }

            #endregion

            #region [Request]

            /// <summary>
            /// (Request)Image
            /// </summary>
            /// <remarks>
            /// HttpWebRequest[POST]
            /// </remarks>
            public static String Image
            {
                get { return "Image"; }
            }

            #endregion
        }

        /// <summary>
        /// User.Update.Password
        /// </summary>
        public static class UpdatePassword
        {
            #region [Method Name]

            public static String Method
            {
                get { return "User.Update.Password"; }
            }

            #endregion

            #region [Request]

            /// <summary>
            /// (Request)Old password
            /// </summary>
            public static String Old
            {
                get { return "Old"; }
            }

            /// <summary>
            /// (Request)New password
            /// </summary>
            public static String New
            {
                get { return "New"; }
            }

            #endregion

            #region [Response]

            /// <summary>
            /// (Response)Session
            /// </summary>
            public static String Session
            {
                get { return "Session"; }
            }

            #endregion
        }

        /// <summary>
        /// User.Reset.Password
        /// </summary>
        public static class ResetPassword
        {
            #region [Method Name]

            public static String Method
            {
                get { return "User.Reset.Password"; }
            }

            #endregion

            #region [Request]

            /// <summary>
            /// (Request)Number
            /// </summary>
            public static String NO
            {
                get { return "NO"; }
            }

            /// <summary>
            /// (Request)Name
            /// </summary>
            public static String Name
            {
                get { return "Name"; }
            }

            #endregion
        }
    }
}
