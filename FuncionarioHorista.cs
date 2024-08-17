
namespace Sistema_de_Gestão_de_Funcionários;

// Funcionário que recebe por hora
public class FuncionarioHorista : Funcionario
{
    public int HoursWorked { get; set; }
    public decimal ValuePerHour { get; set; }

    // Método que calcula o salario multiplicando 'HoursWorked' * 'ValuePerHour'
    public override decimal CalculateSalary()
    {
       SalaryBase = HoursWorked * ValuePerHour;  
        return SalaryBase;
       
    }
    // Construtor que inicializa as propriedades
    public FuncionarioHorista(string name, decimal salaryBase, int hoursWorked, decimal valuePerHour) : base (name, salaryBase)
    {
        HoursWorked = hoursWorked;
        ValuePerHour = valuePerHour;
    }
}
