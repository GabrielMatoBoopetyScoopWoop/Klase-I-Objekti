using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klase_I_Objekti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UnesiButun_Click(object sender, EventArgs e)
        {
            try
            {
                Class1 osoba = new Class1(UnosStringTextBox.Text, Convert.ToInt32(UnosIntTextBox.Text));
                RichTextBox.Text = osoba.ToString();
            }
            catch(Exception greska)
            {
                MessageBox.Show("Greška", greska.Message);
            }
        }
    }
}
