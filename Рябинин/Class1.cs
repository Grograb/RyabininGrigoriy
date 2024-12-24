using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рябинин
{
    public class Building
    {
        public string Adres { get; set; }//Рябинин 34ИС
        public string Discription { get; set; }//Рябинин 34ИС
        public List<Apartament>Library = new List<Apartament>();//Рябинин 34ИС
        public Building(string ad, string ds)
        {
            Adres = ad;
            Discription = ds;
        }//Рябинин 34ИС
        public void Show()
        {
            Console.WriteLine($" Адрес = {Adres}, описание = {Discription}");//Рябинин 34ИС
        }
    }
    public class Apartament
    {//Рябинин 34ИС
        public string Number { get; set; }
        public string Owner { get; set; }
        public Apartament(string nm, string own)//Рябинин 34ИС
        {
            Number = nm;
            Owner = own;//Рябинин 34ИС
        }
        public void ShowAll()
        {
            Console.WriteLine($" номер квартиры = {Number}, владелец = {Owner}");//Рябинин 34ИС
        }
    }
}
//Рябинин 34ИС