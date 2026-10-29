# lib — vendored references

These three assemblies used to be referenced through paths outside the repository:

    ..\..\..\DesignSurface CSharp\GraphicsSurface\bin\Gma.System.MouseKeyHook.dll
    ..\..\..\DesignSurface CSharp\GraphicsSurface\bin\GraphicObjects.dll
    ..\..\..\DesignSurface CSharp\GraphicsSurface\bin\GraphicsSurface.dll

That made the project buildable only on the machine where `E:\DesignSurface CSharp` happened to
sit next to the repo. They are now committed here and referenced as `lib\<name>.dll`, so a clean
checkout builds on its own.

| File | Source | Built |
| --- | --- | --- |
| `Gma.System.MouseKeyHook.dll` | third-party (MouseKeyHook), shipped in the DesignSurface bin | 2023-04-10 |
| `GraphicObjects.dll` | `E:\DesignSurface CSharp\GraphicObjects` | 2025-08-24 |
| `GraphicsSurface.dll` | `E:\DesignSurface CSharp\GraphicsSurface` (assembly `GraphicsSurface`, control type `DesignSurface`) | 2026-10-28 |

`GraphicsSurface.dll` carries two fixes made in the library source:

- `pbCropped_Click` no longer throws `NullReferenceException` when the crop preview is clicked
  before any object has been added.
- `gobjc` is marked `[Browsable(false)]` / `[DesignerSerializationVisibility(Hidden)]`, so the
  WinForms designer stops trying to code-generate it (it failed with "Type System.Drawing.Graphics
  is not marked as serializable").

## When the libraries change

Rebuild the library project, then copy the fresh DLLs over these and commit both together:

    "E:\VS_SSMS\MSBuild\Current\Bin\MSBuild.exe" "E:\DesignSurface CSharp\GraphicsSurface\DesignSurface.csproj"
    cp "E:\DesignSurface CSharp\GraphicsSurface\bin\GraphicsSurface.dll" "E:\DesignSurface CSharp\GraphicsSurface\bin\GraphicObjects.dll" lib\

If you would rather track the library as a project reference again, point `<ProjectReference>` at
`E:\DesignSurface CSharp\GraphicsSurface\DesignSurface.csproj` — but that reintroduces the
out-of-repo dependency this folder exists to remove.
