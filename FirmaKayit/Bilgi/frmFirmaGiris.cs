﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaKayit.Bilgi
{
    public partial class frmFirmaGiris : Form
    {
        public frmFirmaGiris()
        {
            InitializeComponent();
        }

        private void btncollaps_Click(object sender, EventArgs e)
        {
            switch(splitContainer1.Panel2Collapsed)
            {
                case true:
                    splitContainer1.Panel2Collapsed = false;
                    btncollaps.Text = "GİZLE";
                    break;
                case false:
                    splitContainer1.Panel2Collapsed = true;
                    btncollaps.Text = "GÖSTER";
                    break;

            }
        }
    }
}
