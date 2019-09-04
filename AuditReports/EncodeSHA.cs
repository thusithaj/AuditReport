using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditReports
{
    public class EncodeSHA
    {
        public string EncodeText(string text)
        {
            string encodeStr = "";
            System.Security.Cryptography.SHA1CryptoServiceProvider serviceProvider =
                new System.Security.Cryptography.SHA1CryptoServiceProvider();

            byte[] buf = new byte[text.Count()];
            int i = 0;
            foreach (char c in text.ToCharArray())
            {
                byte b = (byte)c;
                buf[i] = b;
                i++;
            }

            byte[] withHash = serviceProvider.ComputeHash(buf, 0, buf.Length);
            List<char> encodeList = new List<char>();
            foreach (byte b in withHash)
            {
                encodeList.Add((char)b);
                encodeStr = encodeStr + ((char)b).ToString();
            }


            return encodeStr;
        }
    }
}
