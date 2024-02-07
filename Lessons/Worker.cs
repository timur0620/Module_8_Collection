using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
//Install - Package Newtonsoft.Json - Version 10.0.3
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Module_7_Class.HomeWork.HomeWork.Structures
{
    public struct Worker
    {
        public int id { get; set; }
        public DateTime dateRegistration { get; set; }
        public string fullName { get; set; }
        public byte age { get; set; }
        public byte height { get; set; }
        public DateTime dateBirth { get; set; }
        public string placeBirth { get; set; }

        public string GetPath()
        {
            return "F:\\c#Projects\\Module_8_Collection\\Lessons\\DB\\testXML.xml";
        }

        public Worker(int id, DateTime dateRegistration, string fullName,
                      byte age, byte height, DateTime dateBirth, string placeBirth)
        {
            this.id = id;
            this.dateRegistration = dateRegistration;
            this.fullName = fullName;
            this.age = age;
            this.height = height;
            this.dateBirth = dateBirth;
            this.placeBirth = placeBirth;
        }
        public void SerializeWorkerXML(List<Worker> worker, string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));

            Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write);

            xmlSerializer.Serialize(fStream, worker);

            fStream.Close();
        }
        public  Worker DESerializeWorkerXML(string path)
        {   
            Worker tempW = new Worker();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));

            Stream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            //tempW = xmlSerializer.Deserialize(fStream) as Worker;
        
            fStream.Close();

            return tempW;
        }
        public void SerializeListWorkerXML(Worker worker, string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Worker>));

            Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write);

            xmlSerializer.Serialize(fStream, worker);

            fStream.Close();
        }
        public List<Worker> DESerializeListWorkerXML(string path)
        {
            List<Worker> tempW = new List<Worker>();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));

            Stream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            tempW = xmlSerializer.Deserialize(fStream) as List<Worker>;

            fStream.Close();

            return tempW;
        }
        public void SerializeWorkerJSON(Worker worker, string path)
        {
            string json = JsonConvert.SerializeObject(worker);

            File.WriteAllText(path, json);           
        }
        public Worker DESerializeWorkerJSON(string path)
        {
            Worker tempW = new Worker();

            string json = File.ReadAllText(path);

            tempW = JsonConvert.DeserializeObject<Worker>(json);

            return tempW;
        }
        public void SerializeWorkerListJSON(List<Worker> worker, string path)
        {
            string json = JsonConvert.SerializeObject(worker);

            File.WriteAllText(path, json);
        }
        public List<Worker> DESerializeWorkerListJSON(string path)
        {
            List<Worker> tempW = new List<Worker>();

            string json = File.ReadAllText(path);

            tempW = JsonConvert.DeserializeObject<List<Worker>>(json);

            return tempW;
        }
        public void CreateJson()
        {
            List<Worker> list = new List<Worker>();
            JObject data = new JObject();
            JObject jarray = new JObject();

            data["name"] = "name";
            data["description"] = "description";
            data["url"] = "url";
            jarray.Add(data);
        }
    }
}
