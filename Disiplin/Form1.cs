using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Disiplin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void yavruform(Form yavru)
        {
            bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                
               
                if (eleman.Text == yavru.Text)
                {
                    durum = true;
                    eleman.Activate();
                }
                else
                {
                    eleman.Close();
                }
                
                
                 
            }

            if (durum == false)
            {
                yavru.MdiParent = this;
                yavru.Show();
            }
        }



        private void öğrenciİşlemleriAltÖToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yavruform(new frmOgrenciKaydet());

        }
    }
}
