using PolygonStatsPlugins.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PolygonStatsPlugins.HttpServer
{
    class PluginHttpHelper
    {



        public static string GetData()
        {
            StringBuilder sb = new();
            sb.Append(Template._headerTempate);
            sb.Append(Template._navTempate);

            sb.Append("<table id=\"plugins\" class=\"display\" style=\"width:100%\">");
            sb.Append(GetPluginTableHeader());
            sb.Append("<tbody>");
            foreach (Plugin plugin in PluginManager.Shared.Plugins.Values)
            {
                sb.AppendLine(GetPluginEntry(plugin));
            }
            sb.Append("</tbody>");
            sb.Append("</table>");
            sb.Append(Template._footerTempate);
            return sb.ToString();
        }

        public static string GetPluginTableHeader()
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
        public static string GetPluginEntry(Plugin plugin)
        {
            StringBuilder sb = new();
            sb.Append("<tr>");
            //sb.Append($"<td>{plugin.GUID}</td>");
            sb.Append($"<td><a href=\"{plugin.Name}\">{plugin.Name}</a></td>");
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
