using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPresentationLayer
{
    public partial class FormEntradaSaidaVeiculos : Form
    {
        public FormEntradaSaidaVeiculos()
        {

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += new EventHandler(this.timer_Tick);
            timer.Start();
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss");
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            FormRegistrarEntradaModal formEntrada = new FormRegistrarEntradaModal();
            formEntrada.ShowDialog();
        }

        private void btnVigencia_Click(object sender, EventArgs e)
        {
            FormAlterarVigenciaPreco formVigencia = new FormAlterarVigenciaPreco();
            formVigencia.ShowDialog();
        }
    }
}
