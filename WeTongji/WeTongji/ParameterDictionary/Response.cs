using System;

namespace WeTongji.ParameterDictionary
{
    public static class Response
    {
        /// <summary>
        /// Status
        /// </summary>
        public static String Status
        {
            get { return "Status"; }
        }

        /// <summary>
        /// Data
        /// </summary>
        public static String Data
        {
            get { return "Data"; }
        }

        /// <summary>
        /// [Status][Id]
        /// </summary>
        public static String Status_Id
        {
            get { return "Id"; }
        }

        /// <summary>
        /// [Status][Memo]
        /// </summary>
        public static String Status_Memo
        {
            get { return "Memo"; }
        }
    }
}
