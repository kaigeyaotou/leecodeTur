using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace ProjectUnitTest
{
    public static class QrcodeHelper
    {
        /// <summary>
        /// 生成二维码 返回byte数组 不带中间图标
        /// </summary>
        /// <param name="url"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static byte[] CreateQrcodeByte(string url, int size = 5)
        {
            var generator = new QRCodeGenerator();
            var qrcodeData = generator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q, true);
            QRCode qrcode = new QRCode(qrcodeData);
            var img = qrcode.GetGraphic(size, Color.Black, Color.White, false);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
        /// <summary>
        /// 生成二维码 返回Base64字符串 不带中间图标
        /// </summary>
        /// <param name="url"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static string CreateQrcodeBase64(string url, int size = 5, bool hasEdify = true)
        {
            string result = "";
            var generator = new QRCodeGenerator();
            var qrcodeData = generator.CreateQrCode(url, QRCodeGenerator.ECCLevel.M, true);
            QRCode qrcode = new QRCode(qrcodeData);
            var img = qrcode.GetGraphic(size, Color.Black, Color.White, false);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Png);

            byte[] arr = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(arr, 0, (int)ms.Length);
            ms.Close();
            if (hasEdify)
            {
                result = "data:image/jpeg;base64," + Convert.ToBase64String(arr);
            }
            else
            {
                result = Convert.ToBase64String(arr);
            }
            return result;
        }
    }
}
