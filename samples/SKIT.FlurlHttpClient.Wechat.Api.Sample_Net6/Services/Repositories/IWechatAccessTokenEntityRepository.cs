using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample.Services.Repositories
{
    public interface IWechatAccessTokenEntityRepository : IEnumerable<Models.WechatAccessTokenEntity>
    {
        void Insert(Models.WechatAccessTokenEntity entity);

        void Update(Models.WechatAccessTokenEntity entity);

        void Delete(Models.WechatAccessTokenEntity entity);
    }
}
