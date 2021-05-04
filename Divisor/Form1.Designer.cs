namespace Divisor
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox_input = new System.Windows.Forms.TextBox();
			this.button_divisors = new System.Windows.Forms.Button();
			this.label_count = new System.Windows.Forms.Label();
			this.listBox_result = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// textBox_input
			// 
			this.textBox_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_input.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.textBox_input.Location = new System.Drawing.Point(12, 12);
			this.textBox_input.MaxLength = 5;
			this.textBox_input.Multiline = true;
			this.textBox_input.Name = "textBox_input";
			this.textBox_input.Size = new System.Drawing.Size(249, 38);
			this.textBox_input.TabIndex = 0;
			this.textBox_input.Text = "55555";
			this.textBox_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button_divisors
			// 
			this.button_divisors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_divisors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.button_divisors.Location = new System.Drawing.Point(12, 56);
			this.button_divisors.Name = "button_divisors";
			this.button_divisors.Size = new System.Drawing.Size(249, 40);
			this.button_divisors.TabIndex = 1;
			this.button_divisors.Text = "Divisors";
			this.button_divisors.UseVisualStyleBackColor = true;
			this.button_divisors.Click += new System.EventHandler(this.button_divisors_Click);
			// 
			// label_count
			// 
			this.label_count.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label_count.AutoSize = true;
			this.label_count.Font = new System.Drawing.Font("Microsoft JhengHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.label_count.ForeColor = System.Drawing.Color.MediumBlue;
			this.label_count.Location = new System.Drawing.Point(12, 99);
			this.label_count.Name = "label_count";
			this.label_count.Size = new System.Drawing.Size(36, 28);
			this.label_count.TabIndex = 2;
			this.label_count.Text = "23";
			// 
			// listBox_result
			// 
			this.listBox_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox_result.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
			this.listBox_result.FormattingEnabled = true;
			this.listBox_result.ItemHeight = 31;
			this.listBox_result.Location = new System.Drawing.Point(12, 139);
			this.listBox_result.Name = "listBox_result";
			this.listBox_result.ScrollAlwaysVisible = true;
			this.listBox_result.Size = new System.Drawing.Size(249, 283);
			this.listBox_result.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 434);
			this.Controls.Add(this.listBox_result);
			this.Controls.Add(this.label_count);
			this.Controls.Add(this.button_divisors);
			this.Controls.Add(this.textBox_input);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "Divisor";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_input;
		private System.Windows.Forms.Button button_divisors;
		private System.Windows.Forms.Label label_count;
		private System.Windows.Forms.ListBox listBox_result;
	}
}

