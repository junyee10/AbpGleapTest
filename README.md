To set up using Visual Studio

1. Open the `.\src\AbpGleapTest.sln` solution
1. Set `AbpGleapTest.Web` project as startup
1. In Package Manager Console, select `AbpGleapTest.EntityFramework` project as default project. Run command `Update-Database`.
1. Update `GLEAP_API_KEY` in `.\src\AbpGleapTest.Web\App\Main\views\layout\layout.cshtml` line 29
1. To run without debugging press `Ctrl + F5`

Default login username: admin
Default login password: 123qwe