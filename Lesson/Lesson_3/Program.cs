﻿using System;

namespace project {
    class Program {
        static void Main() {
           // for(float i = 200; i > 10; i /= 2)
           //     Console.WriteLine("Element: {0}", i);

           /* 
           byte i = 0;
           while(i < 10) {
                Console.WriteLine("Element: {0}", i);
                i++;    
           }
           */
           
           /*
           byte i = 10;
           while(i >= 1) {
            Console.WriteLine("Element: {0}", i);
                i--;
           } 
           */ 

           /* 
           bool isHasCar = true;
           while(isHasCar) {
                string end = Console.ReadLine()!;
                if(end == "end")
                    isHasCar = false;
           }
           */

           for(short i = 0; i < 10; i++) {
                //if(i > 5)
                 //   break;

                 if(i % 2 == 0)
                    continue;

                Console.WriteLine("El: " + i);
           }


        }
    }
}
