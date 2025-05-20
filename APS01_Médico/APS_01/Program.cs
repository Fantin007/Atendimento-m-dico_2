using System;
using System.Collections.Generic;

class Program
{
    static Queue<Paciente> alta = new Queue<Paciente>();
    static Queue<Paciente> media = new Queue<Paciente>();
    static Queue<Paciente> baixa = new Queue<Paciente>();

    static void Main(string[] args)
    {
        bool sair = false;
        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("=== SIMULAÇÃO DE ATENDIMENTO MÉDICO ===");
            Console.WriteLine("1. Adicionar paciente");
            Console.WriteLine("2. Atender paciente");
            Console.WriteLine("3. Listar fila");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1": AdicionarPaciente(); break;
                case "2": AtenderPaciente(); break;
                case "3": ListarFila(); break;
                case "0": sair = true; break;
                default:
                    Console.WriteLine("Opção inválida!");
                    Console.ReadKey();
                    break;
            }
        }
    }

    class Paciente
    {
        public string Nome { get; set; }
        public int Prioridade { get; set; }
    }

    static void AdicionarPaciente()
    {
        Console.Clear();
        Console.Write("Digite o nome do paciente: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a prioridade (1 a 5, sendo 1 mais urgente): ");
        if (int.TryParse(Console.ReadLine(), out int prioridade))
        {
            if (prioridade < 1 || prioridade > 5)
            {
                Console.WriteLine("Prioridade fora do intervalo!");
            }
            else
            {
                Paciente p = new Paciente { Nome = nome, Prioridade = prioridade };

                if (prioridade <= 2)
                    alta.Enqueue(p);
                else if (prioridade == 3)
                    media.Enqueue(p);
                else
                    baixa.Enqueue(p);

                Console.WriteLine("Paciente adicionado com sucesso!");
            }
        }
        else
        {
            Console.WriteLine("Prioridade inválida.");
        }

        Console.ReadKey();
    }

    static void AtenderPaciente()
    {
        Console.Clear();
        Paciente proximo = null;

        if (alta.Count > 0) proximo = alta.Dequeue();
        else if (media.Count > 0) proximo = media.Dequeue();
        else if (baixa.Count > 0) proximo = baixa.Dequeue();

        if (proximo != null)
        {
            Console.ForegroundColor = CorDaPrioridade(proximo.Prioridade);
            Console.WriteLine($"🔔 Atendendo paciente: {proximo.Nome} (Prioridade {proximo.Prioridade})");
        }
        else
        {
            Console.ResetColor();
            Console.WriteLine("Nenhum paciente aguardando.");
        }

        Console.ResetColor();
        Console.ReadKey();
    }

    static void ListarFila()
    {
        Console.Clear();
        Console.WriteLine("=== LISTA DE PACIENTES ===");

        Console.WriteLine("\n>> Prioridade Alta (1-2)");
        foreach (var p in alta)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"🟥 {p.Nome} (P{p.Prioridade})");
        }

        Console.WriteLine("\n>> Prioridade Média (3)");
        foreach (var p in media)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"🟨 {p.Nome} (P{p.Prioridade})");
        }

        Console.WriteLine("\n>> Prioridade Baixa (4-5)");
        foreach (var p in baixa)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"🟩 {p.Nome} (P{p.Prioridade})");
        }

        Console.ResetColor();
        Console.ReadKey();
    }

    static ConsoleColor CorDaPrioridade(int prioridade)
    {
        if (prioridade <= 2) return ConsoleColor.Red;
        if (prioridade == 3) return ConsoleColor.Yellow;
        return ConsoleColor.Green;
    }
}
