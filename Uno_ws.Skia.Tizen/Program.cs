using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Uno_ws.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new Uno_ws.App(), args);
            host.Run();
        }
    }
}
