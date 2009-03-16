using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MobileStorage
{
    [Serializable]
    public class StorageItems
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }

        public StorageItems()
        {
            
        }

        public StorageItems(string pKey, string pValue, string pDescription)
        {
            Key = pKey;
            Value = pValue;
            Description = pDescription;
        }
    }
}
