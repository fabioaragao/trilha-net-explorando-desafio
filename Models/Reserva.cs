namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verifica se a capacidade da suíte é suficiente para os hóspedes
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Lança uma exceção se a capacidade for menor que o número de hóspedes
                throw new Exception("A capacidade da suíte é menor do que o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Cálculo do valor total da diária
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            // Verifica se os dias reservados são maiores ou iguais a 10 para aplicar o desconto de 10%
            if (DiasReservados >= 10)
            {
                valorTotal *= 0.90M; // Aplica o desconto de 10%
            }

            return valorTotal;
        }
    }
}
