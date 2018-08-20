using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3 {
    public partial class frmAtiv2 : Form {
        public frmAtiv2() {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            lstCursos.Items.Add(txtCurso.Text);
            txtCurso.Focus();
            txtCurso.Clear();

        }

        private void lstCursos_SelectedIndexChanged(object sender, EventArgs e) {
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            lstCursos.Items.Remove(lstCursos.SelectedItem);
            txtCurso.Focus();
            txtCurso.Clear();
        }

        private void btnIncluirUni_Click(object sender, EventArgs e) {
            lstUni.Items.Add(txtUni.Text);
            txtUni.Focus();
            txtUni.Clear();
        }

        private void lstUni_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btnExcluirUni_Click(object sender, EventArgs e) {
            lstUni.Items.Remove(lstUni.SelectedItem);
            txtUni.Focus();
            txtUni.Clear();
        }

        private void btnExcluirTd_Click(object sender, EventArgs e) {
            lstUni.Items.Clear();
            lstCursos.Items.Clear();
            txtUni.Clear();
            txtCurso.Clear();


        }

        private void btnSair_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
