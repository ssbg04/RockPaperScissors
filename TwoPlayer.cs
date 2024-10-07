class TwoPlayer
{
    public void Play()
    {   
        Random ahhhh = new Random();
        bool restart = true;
        int playerOnePick = 0;
        int playerTwoPick = 0;
        while(restart){
            int random = ahhhh.Next(1, 2);
            Console.Clear();
            if(random == 1){
                Console.Write("Player One First");
                Console.Write("\nType and Enter (1/2/3/4) 1 = Rock, 2 = Paper, 3 = Scissors, 4 = exit");
                Console.Write("\nPlayer One: ");
                playerOnePick = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.Write("\nType and Enter (1/2/3/4) 1 = Rock, 2 = Paper, 3 = Scissors, 4 = exit");
                Console.Write("\nPlayer Two: ");
                playerTwoPick = int.Parse(Console.ReadLine());
                Console.Clear();

            }else if(random == 2){
                Console.Write("Player Two First");
                Console.Write("\nType and Enter (1/2/3/4) 1 = Rock, 2 = Paper, 3 = Scissors, 4 = exit");
                Console.Write("\nPlayer Two: ");
                playerTwoPick = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.Write("\nType and Enter (1/2/3/4) 1 = Rock, 2 = Paper, 3 = Scissors, 4 = exit");
                Console.Write("\nPlayer One: ");
                playerOnePick = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            if(playerOnePick == 4 || playerTwoPick == 4){
                Console.Write("Game Exit...");
                restart = false;
            }
            Algo(playerOnePick, playerTwoPick);
            Thread.Sleep(2000);
        }
        
    }

    public void Algo(int a, int b )
    {
        if(a == 1 && b == 1){
            Console.Write("Player One Picked: Rock\nPlayer Two Picked: Rock");
            Console.Write("\nNO WIN, TIE!");
        }else if (a == 1 && b == 2){
            Console.Write("Player One Picked: Rock\nPlayer Two Picked: Paper");
            Console.Write("\nPLAYER TWO WIN!");
        }else if(a == 2 && b == 1){
            Console.Write("Player One Picked: Paper\nPlayer Two Picked: Rock");
            Console.Write("\nPLAYER ONE WIN!");
        }else if(a == 1 && b == 3){
            Console.Write("Player One Picked: Rock\nPlayer Two Picked: Scissors");
            Console.Write("\nPLAYER ONE WIN!");
        }else if (a == 3 && b == 1){
            Console.Write("Player One Picked: Scissors\nPlayer Two Picked: Rock");
            Console.Write("\nPLAYER TWO WIN!");
        }else if(a == 2 && b == 2){
            Console.Write("Player One Picked: Paper\nPlayer Two Picked: Paper");
            Console.Write("\nNO WIN, TIE!");
        }else if(a == 2 && b == 3){
            Console.Write("Player One Picked: Paper\nPlayer Two Picked: Scissors");
            Console.Write("\nPLAYER TWO WIN!");
        }else if(a == 3 && b == 2){
            Console.Write("Player One Picked: Scissors\nPlayer Two Picked: Paper");
            Console.Write("\nPLAYER ONE WIN!");
        }else if(a == 3 && b == 3){
            Console.Write("Player One Picked: Scissors\nPlayer Two Picked: Scissors");
            Console.Write("\nNO WIN, TIE!");
        }
    }
}