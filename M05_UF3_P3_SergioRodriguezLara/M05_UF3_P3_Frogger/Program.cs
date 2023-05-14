using System;
using System.Collections.Generic;

namespace M05_UF3_P3_Frogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(Utils.MAP_WIDTH, Utils.MAP_HEIGHT);
            List<ConsoleColor> colorsGreen = new List<ConsoleColor> { ConsoleColor.Green };
            List<ConsoleColor> colorsBlue = new List<ConsoleColor> { ConsoleColor.Blue };


            Player player = new Player();

            Lane lane1 = new Lane(1, true, ConsoleColor.Blue, true, false, 0.4f, Utils.charCars, new List<ConsoleColor>(Utils.colorsCars));
            Lane lane2 = new Lane(2, false, ConsoleColor.Blue, false, true, 0.3f, Utils.charLogs, new List<ConsoleColor>(Utils.colorsLogs));
            Lane lane3 = new Lane(3, true, ConsoleColor.Blue, true, false, 0.4f, Utils.charCars, new List<ConsoleColor> {ConsoleColor.DarkYellow});
            Lane lane4 = new Lane(4, false, ConsoleColor.Blue, false, true, 0.3f, Utils.charLogs, new List<ConsoleColor>(Utils.colorsLogs));
            Lane lane5 = new Lane(5, false, ConsoleColor.Black, false, true, 0.3f, Utils.charLogs, new List<ConsoleColor>(Utils.colorsLogs));
            Lane lane6 = new Lane(6, false, ConsoleColor.Black, false, true, 0.3f, Utils.charLogs, new List<ConsoleColor>(Utils.colorsLogs));
            Lane lane7 = new Lane(6, false, ConsoleColor.Black, false, true, 0.3f, Utils.charLogs, new List<ConsoleColor>(Utils.colorsLogs));
            Lane lane8 = new Lane(6, false, ConsoleColor.Black, false, true, 0.3f, Utils.charLogs, new List<ConsoleColor>(Utils.colorsLogs));


            Utils.GAME_STATE gameState = Utils.GAME_STATE.RUNNING;

            while (gameState == Utils.GAME_STATE.RUNNING)
            {
                Console.Clear();

                lane1.Draw();
                lane2.Draw();
                lane3.Draw();
                lane4.Draw();
                lane5.Draw();
                lane6.Draw();
                lane7.Draw();
                lane8.Draw();

                player.Draw();

                Vector2Int playerMovement = Utils.Input();

                gameState = player.Update(playerMovement, new List<Lane> { lane1, lane2 });
                lane1.Update();
                lane2.Update();
                lane3.Update();
                lane4.Update();
                lane5.Update();
                lane6.Update();
                lane7.Update();
                lane8.Update();

                System.Threading.Thread.Sleep(200);
            }

            Console.Clear();
            if (gameState == Utils.GAME_STATE.WIN)
            {
                Console.WriteLine("¡Has ganado!");
            }
            else if (gameState == Utils.GAME_STATE.LOOSE)
            {
                Console.WriteLine("¡Has perdido!");
            }

            Console.ReadLine();
        }
    }
}

