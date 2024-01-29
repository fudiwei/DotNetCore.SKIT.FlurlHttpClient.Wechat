using System;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_ApiExecuteBillTests
    {
        [Fact(DisplayName = "测试用例：调用 API [GET] /bill/tradebill")]
        public async Task TestExecuteGetBillTradeBill()
        {
            var request = new Models.GetBillTradeBillRequest()
            {
                BillDateString = "2021-04-05"
            };
            var response = await TestClients.InstanceUseRSA.ExecuteGetBillTradeBillAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.HashType);
            Assert.NotNull(response.HashValue);
            Assert.NotNull(response.DownloadUrl);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /bill/fundflowbill")]
        public async Task TestExecuteGetBillFundflowBill()
        {
            var request = new Models.GetBillFundflowBillRequest()
            {
                BillDateString = DateTimeOffset.Now.AddDays(-1).ToString("yyyy-MM-dd")
            };
            var response = await TestClients.InstanceUseRSA.ExecuteGetBillFundflowBillAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.HashType);
            Assert.NotNull(response.HashValue);
            Assert.NotNull(response.DownloadUrl);
        }

        [Fact(DisplayName = "测试用例：调用 API [GET] /billdownload/file")]
        public async Task TestExecuteDownloadBillFile()
        {
            var request = new Models.DownloadBillFileRequest()
            {
                DownloadUrl = "https://api.mch.weixin.qq.com/v3/billdownload/file?token=FAKE_TOKEN"
            };
            var response = await TestClients.InstanceUseRSA.ExecuteDownloadBillFileAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotEmpty(response.GetRawBytes());
        }
    }
}
