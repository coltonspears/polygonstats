using PolygonStatsPlugins.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolygonStatsPlugins.HttpServer
{
    class PluginHttpHelper
    {
        private static readonly string _data =
            "<!DOCTYPE>" +
            "<html>" +
            "  <head>" +
            "    <title>Polygon Stats</title>" +
            "  </head>" +
            "  <body>" +
            "    <table style=\"border-collapse: collapse;\">" +
            "       <tr>" +
            "           <th style=\"text-align:center; padding: 0px 5px 0px 5px;\">" +
            "               Plugin Name" +
            "           </th>" +
            "           <th style=\"text-align:center; padding: 0px 5px 0px 5px;\">" +
            "               Version" +
            "           </th>" +
            "           <th style=\"text-align:center; padding: 0px 5px 0px 5px;\">" +
            "               Escaped Pokemon" +
            "           </th>" +
            "           <th style=\"text-align:center; padding: 0px 5px 0px 5px;\">" +
            "               Shiny Pokemon" +
            "           </th>" +
            "           <th style=\"text-align:center; padding: 0px 5px 0px 5px;\">" +
            "               Spinned Pokestops" +
            "           </th>" +
            "           <th style=\"text-align:center; padding: 0px 5px 0px 5px;\">" +
            "               XP/h" +
            "           </th>" +
            "           <th style=\"text-align:center; padding: 0px 5px 0px 5px;\">" +
            "               XP/Day" +
            "           </th>" +
            "           <th style=\"text-align:center; padding: 0px 5px 0px 5px;\">" +
            "               XP Total" +
            "           </th>" +
            "           <th style=\"text-align:center; padding: 0px 5px 0px 5px;\">" +
            "               Stardust/h" +
            "           </th>" +
            "           <th style=\"text-align:center; padding: 0px 5px 0px 5px;\">" +
            "               Stardust/Day" +
            "           </th>" +
            "           <th style=\"text-align:center; padding: 0px 5px 0px 5px;\">" +
            "               Stardust Total" +
            "           </th>" +
            "           <th style=\"text-align:center; padding: 0px 5px 0px 5px;\">" +
            "               Caught Pokemon / Day" +
            "           </th>" +
            "           <th style=\"text-align:center; padding: 0px 5px 0px 5px;\">" +
            "               Spinned Pokestops / Day" +
            "           </th>" +
            "           <th style=\"text-align:center; padding: 0px 5px 0px 5px;\">" +
            "              " +
            "           </th>" +
            "       </tr>" +
            "{0}" +
            "    </table>" +
            "  <br />" +
            "  <br />" +
            "  Support my work by clicking <a href=\"https://paypal.me/pools/c/8nDB1mCCQz\">here.</a>" +
            "  </body>" +
            "</html>";

        public static readonly string _headerTempate = System.IO.File.ReadAllText(@"C:\Users\colto\source\repos\polygonstats\PolygonStatsPlugins\HttpServer\Templates\header.html");

        public static readonly string _navTempate = System.IO.File.ReadAllText(@"C:\Users\colto\source\repos\polygonstats\PolygonStatsPlugins\HttpServer\Templates\nav.html");

        public static readonly string _footerTempate = System.IO.File.ReadAllText(@"C:\Users\colto\source\repos\polygonstats\PolygonStatsPlugins\HttpServer\Templates\footer.html");

        public static string getData()
        {
            StringBuilder sb = new();
            sb.Append(_headerTempate);
            sb.Append(_navTempate);

            sb.Append("<table id=\"plugins\" class=\"display\" style=\"width:100%\">");
            sb.Append(getPluginTableHeader());
            sb.Append("<tbody>");
            foreach (Plugin plugin in PluginManager.Shared.Plugins.Values)
            {
                sb.AppendLine(getPluginEntry(plugin));
            }
            sb.Append("</tbody>");
            sb.Append("</table>");
            sb.Append(_footerTempate);
            return sb.ToString();
        }

        public static string getPluginTableHeader()
        {
            StringBuilder sb = new();
            sb.Append("<thead>");
            sb.Append("<tr>");
            sb.Append("<th>Plugin Name</th>");
            sb.Append("<th>Version</th>");
            sb.Append("<th>Assembly</th>");
            sb.Append("<th>Assembly Location</th>");
            sb.Append("<th>Enabled</th>");
            sb.Append("<th>Logs</th>");
            sb.Append("</tr>");
            sb.Append("</thead>");
            return sb.ToString();
        }
        public static string getPluginEntry(Plugin plugin)
        {
            StringBuilder sb = new();
            sb.Append("<tr>");
            //sb.Append($"<td>{plugin.GUID}</td>");
            sb.Append($"<td><a href=\"plugin\\6\">{plugin.Name}</a></td>");
            sb.Append($"<td>{plugin.Version}</td>");
            sb.Append($"<td>{plugin.AssemblyName}</td>");
            sb.Append($"<td>{plugin.AssemblyLocation}</td>");
            sb.Append($"<td><label class=\"switch\"><input type =\"checkbox\"");
            if(plugin.Enabled)
                sb.Append($" checked");
            sb.Append($"><span class=\"slider round\"></span</label></td>");
            sb.Append($"<td><button type=\"button\" class=\"btn btn-primary\">View</button> <button class=\"btn btn-danger\">Delete</button></td>");
            sb.Append("</tr>");
            return sb.ToString();
        }
    }
}
