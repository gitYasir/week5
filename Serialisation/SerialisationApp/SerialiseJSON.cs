using Newtonsoft.Json;

namespace SerialisationApp {
    public class SerialiserJson : ISerialiser {
        public T Deserialise<T>( string fromPath ) {
            string jsonString = File.ReadAllText( fromPath );
            return JsonConvert.DeserializeObject<T>( jsonString );
        }

        public void Serialise<T>( T item, string toPath ) {
            string jsonString = JsonConvert.SerializeObject( item );
            File.WriteAllText( toPath, jsonString );
        }
    }
}