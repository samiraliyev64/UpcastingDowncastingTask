using System;

namespace UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string metn = "sallam";
            metn.CustomContains("fjjgsm");

            char herf = 'j';
            metn.CustomContains(herf);
            
            int num1 = 5;
            int num2 = 18;

            num1.IsPrime();
            num2.IsPrime();
        }
    }
}
