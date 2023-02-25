using System.Text.Json;

namespace _Lang_Course.CourseEngine
{
    internal class Serializer
    {
        public static void Save(Storage storage, string name = "CourseDB.json")
        {
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, storage);
            }
        }
        public static Storage Read(string name = "CourseDB.json")
        {
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {
                return JsonSerializer.Deserialize<Storage>(fs)!;
            }
        }
    }
}
