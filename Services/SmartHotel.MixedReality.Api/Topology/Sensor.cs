﻿namespace SmartHotel.MixedReality.Api.Topology
{
    public class Sensor
    {
        public string id { get; set; }
        public int dataTypeId { get; set; }
        public string dataType { get; set; }
        public int dataSubtypeId { get; set; }
        public string dataSubtype { get; set; }
        public int typeId { get; set; }
        public string type { get; set; }
        public string spaceId { get; set; }
        public string deviceId { get; set; }
    }
}