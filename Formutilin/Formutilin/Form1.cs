using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formutilin
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_sabe_Click(object sender, EventArgs e)
        {
            
            string Apellido = Txt_Ape.Text;
            string Nombre = Txt_nom.Text;

            int Telfono = int.Parse(Txb_Edad.Text);
            float Altrua = float.Parse(Txt_Atura.Text);
            int Edad = int.Parse(Txb_Edad.Text);

            string Genero = lbl_masculino.Checked ? "Masculino" : "Femenino";
            string cnt = $"Nombre: {Nombre}\nApellido {Apellido}\nTelefono {Telfono}\nAltura {Altrua}\nGenero {Genero}";
            string Archivo = @"D:\Users\gisel\Documents\xd.txt";

            File.WriteAllText(Archivo, cnt);
            MessageBox.Show("SE A ECHO EL ARCHIVO CON EXITO.");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
