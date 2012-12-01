using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeTongji.Api.Request
{
    public class UserLogOnRequest : IWTRequest<WeTongji.Api.Response.UserLogOnResponse>
    {
        #region [Constructor]

        public UserLogOnRequest()
        {
            NO = String.Empty;
            Password = String.Empty;
        }

        #endregion

        #region [Property]

        public String NO { get; set; }
        public String Password { get; set; }

        #endregion

        #region [Implementation]

        public String GetApiName()
        {
            return "User.LogOn";
        }

        public IDictionary<String, String> GetParameters()
        {
            var result = new Dictionary<String, String>();

            result["NO"] = NO;
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
