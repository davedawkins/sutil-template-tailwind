## Sutil Template for Tailwind

The Sutil Hello World program, but using Tailwind, with:
- CSS purging (using tailwindcss-cli)
- IntelliSense (using Tailwind CSS Intellisense plugin)

### Quick Start

```
    git clone -s https://github.com/davedawkins/sutil-template-tailwind.git
    cd sutil-template-tailwind
    dotnet tool restore
    npm install
    npm run start
```

### Adding Tailwind to an Existing Project

Install Tailwind:

```
$ npm add -D tailwindcss tailwindcss-cli
```

Set your build scripts to something like this:

```json
  "scripts": {
    "start": "dotnet fable watch src/App --runWatch npm run pack",
    "build": "dotnet fable       src/App --run npm run pack:prod",

    "pack": "npm run tailwind && webpack serve",
    "pack:prod": "npm run tailwind && webpack --mode production",

    "tailwind": "NODE_ENV=production tailwindcss-cli build -o public/tailwind.css"
  }
```

Add a reference to generated CSS file `tailwind.css` in your `index.html`

```html
  <link rel="stylesheet" href="tailwind.css"/>
```

### Referencing Tailwind in a Sutil App

Use Sutil's `class'` property to specify the Tailwind classes:

```fs
    Html.div [
        class' "bg-red-400 text-sm p-1"
    ]
```

For the best experience, and to minimise the chance of specifying incorrect class names, install
the Tailwind CSS IntelliSense plugin (for VSCode). Add the following to `settings.json`:

```json
   "tailwindCSS.experimental.classRegex": [
       "class'\\s+\"([^\"]*)\""
   ],
   "tailwindCSS.includeLanguages": {
       "fsharp": "html",
       "fs": "html"
   }
```