using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_De_Estacionamento
{
    public class Estacionamento_Class
    {
        private List<string> veiculos = new List<string>(); 
        public void ListaOveiculo(){
            Console.WriteLine("porfavor coloque a sua placa");
            string addPlaca = Console.ReadLine();
            veiculos.Add(addPlaca);
        }

        public void VerListaDeVeiculos (){
            if (veiculos.Any()){
                for(int contador = 0; contador < veiculos.Count(); contador++){
                    Console.WriteLine($"Essas são as listas de carros estacionados- {contador} - {veiculos[contador]}");
                }
            }
            else{
                Console.WriteLine("Não a veiculos no estacinamento");

            }

        }
        public void TiraVeiculo(){
            Console.WriteLine("Coloque o nome da placa do veiculo");
            string nomeDaPLaca = Console.ReadLine();
            if(veiculos.Any(x => x.ToUpper() == nomeDaPLaca.ToUpper())){
                Random random = new Random();
                int horaAleatorio = random.Next(1,24);

                decimal valorTotal = horaAleatorio * 10;

                Console.WriteLine($"voce ficou {horaAleatorio} Horas por isso o total sera de R${valorTotal}\n \n veiculo removido com sucesso");
            }
            else{
                Console.WriteLine("veiculo não encontrado");
            }


        }
        
    }
}