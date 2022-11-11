using System;
namespace SHVFS_P101_GD08_Naomi
{
    public class program
    {
        public static void Main()
        {
            string name;
            string Guessname;
            int jishuqi = 1;
            string[]Fivehub = { "Naomi", "Cloud", "Bandy", "Oprah", "Johnny" };
            Random random = new Random();
            int suijishu = random.Next(Fivehub.Length);
            Console.WriteLine($"Welcome,please enter your name.");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Nice to meet you,{name},let's guess a name of Naomi,Cloud,Bandy,Oprah,Johnny,please enter a name");
            Guessname = Console.ReadLine();
            Console.Clear();
            while(Guessname!= Fivehub[suijishu])
            {
                Console.WriteLine("You are wrong,try again.");
                jishuqi++;
                Console.WriteLine($"Let's guess a name of Naomi,Cloud,Bandy,Oprah,Johnny,please enter a name");
                Guessname = Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine($"Good!You are right.YOU have tried {jishuqi} times");



        }
        
            


            
    }
}
