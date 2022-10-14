using System;
using static System.Linq.Queryable;
using static System.Linq.Enumerable;
using Microsoft.EntityFrameworkCore;

namespace PolygonStatsPlugins
{
    public class MySQLConnectionManager
    {
        public MySQLContext GetContext() {
            return new MySQLContext();
        }        
    }
}
