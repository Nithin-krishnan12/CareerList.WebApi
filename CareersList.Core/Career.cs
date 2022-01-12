using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareersList.Core
{
  public class Career
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string id { get; set; }
        public string Postname { get; set; }
        public string Description { get; set; }
        public int PostNo { get; set; }
        public string PostType { get; set; }
    }
}
