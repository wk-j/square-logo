﻿module Cake.SquareLogo.Tests.Logo

open Cake.SquareLogo.Main
open System.Drawing
open NUnit.Framework
open FluentAssertions

[<Test>]
let shouldAdd()  = (1 + 1).Should().Be(2, "") |> ignore

[<Test>]
let shouldCreateLogo() =
      let family = new FontFamily("Monaco")
      let font = new Font(family, 40.0f , FontStyle.Regular, GraphicsUnit.Pixel)

      let settings = 
            { //FontFamily = "American Typewriter"
              FontFamily = "Optima"
              //FontFamily = "Gill Sans"
              //FontFamily = "Skia"
              FontSize = 45.0f
              Foreground = "White"
              Background = "DimGray" }

      drawText("C#",  "Screen/csharp.png", settings)
      drawText("F#",  "Screen/fsharp.png", settings)
      drawText("XAN", "Screen/xamarin.png", settings)
      drawText("ANG", "Screen/angular.png", settings)
      drawText("KTN", "Screen/kotlin.png", settings)
      drawText("VSO", "Screen/visual-studio.png", settings)
      drawText("RLN", "Screen/roslyn.png", settings)
      drawText("CKE", "Screen/cake.png", settings)
      drawText("FDY", "Screen/fody.png", settings)
      drawText("CSS", "Screen/css.png", settings)
      drawText("MSB", "Screen/msbuild.png", settings)
      drawText("SCL", "Screen/scala.png", settings)
      drawText("ALF", "Screen/alfresco.png", settings)
      drawText("ELM", "Screen/elm.png", settings)
      drawText("ASP", "Screen/asp.png", settings)
      drawText("TSC", "Screen/typescript.png", settings)
      drawText("JWN", "Screen/jannine.png", settings)
      drawText("LSP", "Screen/listp.png", settings)
      drawText("VTX", "Screen/vertx.png", settings)
      drawText("WPK", "Screen/webpack.png", settings)
      drawText("JSC", "Screen/javascript.png", settings)
      drawText("RCT", "Screen/react.png", settings)
      drawText("UNZ", "Screen/uncategorize.png", settings)




