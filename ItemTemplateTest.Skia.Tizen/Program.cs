using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace ItemTemplateTest.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new ItemTemplateTest.App(), args);
            host.Run();
        }
    }
}
