using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WindowMover.Classes
{
    public static class Helpers
    {
        public static byte[] ObjectToByteArray(Object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        // Convert a byte array to an Object
        public static Object ByteArrayToObject(byte[] arrayOfBytes)
        {
            if (arrayOfBytes != null)
            {
                using (var memStream = new MemoryStream())
                {
                    var binForm = new BinaryFormatter();
                    memStream.Write(arrayOfBytes, 0, arrayOfBytes.Length);
                    memStream.Seek(0, SeekOrigin.Begin);
                    var obj = binForm.Deserialize(memStream);
                    return obj;
                }
            }
            else
                return null;
        }

        public static Stream GenerateStreamFromByteArray(byte[] s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        //Convert a byte array to a File
        public static bool ByteArrayToFile(string fileName, byte[] arrayOfBytes)
        {
            try
            {
                // Open file for reading
                FileStream fileStream = new System.IO.FileStream(fileName, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                fileStream.Write(arrayOfBytes, 0, arrayOfBytes.Length);
                fileStream.Close();

                return true;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Błąd podczas zapisu pliku: {0}", exp.ToString());
            }

            return false;
        }

        //Convert a byte array to a File
        public static byte[] FileToByteArray(string fileName)
        {
            try
            {
                // Open file for reading
                FileStream fileStream = new System.IO.FileStream(fileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] byteArrayOfFile = new byte[fileStream.Length];
                fileStream.Read(byteArrayOfFile, 0, Convert.ToInt32(fileStream.Length));
                fileStream.Close();

                return byteArrayOfFile;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Błąd podczas otwierania pliku: {0}", exp.ToString());
            }

            return null;
        }

        public static List<Classes.WindowHandler> ByteArrayToWindowHandler(byte[] dane)
        {
            List<Classes.WindowHandler> windowHandlers = new List<Classes.WindowHandler>();

            windowHandlers = (List<Classes.WindowHandler>)Helpers.ByteArrayToObject(dane);

            return windowHandlers;
        }

        public static byte[] WindowHandlersToByteArray(List<Classes.WindowHandler> windowhandlers)
        {
            byte[] data = Helpers.ObjectToByteArray(windowhandlers);

            return data;
        }

        public static void CopyProperties(this WindowHandler source, WindowHandler destination)
        {
            // Iterate the Properties of the destination instance and  
            // populate them from their source counterparts  
            PropertyInfo[] destinationProperties = destination.GetType().GetProperties();
            foreach (PropertyInfo destinationPi in destinationProperties)
            {
                PropertyInfo sourcePi = source.GetType().GetProperty(destinationPi.Name);
                destinationPi.SetValue(destination, sourcePi.GetValue(source, null), null);
            }
        }
    }
}
