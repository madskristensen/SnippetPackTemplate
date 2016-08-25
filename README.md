# Snippet Pack Template

[![Build status](https://ci.appveyor.com/api/projects/status/rb32emmcyuwbdm8l?svg=true)](https://ci.appveyor.com/project/madskristensen/snippetpacktemplate)

Download this extension from the [VS Gallery](https://visualstudiogallery.msdn.microsoft.com/64da3455-9172-4bcd-a338-2ba706ebc955)
or get the [CI build](http://vsixgallery.com/extension/800367d9-3754-49c6-a863-1fe65be05d32/).

---------------------------------------

A Visual Studio project template for creating code snippet packs
targeting any supported language. The snippet pack will be an extension
you can share with your team or upload to the Visual Studio extension
gallery.

See the [change log](CHANGELOG.md) for changes and road map.

## Features

- Create snippet pack extensions
- Works with all supported languages like C#, VB, JavaScript, HTML etc.
- The snippet packs will work in Visual Studio 2012, 2013 and 2015.

## How to use
Create a new project and select the **Snippet Pack Extension**.

![New Project Dialog](art/new-project-dialog.png)

That will create a VSIX project with the following structure:

![Solution Explorer](art/solution-explorer.png)

Instructions will automatically show up on how to modify the snippets
to your scenario.

### Changing language
Snippets are per language, and this snippet pack is targeting JavaScript
by default. It is easy to change so you can target any other language
supporting snippets. 

To do that, open *Snippets/snippets.pkgdef* and follow the instructions
found at the top of that file.

You can also have snippets for multiple languages. To do that, add an
additional entry in the *Snippets/snippets.pkgdef* for the new language
and add an additional folder with snippets targeting that language.

### Changing name
The *Snippets* folder contains a folder which has the name of your
extension. You can name this folder whatever you want as long as you
also change the name in *snippets.pkgdef* accordingly.

### .snippet files
The .snippet must have a few properties set correctly for this to work.

Select one or more .snippet files and hit F4 to bring up the property
grid. Set the following properties:

- **Build action** : *Content*
- **Include in VSIX**: *True*

Read more about the possibilities with code snippets on
[MSDN](https://msdn.microsoft.com/en-us/library/ms165392.aspx)

### Examples
Here are some of the snippet packs made by this template:

- [JavaScript Snippet Pack](https://github.com/madskristensen/JavaScriptSnippetPack)
- [HTML Snippet Pack](https://github.com/madskristensen/HtmlSnippetPack)
- [React Snippet Pack](https://github.com/madskristensen/ReactSnippetPack)
- [Gulp Snippet Pack](https://github.com/madskristensen/GulpSnippetPack)

## Contribute
Check out the [contribution guidelines](.github/CONTRIBUTING.md)
if you want to contribute to this project.

For cloning and building this project yourself, make sure
to install the
[Extensibility Tools 2015](https://visualstudiogallery.msdn.microsoft.com/ab39a092-1343-46e2-b0f1-6a3f91155aa6)
extension for Visual Studio which enables some features
used by this project.

## License
[Apache 2.0](LICENSE)