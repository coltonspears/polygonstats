using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using PolygonStats.Common.Proto;

namespace PolygonStats.Common
{
    public class Payload
    {
        public int type { get; set; }
        public string proto { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public long timestamp { get; set; }
        public string token { get; set; }

        public int level { get; set; }


        public string account_name { get; set; }
        public string account_id { get; set; }

        public byte[] getDate()
        {
            return Convert.FromBase64String(proto);
        }
        public Method getMethodType()
        {
            return (Method)type;
        }
    }

    public class MessageObject
    {
        public List<Payload> payloads { get; set; }
        public string key { get; set; }
    }
}
