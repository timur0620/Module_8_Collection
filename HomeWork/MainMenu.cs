namespace Module_8_Collection.HomeWork
{
    internal class MainMenu
    {
        private const int MENU = 0;
        private const int Task_1 = 1;
        private const int Task_2 = 2;
        private const int Task_3 = 3;
        private const int Task_4 = 4;

        static void Main(string[] args)
        {
            int action = 0;

            while (true)
            {
                switch (action)
                {
                    case MENU:

                        Console.WriteLine($"\n_____________MENU______________\n" +
                                          $"1 Task_1\n" +
                                          $"2 Task_2\n" +
                                          $"3 Task_3\n" +
                                          $"4 Task_4\n"
                                          );
                        action = int.Parse(Console.ReadLine());
                        break;

                    case Task_1:

                        Console.WriteLine($"_____________Task_1______________\n");

                        TaskOne task_1 = new TaskOne();

                        task_1.RunTask_1();

                        action = MENU;
                        break;

                    case Task_2:
                        Console.WriteLine($"_____________Task_2______________\n");

                        TaskTwo task_2 = new TaskTwo();

                        task_2.RunTask_2();

                        action = MENU;
                        break;

                    case Task_3:
                        Console.WriteLine($"_____________Task_3______________\n");

                        TaskThree task_3 = new TaskThree();

                        task_3.RunTaskThree();

                        action = MENU;
                        break;

                    case Task_4:

                        TaskFour task_4 = new TaskFour();

                        Console.WriteLine($"\n_____________Task_4______________\n");

                        task_4.RunTaskFour();

                        action = MENU;
                        break;
                }
            }
        }
    }
}
