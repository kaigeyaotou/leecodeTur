using System;
using System.Text;

namespace leecodeTur
{
    class Program
    {
        public static string generateADCode()
        {
            Random rd = new Random();
            return "ITZC--" + DateTime.Now.ToString("yyyyMMddhhmmss") + rd.Next(1000, 9999);
        }

        public static string GenerateRandomCode(int length)
        {
            var result = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                var r = new Random(Guid.NewGuid().GetHashCode());
                result.Append(r.Next(0, 10));
            }
            return result.ToString();
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(GenerateRandomCode(3));
            }
        }
    }
}
