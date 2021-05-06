namespace ButtonChange
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
			this.ChangeColorButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ChangeColorButton
			// 
			this.ChangeColorButton.Location = new System.Drawing.Point(143, 106);
			this.ChangeColorButton.Name = "ChangeColorButton";
			this.ChangeColorButton.Size = new System.Drawing.Size(312, 66);
			this.ChangeColorButton.TabIndex = 0;
			this.ChangeColorButton.Text = "button1";
			this.ChangeColorButton.UseVisualStyleBackColor = true;
			this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 313);
			this.Controls.Add(this.ChangeColorButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ChangeColorButton;
	}
}

