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
    /// ["Assembly-CSharp.dll".""."MapWeather"]
    /// </summary>
    public enum MapWeather : int
    {


        CLEAR = 0x00000000,

        CLOUDY = 0x00000001,

        LIGHT_RAIN = 0x00000002,

        MODERATE_RAIN = 0x00000003,

        HEAVY_RAIN = 0x00000004,

    }


}