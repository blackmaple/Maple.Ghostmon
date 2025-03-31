using Maple.MonoGameAssistant.WebApi;
using Maple.MonoGameAssistant.Windows.Service;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.Ghostmon
{
    internal sealed partial class GhostmonGameExtensions
    {
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)/*, typeof(CallConvSuppressGCTransition)*/], EntryPoint = nameof(Maple))]
        [return: MarshalAs(UnmanagedType.I4)]
        public static int Maple()
        {
            var webapp = WebApiServiceExtensions.AsRunWebApiService(p =>
            {
                p.GameName = "Yaoling Mythical Journey";
                p.QQ = "QQ:75351663";
                p.Http = true;
                p.AutoOpenUrl = true;
                //    p.NamedPipe = true;

            }, services =>
            {
                services.UseGameContextService<GhostmonGameService>();
            });
            Thread.Sleep(8000);
            webapp.Run();

            return 1;
        }




    }

}
