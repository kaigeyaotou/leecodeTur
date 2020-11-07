using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xunit;

namespace ProjectUnitTest
{
    public class QRCode_UnitTest
    {
        private Bitmap GetIconBitmap(string path)
        {
            Bitmap img = null;
            if (path.Length > 0)
            {
                try
                {
                    img = new Bitmap(path);
                }
                catch (Exception)
                {
                }
            }
            return img;
        }

        [Fact]
        public void CreateQrcodeBase64UnitTest()
        {
            string level = "Q";
            QRCodeGenerator.ECCLevel eccLevel = (QRCodeGenerator.ECCLevel)(level == "L" ? 0 : level == "M" ? 1 : level == "Q" ? 2 : 3);
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode("http://www.baidu.com", eccLevel))
                {
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {

                        var pic = qrCode.GetGraphic(20, Color.Black, Color.White,
                            GetIconBitmap("E:/source code/leecodeTur/ProjectUnitTest/logo.png"), 20);

                        var picQ = new Bitmap(pic, new Size(400, 400));
                        picQ.Save("D://test.jpg");
                    }
                }
            }
        }

    }
}
