using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicTelemetryRegister
{
    public class CardiacMonitor : MedicalDevice
    {
        public int AttachedSensorCount { get; set; }

        public CardiacMonitor(string id, string name, int battery, int sensors)
            : base(id, name, battery)
        {
            AttachedSensorCount = sensors;
        }

        public override double CalculateSafetyRating()
        {
            return (BatteryLife * 0.85) + (AttachedSensorCount * 2.5);
        }
    }
}
