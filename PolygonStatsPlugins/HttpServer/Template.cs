using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonStatsPlugins.HttpServer
{
    public class Template
    {
        public static readonly string _headerTempate = System.IO.File.ReadAllText($"{Directory.GetCurrentDirectory()}{Path.DirectorySeparatorChar}HttpServer{Path.DirectorySeparatorChar}Templates{Path.DirectorySeparatorChar}header.html");

        public static readonly string _navTempate = System.IO.File.ReadAllText($"{Directory.GetCurrentDirectory()}{Path.DirectorySeparatorChar}HttpServer{Path.DirectorySeparatorChar}Templates{Path.DirectorySeparatorChar}nav.html");

        public static readonly string _footerTempate = System.IO.File.ReadAllText($"{Directory.GetCurrentDirectory()}{Path.DirectorySeparatorChar}HttpServer{Path.DirectorySeparatorChar}Templates{Path.DirectorySeparatorChar}footer.html");
    }
}
