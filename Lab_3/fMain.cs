 using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class fMain : Form
    { 
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddBicycle_Click(object sender, EventArgs e)
        {
            Bicycle bc = new Bicycle();
            fBicycle fbc = new fBicycle(bc);
            if(fbc.ShowDialog() == DialogResult.OK)
            {
                tbPhonesInfo.Text +=
                $"Модель: {bc.Model}\n " +
                $"Рама:{bc.Frame}\n " +
                $"Передачі: {bc.Broadcast}\n " +
                $"Вилка: {bc.Fork}\n " +
                $"Має дзвінок: {(bc.Ring ? "має дзвінок" : "не має дзвінку")}\n " +
                $"Має 3 колеса:{(bc.Has3Wheels ? "має 3 колеса" : "не має 3х колес")}\n ";
            }

        }

        private void btnCloseClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
