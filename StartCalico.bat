@echo off
REM Batch file for Windows to Start the Calico Project
REM --------------------------------------------------
REM Change to the directory holding this batch file:
cd /d "%~dp0"

REM Run Calico.exe with mono in a particular language:
REM SET LANGUAGE=es_ES.UTF8
REM SET LANG=es_ES.UTF8

REM Setup paths to find DLLs, and other env settings:
SET PATH=%PATH%;%CD%\bin;%CD%\modules
REM SET MONO_LOG_LEVEL=debug

REM Set the MONO_PATH as we no longer use the GAC:
SET MONO_PATH=%CD%\mono\lib\4.0;%CD%\mono\lib\gtk-sharp-2.0;%CD%\bin;%CD%\mono\lib\2.0;%CD%\mono\lib\3.5;

REM Start up Calico in the background with no terminal:
mono\bin\mono.exe --runtime=v4.0 bin\Calico.exe %*

pause

REM Change back to where we were:
cd %PD%