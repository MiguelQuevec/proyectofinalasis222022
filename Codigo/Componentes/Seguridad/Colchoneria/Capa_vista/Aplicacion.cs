﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_vista
{
    public partial class Aplicacion : Form
    {
        public Aplicacion()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Navegador_seg b = new Navegador_seg();
            b.Show();
            this.Hide();
        }
    }
}
