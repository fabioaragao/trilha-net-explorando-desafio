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
            // Verifica se a capacidade da su�te � suficiente para os h�spedes
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Lan�a uma exce��o se a capacidade for menor que o n�mero de h�spedes
                throw new Exception("A capacidade da su�te � menor do que o n�mero de h�spedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de h�spedes
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // C�lculo do valor total da di�ria
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            // Verifica se os dias reservados s�o maiores ou iguais a 10 para aplicar o desconto de 10%
            if (DiasReservados >= 10)
            {
                valorTotal *= 0.90M; // Aplica o desconto de 10%
            }

            return valorTotal;
        }
    }
}
