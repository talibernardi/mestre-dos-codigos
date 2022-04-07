using POO_13;

Televisao televisao = new Televisao();
ControleRemoto controle = new ControleRemoto(televisao);

Console.WriteLine($"Televisão Ligada:\nCanal:{controle.ConsultaCanal()} \nVolume:{controle.ConsultaVolume()}");
controle.AumentarVolume();
controle.AumentarVolume();
controle.AumentarVolume();
controle.AumentarCanal();
Console.WriteLine($"\nTelevisão Ligada:\nCanal:{controle.ConsultaCanal()} \nVolume:{controle.ConsultaVolume()}");
controle.TrocarDeCanal(7);
controle.DiminuirVolume();
controle.AumentarCanal();
Console.WriteLine($"\nTelevisão Ligada:\nCanal:{controle.ConsultaCanal()} \nVolume:{controle.ConsultaVolume()}");

