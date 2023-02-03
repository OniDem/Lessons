namespace ConsoleApp
{
    internal class Program
    {

        class Player
        {
            private int _health;
            private double _height;
            private double _width;
            private int _food;
            private int _armor;
            private double _x;
            private double _y;
            private double _z;

            public void Out()
            {
                Console.WriteLine($"Player healt is {_health}");
                Console.WriteLine($"Player height is {_height}");
                Console.WriteLine($"Player widht is {_width}");
                Console.WriteLine($"Player food is {_food}");
                Console.WriteLine($"Player armor is {_armor}");
                Console.WriteLine($"Player x coords is {_x}");
                Console.WriteLine($"Player y coords is {_y}");
                Console.WriteLine($"Player z coords is {_z}");
                Console.WriteLine();
            }

            public Player()
            {
                _health = 100;
                _height = 1.8; //В метрах 
                _width = 0.6; //В метрах    
                _food = 100;
                _armor = 0;

                _x = 0;
                _y = 0;
                _z = 0;
            }

            public Player(int health, int food, int armor)
            {
                _health = health;
                _height = 1.8; //В метрах 
                _width = 0.6; //В метрах
                _food = food;
                _armor = armor;

                _x = 0;
                _y = 0;
                _z = 0;
            }

            public Player(double height, double width)
            {
                _health = 100;   
                _height = height;
                _width = width;
                _food = 100;
                _armor = 0;

                _x = 0;
                _y = 0;
                _z = 0;
            }

            public Player(double x, double y, double z)
            {
                _health = 100;
                _height = 1.8; //В метрах 
                _width = 0.6; //В метрах    
                _food = 100;
                _armor = 0;

                _x = x;
                _y = y;
                _z = z;
            }

            public Player(int health, double height, double width, int food, int armor, double x, double y, double z)
            {
                _health = health;
                _height = height;
                _width = width;
                _food = food;
                _armor = armor;

                _x = x;
                _y = y;
                _z = z;
            }

        }

       static public void Main()
        {
            int health = 10;
            int food = 5;
            int armor = 10;
            double height = 3;
            double width = 1;
            double x = 10;
            double y = 10;
            double z = 10;
            Player player = new Player();
            Player player1 = new Player(health, food, armor);
            Player player2 = new Player(height, width);
            Player player3= new Player(x, y, z);
            Player player4= new Player(health, height, width, food, armor, x, y, z);

            player.Out();
            player1.Out();
            player2.Out();
            player3.Out();
            player4.Out();




            ////
            int[] arr = new int[10];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                Console.Write(arr[i]);
            }
            /////
            ///





        }
    }
}