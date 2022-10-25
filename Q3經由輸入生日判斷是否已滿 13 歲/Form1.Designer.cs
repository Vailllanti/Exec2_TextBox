namespace Q3經由輸入生日判斷是否已滿_13_歲
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
			this.label1 = new System.Windows.Forms.Label();
			this.inputtxtb = new System.Windows.Forms.TextBox();
			this.confirmbtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "請輸入生日(yyyy/MM/dd):";
			// 
			// inputtxtb
			// 
			this.inputtxtb.Location = new System.Drawing.Point(165, 36);
			this.inputtxtb.Name = "inputtxtb";
			this.inputtxtb.Size = new System.Drawing.Size(100, 22);
			this.inputtxtb.TabIndex = 1;
			// 
			// confirmbtn
			// 
			this.confirmbtn.Location = new System.Drawing.Point(271, 34);
			this.confirmbtn.Name = "confirmbtn";
			this.confirmbtn.Size = new System.Drawing.Size(75, 23);
			this.confirmbtn.TabIndex = 2;
			this.confirmbtn.Text = "確認";
			this.confirmbtn.UseVisualStyleBackColor = true;
			this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(390, 98);
			this.Controls.Add(this.confirmbtn);
			this.Controls.Add(this.inputtxtb);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "輸入生日判斷是否已滿 13 歲";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputtxtb;
		private System.Windows.Forms.Button confirmbtn;
	}
}

