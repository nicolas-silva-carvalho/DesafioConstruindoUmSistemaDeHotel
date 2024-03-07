using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioConstruindoUmSistemaDeHotel.Models
{
    public class Reserva
    {
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes != null && Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = new List<Pessoa>();

                foreach (var hospede in hospedes)
                {
                    Hospedes.Add(hospede);
                }
            }
            else
            {
                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeDeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if (DiasReservados >= 10)
            {
                decimal comPorcentagem = (Suite.ValorDiaria * DiasReservados - (((Suite.ValorDiaria * DiasReservados) * 10) / 100));
                return comPorcentagem;
            }

            return Suite.ValorDiaria * DiasReservados;
        }
    }
}