using _Lang_Course.CourseEngine.Classes.Courses;
using _Lang_Course.CourseEngine.Classes.Languages;
using _Lang_Course.CourseEngine.Classes.Masterings;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

#pragma warning disable SYSLIB0011

namespace _Lang_Course.CourseEngine
{
    internal class Serializer
    {
        [Serializable]
        public class Container
        {
            public int IterationId;
            // Слушатели
            public List<Listener> listeners = new();
            // Курсы
            public List<Group> groupCourses = new();
            public List<Individual> individualCourses = new();
            // Языки
            public List<English> englishLanguages = new();
            public List<Japanese> japaneseLanguages = new();
            public List<German> germanLanguages = new();
            public List<French> frenchLanguages = new();
            // Освоение
            public List<Beginner> beginnerMasterings = new();
            public List<Middle> middleMasterings = new();
            public List<Expert> expertMasterings = new();
        }

        public List<string> logs = new();

        Storage StorageCompiler(Container container)
        {
            Storage storage = new();
            storage.IterationId = container.IterationId;
            storage.Listeners = container.listeners!;
            foreach (Group group in container.groupCourses)
            {
                storage.Courses.Add(group);
                logs.Add(JsonSerializer.Serialize(group));
            }
            foreach (Individual individual in container.individualCourses)
            {
                storage.Courses.Add(individual);
                logs.Add(JsonSerializer.Serialize(individual));
            }
            foreach (English english in container.englishLanguages)
            {
                storage.Languages.Add(english);
                logs.Add(JsonSerializer.Serialize(english));
            }
            foreach(Japanese japanese in container.japaneseLanguages)
            {
                storage.Languages.Add(japanese);
                logs.Add(JsonSerializer.Serialize(japanese));
            }
            foreach(German german in container.germanLanguages)
            {
                storage.Languages.Add(german);
                logs.Add(JsonSerializer.Serialize(german));
            }
            foreach(French french in container.frenchLanguages)
            {
                storage.Languages.Add(french);
                logs.Add(JsonSerializer.Serialize(french));
            }
            foreach(Beginner beginner in container.beginnerMasterings)
            {
                storage.Masterings.Add(beginner);
                logs.Add(JsonSerializer.Serialize(beginner));
            }
            foreach(Middle middle in container.middleMasterings)
            {
                storage.Masterings.Add(middle);
                logs.Add(JsonSerializer.Serialize(middle));
            }
            foreach(Expert expert in container.expertMasterings)
            {
                storage.Masterings.Add(expert);
                logs.Add(JsonSerializer.Serialize(expert));
            }
            return storage;
        }

        Container ContainerCompiler(Storage storage)
        {
            Container container = new();
            container.listeners = storage.Listeners!;
            foreach(Course? course in storage.Courses)
            {
                switch(course!.GetType().Name)
                {
                    case "Group":
                        container.groupCourses.Add((course as Group)!);
                        break;
                    case "Individual":
                        container.individualCourses.Add((course as Individual)!);
                        break;
                }
            }
            foreach(Language? language in storage.Languages)
            {
                switch(language!.GetType().Name)
                {
                    case "English":
                        container.englishLanguages.Add((language as English)!);
                        break;
                    case "Japanese":
                        container.japaneseLanguages.Add((language as Japanese)!);
                        break;
                    case "German":
                        container.germanLanguages.Add((language as German)!);
                        break;
                    case "French":
                        container.frenchLanguages.Add((language as French)!);
                        break;
                }
            }
            foreach(Mastering? mastering in storage.Masterings)
            {
                switch(mastering!.GetType().Name)
                {
                    case "Beginner":
                        container.beginnerMasterings.Add((mastering as Beginner)!);
                        break;
                    case "Middle":
                        container.middleMasterings.Add((mastering as Middle)!);
                        break;
                    case "Expert":
                        container.expertMasterings.Add((mastering as Expert)!);
                        break;
                }
            }
            return container;
        }

        public void Save(Storage storage, string name = "CourseDB.auf")
        {
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, ContainerCompiler(storage));
            }
        }

        public Storage Read(ref List<string> logs, string name = "CourseDB.auf")
        {
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Container tempContainer = (Container)formatter.Deserialize(fs);
                logs = this.logs;
                return StorageCompiler(tempContainer);
            }
        }
    }
}
