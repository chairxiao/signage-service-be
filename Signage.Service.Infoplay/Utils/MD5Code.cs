using System.IO;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;

namespace Signage.Service
{
    /// <summary>
    /// 生成MD5码
    /// </summary>
    public static class MD5Code
    {
        private static string ToString(byte[] HashCodeBuf)
        {
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < HashCodeBuf.Length; i++)
            {
                sBuilder.Append(HashCodeBuf[i].ToString("x2"));
            }
            string rc= sBuilder.ToString();
            return rc;
            
        }
        public static  string StringMD5(string str)
        {

            byte[] hashCode;
          
            MD5 md5 = MD5.Create();
            hashCode = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            string rc=ToString(hashCode);
            return rc;

        }
        public static string FileMD5(string fileName)
        {
            string rc = "";
            byte[] hashCode;

            using (FileStream fs = File.Open(fileName, FileMode.Open))
            {
                MD5 md5 = MD5.Create();
                hashCode = md5.ComputeHash(fs);

                rc = ToString(hashCode);

            }

            return rc;

        }
        /// <summary>
        /// obj类型须可DataContractSerializer
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ObjectMD5<T>(T obj)
        {
            byte[] hashCode;
            string rc = "";
            int objSize;
            
            using (MemoryStream ms = new MemoryStream())
            {
                DataContractSerializer ser = new DataContractSerializer(obj.GetType());
                ser.WriteObject(ms, obj);
                objSize = (int)ms.Length;
                ms.Position = 0;

                MD5 md5 = MD5.Create();
                hashCode = md5.ComputeHash(ms);

                rc = ToString(hashCode);            

            }

            return rc;
        }

        public static string StreamMD5(Stream stream)
        {
            byte[] hashCode;
            string rc = "";
            int objSize;

            objSize = (int)stream.Length;
            stream.Position = 0;

            MD5 md5 = MD5.Create();
            hashCode = md5.ComputeHash(stream);
            
            rc = ToString(hashCode);

            return rc;

        }
    }
    
}
