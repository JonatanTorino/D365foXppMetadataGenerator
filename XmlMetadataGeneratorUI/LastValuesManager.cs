using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace XmlMetadataGeneratorUI
{
    public class LastValuesManager
    {
        private const string lastValuesFileName = "LastValues.json";

        public LastValues LoadLastValues()
        {
            try
            {
                if (File.Exists(lastValuesFileName))
                {
                    var json = File.ReadAllText(lastValuesFileName);
                    return JsonConvert.DeserializeObject<LastValues>(json);
                }
                else
                {
                    File.WriteAllText(lastValuesFileName, string.Empty);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los últimos valores: " + ex.Message);
            }

            return new LastValues();
        }

        public void SaveLastValues(LastValues lastValues)
        {
            var json = JsonConvert.SerializeObject(lastValues, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(lastValuesFileName, json);
        }
    }

    public class LastValues
    {
        public string SourceFolder { get; set; }
        public string DestinationFolder { get; set; }
    }
}

