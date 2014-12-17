@echo off
cls

rem BuildOption: build, rebuild, clean
rem BuildTarget: all, x86, x64

set BuildOption=build
set BuildTarget=all

FOR %%A IN (%*) DO (
	IF /I %%A==rebuild (
		set BuildOption=rebuild
	) ELSE IF /I %%A==clean (
		set BuildOption=clean
	) ELSE IF /I %%A==x86 (
		set BuildTarget=x86
	) ELSE IF /I %%A==x64 (
		set BuildTarget=x64
	) ELSE (
		goto :invalid_build_parameter
	)
)

echo.
echo ---------------
echo Start building
echo %BuildOption% %BuildTarget%
echo ---------------

if X%CCN_LOG_FOLDER% == X (
	goto :missing_log_folder
)
if "%CCN_LOG_FOLDER:~-1%"=="\" (
	rem Removing trailing backslash
	set CCN_LOG_FOLDER=%CCN_LOG_FOLDER:~0,-1%
)

SETLOCAL ENABLEDELAYEDEXPANSION

if /I not %BuildOption%==build (
	rem Ha %BuildOption% rebuild, vagy clean, akkor elõször clean
	for /f %%i in ('dir /a-d/s/b *.sln') do (
		echo.
		echo Clean solution:
		echo %%i
		if /I not %BuildTarget%==x64 (
			echo Debug X86
			set LogFileName=%CCN_LOG_FOLDER%\%%~ni.Debug.x86.log
			msbuild %%i /t:clean /p:Configuration=Debug /p:Platform="Any CPU" > !LogFileName!
			if not !ERRORLEVEL!==0  goto :build_failed
			echo done
			echo Release X86
			set LogFileName=%CCN_LOG_FOLDER%\%%~ni.Release.x86.log
			msbuild %%i /t:clean /p:Configuration=Release /p:Platform="Any CPU" > !LogFileName!
			if not !ERRORLEVEL!==0  goto :build_failed
			echo done
		)
		if /I not %BuildTarget%==x86 (
			echo Debug X64
			set LogFileName=%CCN_LOG_FOLDER%\%%~ni.Debug.x64.log
			msbuild %%i /t:clean /p:Configuration=Debug /p:Platform="x64" > !LogFileName!
			if not !ERRORLEVEL!==0  goto :build_failed
			echo done
			echo Release X64
			set LogFileName=%CCN_LOG_FOLDER%\%%~ni.Release.x64.log
			msbuild %%i /t:clean /p:Configuration=Release /p:Platform="x64" > !LogFileName!
			if not !ERRORLEVEL!==0  goto :build_failed
			echo done
		)
	)
)

if /I %BuildOption%==clean (
	rem Ha csak clean kellett, akkor végeztünk
	goto :build_succeeded
)

for /f %%i in ('dir /a-d/s/b *.sln') do (
 	echo.
 	echo Building solution:
 	echo %%i
 	if /I not %BuildTarget%==x64 (
	 	echo Debug X86
		set LogFileName=%CCN_LOG_FOLDER%\%%~ni.Debug.x86.log
		msbuild %%i /t:build /p:Configuration=Debug /p:Platform="Any CPU" > !LogFileName!
		if not !ERRORLEVEL!==0  goto :build_failed
		echo done
	 	echo Release X86
		set LogFileName=%CCN_LOG_FOLDER%\%%~ni.Release.x86.log
		msbuild %%i /t:build /p:Configuration=Release /p:Platform="Any CPU" > !LogFileName!
		if not !ERRORLEVEL!==0  goto :build_failed
		echo done
	)
	if /I not %BuildTarget%==x86 (
	 	echo Debug X64
		set LogFileName=%CCN_LOG_FOLDER%\%%~ni.Debug.x64.log
		msbuild %%i /t:build /p:Configuration=Debug /p:Platform="x64" > !LogFileName!
		if not !ERRORLEVEL!==0  goto :build_failed
		echo done
	 	echo Release X64
		set LogFileName=%CCN_LOG_FOLDER%\%%~ni.Release.x64.log
		msbuild %%i /t:build /p:Configuration=Release /p:Platform="x64" > !LogFileName!
		if not !ERRORLEVEL!==0  goto :build_failed
		echo done
	)
)

goto :build_succeeded

:missing_log_folder
echo.
echo ---------------
echo Missing log folder
echo ---------------
echo Please set environment variable CCN_LOG_FOLDER for log files.
goto :the_end

:invalid_build_parameter
echo.
echo ---------------
echo Invalid build parameter
echo ---------------
goto :the_end

:build_succeeded
echo.
echo ---------------
echo Build succeeded
echo ---------------
goto :the_end

:build_failed
echo.
echo --------------
echo Build failed
echo --------------
echo See: !LogFileName!

:the_end
echo.
