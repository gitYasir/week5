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

            var serialiserJson = new SerialiserJson();

            string fullTraineePathXML = path + "\\Trainee.json";
            Serialise( trainee, serialiserJson, fullTraineePathXML );
            Trainee traineeDeserialisedJson = Deserialise<Trainee>( serialiserJson, fullTraineePathXML );
            Serialise( eng152, serialiserJson, fullTraineePathXML );
            Course course = Deserialise<Course>( serialiserJson, fullTraineePathXML );

            Console.WriteLine( traineeDeserialisedJson );
            Console.WriteLine( course );


            static T Deserialise<T>( ISerialiser serialiserJson, string fromPath ) {
                return serialiserJson.Deserialise<T>( fromPath );
            }
        }

        private static void Serialise<T>( T serialisable, ISerialiser serialiser, string toPath ) {
            serialiser.Serialise( serialisable, toPath );
        }
    }
}