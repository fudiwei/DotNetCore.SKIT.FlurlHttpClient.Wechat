using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Controllers
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3;

    [RoutePrefix("api/notify")]
    public class TenpayNotifyController : ApiController
    {
        private readonly Services.HttpClients.IWechatTenpayClientFactory _wechatTenpayClientFactory;

        public TenpayNotifyController(
            Services.HttpClients.IWechatTenpayClientFactory wechatTenpayClientFactory)
        {
            _wechatTenpayClientFactory = wechatTenpayClientFactory;
        }


        [HttpPost]
        [Route("m-{merchant_id}/message-push")]
        public async Task<IHttpActionResult> ReceiveMessage([FromUri(Name = "merchant_id")] string merchantId, CancellationToken cancellationToken)
        {
            using (var stream = await Request.Content.ReadAsStreamAsync())
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                string timestamp = Request.Headers.Contains("Wechatpay-Timestamp") ? Request.Headers.GetValues("Wechatpay-Timestamp").First() : null;
                string nonce = Request.Headers.Contains("Wechatpay-Nonce") ? Request.Headers.GetValues("Wechatpay-Nonce").First() : null;
                string signature = Request.Headers.Contains("Wechatpay-Signature") ? Request.Headers.GetValues("Wechatpay-Signature").First() : null;
                string serialNumber = Request.Headers.Contains("Wechatpay-Serial") ? Request.Headers.GetValues("Wechatpay-Serial").First() : null;
                string content = await reader.ReadToEndAsync();
                Debug.WriteLine("接收到微信支付推送的数据：{0}", content);

                using (var client = _wechatTenpayClientFactory.Create(merchantId))
                {
                    bool valid = client.VerifyEventSignature(
                        webhookTimestamp: timestamp,
                        webhookNonce: nonce,
                        webhookBody: content,
                        webhookSignature: signature,
                        webhookSerialNumber: serialNumber
                    );
                    if (!valid)
                    {
                        // NOTICE:
                        //   需提前注入 CertificateManager、并下载平台证书，才可以使用扩展方法执行验签操作。
                        //   请参考本示例项目 TenpayCertificateRefreshingBackgroundService 后台任务中的相关实现。
                        //
                        //   2024-10-01 后微信支付新增了基于微信支付公钥的验证身份方式，
                        //   如果你已切换至使用平台公钥，则使用 PublicKeyManager 替代 CertificateManager，不再需要下载平台证书。
                        //
                        //   有关 CertificateManager/PublicKeyManager 的完整介绍请参阅《开发文档 / 基础用法 / 如何验证回调通知事件签名？》。
                        //   后续如何解密并反序列化，请参阅《开发文档 / 基础用法 / 如何解密回调通知事件中的敏感数据？》。

                        return Json(new { code = "FAIL", message = "验签失败" });
                    }

                    var callbackModel = client.DeserializeEvent(content);
                    var eventType = callbackModel.EventType?.ToUpper();
                    switch (eventType)
                    {
                        case "TRANSACTION.SUCCESS":
                            {
                                var callbackResource = client.DecryptEventResource<Events.TransactionResource>(callbackModel);
                                Debug.WriteLine("接收到微信支付推送的订单支付成功通知，商户订单号：{0}", callbackResource.OutTradeNumber);
                                // 后续处理略
                            }
                            break;

                        default:
                            {
                                // 其他情况略
                            }
                            break;
                    }

                    return Json(new { code = "SUCCESS", message = "成功" });
                }
            }
        }
    }
}
