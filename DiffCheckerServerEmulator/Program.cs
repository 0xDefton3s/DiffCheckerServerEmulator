using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WatsonWebserver;

namespace DiffCheckerServerEmulator
{
    class Program
    {
        /*static async Task ValidateKey(HttpContext ctx)
        {
            string response = "{\"url\":\"\",\"message\":\"OK\",\"key\":\"DEFTO-DEFTO-DEFTO-DEFTO\",\"valid\":\"32498193501\",\"status\":200}";
            await ctx.Response.Send(response);
        }*/


        static async Task DefaultRoute(HttpContext ctx)
        {
            Console.WriteLine("İstek : " +ctx.Request.Url.Full);
            string response = "{\"url\":\"\",\"message\":\"OK\",\"key\":\"DEFTO-DEFTO-DEFTO-DEFTO\",\"license\":\"DEFTO-DEFTO-DEFTO-DEFTO\",\"valid\":\"1\",\"expiresAt\":\"32498193501\",\"status\":200}";
            await ctx.Response.Send(response);
        }

        static void Main(string[] args)
        {
            Server server = new Server("127.0.0.1", 80, false, DefaultRoute);

            //server.Routes.Static.Add(HttpMethod.POST, "/licenses/actions/validate-key", ValidateKey);

            // start the server
            server.Start();

            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }
    }
}
