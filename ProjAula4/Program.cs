
using ProjAula4;

Carro carro1 = new Carro();

carro1.Id = 1;
carro1.Marca = "Fiat";
carro1.Modelo = "Toro";
carro1.AnoFabricacao = 2022;
carro1.AnoModelo = 2022;
carro1.Cor = "Vermelho";
carro1.Ligar();
carro1.Acelerar(150);
carro1.LigarBuzina();
carro1.LigarAr();

Carro carro2 = new Carro()
{
    Id = 2,
    Marca = "Hyundai",
    Modelo = "HB20",
    AnoFabricacao = 2020,
    AnoModelo = 2021,
    Cor = "Preto"
};

Console.WriteLine(carro1);
Console.WriteLine(carro2);