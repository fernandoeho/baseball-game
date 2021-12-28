namespace BaseballGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            char[] space = new char[] { ' ' };

            string[] ops = Console.ReadLine().Split(space);
            int output = solution.CalPoints(ops);

            Console.WriteLine(output);
        }
    }

    public class Solution
    {
        public int CalPoints(string[] ops)
        {
            Stack<int> record = new Stack<int>();

            for (int i = 0; i < ops.Length; i++)
            {
                char c = Convert.ToChar(ops[i].Replace("-", ""));

                if (c >= 48 && c <= 57)
                    record.Push(Convert.ToInt32(ops[i]));
                else
                {
                    if (c == '+')
                    {
                        var number1 = record.Pop();
                        var number2 = record.Pop();

                        record.Push(number2);
                        record.Push(number1);
                        record.Push(number1 + number2);
                    }
                    else if (c == 'D')
                        record.Push(2 * record.Peek());
                    else if (c == 'C')
                        record.Pop();
                }
            }

            return record.Sum();
        }
    }
}