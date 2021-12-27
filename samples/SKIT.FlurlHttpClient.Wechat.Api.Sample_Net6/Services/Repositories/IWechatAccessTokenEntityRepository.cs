using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample_Net5.Services.Repositories
{
    public interface IWechatAccessTokenEntityRepository : IEnumerable<Models.WechatAccessTokenEntity>
    {
        void Insert(Models.WechatAccessTokenEntity entity);

        void Update(Models.WechatAccessTokenEntity entity);

        void Delete(Models.WechatAccessTokenEntity entity);
    }
}
