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
		AmericanaEntities am;
		Prueba p = new Prueba();
		
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
				fila["RNC"] = registro[0];
				fila["Periodo"] = registro[1];
				fila["Codigo Nomina"] = registro[2];
				fila["Tipo Documento"] = registro[3];
				fila["Documento"] = registro[4];
				fila["Nombre"] = registro[5];
				fila["Apellido"] = registro[6];
				fila["Apellido"] = registro[7];
				fila["Salario"] = registro[8];
				fila["Aporte"] = registro[9];
				dt.Rows.Add(fila);
			}

			file.Close();
			dataGridView1.DataSource = dt;
			dataGridView1.Refresh();
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void crear_Click(object sender, EventArgs e)
		{

		}

		private void guardar_Click(object sender, EventArgs e)
		{
			


			string caja = textBox.Text;
			guardar_objeto(caja);
			

		}


		public void guardar_objeto(string b){

			am = new AmericanaEntities();

			for (int x = 0 ; textBox.Lines.Length > x; x++) {

				if (b.Contains("EAM"))
				{
					break;
				}

				string[] a = b.Split(',');

				p.RNC = a[0];
				p.Periodo = a[1];
				p.Codigo_nomina = a[2];
				p.Documento_tipo = a[3];
				p.Documento = a[4];
				p.Nombre = a[5];
				p.Apellido = a[6];
				p.Apellido2 = a[7];
				//p.Salario = int.Parse(a[8]);
				//p.Aporte = int.Parse(a[9]);

				am.Pruebas.Add(p);

			}

			try
			{
				am.SaveChanges();
			}
			catch (Exception x)
			{

				MessageBox.Show(x.Message);
			}
			

		}


	}
}
