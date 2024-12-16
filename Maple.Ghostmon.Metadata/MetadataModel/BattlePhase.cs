using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Ghostmon.Metadata.MetadataModel
{


    /// <summary>
    /// ["Assembly-CSharp.dll".""."BattlePhase"]
    /// </summary>
    public enum BattlePhase : int
    {


        Initialize = 0x00000000,

        Deploy = 0x00000001,

        Fighting = 0x00000002,

        Settlement = 0x00000003,

    }


}