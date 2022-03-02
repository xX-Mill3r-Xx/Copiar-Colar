using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ctrl_C_Ctrl_V
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Copiar_Click(object sender, EventArgs e)
        {
            txt_Box1.SelectAll();
            txt_Box1.Focus();
            txt_Box1.Copy();
            lbl_FeedBack.Text = "Texto copiado para area de transferencia!";
        }

        private void btn_Colar_Click(object sender, EventArgs e)
        {
            txt_Box2.Paste();
            txt_Box1.Text = "";
            lbl_FeedBack.Text = "Feed:";
        }
    }
}
