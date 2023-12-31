﻿using EleccionsM2.Models;
using EleccionsM2.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EleccionsM2.Views
{
    public partial class FormMunicipi : Form
    {
        MunicipiViewModel viewModelMunicipi = new();
        public Municipi Municipi { get => viewModelMunicipi.MunicipiForm; private set => viewModelMunicipi.MunicipiForm = value; }
        public FormMunicipi()
        {
            InitializeComponent();
            textBoxNomMunicipi.DataBindings.Clear();
            textBoxNomMunicipi.DataBindings.Add("Text", viewModelMunicipi.MunicipiForm, "nomMunicipi");
            textBoxNumRegidors.DataBindings.Clear();
            textBoxNumRegidors.DataBindings.Add("Text", viewModelMunicipi.MunicipiForm, "numeroRegidors");
        }
        private void buttonCrearMunicipi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void textBoxNomMunicipi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                textBoxNumRegidors.Focus();
            }
        }
        private void textBoxNumRegidors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab) && textBoxNomMunicipi.Text != string.Empty && int.Parse(textBoxNumRegidors.Text) != 0)
            {
                buttonCrearMunicipi.Focus();
            }
        }

        private void textBoxNomMunicipi_TextChanged(object sender, EventArgs e)
        {
            textBoxNomMunicipi.MaxLength = 20;
        }

        private void textBoxNumRegidors_TextChanged(object sender, EventArgs e)
        {
            textBoxNumRegidors.MaxLength = 2;
        }
    }
}
