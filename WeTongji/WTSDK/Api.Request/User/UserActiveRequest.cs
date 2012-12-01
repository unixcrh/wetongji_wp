using System;
using System.Collections.Generic;

namespace WeTongji.Api.Request
{
    public class UserActiveRequest : IWTRequest<WeTongji.Api.WTResponse>
    {
        #region [Constructor]
        
        public UserActiveRequest()
        {
            NO = String.Empty;
            Name = String.Empty;
            Password = String.Empty;
        }

        #endregion

        #region [Property]

        public String NO { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }

        #endregion

        #region [Implementation]

        public String GetApiName()
        {
            return "User.Active";
        }

        public IDictionary<String, String> GetParameters()
        {
            var result = new Dictionary<String, String>();

            result["NO"] = NO;
            result["Name"] = Name;
            result["Password"] = Password;

            return result;
        }

        public void Validate()
        {
            #region [NO]

            if (String.IsNullOrEmpty(NO) || String.IsNullOrWhiteSpace(NO))
            {
                throw new ArgumentNullException("NO", "NO can NOT be empty.");
            }

            foreach (var c in NO)
            {
                if (!Char.IsDigit(c))
                {
                    throw new ArgumentOutOfRangeException("NO", "NO can only contain digit.");
                }
            }

            //...To do @_@ check length of NO

            #endregion

            #region [Name]

            if (String.IsNullOrEmpty(Name) || String.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("Name", "Name can NOT be empty.");
            }

            #endregion

            #region [Password]

            if (String.IsNullOrEmpty(Password) || String.IsNullOrWhiteSpace(Password))
            {
                throw new ArgumentNullException("Password", "Password can NOT be empty.");
            }

            //...To do @_@ check password length

            #endregion
        }

        #endregion
    }
}
