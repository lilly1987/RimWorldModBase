@echo off
setlocal
set "ROOT=%~dp0"
if not defined RIMWORLD_DIR (
  if exist "%ProgramFiles(x86)%\Steam\steamapps\common\RimWorld\RimWorldWin64_Data\Managed\Assembly-CSharp.dll" (
    set "RIMWORLD_DIR=%ProgramFiles(x86)%\Steam\steamapps\common\RimWorld"
  ) else if exist "%ProgramFiles%\Steam\steamapps\common\RimWorld\RimWorldWin64_Data\Managed\Assembly-CSharp.dll" (
    set "RIMWORLD_DIR=%ProgramFiles%\Steam\steamapps\common\RimWorld"
  )
)
if not defined RIMWORLD_DIR (
  echo [ERROR] Set RIMWORLD_DIR to your RimWorld install directory.
  exit /b 1
)
where msbuild >nul 2>nul
if %errorlevel%==0 (
  msbuild "%ROOT%RimWorldModTemplate.csproj" /restore /t:Build /p:Configuration=Release /p:RimWorldDir="%RIMWORLD_DIR%"
  exit /b %errorlevel%
)
where dotnet >nul 2>nul
if errorlevel 1 (
  echo [ERROR] Install Visual Studio Build Tools or .NET SDK.
  exit /b 1
)
dotnet build "%ROOT%RimWorldModTemplate.csproj" --configuration Release /p:RimWorldDir="%RIMWORLD_DIR%"
exit /b %errorlevel%
