namespace patch_seb_lucas
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			
			// label1
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(180, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(212, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Safe Exam Browser Patch";
			this.label1.ForeColor = System.Drawing.Color.Lime;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			
			// textBox1
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(12, 50);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(547, 196);
			this.textBox1.TabIndex = 1;
			this.textBox1.BackColor = System.Drawing.Color.Black;
			this.textBox1.ForeColor = System.Drawing.Color.Lime;
			
			// button1
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(389, 262);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(170, 46);
			this.button1.TabIndex = 2;
			this.button1.Text = "LET'S PATCH!!!";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.FlatAppearance.BorderSize = 1;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.ForeColor = System.Drawing.Color.Lime;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			
			// checkBox1
			this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(12, 276);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(71, 21);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "Backup";
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.BackColor = System.Drawing.Color.Black;
			this.checkBox1.ForeColor = System.Drawing.Color.Lime;
			
			// checkBox2
			this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox2.AutoSize = true;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(127, 276);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(125, 21);
			this.checkBox2.TabIndex = 4;
			this.checkBox2.Text = "Install Certificate";
			this.checkBox2.UseVisualStyleBackColor = false;
			this.checkBox2.BackColor = System.Drawing.Color.Black;
			this.checkBox2.ForeColor = System.Drawing.Color.Lime;
			
			// Form1
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 330);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Safe Exam Browser Patch";
			this.BackColor = System.Drawing.Color.Black;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
	}
}

