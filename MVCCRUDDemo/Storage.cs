using MVCCRUDDemo.Models.Domain;
using System.Xml.Serialization;

namespace MVCCRUDDemo
{
    public static class Storage
    {
        private static string path = @"Friends.xml";
        public static List<Friend> friends;

        static Storage()
        {
            friends = new List<Friend>();
        }

        private static void SaveListToXmlFile()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Friend>));
            using (var writer = new StreamWriter(path))
            {
                xmlSerializer.Serialize(writer, friends);
            }
        }

        private static void DeserializeXmlFileToList()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Friend>));
            using (var reader = new StreamReader(path))
            {
                friends = xmlSerializer.Deserialize(reader) as List<Friend>;
            }
        }

        public static void UpdateOfFriends()
        {
            SaveListToXmlFile();
            DeserializeXmlFileToList();
        }
    }
}
