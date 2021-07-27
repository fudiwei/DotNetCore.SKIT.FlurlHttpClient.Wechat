using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NMemory;
using NMemory.Tables;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample_Net5.Services.Repositories.Implements
{
    internal class GlobalDatabase
    {
        static GlobalDatabase()
        {
            Database db = new Database();

            TableWechatAccessTokenEntity = db.Tables.Create<Models.WechatAccessTokenEntity, string>(e => e.AppId);
        }

        public static Table<Models.WechatAccessTokenEntity, string> TableWechatAccessTokenEntity { get; }
    }
}
