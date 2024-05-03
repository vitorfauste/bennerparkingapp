using BusinessLogicalLayer.Interfaces;
using Entities;
using System;
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
        private readonly IRegistroEstacionamentoService _registroEstacionamentoService;
        decimal valor;
        public FormRegistrarEntradaModal(decimal valorHora, IRegistroEstacionamentoService registro)
        {
            this.valor = valorHora;
            this._registroEstacionamentoService = registro;
            dtpHora.Format = DateTimePickerFormat.Time;
            txtPlaca.MaxLength = 8;
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            _registroEstacionamentoService.Create(new RegistroEstacionamento(dtpHora.Value, valor, new Veiculo(txtPlaca.Text)));
        }
    }
}
