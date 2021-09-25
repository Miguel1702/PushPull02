
namespace PushPull
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
			this.textBox = new System.Windows.Forms.TextBox();
			this.writeFile = new System.Windows.Forms.Button();
			this.loadFile = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(34, 78);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(481, 484);
			this.textBox.TabIndex = 0;
			this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// writeFile
			// 
			this.writeFile.Location = new System.Drawing.Point(34, 21);
			this.writeFile.Name = "writeFile";
			this.writeFile.Size = new System.Drawing.Size(164, 41);
			this.writeFile.TabIndex = 1;
			this.writeFile.Text = "Generar";
			this.writeFile.UseVisualStyleBackColor = true;
			this.writeFile.Click += new System.EventHandler(this.button1_Click);
			// 
			// loadFile
			// 
			this.loadFile.Location = new System.Drawing.Point(568, 21);
			this.loadFile.Name = "loadFile";
			this.loadFile.Size = new System.Drawing.Size(176, 41);
			this.loadFile.TabIndex = 2;
			this.loadFile.Text = "Cargar";
			this.loadFile.UseVisualStyleBackColor = true;
			this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(568, 78);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 72;
			this.dataGridView1.RowTemplate.Height = 31;
			this.dataGridView1.Size = new System.Drawing.Size(718, 484);
			this.dataGridView1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1318, 588);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.loadFile);
			this.Controls.Add(this.writeFile);
			this.Controls.Add(this.textBox);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Button writeFile;
		private System.Windows.Forms.Button loadFile;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

