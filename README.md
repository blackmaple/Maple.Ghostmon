# Maple.Ghostmon

## 项目说明

0.  描述

      -  [妖之乡](https://store.steampowered.com/app/2816950/_/) 修改器源代码
      -  DEMO 版本
1.  要求

    -  一个VS2022
    -  一个DotNet8 SDK 需要安装AOT
    -  [一个UnityGame的通用修改框架](https://github.com/blackmaple/Maple.MonoGameAssistant)
   
2.  项目
    
    -  Maple.Ghostmon

      ###
      |  Item                             |  desc                                                                                            |  source  |
      |  -------------------------------  |  ----------------------------------------------------------------------------------------------  |  ------  |
     |  GameJson      |  game的json结构   |   game 存储数据的模型  |
      |  GameDllExport  |  WINHTTP.DLL劫持代码目录 UnityGame的一个通用劫持方案 依赖源生成器  |  [Maple.MonoGameAssistant.DllHijackGenerator](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.DllHijackGenerator)  |
      |  GameModel*0*      |  game的数据结构  生成文件->  |   [Maple.MonoGameAssistant.WinForm](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.WinForm)  |
      |  GameModel*1*      |  game的数据结构 类似`ILC2CPPDUMP`生成器C++ `il2cpp.h`  搭配源生成器使用  |  [Maple.MonoGameAssistant.MonoCollectorGeneratorV2](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.MonoCollectorGeneratorV2)  |
      |  GameSourceGen*0*      |  `GhostmonGameContext`将需要使用到game数据结构添加到源生成器()  |  [Maple.MonoGameAssistant.MonoCollectorGeneratorV2](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.MonoCollectorGeneratorV2)  |
      |  GameSourceGen*1*      |  `GhostmonGameContextExtensions` 修改game的功能实现  |  [Maple.MonoGameAssistant.MonoCollectorGeneratorV2](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.MonoCollectorGeneratorV2)  |
      |  GameService*0*      |  `GhostmonGameService` 修改game的功能实现让WebApi调用   |  [Maple.GameContext](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.GameContext)  |
      |  GameService*1*      |  `GhostmonWebApiService` WebApi 实现 跟GameUI http通信 以及 MONOAPI的数据收集 |  [Maple.MonoGameAssistant.WebApi](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.WebApi)  |
      |  GameService*2*      |  `Initializer` 利用`ModuleInitializer`运行托管代码 是整个程序的入口 |  [Maple.MonoGameAssistant.WebApi](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.WebApi)  |
      |  GameService*3*      |  `DllMain` 只是一个 [dllmain](https://learn.microsoft.com/zh-cn/windows/win32/dlls/dllmain) 加快 `ModuleInitializer` 执行 |  [Maple.MonoGameAssistant.WebApi](https://github.com/blackmaple/Maple.MonoGameAssistant/tree/main/Maple.MonoGameAssistant.WebApi)  |


     
 
