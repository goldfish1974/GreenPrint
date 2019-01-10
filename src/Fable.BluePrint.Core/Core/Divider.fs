namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

type IDividerProps =
    | ClassName of string
    | TagName of obj

[<RequireQualifiedAccess>]
module Divider =
    let inline divider (props : IDividerProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Divider" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
