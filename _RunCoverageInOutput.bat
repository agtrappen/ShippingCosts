@REM @echo off
@REM
@REM SET dotnet="C:/Program Files/dotnet/dotnet.exe"
@REM SET opencover="C:\Users\stefan\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\OpenCover\OpenCover Prompt.exe"
@REM SET reportgenerator="C:/Users/stefan/Desktop/ReportGenerator_5.0.0/netcoreapp3.1/ReportGenerator.exe"
@REM
@REM SET sourcedir = "D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCosts"
@REM SET targetargs="D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCosts\DetermineShippingCosts\bin\Debug\netcoreapp3.1\DetermineShippingCostsTest.exe"
@REM SET coveragefile=Coverage.xml
@REM SET coveragedir="D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCosts\coverage"
@REM
@REM SET reportfile = index.htm
@REM SET reportdir = "D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCosts\report"
@REM
@REM
@REM REM Run Opencover Prompt
@REM %opencover% -target:%targetargs% -output:%coveragefile% -register:user
@REM
@REM REM Run openCover ReportGenerator
@REM %ReportGenerator% -reports:%coveragefile% -targetdir:%reportdir%/%reportfile% -sourcedir:%souredir% -verbosity:Error
@REM
@REM REM Open the report
@REM start "report" %sourcedir%/reportdir/reportfile
@REM
@REM
@REM REM Adjust pathways to your own to your situation.
@REM REM Run OpenCover - Manual - Run in openCover console
@REM Opencover.Console.exe -target:"D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCosts\DetermineShippingCostsTest\bin\Debug\net5.0\DetermineShippingCosts.exe" -output:"D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCosts\coverage.xml" -register:user
@REM
@REM REM Run ReportGenerator - Manual - Run CMD in ReportGenerator root.
@REM ReportGenerator.exe -reports:"D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCosts\coverage.xml" -targetdir:"D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCosts\report" sourcedirs:"D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCostsTest"
@REM
@REM REM Open index.htm in coverage