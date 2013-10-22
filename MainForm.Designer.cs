namespace babylonQR
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.imageQRCode = new System.Windows.Forms.PictureBox();
            this.OneMoreCode = new System.Windows.Forms.Button();
            this.labelMin = new System.Windows.Forms.Label();
            this.minNumber = new System.Windows.Forms.TextBox();
            this.maxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // imageQRCode
            // 
            this.imageQRCode.Location = new System.Drawing.Point(100, 35);
            this.imageQRCode.Name = "imageQRCode";
            this.imageQRCode.Size = new System.Drawing.Size(200, 200);
            this.imageQRCode.TabIndex = 0;
            this.imageQRCode.TabStop = false;
            // 
            // OneMoreCode
            // 
            this.OneMoreCode.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OneMoreCode.Location = new System.Drawing.Point(100, 265);
            this.OneMoreCode.Name = "OneMoreCode";
            this.OneMoreCode.Size = new System.Drawing.Size(199, 28);
            this.OneMoreCode.TabIndex = 1;
            this.OneMoreCode.Text = "再来一个(&M)";
            this.OneMoreCode.UseVisualStyleBackColor = true;
            this.OneMoreCode.Click += new System.EventHandler(this.OneMoreCode_Click);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(13, 337);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(41, 12);
            this.labelMin.TabIndex = 2;
            this.labelMin.Text = "最小值";
            // 
            // minNumber
            // 
            this.minNumber.Location = new System.Drawing.Point(60, 335);
            this.minNumber.Name = "minNumber";
            this.minNumber.Size = new System.Drawing.Size(100, 21);
            this.minNumber.TabIndex = 3;
            this.minNumber.Text = "1000000";
            // 
            // maxNumber
            // 
            this.maxNumber.Location = new System.Drawing.Point(229, 334);
            this.maxNumber.Name = "maxNumber";
            this.maxNumber.Size = new System.Drawing.Size(100, 21);
            this.maxNumber.TabIndex = 5;
            this.maxNumber.Text = "1500000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "最大值";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.maxNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minNumber);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.OneMoreCode);
            this.Controls.Add(this.imageQRCode);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "来往二维码生成器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageQRCode;
        private System.Windows.Forms.Button OneMoreCode;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.TextBox minNumber;
        private System.Windows.Forms.TextBox maxNumber;
        private System.Windows.Forms.Label label2;
    }
}

