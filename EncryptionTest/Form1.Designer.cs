
namespace EncryptionTest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtB_PlainText = new System.Windows.Forms.TextBox();
            this.txtB_CipherText = new System.Windows.Forms.TextBox();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtB_PlainText
            // 
            this.txtB_PlainText.Location = new System.Drawing.Point(51, 49);
            this.txtB_PlainText.Multiline = true;
            this.txtB_PlainText.Name = "txtB_PlainText";
            this.txtB_PlainText.Size = new System.Drawing.Size(292, 346);
            this.txtB_PlainText.TabIndex = 0;
            // 
            // txtB_CipherText
            // 
            this.txtB_CipherText.Location = new System.Drawing.Point(479, 49);
            this.txtB_CipherText.Multiline = true;
            this.txtB_CipherText.Name = "txtB_CipherText";
            this.txtB_CipherText.Size = new System.Drawing.Size(292, 346);
            this.txtB_CipherText.TabIndex = 1;
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(368, 101);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(86, 43);
            this.btn_Encrypt.TabIndex = 2;
            this.btn_Encrypt.Text = "暗号化";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(368, 256);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(86, 43);
            this.btn_Decrypt.TabIndex = 3;
            this.btn_Decrypt.Text = "復号";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.txtB_CipherText);
            this.Controls.Add(this.txtB_PlainText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_PlainText;
        private System.Windows.Forms.TextBox txtB_CipherText;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
    }
}

