using Maple.MonoGameAssistant.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon.Metadata.MetadataModel.UniTask
{


    /// <summary>
    /// ["UniTask.dll"."Cysharp.Threading.Tasks"."UniTaskStatus"]
    /// </summary>
    public enum UniTaskStatus : int
    {


        Pending = 0x00000000,

        Succeeded = 0x00000001,

        Faulted = 0x00000002,

        Canceled = 0x00000003,

    }


}