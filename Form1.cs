using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PushPull
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			try
			{
				string path = @"C:\Users\mjmer\Documents\Calc01";
				string fileName = "Datos.txt";
				string contents = textBox.Text;
				File.WriteAllText(path + fileName, contents);
			}
			catch (Exception x)
			{

				MessageBox.Show("Ooops" + x.Message); 
			}
			
			
		}

		private void loadFile_Click(object sender, EventArgs e)
		{
			string line;
			DataTable dt = new DataTable();
			dt.Clear();
			dt.Columns.Add("Matricula");
			dt.Columns.Add("Nombre");
			dt.Columns.Add("Carrera");


			// abre dialogo para leer el archivo

			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			// Set filter options and filter index.
			openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
			openFileDialog1.FilterIndex = 1;

			//openFileDialog1.Multiselect = true;

			// Call the ShowDialog method to show the dialog box.
			openFileDialog1.ShowDialog();

			string archivo = openFileDialog1.FileName;

			// lee linea a linea 


			System.IO.StreamReader file = new System.IO.StreamReader(archivo);
			while ((line = file.ReadLine()) != null)
			{
				string[] registro = line.Split(',');
				DataRow fila = dt.NewRow();
				fila["Matricula"] = registro[0];
				fila["Nombre"] = registro[1];
				fila["Carrera"] = registro[2];
				dt.Rows.Add(fila);
			}

			file.Close();
			dataGridView1.DataSource = dt;
			dataGridView1.Refresh();
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
