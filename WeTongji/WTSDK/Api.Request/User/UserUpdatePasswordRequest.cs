using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeTongji.Api.Request
{
    public class UserUpdatePasswordRequest : IWTUploadRequest<WeTongji.Api.Response.UserUpdatePasswordResponse>, IWTRequest<WeTongji.Api.Response.UserUpdatePasswordResponse>
    {
        #region [Constructor]

        public UserUpdatePasswordRequest()
        {
            NewPassword = String.Empty;
            OldPassword = String.Empty;
        }

        #endregion

        #region [Property]

        public String NewPassword { get; set; }
        public String OldPassword { get; set; }

        #endregion

        #region [Implementation]

        public IDictionary<String, WeTongji.Api.Util.FileItem> GetFileParameters()
        {
            return new Dictionary<String, WeTongji.Api.Util.FileItem>();
        }

        public IDictionary<String, String> GetParameters()
        {
            var result = new Dictionary<String, String>();
            result["Old"] = OldPassword;
            result["New"] = NewPassword;
            return result;
        }

        public String GetApiName()
        {
            return "User.Update.Password";
        }

        public void Validate()
        {
            if (String.IsNullOrEmpty(OldPassword))
                throw new ArgumentNullException("OldPassword");
            if (String.IsNullOrEmpty(NewPassword))
                throw new ArgumentNullException("NewPassword");

            //...To do @_@ check length of Old and New Password
        }

        #endregion
    }
}
