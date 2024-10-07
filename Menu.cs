class Menu
{
    public Menu()
    {
        OnePlayer menu1 = new OnePlayer();
        TwoPlayer menu2 = new TwoPlayer();
        Console.Write("ROCK, PAPER, SCISSORS\nChoose Game Mode:\tSingle Player (1), 2-Player (2)");
        Console.Write("\nType and Enter: ");
        int a = int.Parse(Console.ReadLine());
        if(a == 1){
            menu1.Play();
        }else if(a == 2){
            menu2.Play();
        }else{
            Console.Write("Invalid input!");
        }
    }
}