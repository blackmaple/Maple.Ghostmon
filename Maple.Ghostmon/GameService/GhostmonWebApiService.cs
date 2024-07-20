using Maple.GameContext;
using Maple.MonoGameAssistant.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.Ghostmon
{
    internal sealed class GhostmonWebApiService()
        : GameWebApi<GhostmonWebApiService, GhostmonGameService, GhostmonGameContext>("//0.Yaoling Mythical Journey 0.95//1.应用不收费!!!//2.想让大学一起学习dotNET//3.唯一反馈QQ群:136107898")
    {

        [ModuleInitializer]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2255:不应在库中使用 “ModuleInitializer” 属性", Justification = "<挂起>")]
        public static void Initializer()
        {
            Maple.MonoGameAssistant.DllExportTmp.DllExport.LoadApis();
            Initializer(8000);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = nameof(DllMain))]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static bool DllMain(nint hModule, [MarshalAs(UnmanagedType.U4)] EnumReasonForCall ul_reason_for_call, nint lpReserved)
        {
            switch (ul_reason_for_call)
            {
                case EnumReasonForCall.DLL_PROCESS_ATTACH:
                    {
                        break;
                    }
                case EnumReasonForCall.DLL_THREAD_ATTACH:
                case EnumReasonForCall.DLL_THREAD_DETACH:
                case EnumReasonForCall.DLL_PROCESS_DETACH:
                    {
                        break;
                    }

            }
            return true;
        }

    }

}
