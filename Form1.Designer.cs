
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
			this.crear = new System.Windows.Forms.Button();
			this.guardar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(49, 101);
			this.textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(698, 624);
			this.textBox.TabIndex = 0;
			this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// writeFile
			// 
			this.writeFile.Location = new System.Drawing.Point(49, 27);
			this.writeFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.writeFile.Name = "writeFile";
			this.writeFile.Size = new System.Drawing.Size(239, 53);
			this.writeFile.TabIndex = 1;
			this.writeFile.Text = "Generar";
			this.writeFile.UseVisualStyleBackColor = true;
			this.writeFile.Click += new System.EventHandler(this.button1_Click);
			// 
			// loadFile
			// 
			this.loadFile.Location = new System.Drawing.Point(826, 27);
			this.loadFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.loadFile.Name = "loadFile";
			this.loadFile.Size = new System.Drawing.Size(256, 53);
			this.loadFile.TabIndex = 2;
			this.loadFile.Text = "Cargar";
			this.loadFile.UseVisualStyleBackColor = true;
			this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(826, 101);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 72;
			this.dataGridView1.RowTemplate.Height = 31;
			this.dataGridView1.Size = new System.Drawing.Size(1044, 625);
			this.dataGridView1.TabIndex = 3;
			// 
			// crear
			// 
			this.crear.Location = new System.Drawing.Point(1131, 28);
			this.crear.Name = "crear";
			this.crear.Size = new System.Drawing.Size(157, 52);
			this.crear.TabIndex = 4;
			this.crear.Text = "Crear";
			this.crear.UseVisualStyleBackColor = true;
			this.crear.Click += new System.EventHandler(this.crear_Click);
			// 
			// guardar
			// 
			this.guardar.Location = new System.Drawing.Point(319, 27);
			this.guardar.Name = "guardar";
			this.guardar.Size = new System.Drawing.Size(191, 53);
			this.guardar.TabIndex = 5;
			this.guardar.Text = "Guardar";
			this.guardar.UseVisualStyleBackColor = true;
			this.guardar.Click += new System.EventHandler(this.guardar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1917, 759);
			this.Controls.Add(this.guardar);
			this.Controls.Add(this.crear);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.loadFile);
			this.Controls.Add(this.writeFile);
			this.Controls.Add(this.textBox);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
		private System.Windows.Forms.Button crear;
		private System.Windows.Forms.Button guardar;
	}
}

