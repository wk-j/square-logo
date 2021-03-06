﻿
namespace Cake.SquareLogo.LogoAlias

open Cake.Core
open Cake.Core.Annotations
open Cake.SquareLogo.Main
open System.Runtime.CompilerServices

type LogoSettings() =
      member val FontFamily = "Optima" with set,get
      member val FontSize = 45.0f with set,get
      member val Foreground = "White" with set,get
      member val Background = "DimGray" with set,get
      member val Padding = 20.0f with set,get
      member val NoSquare = false with set,get

[<Extension>]
[<AbstractClass>]
[<Sealed>]
type ContextExtension =
      [<CakeMethodAlias>]
      [<Extension>]
      static member CreateLogo(context: ICakeContext, text: string, outputPath: string, settings: LogoSettings) =
            let settings =
                { DrawSettings.FontSize =  settings.FontSize
                  FontFamily = settings.FontFamily
                  Foreground = settings.Foreground
                  Padding = settings.Padding
                  NoSquare = settings.NoSquare
                  Background = settings.Background }
            drawText(text, outputPath, settings)

      [<CakeMethodAlias>]
      [<Extension>]
      static member CreateLogo(context: ICakeContext, text: string, outputPath: string) =
            let settings = LogoSettings()
            ContextExtension.CreateLogo(context, text, outputPath, settings)