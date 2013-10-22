using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;
using ThoughtWorks.QRCode.Codec.Util;

namespace babylonQR
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OneMoreCode_Click(object sender, EventArgs e)
        {
            try
            {
                int min = Int32.Parse(minNumber.Text);
                int max = Int32.Parse(maxNumber.Text);

                Random r = new Random();
                String data = "http://laiwang.com/u/" + r.Next(min, max).ToString() + "#";

                CreateQRCode(data);
            }
            catch {
                MessageBox.Show("别闹，好好输入数字。最好6位以上。");
            }
        }

        private void CreateQRCode(string url)
        {
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();

            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeScale = 4;
            qrCodeEncoder.QRCodeVersion = 7;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;

            imageQRCode.Image = qrCodeEncoder.Encode(url);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateQRCode("http://laiwang.com/u/850021");
        }
    }
}
