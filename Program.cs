// Main
int userInput= GetUserChoice(); // Priming read 
while (userInput !=3){          // Condition Check 
    RouteEm(userInput);
    userInput = GetUserChoice(); // Update Read 
}

// End Main

static int GetUserChoice()
{
    Display();
    string userInput= Console.ReadLine(); 
    if(IsVailidChoice(userInput)){
        return int.Parse(userInput);
    }
    return int.Parse(Console.ReadLine());
}

static void Display() 
{
    Console.Clear();
    System.Console.WriteLine("Enter 1 for Full Triangle\nEnter 2 for Partital Triangle\nEnter 3 to exit");
    
}

static bool IsVailidChoice(string userInput)
{
    if(userInput=="1" || userInput=="2" || userInput=="3"){
        return true; 
    }
    return false;
}

static void SayInvaild()
{
    System.Console.WriteLine("Invaild Choice");
    PauseAction();
}

static void FullTriangle()
{   Random rnd = new Random();
    int i, j, k; 
    int n = rnd.Next(3,9);
            for (i = 1; i <= n; i++ )
            {
               for ( j = 1; j >=n; j++)
               {
                System.Console.Write(" ");
               }
               for (k= 1; k<=i; k++)
               {
                Console.Write("* ");
               }
            Console.WriteLine("");
            }

    PauseAction();

}

static void PartTriangle()
{
    int n = new Random().Next(3,10);
    for (int i =1; i <= n; i++){
        for(int j =1; j<= i; j++){
            if(j == 1 || j==i || i==n){
                Console.Write("* ");
            }
            else{
                int number = new Random().Next(0,10);
                if (number ==0){
                    Console.Write("* ");
                }
                else{
                    Console.Write(" ");
                }
             }

        }
        Console.WriteLine();
        }
    PauseAction();
}

static void PauseAction() 
 {
    System.Console.WriteLine("Press any key to return to the menu");
    Console.ReadKey();
 }


static void RouteEm(int menuChoice)
{
    if(menuChoice==1){
        FullTriangle();
    }
    else if(menuChoice==2){
        PartTriangle();
    }
    else if(menuChoice!=3)
    {
        SayInvaild();
    }
 
 }

