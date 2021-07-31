using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample_Net5.Models
{
    public class CreateRefundRequest
    {
        public string MerchantId { get; set; } = default!;

        public string TransactionId { get; set; } = default!;

        // NOTICE: 单机演示时金额来源于客户端请求，生产项目请替换成服务端获取生成
        public int OrderAmount { get; set; }

        public int RefundAmount { get; set; }
    }
}
