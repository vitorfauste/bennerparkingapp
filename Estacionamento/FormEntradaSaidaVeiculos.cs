using BusinessLogicalLayer.Interfaces;
using Microsoft.Extensions.DependencyInjection;
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
        private readonly IVigenciaPrecoService _vigenciaPrecoService;
        private readonly IRegistroEstacionamentoService _registroEstacionamentoService;

        public FormEntradaSaidaVeiculos(IServiceProvider serviceProvider)
        {
            _vigenciaPrecoService = serviceProvider.GetService<IVigenciaPrecoService>();
            _registroEstacionamentoService = serviceProvider.GetService<IRegistroEstacionamentoService>();

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

        private async void btnEntrada_Click(object sender, EventArgs e)
        {
            var valor = await _vigenciaPrecoService.GetInstance();
            FormRegistrarEntradaModal formEntrada = new FormRegistrarEntradaModal(valor.Item != null ? valor.Item.ValorHora : 5, _registroEstacionamentoService);
            formEntrada.ShowDialog();
        }

        private void btnVigencia_Click(object sender, EventArgs e)
        {
            FormAlterarVigenciaPreco formVigencia = new FormAlterarVigenciaPreco(_vigenciaPrecoService);
            formVigencia.ShowDialog();
        }

        private async void FormEntradaSaidaVeiculos_Load(object sender, EventArgs e)
        {
            var movimentacoes = await _registroEstacionamentoService.GetAllMovimentacoes();
            if (movimentacoes != null)
            {
                dgvGridCarros.DataSource = movimentacoes.Itens;
            }
            else
            {
                dgvGridCarros.DataSource = null;
            }
        }
    }
}
