using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Dictionary
{

    public class Dictionary
    {
        public List<Data> DictionaryList { get; set; }

        public Dictionary()                               // Создание списка
        {
            DictionaryList = new List<Data>();
        }

        public void Add(Data data)                          // Добавление записи
        {
            DictionaryList.Add(data);
        }

        public void Save()                                      // Сохранение
        {
            XmlSerializeHelper.SerializeAndSave(BaseName, this);
        }

        public void Remove(Data data)                       // Удаление записи
        {
            DictionaryList.Remove(data);
        }

        public void Clear()                                     // Очистить коллекцию
        {
            DictionaryList.Clear();
        }

        public static Dictionary Load()                   // Загрузка коллекции
        {
            Dictionary result;
            try
            {
                result = BaseName.LoadAndDeserialize<Dictionary>();
            }
            catch
            {
                return new Dictionary();
            }
            return result;
        }

        [XmlIgnore]
        private static string fileName = "Dictionary.xml";       // Файл базы коллекции
        [XmlIgnore]
        public static string BaseName { get { return fileName; } }
    }
}