
namespace Sistema_de_Gestão_de_Funcionários;

// Classe Base
public class Funcionario
{
    public string? Name { get; set; }
    public decimal SalaryBase { get; set; }

    //Métodos
    public virtual decimal CalculateSalary()
    {
        return SalaryBase;
    }
    // Métodos que exibe os dados do funcionário
    public string ExibirDados()
    {
        return ($"Nome do Funcinário: {Name}\nSalário do Funcionário: {SalaryBase.ToString("C")}");
    }

    public Funcionario(string name, decimal salaryBase)
    {
        Name = name;
        SalaryBase = salaryBase;
    }
}
