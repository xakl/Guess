using System;

namespace Guess
{
    class Guess
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public void guess()
        {

        }

        static void Main(string[] args)
        {
            
            const int answerNumber = 35;
            int minNumber = 0;
            int maxNumber = 100;
            int loopCount =0;
            Console.WriteLine("数当てゲーム");
            Console.WriteLine("0～100の間の数字を当ててください");
            while (true)
            {

                loopCount += 1;
                int inputNumber = int.Parse(Console.ReadLine());

                if (0<inputNumber&&inputNumber < answerNumber)
                {
                    minNumber = inputNumber;
                    Console.WriteLine("答はもっと大きいです。");
                    Console.WriteLine("{0}～{1}の間の数字を当ててください", minNumber, maxNumber);
                    continue;
                }
                else if (answerNumber < inputNumber&&inputNumber<100)
                {
                    maxNumber = inputNumber;
                    Console.WriteLine("答はもっと小さいです。");
                    Console.WriteLine("{0}～{1}の間の数字を当ててください", minNumber, maxNumber);
                    continue;
                }
                else if (answerNumber == inputNumber)
                {
                    Console.WriteLine("おめでとうございます！{0}回目で当たりました！", loopCount);
                    break;
                }
                else
                {
                    Console.WriteLine("不正な入力です。");
                    Console.WriteLine("{0}～{1}の間の数字を当ててください", minNumber, maxNumber);
                    continue;
                }
            }



        }
    }
}
