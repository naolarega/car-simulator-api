﻿using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace car_simulator_api.Options
{
    public class GeneralOption
    {
        public static string? SqlServerConnectionString => ConfigurationManager.ConnectionStrings["CarSimulatorApiDB"].ConnectionString;
    }
}
