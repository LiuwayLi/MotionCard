using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotionCard.Core.Definitions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MotionCard.Core
{
    public class CalibrationPositionReader
    {
        private CalibrationPositionReader() 
        { 

        }


        public static CalibrationPositionReader Instance { get; } = new CalibrationPositionReader();
        private Dictionary<string, Dictionary<string,CalibrationPosition>> _calibrationPositioninfos = new Dictionary<string, Dictionary<string, CalibrationPosition>>();

        public void Load(string file, Encoding encoding)
        {
            JObject keyValuePairs = JObject.Parse(File.ReadAllText(file, encoding));
            foreach (var item in keyValuePairs.Properties())
            {
                if (_calibrationPositioninfos.ContainsKey(item.Name))
                {
                    _calibrationPositioninfos[item.Name] = new Dictionary<string, CalibrationPosition>() { { item.Value.ToObject<CalibrationPosition>().PositionName, item.Value.ToObject<CalibrationPosition>() } };
                }
                else
                {
                    _calibrationPositioninfos[item.Name][item.Value.ToObject<CalibrationPosition>().PositionName] = item.Value.ToObject<CalibrationPosition>();
                }
            }
        }

        public void Save(string file, Encoding encoding)
        {
            Dictionary<string, List<CalibrationPosition>> keyValuePairs = new Dictionary<string, List<CalibrationPosition>>();
            foreach (string axis in _calibrationPositioninfos.Keys)
            {
                keyValuePairs[axis] = _calibrationPositioninfos[axis].Values.ToList();
            }
            string json = JsonConvert.SerializeObject(keyValuePairs);
            File.WriteAllText(file, json, encoding);
        }

        public double GetCalibrationPositionValue(string calibrationPositionName, string axisName)
        {
            return _calibrationPositioninfos[axisName][calibrationPositionName].PositionValue;
        }

    }
}
