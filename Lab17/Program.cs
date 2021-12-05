using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Счет в банке

            BillBank<int> billBank1 = new BillBank<int>();
            billBank1.WriteBill();
            billBank1.PrintBill();

            Console.WriteLine();

            BillBank<string> billBank2 = new BillBank<string>();
            billBank2.WriteBill();
            billBank2.PrintBill();
            Console.ReadKey();
        }
        public class BillBank<T>
        {
            private T numberBill { get; set; }
            public T NumberBill
            {
                get
                {
                    return numberBill;
                }
                set
                {
                    numberBill = value;
                }
            }
            private double balanceBill { get; set; }
            public double BalanceBill
            {
                get
                {
                    return balanceBill;
                }
                set
                {
                    if (value > 0)
                    {
                        balanceBill = value;
                    }
                    else
                    {
                        Console.WriteLine("Введен недопустимый номер счета");
                    }
                }
            }
            private string ownerBill { get; set; }
            public string OwnerBill
            {
                get
                {
                    return ownerBill;
                }
                set
                {
                    ownerBill = value;
                }
            }
            public void WriteBill()
            {
                Console.WriteLine("Введите данные счета в банке\nВведите номер счета: ");
                NumberBill = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                Console.WriteLine("Введите баланс счета: ");
                BalanceBill = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите ФИО владельца счета: ");
                OwnerBill = Convert.ToString(Console.ReadLine());
            }
            public void PrintBill()
            {
                Console.WriteLine("Данные счета в банке: номер - {0}, баланс - {1} руб, ФИО владельца - {2}", NumberBill, BalanceBill, OwnerBill);
            }
        }
    }
}
