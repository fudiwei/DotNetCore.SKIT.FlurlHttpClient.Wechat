using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat
{
    public sealed class WechatHttpCallInterceptorCollection : IEnumerable<WechatHttpCallInterceptor>
    {
        private readonly IList<WechatHttpCallInterceptor> _list;

        public int Count
        {
            get { return _list.Count; }
        }

        public WechatHttpCallInterceptor this[int index]
        {
            get { return _list[index]; }
        }

        public WechatHttpCallInterceptorCollection()
        {
            _list = new List<WechatHttpCallInterceptor>();
        }

        public void Add(WechatHttpCallInterceptor interceptor)
        {
            _list.Add(interceptor);
        }

        public void Remove(WechatHttpCallInterceptor interceptor)
        {
            _list.Remove(interceptor);
        }

        public IEnumerator<WechatHttpCallInterceptor> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_list).GetEnumerator();
        }
    }
}
