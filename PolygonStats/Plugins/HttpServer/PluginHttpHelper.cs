using PolygonStats.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolygonStats.Plugins
{
    class PluginHttpHelper
    {
        private static readonly string data =
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

        public static readonly string HeaderTempate = System.IO.File.ReadAllText(@"C:\Users\colto\source\repos\polygonstats\PolygonStats\Plugins\HttpServer\Templates\header.html");

        public static readonly string NavTempate = System.IO.File.ReadAllText(@"C:\Users\colto\source\repos\polygonstats\PolygonStats\Plugins\HttpServer\Templates\nav.html");

        public static readonly string FooterTempate = System.IO.File.ReadAllText(@"C:\Users\colto\source\repos\polygonstats\PolygonStats\Plugins\HttpServer\Templates\footer.html");

        public static string getData()
        {
            StringBuilder sb = new();
            sb.Append(HeaderTempate);
            sb.Append(NavTempate);

            sb.Append("<table id=\"plugins\" class=\"display\" style=\"width:100%\">");
            sb.Append(getPluginTableHeader());
            sb.Append("<tbody>");
            foreach (Plugin plugin in PluginManager.Shared.Plugins.Values)
            {
                sb.AppendLine(getPluginEntry(plugin));
            }
            sb.Append("</tbody>");
            sb.Append("</table>");
            sb.Append(FooterTempate);
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

        public static string getTableEntry(string accName, Stats stat, bool isAdmin)
        {
            StringBuilder sb = new();
            sb.Append("<tr>");
            sb.Append("<td style=\"padding: 0px 10px 0px 10px;\">");
            sb.Append(getName(isAdmin, stat));
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center\">");
            sb.Append(stat.CaughtPokemon.ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center\">");
            sb.Append(stat.FleetPokemon.ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center\">");
            sb.Append(stat.ShinyPokemon.ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center\">");
            sb.Append(stat.SpinnedPokestops.ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
            sb.Append(stat.XpPerHour.ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
            sb.Append(stat.XpPerDay.ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
            sb.Append(stat.XpTotal.ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
            sb.Append(stat.StardustPerHour.ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
            sb.Append(stat.StardustPerDay.ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
            sb.Append(stat.StardustTotal.ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
            sb.Append(stat.CaughtPokemonPerDay.ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
            sb.Append(stat.SpinnedPokestopsPerDay.ToString());
            sb.Append("</td>");
            if (isAdmin)
            {
                sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
                sb.Append($"<form method=\"post\" action=\"remove-{stat.AccountName}\"><input type=\"submit\" value=\"Remove\"> </form>");
                sb.Append("</td>");
            }
            sb.Append("</tr>");

            return sb.ToString();
        }

        public static string getAverageTableEntry()
        {
            Dictionary<string, Stats> dic = StatManager.sharedInstance.getAllEntries();

            StringBuilder sb = new();
            // Add a black line
            sb.AppendLine("<tr style=\"border-bottom: 1px solid black\">" +
                "<td style=\"border-bottom: 1px solid black\"/>" +
                "<td style=\"border-bottom: 1px solid black\"/>" +
                "<td style=\"border-bottom: 1px solid black\"/>" +
                "<td style=\"border-bottom: 1px solid black\"/>" +
                "<td style=\"border-bottom: 1px solid black\"/>" +
                "<td style=\"border-bottom: 1px solid black\"/>" +
                "<td style=\"border-bottom: 1px solid black\"/>" +
                "<td style=\"border-bottom: 1px solid black\"/>" +
                "<td style=\"border-bottom: 1px solid black\"/>" +
                "<td style=\"border-bottom: 1px solid black\"/>" +
                "<td style=\"border-bottom: 1px solid black\"/>" +
                "<td style=\"border-bottom: 1px solid black\"/>" +
                "<td style=\"border-bottom: 1px solid black\"/></tr>");

            sb.Append("<tr>");
            sb.Append("<td style=\"padding: 0px 10px 0px 10px;\">");
            sb.Append("Average Stats");
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center\">");
            sb.Append((dic.Values.Sum(s => s.CaughtPokemon) / dic.Values.Count).ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center\">");
            sb.Append((dic.Values.Sum(s => s.FleetPokemon) / dic.Values.Count).ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center\">");
            sb.Append((dic.Values.Sum(s => s.ShinyPokemon) / dic.Values.Count).ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center\">");
            sb.Append((dic.Values.Sum(s => s.SpinnedPokestops) / dic.Values.Count).ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
            sb.Append((dic.Values.Sum(s => s.XpPerHour) / dic.Values.Count).ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
            sb.Append((dic.Values.Sum(s => s.XpPerDay) / dic.Values.Count).ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
            sb.Append((dic.Values.Sum(s => s.XpTotal) / dic.Values.Count).ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
            sb.Append((dic.Values.Sum(s => s.StardustPerHour) / dic.Values.Count).ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
            sb.Append((dic.Values.Sum(s => s.StardustPerDay) / dic.Values.Count).ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
            sb.Append((dic.Values.Sum(s => s.StardustTotal) / dic.Values.Count).ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
            sb.Append((dic.Values.Sum(s => s.CaughtPokemonPerDay) / dic.Values.Count).ToString());
            sb.Append("</td>");
            sb.Append("<td style=\"text-align:center; padding: 0px 5px 0px 5px;\">");
            sb.Append((dic.Values.Sum(s => s.SpinnedPokestopsPerDay) / dic.Values.Count).ToString());
            sb.Append("</td>");
            sb.Append("</tr>");

            return sb.ToString();
        }

        private static string getName(bool isAdmin, Stats stat)
        {
            if(isAdmin || ConfigurationManager.Shared.Config.Http.ShowAccountNames)
            {
                return stat.AccountName;
            }
            return $"{stat.AccountName.Substring(0, 2)}XXXXXX{stat.AccountName.Substring(stat.AccountName.Length-2, 2)}";
        }
    }
}
