using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MobileStorage.Business
{
    public class Convertor
    {
        public static List<StorageItems> EncryptList(List<StorageItems> siList, string sPassword)
        {
            List<StorageItems> siReturnValue = new List<StorageItems>();

            foreach (StorageItems item in siList)
            {
                siReturnValue.Add(new StorageItems(Crypto.Encrypt(item.Key, sPassword), Crypto.Encrypt(item.Value, sPassword), Crypto.Encrypt(item.Description, sPassword)));
            }

            return siReturnValue;
        }

        public static List<StorageItems> DecryptList(List<StorageItems> siList, string sPassword)
        {
            try
            {
                List<StorageItems> siReturnValue = new List<StorageItems>();

                foreach (StorageItems item in siList)
                {
                    siReturnValue.Add(new StorageItems(Crypto.Decrypt(item.Key, sPassword), Crypto.Decrypt(item.Value, sPassword), Crypto.Decrypt(item.Description, sPassword)));
                }

                return siReturnValue;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
