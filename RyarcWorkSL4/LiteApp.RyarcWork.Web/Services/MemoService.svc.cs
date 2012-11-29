using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using LiteApp.RyarcWork.Web.Entities;
using MongoDB.Driver;
using System.Configuration;
using System.Threading;

namespace LiteApp.RyarcWork.Web.Services
{
    [ServiceContract(Namespace = "")]
    [SilverlightFaultBehavior]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class MemoService
    {
        [OperationContract]
        public List<Memo> GetMemos()
        {
            MongoServer server = MongoServer.Create(ConfigurationManager.ConnectionStrings["RyarcWork_Mongo"].ConnectionString); // connect to localhost
            var db = server.GetDatabase("RyarcWork");
            return db.GetCollection<Memo>("Memos").FindAll().ToList();
        }
    }
}
