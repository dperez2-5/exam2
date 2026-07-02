using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicTelemetryRegister
{
    public abstract class MedicalDevice
    {
        private string deviceID;
        private int batteryLife;

        public string deviceName;

        public string DeviceID
        {
            get { return deviceID; }
            set { deviceID = value; }
        }
        public int BatteryLife
        {
            get { return batteryLife; } 
            set { batteryLife = value; }
        }
        public MedicalDevice(string id, int battery, string name)
        {
            deviceID = id;
            batteryLife = battery;
            deviceName = name;
        }

        public abstract double CalculateSafetyRating();
        protected MedicalDevice(string id, string name, int battery)
        {
        }
    }   
}
