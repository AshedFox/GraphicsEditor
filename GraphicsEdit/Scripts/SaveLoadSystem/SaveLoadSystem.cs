using SharedLib;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Scripts
{
    public class SaveLoadSystem : ISaveLoad
    {
        public ProgramData Load(string path)
        {         
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                return binaryFormatter.Deserialize(fileStream) as ProgramData;
            }
        }

        public void Save(ProgramData data, string path)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                binaryFormatter.Serialize(fileStream, data);
            }
        }
    }
}
