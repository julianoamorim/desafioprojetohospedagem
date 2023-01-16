using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioprojetohospedagem.models
{
    public class Reserva
    {
        public Reserva(int diasReservados){
            DiasReservados = diasReservados;
        }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes){
            Hospedes = hospedes;
        }
        public void CadastrarSuite(Suite suite){
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(){
            if(Hospedes.Count() > 0 && Hospedes.Count() <= Suite.Capacidade){
                return Hospedes.Count();
            }
            else{
                throw new Exception("A quantidade de hospedes nao pode exceder a capacidade da suite");
            }
        }
        public decimal CalcularValorDiaria(){
            if( DiasReservados >= 10){
                Suite.ValorDiaria = Suite.ValorDiaria*0.9M;
                return Suite.ValorDiaria;
            }
            else{
                return Suite.ValorDiaria;
            }
        }
    }
}