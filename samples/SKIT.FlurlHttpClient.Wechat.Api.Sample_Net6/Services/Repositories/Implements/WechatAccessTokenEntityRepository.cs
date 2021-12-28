using System;
using System.Collections;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample.Services.Repositories.Implements
{
    public class WechatAccessTokenEntityRepository : IWechatAccessTokenEntityRepository
    {
        public void Insert(Models.WechatAccessTokenEntity entity)
        {
            entity.CreateTimestamp = DateTimeOffset.Now.ToUnixTimeSeconds();
            entity.UpdateTimestamp = entity.CreateTimestamp;
            GlobalDatabase.TableWechatAccessTokenEntity.Insert(entity);
        }

        public void Update(Models.WechatAccessTokenEntity entity)
        {
            entity.UpdateTimestamp = DateTimeOffset.Now.ToUnixTimeSeconds();
            GlobalDatabase.TableWechatAccessTokenEntity.Update(entity);
        }

        public void Delete(Models.WechatAccessTokenEntity entity)
        {
            GlobalDatabase.TableWechatAccessTokenEntity.Delete(entity);
        }

        IEnumerator<Models.WechatAccessTokenEntity> IEnumerable<Models.WechatAccessTokenEntity>.GetEnumerator()
        {
            return GlobalDatabase.TableWechatAccessTokenEntity.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GlobalDatabase.TableWechatAccessTokenEntity.GetEnumerator();
        }
    }
}
