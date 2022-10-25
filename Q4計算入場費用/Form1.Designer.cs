namespace Q4計算入場費用
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
			this.label2 = new System.Windows.Forms.Label();
			this.calebtn = new System.Windows.Forms.Button();
			this.peopletxtb = new System.Windows.Forms.TextBox();
			this.carstxtb = new System.Windows.Forms.TextBox();
			this.resulttxtb = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "人數(每人60元):";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(171, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "車輛數(每輛200元):";
			// 
			// calebtn
			// 
			this.calebtn.Location = new System.Drawing.Point(287, 59);
			this.calebtn.Name = "calebtn";
			this.calebtn.Size = new System.Drawing.Size(63, 30);
			this.calebtn.TabIndex = 1;
			this.calebtn.Text = "計算";
			this.calebtn.UseVisualStyleBackColor = true;
			this.calebtn.Click += new System.EventHandler(this.calebtn_Click);
			// 
			// peopletxtb
			// 
			this.peopletxtb.Location = new System.Drawing.Point(103, 23);
			this.peopletxtb.Name = "peopletxtb";
			this.peopletxtb.Size = new System.Drawing.Size(62, 22);
			this.peopletxtb.TabIndex = 2;
			// 
			// carstxtb
			// 
			this.carstxtb.Location = new System.Drawing.Point(283, 23);
			this.carstxtb.Name = "carstxtb";
			this.carstxtb.Size = new System.Drawing.Size(62, 22);
			this.carstxtb.TabIndex = 2;
			// 
			// resulttxtb
			// 
			this.resulttxtb.Location = new System.Drawing.Point(14, 97);
			this.resulttxtb.Multiline = true;
			this.resulttxtb.Name = "resulttxtb";
			this.resulttxtb.ReadOnly = true;
			this.resulttxtb.Size = new System.Drawing.Size(336, 131);
			this.resulttxtb.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 240);
			this.Controls.Add(this.resulttxtb);
			this.Controls.Add(this.carstxtb);
			this.Controls.Add(this.peopletxtb);
			this.Controls.Add(this.calebtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button calebtn;
		private System.Windows.Forms.TextBox peopletxtb;
		private System.Windows.Forms.TextBox carstxtb;
		private System.Windows.Forms.TextBox resulttxtb;
	}
}

