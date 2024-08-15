using Sistema_De_Estacionamento;


Estacionamento_Class estacionameto = new Estacionamento_Class();
bool exbirtru = true;
while(exbirtru){
    Console.Clear();
    Console.WriteLine("Bem vindo ao estacionamento de aracruz , porfavor escolha sua opção desejada\n\t1- listar o veiculo\n\t 2- ver lista de veiculo\n\t 3- tirar veiuculo\n\t 4- encerra programa");

    int escolhaDeOpção = Convert.ToInt32(Console.ReadLine());
    switch(escolhaDeOpção){
        case 1:
            estacionameto.ListaOveiculo();
        break;
        case 2:
            estacionameto.VerListaDeVeiculos();
        break;
        case 3:
            estacionameto.TiraVeiculo();
        break;
        case 4:
            exbirtru = false;
        break;

        default:
            Console.WriteLine($"a opção {escolhaDeOpção} é invalido.\n porfavor coloque as opções sugerido");
        break;

    }
    Console.WriteLine("presione qualquer tecla pra continuar");
    Console.ReadLine();
}


Console.WriteLine("////////////////////////////////");
Console.WriteLine("///////programa encerrado///////");
Console.WriteLine("////////////////////////////////");