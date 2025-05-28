public class Program
{
    public static double totalInterest (double money, int month, double interestRate)
    {
        double result = 0;
        for (int i = 0; i < month; i++)
        {
            result += money * (interestRate / 100) / 12;
        }
        return result;
    }
    private static void Main(string[] args)
    {
        //khai bao bien
        Console.Write("Enter investment amount: ");
        double money = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter number of months: ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter annual interest rate in percentage: ");
        double interestRate = Convert.ToDouble(Console.ReadLine());

        //in kết quả ra màn hìnhhình
        Console.Write("Total of interest: " + totalInterest(money, month, interestRate));

    }
}