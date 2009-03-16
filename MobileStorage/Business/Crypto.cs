using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace MobileStorage.Business
{
    public class Crypto
    {
        public static byte[] Encrypt(byte[] data, string password)
        {
            SymmetricAlgorithm sa = Rijndael.Create();

            ICryptoTransform ct = sa.CreateEncryptor(Encoding.UTF8.GetBytes(password), Encoding.UTF8.GetBytes("1234567890abcdef"));

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);

            cs.Write(data, 0, data.Length);
            cs.FlushFinalBlock();

            return ms.ToArray();
        }

        public static string Encrypt(string data, string password)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(data), password));
        }

        static public byte[] Decrypt(byte[] data, string password)
        {
            BinaryReader br = new BinaryReader(InternalDecrypt(data, password));
            return br.ReadBytes((int)br.BaseStream.Length);
        }

        static public string Decrypt(string data, string password)
        {
            CryptoStream cs = InternalDecrypt(Convert.FromBase64String(data), password);
            StreamReader sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }

        static CryptoStream InternalDecrypt(byte[] data, string password)
        {
            SymmetricAlgorithm sa = Rijndael.Create();
            ICryptoTransform ct = sa.CreateDecryptor(Encoding.UTF8.GetBytes(password), Encoding.UTF8.GetBytes("1234567890abcdef"));

            MemoryStream ms = new MemoryStream(data);
            return new CryptoStream(ms, ct, CryptoStreamMode.Read);
       }
       
    }
}
