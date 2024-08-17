namespace Sistema_de_Gestão_de_Funcionários;

// Classe Gerente
public class FuncionarioGerente : Funcionario
{
    public decimal Bonus { get; set; }

    public override decimal CalculateSalary()
    {
        return SalaryBase + Bonus;
    }

    public FuncionarioGerente(string name, decimal salaryBase, decimal bonus) : base(name, salaryBase)
    {
         Bonus = bonus;
    }
}
