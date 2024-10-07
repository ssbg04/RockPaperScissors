class OnePlayer
{
    public void Play()
    {
        Random random = new Random();
        bool userRestart = true;
        int playerChoose = 0;
        int playerWinStreak = 0;

        do{
            Console.Clear();
            Console.Write("Type and Enter (1/2/3/4) 1 = Rock, 2 = Paper, 3 = Scissors, 4 = exit");
            Console.Write($"\nWin Streak: {playerWinStreak} \t\tInput: ");
            playerChoose = int.Parse(Console.ReadLine());
            


            int randomNum = random.Next(1, 4);
            if(playerChoose == 1 && randomNum == 1){
                Console.Write("You picked Rock, Cpu picked Rock");
                Console.Write("\nTIE!");
            }else if(playerChoose == 1 && randomNum == 2){
                Console.Write("You picked Rock, Cpu picked Paper");
                Console.Write("\nYOU LOSE!");
                playerWinStreak = 0;
            }else if(playerChoose == 1 && randomNum == 3){
                Console.Write("You picked Rock, Cpu picked Scissors");
                Console.Write("\nYOU WIN!");
                playerWinStreak++;
            }

            if(playerChoose == 2 && randomNum == 1){
                Console.Write("You picked Paper, Cpu picked Rock");
                Console.Write("\nYOU WIN!");
                playerWinStreak++;
            }else if(playerChoose == 2 && randomNum == 2){
                Console.Write("You picked Paper, Cpu picked Paper");
                Console.Write("\nTIE!");
            }else if(playerChoose == 2 && randomNum == 3){
                Console.Write("You picked Paper, Cpu picked Scissors");
                Console.Write("\nYOU LOSE!");
                playerWinStreak = 0;
            }

            if(playerChoose == 3 && randomNum == 1){
                Console.Write("You picked Scissors, Cpu picked Rock");
                Console.Write("\nYOU LOSE!");

            }else if(playerChoose == 3 && randomNum == 2){
                Console.Write("You picked Scissors, Cpu picked Paper");
                Console.Write("\nYOU WIN!");
                playerWinStreak++;
            }else if(playerChoose == 3 && randomNum == 3){
                Console.Write("You picked Scissors, Cpu picked Scissors");
                Console.Write("\nTIE!");
                playerWinStreak = 0;
            }

            if(playerChoose == 4){
                Console.Write("Game Exit...");
                userRestart = false;
            }

            Thread.Sleep(1500);

        }while(userRestart);
    }
}