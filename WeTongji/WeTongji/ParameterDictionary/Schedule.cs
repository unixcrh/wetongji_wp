using System;

namespace WeTongji.ParameterDictionary
{
    /// <summary>
    /// Schedule
    /// </summary>
    public static class Schedule
    {
        /// <summary>
        /// Get Schedule
        /// </summary>
        public static class Get
        {
            #region [Method Name]

            public static String Method
            {
                get { return "Schedule.Get"; }
            }

            #endregion

            #region [Response]

            public static String Exams
            {
                get { return "Exams"; }
            }

            public static String Activities
            {
                get { return "Activities"; }
            }
            
            #endregion
        }
    }
}
