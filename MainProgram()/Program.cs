using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Рябинин;

namespace MainProgram__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building ps = new Building("Алтуфьевское шоссе 100", "В доме 22 этажа, красного цвета, 5 подьездов");//Рябинин 34ИС
            ps.Show();//Рябинин 34ИС
            Apartament b1 = new Apartament(" 99 ","Никольский Д.А.");//Рябинин 34ИС
            ps.Library.Add(b1);//Рябинин 34ИС
            Apartament b2 = new Apartament("282 ","Ярлыков А.М.");//Рябинин 34ИС
            ps.Library.Add(b2);//Рябинин 34ИС
            Apartament b3 = new Apartament("77 ", "Анашкин А.П.");//Рябинин 34ИС
            ps.Library.Add(b3);//Рябинин 34ИС
            Apartament b4 = new Apartament("132 ", "Шеченков А.М.");//Рябинин 34ИС
            ps.Library.Add(b4);//Рябинин 34ИС
            foreach (Apartament b in ps.Library)//Рябинин 34ИС
            {
                b.ShowAll();//Рябинин 34ИС
            }
            Console.WriteLine("Выполнил Рябинин Григорий 34ИС");//Рябинин 34ИС
            Console.ReadKey();//Рябинин 34ИС
        }
    }
}
