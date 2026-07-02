using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicTelemetryRegister
{
  class DataBaseHelper
    {
        public static string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=ClinicDeviceDB;
            Integrated Security=True";
    }
}
