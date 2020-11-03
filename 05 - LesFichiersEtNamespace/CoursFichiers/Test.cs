using CoursFichiers;

namespace ClasseDeTest
{    class Test
    {
        public static void TestFunction()
        {
            Program.TestFunctionProgram();
        }

        private static void TestFunctionPrivate()
        {
            CoursFichiers.Test.Test2();
        }
    }
}