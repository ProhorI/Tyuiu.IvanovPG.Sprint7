﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V14
{
    public partial class FormGuide : Form
    {
        public FormGuide()
        {
            InitializeComponent();
        }
        private void textBoxGuide_IPG_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void pictureBoxGuide_IPG_Click(object sender, EventArgs e)
        {

        }
    }
}
