namespace SerialisationApp {
    internal class Program {
        static string path =
             Environment.GetFolderPath(
                 Environment.SpecialFolder.MyDocuments );
        static void Main( string[] args ) {
            Trainee trainee = new Trainee {
                FirstName = "Philip",
                LastName = "Windridge",
                SpartaNo = 100
            };
            Course eng152 = new Course {
                Title = "Engineering 152",
                Subject = "C# Development"
            };
            eng152.AddTrainee( trainee );
            eng152.AddTrainee( new Trainee { FirstName = "Laura", LastName = "Tozer", SpartaNo = 1 } );

            var serialiser = new SerialiserXML();
            var serialiserJson = new SerialiserJson();

            string fullTraineePathXML = path + "\\Trainee.xml";
            string fullCoursePathhXML = path + "\\course.xml";

            Serialise( trainee, serialiser, fullTraineePathXML );
            Trainee traineeDeserialisedXML = Deserialise<Trainee>( serialiser, fullTraineePathXML );
            Serialise( eng152, serialiser, fullCoursePathhXML );
            Course courseXML = Deserialise<Course>( serialiser, fullCoursePathhXML );

            string fullTraineePathJson = path + "\\Trainee.json";
            string fullCoursePathhJson = path + "\\course.json";
            Serialise( trainee, serialiserJson, fullTraineePathJson );
            Trainee traineeDeserialisedJson = Deserialise<Trainee>( serialiserJson, fullTraineePathJson );
            Serialise( eng152, serialiserJson, fullCoursePathhJson );
            Course courseJson = Deserialise<Course>( serialiserJson, fullCoursePathhJson );

            Console.WriteLine( traineeDeserialisedXML );
            Console.WriteLine( courseXML );

            Console.WriteLine( traineeDeserialisedJson );
            Console.WriteLine( courseJson );


            static T Deserialise<T>( ISerialiser serialiserJson, string fromPath ) {
                return serialiserJson.Deserialise<T>( fromPath );
            }
        }

        private static void Serialise<T>( T serialisable, ISerialiser serialiser, string toPath ) {
            serialiser.Serialise( serialisable, toPath );
        }
    }
}