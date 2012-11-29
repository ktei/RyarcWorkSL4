using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace LiteApp.RyarcWork.Web.Entities
{
    public class Memo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public ISet<string> Keys
        {
            get;
            set;
        }

        public BsonDocument Values
        {
            get;
            set;
        }

        public DateTime LastModifiedDate { get; set; }
    }
}