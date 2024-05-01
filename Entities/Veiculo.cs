using System.Text.RegularExpressions;

namespace Entities
{
    public class Veiculo : BaseEntity
    {
        public string Placa { get; set; }

        public Veiculo() { }

        public Veiculo(string placa)
        {
            if (!Regex.IsMatch(placa, "^[a-zA-Z]{3}([-]?)[0-9][A-Za-z0-9][0-9]{2}$"))
                throw new Exception("Formato inválido.");

            Placa = placa.Replace("-", "").ToUpper();
        }
    }
}
