namespace Asteroid_Collision
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AsteroidCollision([1, -1, -2, -2]));

            Console.ReadLine();
        }

        public static int[] AsteroidCollision(int[] asteroids)
        {
            var stack = new Stack<int>();
            stack.Push(asteroids[0]);

            for (int i = 1; i < asteroids.Length; i++)
            {               
                int asteroid = asteroids[i];
                if (!stack.TryPeek(out int peek))
                {
                    stack.Push(asteroid); 
                    continue;
                }

                if ((peek ^ asteroid) >= 0 || peek < 0 && asteroid > 0)
                {
                    stack.Push(asteroid);
                }
                else
                {
                    while (true)
                    {
                        if(stack.TryPeek(out int peek2) == false || (peek2 ^ asteroid) >= 0)
                        {
                            stack.Push(asteroid);
                            break;
                        }

                        int collide = peek2 + asteroid;
                        if(collide == 0)
                        {
                            stack.Pop();
                            break;
                        }
                        else if(collide < 0) 
                        {
                            stack.Pop();
                        }
                        else
                        {
                            break;
                        }
                    }
                }                             
            }

            return stack.Reverse().ToArray();
        }
    }
}
