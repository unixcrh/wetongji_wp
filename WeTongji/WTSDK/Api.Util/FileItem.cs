using System;
using System.IO;

namespace WeTongji.Api.Util
{
    public class FileItem
    {
        public FileItem(String filePath) 
        { 
            this.filePath = filePath; 
        }

        public byte[] GetContent()
        {
            byte[] result = null;

            try
            {
                var stream = File.OpenRead(filePath);

                if (stream.Length > int.MaxValue)
                {
                    throw new IndexOutOfRangeException("File is too long.");
                }

                result = new byte[stream.Length];
                stream.BeginRead(
                    result,
                    0,
                    result.Length,
                    (args) => { stream.EndRead(args); },
                    new object()
                    );
            }
            catch
            {
            }

            return result;
        }

        private String filePath { get; set; }
    }
}
