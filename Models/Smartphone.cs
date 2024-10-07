using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
      
        public string Modelo {get;set;}

        public string Imei {get;set;}

        public int Memoria {get;set;}
      
        public Smartphone(string numero)
        {
            Numero = numero;
            Modelo = Modelo;
            Imei = Imei;
            Memoria = Memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligan do...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
