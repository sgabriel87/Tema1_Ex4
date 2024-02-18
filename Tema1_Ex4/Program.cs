/*EX4
Scrieti un program care va afisa semnul unui numar citit de la tastatura
• Daca numarul este pozitiv, va afisa “+”
• Daca numarul este negativ, va afisa “-”
• Daca numarul este 0, va afisa “0”*/


    Console.WriteLine("Introduceti un numar:");
    // Citirea numărului de la tastatură și convertirea într-un număr întreg
    int numar = Convert.ToInt32(Console.ReadLine());

    // Verificarea semnului
    if (numar > 0)
    {
        Console.WriteLine("+");
    }
    else if (numar < 0)
    {
        Console.WriteLine("-");
    }
    else
    {
        Console.WriteLine("0");
    }

