using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotionCard.Core
{
    public class WorkLevelReader
    {
        private Dictionary<string, int> _diWorkLevel = new Dictionary<string, int>();
        private Dictionary<string, int> _doWorkLevel = new Dictionary<string, int>();
        private WorkLevelReader() { }
        public static WorkLevelReader Instance { get; } = new WorkLevelReader();

        public void Load(string file, Encoding encoding)
        {
            JObject root = JObject.Parse(File.ReadAllText(file, encoding));
            JObject diJObject = root["DigitalInput"] as JObject;
            JObject doJObject = root["DigitalOutput"] as JObject;
            foreach (JProperty item in diJObject.Properties())
            {
                _diWorkLevel[item.Name] = (int)(item.Value as JValue);
            }
            foreach (JProperty item in doJObject.Properties())
            {
                _doWorkLevel[item.Name] = (int)(item.Value as JValue);
            }
        }

        public int GetDIWorkLevel(string diName)
        {
            return _diWorkLevel[diName];
        }

        public void SetDIWorkLevel(string diName,int workLevel)
        {
            _diWorkLevel[diName] = workLevel;
        }

        public void SetDOWorkLevel(string doName, int workLevel)
        {
            _doWorkLevel[doName] = workLevel;
        }

        public int GetDOWorkLevel(string doName)
        {
            return _doWorkLevel[doName];
        }

        public void Save(string file, Encoding encoding)
        {
            string json = JsonConvert.SerializeObject(new { DigitalInput = _diWorkLevel, DigitalOutput = _doWorkLevel },Formatting.Indented);
            File.WriteAllText(file, json, encoding);
        }
    }
}
