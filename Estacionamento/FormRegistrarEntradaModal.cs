﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPresentationLayer
{
    public partial class FormRegistrarEntradaModal : Form
    {
        public FormRegistrarEntradaModal()
        {
            InitializeComponent();
            dtpHora.Format = DateTimePickerFormat.Time;
        }
    }
}