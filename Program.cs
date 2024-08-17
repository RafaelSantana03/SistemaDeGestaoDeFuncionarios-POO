using Sistema_de_Gestão_de_Funcionários;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("## Sistema de Gestão de Funcionários  ##\n");
Console.ResetColor();

List<Funcionario> funcionarios = new List<Funcionario>();
// Criando funcionarioHorista e adicionando a lista
FuncionarioHorista funcionarioHorista = new("Rafael",0,40, 50);
funcionarioHorista.CalculateSalary();
funcionarios.Add(funcionarioHorista);

// Criando funcionarioComissionado e adicionando a lista
FuncionarioComissionado funcionarioComissionado = new("Pedro", 2000, 15, 3);
funcionarioComissionado.CalculateSalary();
funcionarios.Add(funcionarioComissionado);

// Criando funcionario e adicionando a lista
FuncionarioGerente funcionarioGerente = new("Ricardo", 5000, 2000);
funcionarioGerente.CalculateSalary();
funcionarios.Add(funcionarioGerente);

foreach (var funcionario in funcionarios)
{
    Console.WriteLine($"{funcionario.ExibirDados()}\n");
}






