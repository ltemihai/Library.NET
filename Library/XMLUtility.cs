using System;
using System.IO;
using System.Xml.Serialization;

namespace Library
{
    class XMLUtility<T> where T : class
    {
        public static void SaveData(T type, string filename)
        {

            XmlSerializer serializer = new XmlSerializer(type.GetType());
            using (FileStream fileStream = new FileStream(Environment.CurrentDirectory + filename, FileMode.Create,
                FileAccess.Write))
            {
                serializer.Serialize(fileStream, type);
            }
        }

        public static T ReadData(string filename)
        {
            T type;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream fileStream = new FileStream(Environment.CurrentDirectory + filename, FileMode.Open,
                FileAccess.Read))
            {
                type = serializer.Deserialize(fileStream) as T;
            }
            return type;
        }

    }
}
