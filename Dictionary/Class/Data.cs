using System.Xml.Serialization;

namespace Dictionary
{
    public class Data
    {
        public string WordEn { get; set; }
        public string WordRu { get; set; }

        private TypeWord _typeWord = TypeWord.Unknown;
        [XmlIgnore]
        public TypeWord Type
        {
            get { return _typeWord; }
            set { _typeWord = value; }
        }

        private string TypeString                   //  используется для вывода значения в таблицу
        {
            get { return TypeToString(Type); }
            set { Type = StringToType(value); }
        }

        private static string TypeToString(TypeWord typeWord)
        {
            switch (typeWord)
            {
                case TypeWord.verb: return "глагол";
                case TypeWord.noun: return "существительное";
                case TypeWord.pronoun: return "местоимение";
                case TypeWord.questions: return "вопросы";
                case TypeWord.participle: return "причастие";
                case TypeWord.prepositions: return "предлоги";
                case TypeWord.Unknown: return "прочие";
                default: return "прочие";
            }
        }

        private static TypeWord StringToType(string type)
        {
            switch (type)
            {
                case "глагол": return TypeWord.verb;
                case "существительное": return TypeWord.noun;
                case "местоимение": return TypeWord.pronoun;
                case "вопросы": return TypeWord.questions;
                case "причастие": return TypeWord.participle;
                case "предлоги": return TypeWord.prepositions;
                case "прочие": return TypeWord.Unknown;
                default: return TypeWord.Unknown;
            }
        }


        public bool Equals(Data _data)
        {
            if (_data is Data && _data != null)
            {
                Data temp;
                temp = (Data)_data;
                return (temp.WordEn == this.WordEn) ? true : false;
            }
            return false;
        }


        public static int CompareByName(Data a, Data b) // Сравнение по названию
        {
            return string.Compare(a.WordEn, b.WordEn);
        }

        //public static int CompareByCategory(Record a, Record b) // Сравнение по категории
        //{
        //    if (a.Category == b.Category)
        //        return CompareByName(a, b);
        //    if (a.Category == CategoryVideo.Film)
        //        return -1;
        //    if (b.Category == CategoryVideo.Film)
        //        return 1;
        //    if (a.Category == CategoryVideo.Cartoon)
        //        return -1;
        //    if (b.Category == CategoryVideo.Cartoon)
        //        return 1;
        //    if (a.Category == CategoryVideo.Series)
        //        return -1;
        //    if (b.Category == CategoryVideo.Series)
        //        return 1;
        //    if (a.Category == CategoryVideo.Unknown)
        //        return -1;
        //    if (b.Category == CategoryVideo.Unknown)
        //        return 1;
        //    return 0;
        //}

        ////public static int CompareByScore(Record a, Record b)
        ////{
        ////    if (a.Score == b.Score)
        ////        return CompareByName(a, b);
        ////    return (int)((b.Score - a.Score) * 100);
        ////}

    }
}
