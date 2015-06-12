/*
 * Authors:
 *   钟峰(Popeye Zhong) <zongsoft@gmail.com>
 *
 * The MIT License (MIT)
 * 
 * Copyright (C) 2015 Zongsoft Corporation <http://www.zongsoft.com>
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

namespace Zongsoft.Regular
{
	partial class AboutDialog
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
			this.picBanner = new System.Windows.Forms.PictureBox();
			this.lblProductName = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblCompanyName = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.txtCopyright = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
			this.SuspendLayout();
			// 
			// picBanner
			// 
			this.picBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.picBanner.Image = ((System.Drawing.Image)(resources.GetObject("picBanner.Image")));
			this.picBanner.Location = new System.Drawing.Point(5, 4);
			this.picBanner.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.picBanner.Name = "picBanner";
			this.picBanner.Size = new System.Drawing.Size(175, 353);
			this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBanner.TabIndex = 26;
			this.picBanner.TabStop = false;
			// 
			// lblProductName
			// 
			this.lblProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblProductName.AutoEllipsis = true;
			this.lblProductName.Location = new System.Drawing.Point(193, 7);
			this.lblProductName.Margin = new System.Windows.Forms.Padding(8, 0, 5, 0);
			this.lblProductName.MaximumSize = new System.Drawing.Size(0, 21);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(380, 21);
			this.lblProductName.TabIndex = 27;
			this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblVersion
			// 
			this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblVersion.AutoEllipsis = true;
			this.lblVersion.Location = new System.Drawing.Point(193, 28);
			this.lblVersion.Margin = new System.Windows.Forms.Padding(8, 0, 5, 0);
			this.lblVersion.MaximumSize = new System.Drawing.Size(0, 21);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(380, 21);
			this.lblVersion.TabIndex = 25;
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCompanyName
			// 
			this.lblCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCompanyName.AutoEllipsis = true;
			this.lblCompanyName.Location = new System.Drawing.Point(193, 58);
			this.lblCompanyName.Margin = new System.Windows.Forms.Padding(8, 0, 5, 0);
			this.lblCompanyName.MaximumSize = new System.Drawing.Size(0, 21);
			this.lblCompanyName.Name = "lblCompanyName";
			this.lblCompanyName.Size = new System.Drawing.Size(380, 21);
			this.lblCompanyName.TabIndex = 29;
			this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtDescription
			// 
			this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription.Location = new System.Drawing.Point(187, 160);
			this.txtDescription.Margin = new System.Windows.Forms.Padding(8, 4, 5, 4);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ReadOnly = true;
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtDescription.Size = new System.Drawing.Size(384, 162);
			this.txtDescription.TabIndex = 30;
			this.txtDescription.TabStop = false;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnOK.Location = new System.Drawing.Point(493, 331);
			this.btnOK.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(80, 24);
			this.btnOK.TabIndex = 31;
			this.btnOK.Text = "确定(&O)";
			// 
			// txtCopyright
			// 
			this.txtCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCopyright.Location = new System.Drawing.Point(193, 90);
			this.txtCopyright.Multiline = true;
			this.txtCopyright.Name = "txtCopyright";
			this.txtCopyright.ReadOnly = true;
			this.txtCopyright.Size = new System.Drawing.Size(377, 55);
			this.txtCopyright.TabIndex = 32;
			// 
			// AboutDialog
			// 
			this.AcceptButton = this.btnOK;
			this.CancelButton = this.btnOK;
			this.ClientSize = new System.Drawing.Size(584, 362);
			this.Controls.Add(this.txtCopyright);
			this.Controls.Add(this.picBanner);
			this.Controls.Add(this.lblProductName);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.lblCompanyName);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.btnOK);
			this.Font = new System.Drawing.Font("Courier New", 10.02F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.HelpButton = true;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDialog";
			this.Padding = new System.Windows.Forms.Padding(11);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "关于";
			((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picBanner;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label lblCompanyName;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox txtCopyright;

	}
}
