# Snippet Pack
Congratulations, you've just created a snippet pack.

## Changing language
Snippets are per language, and this snippet pack is targeting JavaScript
by default. It is easy to change so you can target any other language
supporting snippets. 

To do that, open *Snippets/snippets.pkgdef* and follow the instructions
found at the top of that file.

You can also have snippets for multiple languages. To do that, add an
additional entry in the *Snippets/snippets.pkgdef* for the new language
and add an additional folder with snippets targeting that language.

## Changing name
The *Snippets* folder contains a folder which has the name of your
extension. You can name this folder whatever you want as long as you
also change the name in *snippets.pkgdef* accordingly.

## .snippet files
The .snippet must have a few properties set correctly for this to work.

Select one or more .snippet files and hit F4 to bring up the property
grid. Set the following properties:

- **Build action** : *Content*
- **Include in VSIX**: *True*

Read more about the possibilities with code snippets on
[MSDN](https://msdn.microsoft.com/en-us/library/ms165392.aspx)

Happy coding!  
Mads Kristensen