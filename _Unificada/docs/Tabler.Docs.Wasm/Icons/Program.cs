using System.Threading.Tasks;
using IconGenerator.Tabler;

namespace IconGenerator
{
    class Program
    {
        private static async Task Main(string[] args)
        {
           //await TablerGenerator.GenerateFlags();
            await TablerGenerator.GenerateIcons();
            //await MaterialDesignGenerator.GenerateIcons();
        }


    }
}
