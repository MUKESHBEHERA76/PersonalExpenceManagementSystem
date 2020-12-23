using EntityLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Database
    {
        public static List<Entity> entity = new List<Entity>();
        // Serializing Budget Details
        public static void ListSerialize(Entity entities)
        {
            entity.Add(entities);
            string path = @"C:\Users\MUKESH KUMAR BEHERA\Desktop\Office Project\PersonalExpenceManagemetSystem\Result.txt";
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = File.Open(path, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, entities);
            stream.Close();
        }
        public static List<Entity> ListDeserializer()
        {
            string path = @"C:\Users\MUKESH KUMAR BEHERA\Desktop\Office Project\PersonalExpenceManagemetSystem\Result.txt";
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = File.Open(path, FileMode.Open, FileAccess.Read);
            List<Entity> entities = (List<Entity>)formatter.Deserialize(stream);
            stream.Close();
            return entities;
        }
    }
}
