using System;

namespace WeTongji.ParameterDictionary
{
    public static class Request
    {
        /// <summary>
        /// Method
        /// </summary>
        public static String Method
        {
            get { return "M"; }
        }

        /// <summary>
        /// MD5 Hash Checksum
        /// </summary>
        public static String Hash
        {
            get { return "H"; }
        }

        /// <summary>
        /// Device
        /// </summary>
        public static String Device
        {
            get { return "D"; }
        }

        /// <summary>
        /// Client Version
        /// </summary>
        public static String Version
        {
            get { return "V"; }
        }

        /// <summary>
        /// User ID
        /// </summary>
        public static String UID
        {
            get { return "U"; }
        }

        /// <summary>
        /// Page Number
        /// </summary>
        public static String Page
        {
            get { return "P"; }
        }

        /// <summary>
        /// Session
        /// </summary>
        public static String Session
        {
            get { return "S"; }
        }
    }
}
