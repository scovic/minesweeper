using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Ekstenzije
{
    public static class Ekstenzije
    {

        public static string Serialize<T>(this T value)
        {
            if (value == null)
            {
                return String.Empty;
            }
            try
            {
                var xmlserializer = new XmlSerializer(typeof(T));
                var stringWriter = new StringWriter();
                using(var writer = XmlWriter.Create(stringWriter))
                {
                    writer.Settings.Indent = true;
                    xmlserializer.Serialize(writer, value);
                    return stringWriter.ToString();
                }
            }
            catch (Exception e)
            {
                throw new Exception("New error ocured!", e);
            }
        }

        public static bool Serialize<T>(this T value, string path)
        {
            if(value == null)
            {
                return false;
            }

            try
            {
                var xmlserializer = new XmlSerializer(typeof(T));

                using(var filewriter = new FileStream(path, FileMode.Create))
                {
                    xmlserializer.Serialize(filewriter, value);

                }
                return true;

            }
            catch(Exception e)
            {
                throw new Exception("Greska neka" + e.ToString());
            }

        }

        public static T Deserialize<T>(this T value, string path)
        {
            T type;

            var serializer = new XmlSerializer(typeof(T));

            using (var fileWriter = XmlReader.Create(path))
            {
                type = (T)serializer.Deserialize(fileWriter);
            }

            return type;
        }
    }
}
