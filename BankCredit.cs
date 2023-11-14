using System.Text;

namespace HW_8_2_BankCredit
{
    internal class BankCredit
    {
        //Уявіть, що ви реалізуєте програму для банку, яка допомагає визначити, чи погасив клієнт кредит чи ні.
        //Припустимо, щомісячна сума платежу має становити 100 грн. Клієнт повинен виконати 7 платежів,
        //але може платити рідше за великі суми.
        //Тобто може двома платежами по 300 і 400 грн. закрити весь обов'язок.
        //Створіть метод, який як аргумент прийматиме суму платежу, введену економістом банку.
        //Метод виводить на екран інформацію про стан кредиту
        //(сума заборгованості, сума переплати, повідомлення про відсутність боргу). 

        static void CalculSchedulePayment (double balanceOwed, in double currPayAm, ushort iMonth)
        {

            if (balanceOwed > 0)
            {
                Console.Write($"{iMonth:G}-й місяць. Залишок заборгованності {balanceOwed:G} грн. ");
                Console.WriteLine($"Платіж {iMonth:G}-го місяця {currPayAm:G} грн.");
                CalculSchedulePayment(Math.Round(balanceOwed-currPayAm,2), currPayAm, (ushort)(iMonth+1));
            }
            else
            {
                Console.WriteLine($"На {iMonth:G}-й місяць кредит буде погашений! Вм будете вільні)))");
                if (balanceOwed < 0) Console.WriteLine($"Переплата складе {-balanceOwed:G} грн.");
                else Console.WriteLine("Вм вийдете в ноль!");
            };
        }

        static void Main(string[] args)
        {
            double initialDebtAmount;
            double monthPayment;

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Goodbye, World!\nHomeWork 8.2. Банковский кредит.\n");
            Console.Write("Початкова сума заборгованості складає : ");
            initialDebtAmount=Convert.ToDouble(Console.ReadLine());
            Console.Write("Запланований щомісячний платіж буде   : ");
            monthPayment = Convert.ToDouble(Console.ReadLine());

            CalculSchedulePayment(initialDebtAmount, monthPayment, 1);
        }
    }
}