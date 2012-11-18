using System;

namespace WeTongji.ParameterDictionary
{
    /// <summary>
    /// TimeTable
    /// </summary>
    public static class TimeTable
    {
        /// <summary>
        /// Get TimeTable
        /// </summary>
        public static class Get
        {
            #region [Method Name]
            public static String Method
            {
                get
                {
                    return "TimeTable.Get";
                }
            }
            #endregion

            #region [Response]

            public static String Courses
            {
                get { return "Courses"; }
            }

            public static String SchoolYearStartAt
            {
                get { return "SchoolYearStartAt"; }
            }

            public static String SchoolYearWeekCount
            {
                get { return "SchoolYearWeekCount"; }
            }

            public static String SchoolYearCourseWeekCount
            {
                get { return "SchoolYearCourseWeekCount"; }
            }
            
            #endregion
        }
    }
}
