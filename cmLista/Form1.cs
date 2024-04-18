using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cmLista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmlista_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmblista.SelectedIndex = 0;

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (textBoxname.TextLength == 0)
                MessageBox.Show("Por favor digite algo!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBoxname.Focus();

            {
                cmblista.Items.Add(textBoxname.Text);
                textBoxname.Clear();
                textBoxname.Focus();
            }
        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            if (cmblista.SelectedIndex == 0)
                MessageBox.Show("Por favor selecione um item", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            {
                cmblista.Items.Remove(cmblista.SelectedItem);
                cmblista.SelectedIndex = 0;
            }
        }
    }
}
