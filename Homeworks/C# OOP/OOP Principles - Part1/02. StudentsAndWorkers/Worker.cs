public class Worker:Human
{
    private decimal weekSalary;
    private int workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
        :base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary { get; private set; }
    public int WorkHoursPerDay { get; private set; }

    public decimal MoneyPerHour(decimal weekSalary, int workHoursPerDay)
    {
        return weekSalary / (decimal)(workHoursPerDay * 5);
    }
}