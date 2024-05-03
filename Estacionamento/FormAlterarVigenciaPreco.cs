using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BusinessLogicalLayer.Interfaces;
using Entities;

namespace WFPresentationLayer
{
    public partial class FormAlterarVigenciaPreco : Form
    {
        private readonly IVigenciaPrecoService _vigenciaPrecoService;
        bool HasVigence = true;
        public FormAlterarVigenciaPreco(IVigenciaPrecoService vigenciaPrecoService)
        {
            this._vigenciaPrecoService = vigenciaPrecoService;
            InitializeComponent();

            txtValor.KeyPress += new KeyPressEventHandler(this.txtValor_KeyPress);
            txtValor.TextChanged += new EventHandler(this.txtValor_TextChanged);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e controle de teclas
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            // Remove o manipulador de eventos para evitar um loop infinito
            txtValor.TextChanged -= this.txtValor_TextChanged;

            string value = txtValor.Text.Replace(",", "").Replace("R$", "").Replace(" ", "").Replace(".", "");

            if (decimal.TryParse(value, out decimal aux))
            {
                txtValor.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", aux / 100);
                txtValor.Select(txtValor.Text.Length, 0);
            }

            // Adiciona o manipulador de eventos de volta
            txtValor.TextChanged += this.txtValor_TextChanged;
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            VigenciaPreco vigencia = new()
            {
                Inicio = Convert.ToDateTime(dtpInicioVigencia.Text),
                Fim = Convert.ToDateTime(dtpFimVigencia.Text),
                ValorHora = Convert.ToDecimal(txtValor.Text.Replace("R", "").Replace("$", "").Replace(",", ".").Replace(" ", ""))
            };
            var response = HasVigence ? await _vigenciaPrecoService.UpdateInstance(vigencia) : await _vigenciaPrecoService.Create(vigencia);
            MessageBox.Show(response.Message);
        }

        private async void FormAlterarVigenciaPreco_Load(object sender, EventArgs e)
        {
            //var vigence = await _vigenciaPrecoService.GetInstance();
            //if (vigence != null)
            //{
            //    dtpInicioVigencia.Value = vigence.Item.Inicio;
            //    dtpFimVigencia.Value = vigence.Item.Fim;
            //    txtValor.Text = vigence.Item.ValorHora.ToString();
            //}
            //else
            //{ HasVigence = false; }
        }
    }
}
