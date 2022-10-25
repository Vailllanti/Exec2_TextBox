namespace Q1輸入數值是否在_1_99_
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.inputtxtb = new System.Windows.Forms.TextBox();
			this.judgebtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// inputtxtb
			// 
			this.inputtxtb.Location = new System.Drawing.Point(157, 59);
			this.inputtxtb.Name = "inputtxtb";
			this.inputtxtb.Size = new System.Drawing.Size(100, 22);
			this.inputtxtb.TabIndex = 0;
			// 
			// judgebtn
			// 
			this.judgebtn.Location = new System.Drawing.Point(272, 51);
			this.judgebtn.Name = "judgebtn";
			this.judgebtn.Size = new System.Drawing.Size(89, 34);
			this.judgebtn.TabIndex = 1;
			this.judgebtn.Text = "表示結果";
			this.judgebtn.UseVisualStyleBackColor = true;
			this.judgebtn.Click += new System.EventHandler(this.judgebtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "請輸入一個數字:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 144);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.judgebtn);
			this.Controls.Add(this.inputtxtb);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Form1";
			this.Text = "判斷數值是否在[1,99]";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputtxtb;
		private System.Windows.Forms.Button judgebtn;
		private System.Windows.Forms.Label label1;
	}
}

