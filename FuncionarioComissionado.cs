namespace Sistema_de_Gestão_de_Funcionários;

// Classe do funcionário comissionado
public class FuncionarioComissionado : Funcionario
{
    // Vendas Realizadas
    public decimal SalesMade { get; set; }
    // Percentual de Comissão
    public decimal CommissionPercentage { get; set; }

    // Método que retorna o salário base mais o valor das comissões (vendas realizadas * percentual de comissão).
    public override decimal CalculateSalary()
    {
        return SalaryBase + (SalesMade * CommissionPercentage);
    }

    public FuncionarioComissionado(string name, decimal salaryBase, decimal salesMade, decimal commisionPercentage) : base (name, salaryBase)
    {
        SalesMade = salesMade;
        CommissionPercentage = commisionPercentage;
    }
}
