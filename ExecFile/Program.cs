using Wrapper;

namespace Test
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Use method from library
            var wrap = new CPlusPlusWraper();
            wrap.UseAddNumbers();
        }
    }
}