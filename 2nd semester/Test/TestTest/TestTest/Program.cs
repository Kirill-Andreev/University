using System;

namespace TestTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GameTools gameTools = new GameTools();
            Player player = new Player();


            player.GetWound(20); //нанесено урон 20
            player.GetWound(30); //нанесено урон 30
            player.GetWound(20); //нанесено урон 20
            player.PrintPulse();//печатаем пульс 

            //сохраняем состояние
            gameTools.SaveState(player);

            player.GetCure(30); //принимем лекарство
            player.PrintPulse();//печатаем пульс

            //восстанавливаем состояние
            gameTools.LoadState(player);

            player.PrintPulse(); //печатаем пульс

            Console.ReadLine();
        }
    }
}
