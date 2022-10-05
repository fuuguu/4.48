//Голубихин Данила 22-ИСП-2/2 4.48
//Известен рост трех человек. Определить, одинаков ли их рост?
try
{
    Console.WriteLine("Введите рост 1 человека:");
    double r1=double.Parse(Console.ReadLine());
    Console.WriteLine("Введите рост 2 человека:");
    double r2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите рост 3 человека:");
    double r3 = double.Parse(Console.ReadLine());
    if ((r1==r2)&&(r2==r3)) Console.WriteLine("Рост этих людей одинаковый");
    else Console.WriteLine("Рост этих людей разный");

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
