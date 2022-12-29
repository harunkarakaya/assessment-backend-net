using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.API.DataAccess.Context
{
    public class MongoSettings
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }

    }
}
