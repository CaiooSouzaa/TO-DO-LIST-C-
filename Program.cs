List<string> tarefa = new List<string>();
List<bool> concluida = new List<bool>();
char opcao;
int opcaoTarefa, indice, remover;
string status, novaTerefa;

Console.Write("Deseja nserir algo na sua lista [s/n]: ");
opcao = char.Parse(Console.ReadLine());

while (opcao == 's')
{
    Console.WriteLine("[1] - Adicionar tarefa");
    Console.WriteLine("[2] - Listar tarefas");
    Console.WriteLine("[3] - Tarefas concluidas");
    Console.WriteLine("[4] - Remover tarefa");
    Console.WriteLine("[0] - Sair");
    opcaoTarefa = int.Parse(Console.ReadLine());

    if (opcaoTarefa == 1)
    {
        //add tarefa

        Console.Write("Digite a tarefa: ");
        novaTerefa = Console.ReadLine();
        tarefa.Add(novaTerefa);
        concluida.Add(false);
        Console.WriteLine("Tarefa adiciona com sucesso");
    }
    else if (opcaoTarefa == 2)
    {
        //Lista tarefas
        Console.Write("Tarefas adicionadas");

        for (int i = 0; i < tarefa.Count; i++)
        {
            status = concluida[i] ? "[x]" : "[]";
            Console.WriteLine($"{i + 1}. {status} {tarefa[i]}");
        }
    }
    else if (opcaoTarefa == 3)
    {
        //Conclui a tarefa
        Console.Write("Tarefas concluidas");

        indice = int.Parse(Console.ReadLine()) - 1;

        if (indice >= 0 && indice < tarefa.Count)
        {
            concluida[indice] = true;
            Console.WriteLine("Tarefa marcada como concluida");
        }
        else
        {
            Console.WriteLine("Numero invalido");
        }
    }
    else if (opcaoTarefa == 4)
    {
        //Remove a tarefa
        Console.Write("Remover tarefa");
        remover = int.Parse(Console.ReadLine());
        if (remover >= 0 && remover < tarefa.Count)
        {
            tarefa.RemoveAt(remover);
            concluida.RemoveAt(remover);
            Console.WriteLine("Tarefa removida");
        }
        else
        {
            Console.WriteLine("Numero invalido");
        }
    }
    else
    {
        Console.WriteLine("Saindo");
    }

    Console.Write("Pressione ENTER para continuar...");
    Console.ReadLine();
}

Console.WriteLine("Voce encerrou o app, volte depois 😊");