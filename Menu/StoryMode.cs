namespace GruppUppgift2
{
  public class StoryMode
  {
    private string Name { get; set; } = null!;

    public void StartStory()
    {
      Console.Clear();
      Console.Write("Enter your name to begin the story or write 'skip' to skip the story: ");
      Name = Console.ReadLine()!;
      if (!Name.Equals("skip"))

      {
        StoryLine();
      }
      else
      {
        Program.DisplayMainMenu();
      }
    }

    public void StoryLine()
    {
      Console.Clear();
      Console.WriteLine($"{Name}, a young kid from the slums of Angered Centrum, walked slowly home from school, his head hanging low \n");
      Thread.Sleep(3000);
      Console.WriteLine($"The day had been rough, the other kids had bullied him relentlessly for his dreams \n");
      Thread.Sleep(3000);
      Console.WriteLine($"{Name} often spoke of discovering a virtual gaming world, much like the one in his favorite movie..\n");
      Thread.Sleep(3000);
      Console.WriteLine(@"""Ready Player One""");
      Thread.Sleep(2000);
      Console.Write("\nPress any key to continue ");
      Console.ReadKey();

      Console.Clear();
      Console.Write("But to his classmates, his dreams were just another reason to mock him \n");
      Thread.Sleep(3000);
      Console.Write($"\nAs {Name} walked through the narrow, dimly lit streets, something caught his eye \n");
      Thread.Sleep(3000);
      Console.Write("\nIn the distance, a strange, shining object glimmered \n");
      Thread.Sleep(3000);
      while (true)
      {
        Console.WriteLine("\n'Walk' towards the object:\n");
        string walk = Console.ReadLine()!.ToLower();
        if (walk.Equals("walk"))
        {
          break;
        }
        else
        {
          Console.WriteLine("Please write 'walk' to continue.");
        }
      }

      Walking();
      Sleeping();

      Console.Clear();
      Console.WriteLine($"{Name} \"woke up\", in a place unlike any {Name} had ever seen before \n");
      Thread.Sleep(3000);
      Console.WriteLine($"{Name} was in \"Mundos Ludos\" a fantastical world filled with games and adventures designed just for him \n");
      Thread.Sleep(3000);
      Console.WriteLine($"Here, {Name} could be anything {Name} wanted, do anything {Name} dreamed of. \n");
      Console.WriteLine($"It was as if {Name}'s deepest desires had come to life.");
      Thread.Sleep(3000);

      while (true)
      {
        Console.WriteLine("\n'Play' Mundos Ludos\n");
        string play = Console.ReadLine()!.ToLower();
        if (play.Equals("play"))
        {
          break;
        }
        else
        {
          Console.WriteLine("\nPlease write 'play' to continue.");
        }
      }
    }

    public void Walking()
    {
      Console.Clear();
      Console.Write($@"


                           
                           
  
                                                       
                                          
                       :               
                       ╨");
      Thread.Sleep(1500);
      Console.Clear();
      Console.Write($@"


      (??)
      /}} 
   ∞_/(_
  /|{{\\                                         
 | |-, )                 
  \|/__\               :       
    `  ´               ╨");

      Thread.Sleep(3000);
      Console.Clear();
      Console.Write($@"Curiosity piqued, {Name} decides to approach the source of the light



      /}} 
   ∞_/(_
  /|{{\\                                         
 | |-, )                 
  \|/__\               :       
    `  ´               ╨");

      Thread.Sleep(1500);
      Console.Clear();
      Console.Write($@"Curiosity piqued, {Name} decides to approach the source of the light



         /}} 
      ∞_/(_
     /|{{\\ 
    | |-,/ 
     \|/__\            :
       `  ´            ╨");

      Thread.Sleep(1500);
      Console.Clear();
      Console.Write($@"Curiosity piqued, {Name} decides to approach the source of the light



          /}} 
       ∞_/(_
      /|{{\\ 
     | |-, )
      \|( (            :
         `¯            ╨");

      Thread.Sleep(1500);
      Console.Clear();
      Console.Write($@"Curiosity piqued, {Name} decides to approach the source of the light



          ∞  /}} 
         /|_/(_
        | |{{\\    
         \|`, \        
           (_(         :
             '         ╨");

      Thread.Sleep(1500);
      Console.Clear();
      Console.Write($@"Curiosity piqued, {Name} decides to approach the source of the light


                 .
          ∞  /}} 
         /|_/(_
        | |{{\\ 
         \|`, \        
           (_(         :
             '         ╨");
      Thread.Sleep(750);
      Console.Clear();
      Console.Write($@"Curiosity piqued, {Name} decides to approach the source of the light


                 ..
          ∞  /}} 
         /|_/(_
        | |{{\\ 
         \|`, \        
           (_(         :
             '         ╨");
      Thread.Sleep(750);
      Console.Clear();
      Console.Write($@"Curiosity piqued, {Name} decides to approach the source of the light


                 ...
          ∞  /}} 
         /|_/(_
        | |{{\\ 
         \|`, \        
           (_(         :
             '         ╨");
      Thread.Sleep(750);

      Console.Clear();
      Console.Write($@"Curiosity piqued, {Name} decides to approach the source of the light
                {Name} picks up the shiny object


          ∞  /}} 
         /|_/(_
        | |{{\\ 
         \|`, \        
           (_(         :
             '         ╨");

      Thread.Sleep(2000);
      Console.Clear();
      Console.Write($@"Curiosity piqued, {Name} decides to approach the source of the light
                {Name} picks up the shiny object




            ∞_   
           / /,-´/}}_
          / /,' ,¯¯    :
          |/  ¯¯       ╨");

      Thread.Sleep(1500);
      Console.Clear();
      Console.Write($@"Curiosity piqued, {Name} decides to approach the source of the light
                {Name} picks up the shiny object




                
               --- ∞ _
                ,-'¯´_):
                ¯¯¯ ¯¯ ╨");

      Thread.Sleep(1500);
      Console.Clear();
      Console.Write($@"Curiosity piqued, {Name} decides to approach the source of the light
                {Name} picks up the shiny object




               ∞_   
              / /,-´/}}_ 
             / /,' ,¯¯:
             |/  ¯¯   ╨");

      Thread.Sleep(1500);
      Console.Clear();
      Console.Write($@"Curiosity piqued, {Name} decides to approach the source of the light
                {Name} picks up the shiny object


             ∞  /}}  
            /|_/(_:
           | |{{\\ ╨
            \|`, \
              (_( 
                '          ");
      Thread.Sleep(750);
      Console.Clear();
      Console.Write($@"Curiosity piqued, {Name} decides to approach the source of the light


                    .
             ∞  /}}  
            /|_/(_:
           | |{{\\ ╨
            \|`, \
              (_( 
                '          ");
      Thread.Sleep(750);
      Console.Clear();
      Console.Write($@"Curiosity piqued, {Name} decides to approach the source of the light


                    ..
             ∞  /}}  
            /|_/(_:
           | |{{\\ ╨
            \|`, \
              (_( 
                '          ");
      Thread.Sleep(750);
      Console.Clear();
      Console.Write($@"Curiosity piqued, {Name} decides to approach the source of the light


                    ...
             ∞  /}}  
            /|_/(_:
           | |{{\\ ╨
            \|`, \
              (_( 
                '          ");
      Thread.Sleep(1500);
      Console.Clear();
      Console.Write($@"Curiosity piqued, {Name} decides to approach the source of the light
                   All of a sudden... in an instant... everything went dark.


             ∞  /}}  
            /|_/(_:
           | |{{\\ ╨
            \|`, \
              (_( 
                '          ");
      Thread.Sleep(2500);
    }

    public void Sleeping()
    {
      Console.Clear();
      Thread.Sleep(2800);
      Console.Clear();
      Console.WriteLine(@"
                              
                             
                              
        .--.  Z                        ∞__
       / _(c\   .-.     __              \ \
      | / /  '-;   \'-'`  `\______       \ \
      \_\/'/ __/ )  /  )   |      \--,    \_\
         | \`"" `__-/ .'--/   /--------\ \
          \\`  ///-\/   /   /---;-.    '-'
                       (________\  \
                                 '-'");
      Thread.Sleep(800);
      Console.Clear();
      Console.WriteLine(@"
                              
                             
                              
        .--.  Z Z                      ∞__
       / _(c\   .-.     __              \ \
      | / /  '-;   \'-'`  `\______       \ \
      \_\/'/ __/ )  /  )   |      \--,    \_\
         | \`"" `__-/ .'--/   /--------\ \
          \\`  ///-\/   /   /---;-.    '-'
                       (________\  \
                                 '-'");
      Thread.Sleep(800);
      Console.Clear();
      Console.WriteLine(@"
                              
                             
                  Z
        .--.  Z Z                      ∞__
       / _(c\   .-.     __              \ \
      | / /  '-;   \'-'`  `\______       \ \
      \_\/'/ __/ )  /  )   |      \--,    \_\
         | \`"" `__-/ .'--/   /--------\ \
          \\`  ///-\/   /   /---;-.    '-'
                       (________\  \
                                 '-'");
      Thread.Sleep(800);
      Console.Clear();
      Console.WriteLine(@"
                              
                 z
                  Z
        .--.  Z Z                      ∞__
       / _(c\   .-.     __              \ \
      | / /  '-;   \'-'`  `\______       \ \
      \_\/'/ __/ )  /  )   |      \--,    \_\
         | \`"" `__-/ .'--/   /--------\ \
          \\`  ///-\/   /   /---;-.    '-'
                       (________\  \
                                 '-'");
      Thread.Sleep(800);
      Console.Clear();
      Console.WriteLine(@"
                  z
                 z
                  Z
        .--.  Z Z                      ∞__
       / _(c\   .-.     __              \ \
      | / /  '-;   \'-'`  `\______       \ \
      \_\/'/ __/ )  /  )   |      \--,    \_\
         | \`"" `__-/ .'--/   /--------\ \
          \\`  ///-\/   /   /---;-.    '-'
                       (________\  \
                                 '-'");

      Thread.Sleep(1500);
      Console.Write("\nPress any key to continue ");
      Console.ReadKey();
    }

    public void ExitGameStory()
    {
      Console.WriteLine(@"
You wake up from this dream of Mundos Ludos... only to find yourself back in the dimly lit streets of Angered Centrum. 
Where the bullies surrounded you once again.. 
Only this time, you had a smile to your face, because you knew you weren't insane.");
    }
  }
}
