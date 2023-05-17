using gatoEuPeidei_Service;

namespace gatoEuPeidei_Service_Test
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var foo = new Class1();

            await foo.PrintOutputToScreen();
        }
    }
}