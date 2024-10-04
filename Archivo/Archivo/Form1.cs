using Archivo.models;
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

namespace Archivo
{
    public partial class Form1 : Form
    {
        private List<Persona> personas;

        public Form1()
        {
            InitializeComponent();
            cbSex.Items.AddRange(new string[] { "M", "F" });
            configdgv();
            showData();

        }

        private void configdgv()
        {
            dgvData.ColumnCount = 4;
            dgvData.Columns[0].Name = "Nombre";
            dgvData.Columns[1].Name = "Edad";
            dgvData.Columns[2].Name = "Nota";
            dgvData.Columns[3].Name = "Sexo";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int edad = DateTime.Now.Year - dtpAge.Value.Year;

                using (FileStream mArchivoEscritor = new FileStream("datos.dat", FileMode.Append, FileAccess.Write))
                using (BinaryWriter Escritor = new BinaryWriter(mArchivoEscritor))
                {
                    string nombre = tbName.Text;
                    int nota = int.Parse(tbGrade.Text);
                    char sexo = cbSex.Text[0];

                    Escritor.Write(nombre.Length);
                    Escritor.Write(nombre.ToCharArray());
                    Escritor.Write(edad);
                    Escritor.Write(nota);
                    Escritor.Write(sexo);

                    MessageBox.Show("Se ha agregado a la persona");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido guardar" + ex.Message);
            }
        }
        private void showData()
        {
            try
            {
                dgvData.Rows.Clear();

                using (FileStream mArchivoLector = new FileStream("datos.dat", FileMode.Open, FileAccess.Read))
                using (BinaryReader Lector = new BinaryReader(mArchivoLector))
                {
                    while (Lector.BaseStream.Position != Lector.BaseStream.Length)
                    {
                        int longitud = Lector.ReadInt32();
                        string nombre = new string(Lector.ReadChars(longitud));
                        int edad = Lector.ReadInt32();
                        int nota = Lector.ReadInt32();
                        char sexo = Lector.ReadChar();

                        dgvData.Rows.Add(new string[] { nombre, edad.ToString(), nota.ToString(), sexo.ToString() });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido leer" + ex.Message);
            }
        }

        private void Clear()
        {
            tbName.Clear();
            tbGrade.Clear();
            cbSex.SelectedIndex = -1;
            dtpAge.Value = DateTime.Now;
        }
    }
}