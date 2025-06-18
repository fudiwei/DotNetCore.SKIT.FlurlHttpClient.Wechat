using NMemory;
using NMemory.Tables;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample.Services.Repositories.Implements
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
