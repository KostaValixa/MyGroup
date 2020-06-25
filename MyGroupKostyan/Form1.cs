using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGroupKostyan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butCreate_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Fum = txtFum.Text;
            string Num = txtNum.Text;
            string Adres = txtAdres.Text;
            TableView.Rows.Add(Name, Fum, Num, Adres);  
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            int indeks = TableView.SelectedCells[0].RowIndex;
            TableView.Rows.RemoveAt(indeks);
        }
    }
}
