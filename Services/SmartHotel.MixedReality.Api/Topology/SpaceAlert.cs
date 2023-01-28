﻿using System.Runtime.Serialization;

namespace SmartHotel.MixedReality.Api.Topology
{
    [DataContract]
    public class SpaceAlert
    {
        [DataMember]
        public string SpaceId { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string[] AncestorSpaceIds { get; set; }
    }
}