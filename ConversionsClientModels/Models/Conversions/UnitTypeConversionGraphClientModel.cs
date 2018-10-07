﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Chimerical.Conversions.ClientModels.Models.Conversions
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class UnitTypeConversionGraphClientModel
    {
        public UnitTypeClientModel UnitType;

        public Dictionary<string, Dictionary<string, double>> ConversionGraph;
    }
}
