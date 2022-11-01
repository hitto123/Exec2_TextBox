namespace Q3
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
			this.buttoncheck = new System.Windows.Forms.Button();
			this.textBoxShow = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttoncheck
			// 
			this.buttoncheck.Location = new System.Drawing.Point(240, 31);
			this.buttoncheck.Name = "buttoncheck";
			this.buttoncheck.Size = new System.Drawing.Size(97, 77);
			this.buttoncheck.TabIndex = 0;
			this.buttoncheck.Text = "確定年紀";
			this.buttoncheck.UseVisualStyleBackColor = true;
			this.buttoncheck.Click += new System.EventHandler(this.buttoncheck_Click);
			// 
			// textBoxShow
			// 
			this.textBoxShow.Location = new System.Drawing.Point(41, 31);
			this.textBoxShow.Multiline = true;
			this.textBoxShow.Name = "textBoxShow";
			this.textBoxShow.Size = new System.Drawing.Size(152, 59);
			this.textBoxShow.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 314);
			this.Controls.Add(this.textBoxShow);
			this.Controls.Add(this.buttoncheck);
			this.Name = "Form1";
			this.Text = "Q3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttoncheck;
		private System.Windows.Forms.TextBox textBoxShow;
	}
}

