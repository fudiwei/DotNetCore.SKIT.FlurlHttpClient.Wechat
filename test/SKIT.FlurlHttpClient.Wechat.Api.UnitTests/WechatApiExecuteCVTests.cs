using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class WechatApiExecuteCVTests
    {
        [Fact(DisplayName = "[POST] /cv/img/qrcode")]
        public async Task CVImageQrcodeTest()
        {
            var request = new Models.CVImageQrcodeRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
                ImageFileBytes = Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAADIAAAAyCAYAAAAeP4ixAAAD/UlEQVRoBd2X21IjMQxE8/8/DSVXjjnpkcaBNzJVuy31zR6yFOzj60Oex4e8x9d+kcfj8fXOn3px+/hCJMfe+dEKT7q9OXP26mBJ07R3B3cc+TutPCedng5X+PnX5ROx6JkiczVzGXh8E5Kx7qx1+ESy5tsXwQh25dZSL82PvcygfczWmMHyeN6ZPTy/R2x0IOfMWUebuqzbA+8uZrDzL+4v4Srl4QAQHoQH4Y2peWcGK+eZnn0ji8zgFKbEujPw9sGlzx5rzKDzLxkWG+GMqbN3WDl4z8X5secdHk+X282IJ6yy8vAwk5t08ycv+gm5w+pmOYXQfSHPJ/03XrpOyN1Xt5ffzBxCxnvN3QM/edG77IlrT3Qhh4JVaJ3d+nQonhNmHj987usOKZZpCfq5ggfeOzPlILwRzVg6u73MpeXT+bcLkSB7V5Jc7fjBdzyns+jNru6My4sQwpyHmUfjQDQ6wImfcvjpz51e436RFzJ+pU+tdso9w91hdqXXetedOvtbL+LDCIKl+cELN+nwYPkza84+uo2vt3gqFHbocM15ABl8kw4P0uXdXPL0g5cXqYBDuROc0Fk8dJwQv9EZ8zlfXqQMDtdszrN9y6Qsu/2e3WuvZ/rh2EH4wsuLcIBNnlNn78qdY8aXOXZ8xinz4vFS811hp+PnsOzLHV/m2NPPmeS827s/kTRiggddVBwPurnOO/nSi898nsW+PF4WoctNuy/LnAe71xqdcOThuxxeazn/fEmfiouL6nZzzIWefZA1OuHIwHc5vNZy3i+CmWJ2At6Z7bWv5vTA4QPpsE7WHLP9dCyNhfCE9q2gfo3J3Yd5psPo88zTCR57unBXDkdx5rz70G6mCyRrL+eYww+SW14vDqfZe813j/Vupguky17fxTqZixcTaKNn68x3SNaey+GH3xoqS09m3bt8EAQyTAH6ae/ymeVMvOz4cofnbHTj5d9ImikhxJ446fCFXSa52nmY8cB3+JN6qoQxZwl7YvrR4QvhwI4rjYfZfrTEnZrMXRleNJfC4bHWzfhLI5PonLUX3su7s8u6+a7H/vSVlo/9zOmpfScxnTBLyr+K9CtK56HXXrL42SeveTLg574Ib5jorwZfufKYn3Z3OQtPx6TZx5x4+UTK4GLK4VJnpxjfhPjp9T5lJp4zVwcL5q7YXPq5EHmw86EZ8XVYvnrsh0v/nz6RLM/dh+Ulcs8LeafnncyfXsTFvAQX4PC7nbw95NDY6Yf3Tn5xLDbCGe90H7pK4+eBs8wdZjY96PAv92NBPCF+sPz1kGO2bg09c93e5TK/z9mD/sdHQYf4wbxA8XDM9DiDB63b0ZxzJ/zivPzneX+z/+eX+KhP5Btmhzo0tfoUxgAAAABJRU5ErkJggg==")
            };
            var response = await TestClients.Instance.ExecuteCVImageQrcodeAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotEmpty(response.ResultList);
            Assert.NotNull(response.ImageSize);
        }

        [Fact(DisplayName = "[POST] /cv/img/aicrop")]
        public async Task CVImageAICropTest()
        {
            var request = new Models.CVImageAICropRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
                ImageFileBytes = Convert.FromBase64String("/9j/4AAQSkZJRgABAQEAeAB4AAD/2wBDAAIBAQIBAQICAgICAgICAwUDAwMDAwYEBAMFBwYHBwcGBwcICQsJCAgKCAcHCg0KCgsMDAwMBwkODw0MDgsMDAz/2wBDAQICAgMDAwYDAwYMCAcIDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAz/wAARCAAcABwDASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD9/KK+bv25viR458H/ABS+E+meDNb8S6YNW1LffWuk22lyRaig1DS7fZePfRuY7QR3cxc2zR3BOwRsWwp8I8Hftl/FD4k+H9G1HVvEnij4dHSbnTJ2hubXQGXxYrHSIypKpc7bS7N9MyqjW92DsH7nGwkfe++3/pP/AMktN97IbTX3X/P/AORfltqfoRRXzTr3xA8eeI7T4i6BdeJ/EXhM/DiyuFm13RrLTmvtZmuJPtGn/ZhdW09v5iWapHKDAVea6wqjZXvnw40rVtC+HuhWWv6m+ta7aafBDqOoNHHGb65WNRLMVjREXe4ZsIiqM8KBxRHVc3p+N/ytr2uvkno7ev4W/O+nezK3jX4TaB8Q9VsL7V7Frm70yNo7WVbmWFoVaa3nONjLz5lrA2eo8vjgsD554v8A+Cf/AMKvHGnaLaX2g6tHb6Bc2d1aR2PiTVLAFrQQi3WXyLhPPjQ28DeVNvRmhRmUsoNezUUdb9tfu2DpY4X4mfs4+E/i54b8RaVrFrq0dv4qntLrUZtM1u+0q7eW1aJ7eSO5tZopoGRoYyDE6E7ec5Oes8NeH4PCfh2w0u1e9lttOt47aJ7y8mvbh0RQoMk8zPLK+By8jM7HJYkkmr1FC0VkG+/T+v0R/9k=")
            };
            var response = await TestClients.Instance.ExecuteCVImageAICropAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotEmpty(response.ResultList);
            Assert.NotNull(response.ImageSize);
        }

        [Fact(DisplayName = "[POST] /cv/img/superresolution")]
        public async Task CVImageSuperResolutionTest()
        {
            var request = new Models.CVImageSuperResolutionRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
                ImageFileBytes = Convert.FromBase64String("/9j/4AAQSkZJRgABAQEAeAB4AAD/2wBDAAIBAQIBAQICAgICAgICAwUDAwMDAwYEBAMFBwYHBwcGBwcICQsJCAgKCAcHCg0KCgsMDAwMBwkODw0MDgsMDAz/2wBDAQICAgMDAwYDAwYMCAcIDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAz/wAARCAAcABwDASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD9/KK+bv25viR458H/ABS+E+meDNb8S6YNW1LffWuk22lyRaig1DS7fZePfRuY7QR3cxc2zR3BOwRsWwp8I8Hftl/FD4k+H9G1HVvEnij4dHSbnTJ2hubXQGXxYrHSIypKpc7bS7N9MyqjW92DsH7nGwkfe++3/pP/AMktN97IbTX3X/P/AORfltqfoRRXzTr3xA8eeI7T4i6BdeJ/EXhM/DiyuFm13RrLTmvtZmuJPtGn/ZhdW09v5iWapHKDAVea6wqjZXvnw40rVtC+HuhWWv6m+ta7aafBDqOoNHHGb65WNRLMVjREXe4ZsIiqM8KBxRHVc3p+N/ytr2uvkno7ev4W/O+nezK3jX4TaB8Q9VsL7V7Frm70yNo7WVbmWFoVaa3nONjLz5lrA2eo8vjgsD554v8A+Cf/AMKvHGnaLaX2g6tHb6Bc2d1aR2PiTVLAFrQQi3WXyLhPPjQ28DeVNvRmhRmUsoNezUUdb9tfu2DpY4X4mfs4+E/i54b8RaVrFrq0dv4qntLrUZtM1u+0q7eW1aJ7eSO5tZopoGRoYyDE6E7ec5Oes8NeH4PCfh2w0u1e9lttOt47aJ7y8mvbh0RQoMk8zPLK+By8jM7HJYkkmr1FC0VkG+/T+v0R/9k=")
            };
            var response = await TestClients.Instance.ExecuteCVImageSuperResolutionAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.MediaId);
        }

        [Fact(DisplayName = "[POST] /cv/ocr/comm")]
        public async Task CVOCRCommonTest()
        {
            var request = new Models.CVOCRCommonRequest()
            {
                AccessToken = TestConfigs.WechatAccessToken,
                ImageFileBytes = Convert.FromBase64String("/9j/4AAQSkZJRgABAQEAeAB4AAD/2wBDAAIBAQIBAQICAgICAgICAwUDAwMDAwYEBAMFBwYHBwcGBwcICQsJCAgKCAcHCg0KCgsMDAwMBwkODw0MDgsMDAz/2wBDAQICAgMDAwYDAwYMCAcIDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAz/wAARCAAcABwDASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD9/KK+bv25viR458H/ABS+E+meDNb8S6YNW1LffWuk22lyRaig1DS7fZePfRuY7QR3cxc2zR3BOwRsWwp8I8Hftl/FD4k+H9G1HVvEnij4dHSbnTJ2hubXQGXxYrHSIypKpc7bS7N9MyqjW92DsH7nGwkfe++3/pP/AMktN97IbTX3X/P/AORfltqfoRRXzTr3xA8eeI7T4i6BdeJ/EXhM/DiyuFm13RrLTmvtZmuJPtGn/ZhdW09v5iWapHKDAVea6wqjZXvnw40rVtC+HuhWWv6m+ta7aafBDqOoNHHGb65WNRLMVjREXe4ZsIiqM8KBxRHVc3p+N/ytr2uvkno7ev4W/O+nezK3jX4TaB8Q9VsL7V7Frm70yNo7WVbmWFoVaa3nONjLz5lrA2eo8vjgsD554v8A+Cf/AMKvHGnaLaX2g6tHb6Bc2d1aR2PiTVLAFrQQi3WXyLhPPjQ28DeVNvRmhRmUsoNezUUdb9tfu2DpY4X4mfs4+E/i54b8RaVrFrq0dv4qntLrUZtM1u+0q7eW1aJ7eSO5tZopoGRoYyDE6E7ec5Oes8NeH4PCfh2w0u1e9lttOt47aJ7y8mvbh0RQoMk8zPLK+By8jM7HJYkkmr1FC0VkG+/T+v0R/9k=")
            };
            var response = await TestClients.Instance.ExecuteCVOCRCommonAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotEmpty(response.ResultList);
            Assert.NotNull(response.ResultList.First().Text);
            Assert.NotNull(response.ResultList.First().Position);
        }
    }
}
