module App

open Sutil

// For the best Tailwind experience, install the 'Tailwind CSS IntelliSense' extension.
// See README.md for full details.

let view() =
    Html.divc "text-center text-6xl p-6" [
        text "Hello Tailwind World"
    ]

view() |> Program.mountElement "sutil-app"
