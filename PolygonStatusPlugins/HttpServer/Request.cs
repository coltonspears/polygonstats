﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonStatsPlugins.HttpServer
{
    public class Request
    {
        public string Type { get; set; }
        public string URL { get; set; }
        public string Host { get; set; }

        private Request(string type, string url, string host)
        {

        }
        public static Request GetRequest(String request)
        {
            if (string.IsNullOrEmpty(request)) return null;

            string[] tokens = request.Split(' ');
            return new Request("", "", "");
        }
    }
}
