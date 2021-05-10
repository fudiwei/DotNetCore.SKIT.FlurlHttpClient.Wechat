using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class WechatTenpayExecuteBillTests
    {
        [Fact(DisplayName = "[GET] /bill/tradebill")]
        public async Task GetBillTradeBillTest()
        {
            var request = new Models.GetBillTradeBillRequest()
            {
                BillDateString = "2021-04-05"
            };
            var response = await TestClients.Instance.ExecuteGetBillTradeBillAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.HashType);
            Assert.NotNull(response.HashValue);
            Assert.NotNull(response.DownloadUrl);
        }

        [Fact(DisplayName = "[GET] /bill/fundflowbill")]
        public async Task GetBillFundflowBillTest()
        {
            var request = new Models.GetBillFundflowBillRequest()
            {
                BillDateString = DateTimeOffset.Now.AddDays(-1).ToString("yyyy-MM-dd")
            };
            var response = await TestClients.Instance.ExecuteGetBillFundflowBillAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.HashType);
            Assert.NotNull(response.HashValue);
            Assert.NotNull(response.DownloadUrl);
        }

        [Fact(DisplayName = "[GET] /billdownload/file")]
        public async Task DownloadBillFileTest()
        {
            var request = new Models.DownloadBillFileRequest()
            {
                DownloadUrl = "https://api.mch.weixin.qq.com/v3/billdownload/file?token=FAKE_TOKEN"
            };
            var response = await TestClients.Instance.ExecuteDownloadBillFileAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotEmpty(response.RawBytes);
        }
    }
}
