using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Dictionary
{
    public class Dictionary
    {
        public List<Data> DictionaryList { get; set; }

        public Dictionary() { DictionaryList = new List<Data>(); }

        public void Add(Data data) { DictionaryList.Add(data); }

        public void Save() { XmlSerializeHelper.SerializeAndSave(BaseName, this); }

        public void Remove(Data data) { DictionaryList.Remove(data); }

        public void Clear() { DictionaryList.Clear(); }

        public static Dictionary Load()
        {
            Dictionary result;
            try { result = BaseName.LoadAndDeserialize<Dictionary>(); }
            catch { return new Dictionary(); }
            return result;
        }

        private static string fileName = "Dictionary.xml";       // Файл базы коллекции
        [XmlIgnore]
        public static string BaseName { get { return fileName; } }
    }
}