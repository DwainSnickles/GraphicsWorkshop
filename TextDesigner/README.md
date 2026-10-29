# TextDesignerCSLibrary (restored source)

The `TextDesignerCSLibrary` types used by `Form Tabs\frmShadowText.cs` (`PngOutlineText`,
`BmpOutlineText`, `GradientType`, `LOGFONT`, the text strategies) were referenced as a compiled
DLL living outside this repository:

    ..\TextDesigner\bin\Debug\TextDesignerCSLibrary.dll

That DLL no longer existed, so the project could not compile. This folder contains the library's
C# source, added to `GraphicsWorkshop.csproj` directly, so the repo builds on its own.

Origin: https://github.com/shaovoon/outline-text ("Outline Text in C++ and CSharp"),
`OutlineText/TextDesignerCSLibrary`. The library accompanies the CodeProject/CodeGuru article of
the same name.

License: The Code Project Open License (CPOL) 1.02 - see [CPOL-License.html](CPOL-License.html).

`TextDesignerCSLibrary.cs` in the project root was a reformatted copy of `BmpOutlineText.cs` with
the `new PngOutlineText()` constructor calls commented out, which is why the type it declared was
never resolvable. It was removed in favour of the original `TextDesigner/BmpOutlineText.cs`.
