using System;
using System.Collections.Generic;
using System.Text;

namespace UpcastingDowncasting
{
    static class ExtensionMethods
    {

        public static void CustomContains(this string metn)
        {
           
        }

        public static bool CustomContains(this string metn, string metn2)
        {
            bool checking = false;
            string newStr = String.Empty;
            int extraI = 0;
            int extraJ = 0;

            for (int i = 0; i < metn2.Length; i++)
            {
                 
                for (int j = 0; j < metn.Length; j++)
                {
                    Here:

                    if (metn[j] == metn2[i]) 
                    {
                        newStr += metn[j];
                        checking = true;
                        
                        if(checking == true)
                        {
                            while (checking == true)
                            {
                                extraI = i + 1;
                                extraJ = j + 1;
                                while (extraI < metn2.Length && extraJ < metn.Length)
                                    if (metn2[extraI] == metn[extraJ])
                                    {
                                        newStr += metn[extraJ];
                                        extraI++;
                                        extraJ++;
                                    }
                                    else
                                    {
                                        newStr = String.Empty;
                                        checking = false;
                                        j++;
                                        goto Here;
                                    }
                            }
                            if (newStr == metn2)
                            {
                                Console.WriteLine("True");
                                return true;
                            }
                            else
                            {
                                Console.WriteLine("False");
                                return false;
                            }
                        }
                        
                    }
                       
                } 
            }
            return false;
        }

        public static bool CustomContains(this string metn, char karakter)
        {
            bool check = false;

            for (int i = 0; i < metn.Length; i++)
            {
                if(metn[i] == karakter)
                {
                    check = true;
                    Console.WriteLine("True");
                    return true;
                }
            }

            if(check == false)
            {
                Console.WriteLine("False");
                return false;
            }
            return true;
        }

        public static bool IsPrime(this int eded)
        {
            int count = 0;

            if(eded == 1)
            {
                Console.WriteLine("1 ne sade ne de murekkebdir");
            }

            else
            {
                for (int i = 2; i < eded; i++)
                {
                    if (eded % i == 0)
                    {
                        count++;
                    }
                }

                if (count >= 1)
                {
                    Console.WriteLine("False");
                    return false;
                }

                else
                {
                    Console.WriteLine("True");
                    return true;
                }
            }
            return true;

        }
    }
}
