module App

open Sutil
open Sutil.DOM
open Sutil.Attr

// For the best Tailwind experience, install the 'Tailwind CSS IntelliSense' extension.
// See README.md for full details.

let view() =
    Html.div [
        class' "text-center text-6xl p-6"
        text "Hello Tailwind World"
    ]

view() |> Program.mountElement "sutil-app"
