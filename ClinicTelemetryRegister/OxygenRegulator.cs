using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicTelemetryRegister
{
    public class OxygenRegulator : MedicalDevice
    {
        public double FlowRateLiters { get; set; }

        public OxygenRegulator(string id, string name, int battery, double flow)
            : base(id, name, battery)
        {
            FlowRateLiters = flow;
        }

        public override double CalculateSafetyRating()
        {
            return (BatteryLife * 0.95) - (FlowRateLiters * 1.2);
        }
    }
}
