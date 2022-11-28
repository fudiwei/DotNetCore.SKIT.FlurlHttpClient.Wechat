using System;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_ApiExecuteMarketingMediaTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /marketing/favor/media/image-upload")]
        public async Task TestExecuteUploadMarketingMediaImage()
        {
            var request = new Models.UploadMarketingMediaImageRequest()
            {
                FileName = "FAKE_IMAGE.jpg",
                FileBytes = Convert.FromBase64String("/9j/4AAQSkZJRgABAQEAeAB4AAD/2wBDAAIBAQIBAQICAgICAgICAwUDAwMDAwYEBAMFBwYHBwcGBwcICQsJCAgKCAcHCg0KCgsMDAwMBwkODw0MDgsMDAz/2wBDAQICAgMDAwYDAwYMCAcIDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAz/wAARCAAcABwDASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD9/KK+bv25viR458H/ABS+E+meDNb8S6YNW1LffWuk22lyRaig1DS7fZePfRuY7QR3cxc2zR3BOwRsWwp8I8Hftl/FD4k+H9G1HVvEnij4dHSbnTJ2hubXQGXxYrHSIypKpc7bS7N9MyqjW92DsH7nGwkfe++3/pP/AMktN97IbTX3X/P/AORfltqfoRRXzTr3xA8eeI7T4i6BdeJ/EXhM/DiyuFm13RrLTmvtZmuJPtGn/ZhdW09v5iWapHKDAVea6wqjZXvnw40rVtC+HuhWWv6m+ta7aafBDqOoNHHGb65WNRLMVjREXe4ZsIiqM8KBxRHVc3p+N/ytr2uvkno7ev4W/O+nezK3jX4TaB8Q9VsL7V7Frm70yNo7WVbmWFoVaa3nONjLz5lrA2eo8vjgsD554v8A+Cf/AMKvHGnaLaX2g6tHb6Bc2d1aR2PiTVLAFrQQi3WXyLhPPjQ28DeVNvRmhRmUsoNezUUdb9tfu2DpY4X4mfs4+E/i54b8RaVrFrq0dv4qntLrUZtM1u+0q7eW1aJ7eSO5tZopoGRoYyDE6E7ec5Oes8NeH4PCfh2w0u1e9lttOt47aJ7y8mvbh0RQoMk8zPLK+By8jM7HJYkkmr1FC0VkG+/T+v0R/9k=")
            };
            var response = await TestClients.InstanceUseRSA.ExecuteUploadMarketingMediaImageAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.MediaUrl);
        }
    }
}
