using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Quality
{
    public partial class FCHXZ : DevExpress.XtraEditors.XtraForm
    {
        public FCHXZ()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listView2.Items.Add(listView1.SelectedItems[0].Text);
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(listView2.SelectedItems[0].Text);
            listView2.Items.Remove(listView2.SelectedItems[0]);
        }

        private void FCHXZ_Load(object sender, EventArgs e)
        {
            this.FSUPPLY.Text = Model.FSUPPLY;
            this.textBox1.Text = Model.FitemName;
        }
    }
}