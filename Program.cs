/*1 dan 1000 gacha bo’lgan toq sonlarni yig’indisini ekranga chiqaradigan dastur tuzing.
 While loop dan foydalaning!
*/
using System;
namespace Takrorlash
{
    class Program
    {
        static void Main ()
        {
            int result = 0;
            int i = 0;
            while(i < 1000)
            {
                if(i % 2 == 1){
                    result += i;
                    i++;       
                }
                else
                {
                    i++;
                }
            }   
            Console.WriteLine ($"Natija: {result}");
            
        }
    }
}
