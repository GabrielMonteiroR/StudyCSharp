using System;

namespace chalenge
{
    class Program
    {
        static void Main(string[] args)
        {
            static void ShowProducts(string firstProduct, double priceOne, string secondProduct, double priceTwo)
            {
                Console.WriteLine($"{firstProduct} cujo preço é {priceOne}\n{secondProduct} cujo preço é {priceTwo}");
            }

            static void ShowPerson(int age, int id, char gender)
            {
                Console.WriteLine($"Registro: {age} anos de idade, código {id} e gênero {gender}");
            }





            string firstProduct = "PC";
            string secondProduct = "Desk";

            byte age = 30;
            int id = 5290;
            char gender = 'M';

            double priceOne = 2100.0;
            double priceTwo = 650.50;
            double avg = 53.23321;

            ShowProducts(firstProduct, priceOne, secondProduct, priceTwo);
            ShowPerson(age, id, gender);
        }



    }
}
