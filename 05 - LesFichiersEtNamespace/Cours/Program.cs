using System;
using Helper;

namespace HelperInput_Test
{    class Program
    {
        static void Main(string[] args)
        {
            int value = HelperInput.ReadIntInput();

            HelperInput.ReadFloatInput("coucou");

            HelperInput.ReadDoubleInput();
        }
    }
}
