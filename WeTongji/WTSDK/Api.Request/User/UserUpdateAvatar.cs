using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeTongji.Api.Request
{
    public class UserUpdateAvatar : IWTUploadRequest<WeTongji.Api.WTResponse>, IWTRequest<WeTongji.Api.WTResponse>
    {
        #region [Constructor]

        public UserUpdateAvatar() { }

        #endregion

        #region [Property]

        public String ImagePath { get; set; }

        #endregion

        #region [Implementation]

        public IDictionary<String, WeTongji.Api.Util.FileItem> GetFileParameters()
        {
            var result = new Dictionary<String, WeTongji.Api.Util.FileItem>();
            result["Image"] = new Util.FileItem(ImagePath);
            return result;
        }

        public IDictionary<String, String> GetParameters()
        {
            return new Dictionary<String, String>();
        }

        public String GetApiName()
        {
            return "User.Update.Avatar";
        }

        public void Validate()
        {
            if (String.IsNullOrEmpty(ImagePath))
                throw new ArgumentNullException("ImagePath");
        }

        #endregion
    }
}
