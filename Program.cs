Console.WriteLine("---Esperto Contra Sabido---\n");

Console.Write("quantos alimentos serão distribuidos? ");

int totalAlimentos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int restantes = totalAlimentos;
int picapau = 0, raposa = 0;
int contadorparamim = 0, contadorparavoce = 0;

while(restantes > 0)
{
    contadorparavoce = contadorparavoce +1;
    picapau = picapau + 1;
    restantes = restantes - 1;

    Console.WriteLine($"{picapau} para você. ");
    
    contadorparamim = 0;

    while(restantes >0 && contadorparamim < contadorparavoce)
    {
        contadorparamim = contadorparamim + 1;
        raposa = raposa + 1;
        restantes = restantes - 1;
        
        Console.Write($"{contadorparamim} para mim, ");

    }
    Console.WriteLine();

}
Console.WriteLine($"picapau recebeu {picapau} alimento(s)");
Console.WriteLine($"raposa recebeu {raposa} alimento(s)");



