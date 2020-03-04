﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_02
{
    class IsAsOperatorApp
    {
        static void IsOperator(object obj)
        {
            Console.WriteLine(obj + " is int: " + (obj is int));
            Console.WriteLine(obj + " is string: " + (obj is string));
        }
        static void AsOperator(object obj)
        {
            Console.WriteLine(obj + " as string == null: " + (obj as string == null));
        }
        public static void Main()
        {
            IsOperator(10);
            IsOperator("ABC");
            AsOperator(10);
            AsOperator("ABC");
        }
    }
}
