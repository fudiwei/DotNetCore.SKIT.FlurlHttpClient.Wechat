using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample_Net5.Models
{
    public class CreateOrderByJsapiRequest
    {
        public string MerchantId { get; set; } = default!;

        public string AppId { get; set; } = default!;

        public string OpenId { get; set; } = default!;

        // NOTICE: 单机演示时金额来源于客户端请求，生产项目请替换成服务端计算生成
        public int Amount { get; set; }
    }
}
