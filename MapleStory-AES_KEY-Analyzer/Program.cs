using System;

namespace 키값정렬기
{
    class Program
    {
        private static string key, key1, key2, key3, key4, key5, key6, key7, key8;
        private static string key1_1, key1_2, key1_3;
        private static string key2_1, key2_2, key2_3;
        private static string key3_1, key3_2, key3_3;
        private static string key4_1, key4_2, key4_3;
        private static string key5_1, key5_2, key5_3;
        private static string key6_1, key6_2, key6_3;
        private static string key7_1, key7_2, key7_3;
        private static string key8_1, key8_2, key8_3;
        private const int a = 2;
        private static int b = 0, c = 0;
        private static int NUM(int a) => b = a + 2;
        private static int NUM2(int a) => c = a + 8;
        static void Main(string[] args)
        {
            Console.Title = "키값 정렬기 (SLFCG 제작)";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("개발자 네이트온: slfcg_dev@nate.com");
            Console.ResetColor();
            Console.Write("키값을 입력해주세요:\n");
            key = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("개발자 네이트온: slfcg_dev@nate.com");
            Console.ResetColor();
            Console.WriteLine("키값 원본:\n{0}", key);
            key1 = key.Substring(0, a);
            key1_1 = key.Substring(NUM(b), a);
            key1_2 = key.Substring(NUM(b), a);
            key1_3 = key.Substring(NUM(b), a);
            key2 = key.Substring(NUM(b), a);
            key2_1 = key.Substring(NUM(b), a);
            key2_2 = key.Substring(NUM(b), a);
            key2_3 = key.Substring(NUM(b), a);
            key3 = key.Substring(NUM(b), a);
            key3_1 = key.Substring(NUM(b), a);
            key3_2 = key.Substring(NUM(b), a);
            key3_3 = key.Substring(NUM(b), a);
            key4 = key.Substring(NUM(b), a);
            key4_1 = key.Substring(NUM(b), a);
            key4_2 = key.Substring(NUM(b), a);
            key4_3 = key.Substring(NUM(b), a);
            key5 = key.Substring(NUM(b), a);
            key5_1 = key.Substring(NUM(b), a);
            key5_2 = key.Substring(NUM(b), a);
            key5_3 = key.Substring(NUM(b), a);
            key6 = key.Substring(NUM(b), a);
            key6_1 = key.Substring(NUM(b), a);
            key6_2 = key.Substring(NUM(b), a);
            key6_3 = key.Substring(NUM(b), a);
            key7 = key.Substring(NUM(b), a);
            key7_1 = key.Substring(NUM(b), a);
            key7_2 = key.Substring(NUM(b), a);
            key7_3 = key.Substring(NUM(b), a);
            key8 = key.Substring(NUM(b), a);
            key8_1 = key.Substring(NUM(b), a);
            key8_2 = key.Substring(NUM(b), a);
            key8_3 = key.Substring(NUM(b), a);
            Console.Beep();
            Console.WriteLine("정렬된 키값:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" [{0}] ", key1);
            Console.ResetColor();
            Console.Write("{0} {1} {2}\n", key1_1, key1_2, key1_3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" [{0}] ", key2);
            Console.ResetColor();
            Console.Write("{0} {1} {2}\n", key2_1, key2_2, key2_3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" [{0}] ", key3);
            Console.ResetColor();
            Console.Write("{0} {1} {2}\n", key3_1, key3_2, key3_3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" [{0}] ", key4);
            Console.ResetColor();
            Console.Write("{0} {1} {2}\n", key4_1, key4_2, key4_3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" [{0}] ", key5);
            Console.ResetColor();
            Console.Write("{0} {1} {2}\n", key5_1, key5_2, key5_3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" [{0}] ", key6);
            Console.ResetColor();
            Console.Write("{0} {1} {2}\n", key6_1, key6_2, key6_3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" [{0}] ", key7);
            Console.ResetColor();
            Console.Write("{0} {1} {2}\n", key7_1, key7_2, key7_3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" [{0}] ", key8);
            Console.ResetColor();
            Console.Write("{0} {1} {2}\n", key8_1, key8_2, key8_3);
            key1 = key.Substring(0, a);
            key2 = key.Substring(NUM2(c), a);
            key3 = key.Substring(NUM2(c), a);
            key4 = key.Substring(NUM2(c), a);
            key5 = key.Substring(NUM2(c), a);
            key6 = key.Substring(NUM2(c), a);
            key7 = key.Substring(NUM2(c), a);
            key8 = key.Substring(NUM2(c), a);
            Console.WriteLine("분석된 키값:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" {0} {1} {2} {3} {4} {5} {6} {7}", key1, key2, key3, key4, key5, key6, key7, key8);
            Console.ResetColor();
            Console.WriteLine("리디에는 그대로 숫자만 바꿔주시고,\n팩소스에는 위 숫자 앞에 (byte)를 꼭 붙여서 넣어주세요!\n뭔소리인지 이해가 안가는분들을 위해 아래에 이해가도록 적어드립니다! ^^");
            Console.WriteLine("팩적용 예:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("(byte) 0x{0}, 0x00, 0x00, 0x00, \n(byte) 0x{1}, 0x00, 0x00, 0x00, \n(byte) 0x{2}, 0x00, 0x00, 0x00,\n(byte) 0x{3}, 0x00, 0x00, 0x00,\n(byte) 0x{4}, 0x00, 0x00, 0x00, \n(byte) 0x{5}, 0x00, 0x00, 0x00,\n(byte) 0x{6}, 0x00, 0x00, 0x00,\n(byte) 0x{7}, 0x00, 0x00, 0x00", key1, key2, key3, key4, key5, key6, key7, key8);
            Console.ResetColor();
            Console.WriteLine("리디적용 예:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("(byte)0x{0}, (byte)0x00, (byte)0x00, (byte)0x00, \n(byte)0x{1}, (byte)0x00, (byte)0x00, (byte)0x00, \n(byte)0x{2}, (byte)0x00, (byte)0x00, (byte)0x00,\n(byte)0x{3}, (byte)0x00, (byte)0x00, (byte)0x00,\n(byte)0x{4}, (byte)0x00, (byte)0x00, (byte)0x00, \n(byte)0x{5}, (byte)0x00, (byte)0x00, (byte)0x00,\n(byte)0x{6}, (byte)0x00, (byte)0x00, (byte)0x00,\n(byte)0x{7}, (byte)0x00, (byte)0x00, (byte)0x00", key1, key2, key3, key4, key5, key6, key7, key8);
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}


