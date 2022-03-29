using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula4
{
    public class Carro
    {
        #region Propriedades
        public int Id { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int AnoModelo { get; set; }

        public int AnoFabricacao { get; set; }

        public string Cor { get; set; }

        public int Velocidade { get; set; }

        public bool StatusCarro { get; set; }

        public bool Buzinar { get; set; }

        public bool Ar { get; set; }
        #endregion

        #region Metodos
        //Acelera
        public void Acelerar(int Velocidade)
        {
            this.Velocidade += Velocidade;
        }

        //Freia
        public void Freiar(int Velocidade)
        {
            this.Velocidade -= Velocidade;
        }

        //Liga
        public void Ligar()
        {
            this.StatusCarro = true;
        }

        //Desliga
        public void Desligar()
        {
            this.StatusCarro = false;
        }

        //rAr
        public void LigarAr()
        {
            if (this.Ar == false)
            {
                if (this.StatusCarro == true)
                {
                    this.Ar = true;
                }
                else
                    Console.WriteLine("O carro esta desligado!");
            }
            else
                Console.WriteLine("O ar já esta ligado!");
        }
        public void DesligarAr()
        {
            if (this.Ar == true)
            {
                this.Ar = false;
            }
            else
                Console.WriteLine("O ar condicionado já esta desligado");
        }

        //Buzina
        public void LigarBuzina()
        {
            this.Buzinar = true;
        }

        public void DesligarBuzina()
        {
            this.Buzinar = false;
        }
      

        public override string ToString()
        {
            return "\nId: " + this.Id +
                "\nMarca: " + this.Marca +
                "\nModelo: " + this.Modelo +
                "\nAno Modelo: " + this.AnoModelo +
                "\nAno Fabricação: " + this.AnoFabricacao +
                "\nCor: " + this.Cor +
                "\nStaus Carro: " + this.StatusCarro +
                "\nVelocidade: " + this.Velocidade +
                "\nBuzina: " + this.Buzinar +
                "\nAr: " + this.Ar;

        }
        #endregion

    }
}
