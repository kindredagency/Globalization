using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace Framework.AssetLibrary.Globalization
{
    internal static class Utility
    {
        internal static byte[] LoadResourceFile(string fileName)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();

            string resourceName = currentAssembly.GetName().Name + ".Resources." + fileName;

            if (currentAssembly.GetManifestResourceNames().Contains(resourceName))
            {
                Stream manifestStream = currentAssembly.GetManifestResourceStream(resourceName);

                if (manifestStream != null)
                {
                    byte[] fileContent = new  byte[manifestStream.Length];

                    using (BinaryReader reader = new BinaryReader(manifestStream))
                    {
                        fileContent = reader.ReadBytes(fileContent.Length);
                    }

                    return fileContent;
                }
            }

            return null;
        }

        internal static XDocument LoadDataFile(string fileName)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            string resourceName = currentAssembly.GetName().Name + ".Data." + fileName;

            if (currentAssembly.GetManifestResourceNames().Contains(resourceName))
            {
                Stream manifestStream = currentAssembly.GetManifestResourceStream(resourceName);

                if (manifestStream != null)
                {
                    using (StreamReader reader = new StreamReader(manifestStream))
                    {
                        XDocument xDocument = XDocument.Parse(reader.ReadToEnd());

                        return xDocument;
                    }
                }
               
            }

            return null;
        }
    }
}
