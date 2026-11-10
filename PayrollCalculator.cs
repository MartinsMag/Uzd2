// Paskaidrojums: Polimorfisms redzams rindā e.CalculateSalary() – katrs darbinieka tips to izpilda
// savādāk, lai gan mainīgais ir tipa Employee. PayrollCalculator nebija jāmaina, jo tas strādā ar
// abstrakto Employee, tāpēc jaunu tipu (SalesEmployee) var pievienot, nemainot esošo kodu (O princips),
// un jebkuru pēcteci var lietot bāzes klases vietā (L princips).
public class PayrollCalculator
{
    public decimal TotalSalary(List<Employee> employees)
    {
        decimal total = 0;
        foreach (Employee e in employees)
        {
            total += e.CalculateSalary();
        }
        return total;
    }
}
