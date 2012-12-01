using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace WeTongji.Api.Request
{
    public class UserUpdateRequest : IWTUploadRequest<WeTongji.Api.WTResponse>, IWTRequest<WeTongji.Api.WTResponse>
    {
        #region [Constructor]

        public UserUpdateRequest()
        {
            User = null;
            DisplayName = null;
            Email = null;
            QQ = null;
            Phone = null;
            SinaWeibo = null;
        }

        #endregion

        #region [Property]

        public WeTongji.Api.Domain.User User { get; set; }
        public String DisplayName { get; set; }
        public String Email { get; set; }
        public String QQ { get; set; }
        public String Phone { get; set; }
        public String SinaWeibo { get; set; }

        #endregion

        #region [Implementation]

        public IDictionary<String, WeTongji.Api.Util.FileItem> GetFileParameters()
        {
            return new Dictionary<String, WeTongji.Api.Util.FileItem>();
        }

        public IDictionary<String, String> GetParameters()
        {
            var result = new Dictionary<String, String>();

            if (String.IsNullOrEmpty(DisplayName))
                User.DisplayName = DisplayName;
            if (String.IsNullOrEmpty(Email))
                User.Email = Email;
            if (String.IsNullOrEmpty(QQ))
                User.QQ = QQ;
            if (String.IsNullOrEmpty(Phone))
                User.Phone = Phone;
            if (String.IsNullOrEmpty(SinaWeibo))
                User.SinaWeibo = SinaWeibo;

            result["User"] = JsonConvert.SerializeObject(User);
            return result;
        }

        public String GetApiName()
        {
            return "User.Update";
        }

        public void Validate()
        {
            if (User == null)
            {
                throw new ArgumentNullException("User");
            }

            if (String.IsNullOrEmpty(DisplayName) 
                && String.IsNullOrEmpty(Email) 
                && String.IsNullOrEmpty(QQ) 
                && String.IsNullOrEmpty(Phone) 
                && String.IsNullOrEmpty(SinaWeibo))
            {
                throw new ArgumentNullException("DisplayName,Email,QQ,Phone,SinaWeibo", "At least one parameter should be modified.");
            }
        }

        #endregion
    }
}
