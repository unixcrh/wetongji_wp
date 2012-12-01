using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeTongji.Api.Request
{
    public class UserResetPassword : IWTRequest<WeTongji.Api.WTResponse>
    {
        public UserResetPassword() 
        {
            NO = String.Empty;
            Name = String.Empty;
        }

        public String NO { get; set; }
        public String Name { get; set; }

        public String GetApiName()
        {
            return "User.Reset.Password";
        }

        public IDictionary<String, String> GetParameters()
        {
            var result = new Dictionary<String, String>();
            result["NO"] = NO;
            result["Name"] = Name;
            return result;
        }

        public void Validate()
        {
            if (String.IsNullOrEmpty(NO))
                throw new ArgumentNullException("NO");
            if (String.IsNullOrEmpty(Name))
                throw new ArgumentNullException("Name");

            //...To do @_@ check NO and Name length
        }

    }
}
