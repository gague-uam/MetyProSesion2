﻿using MyApp1.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = tbNombre1.Text;
            persona.FechaNac = dtpFechaNac.Value;
            MessageBox.Show(persona.EvaluarEdad());
        }
    }
}
