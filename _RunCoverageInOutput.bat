@echo off

SET dotnet="C:/Program Files/dotnet/dotnet.exe"  
SET opencover="C:\Users\stefan\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\OpenCover\OpenCover Prompt.exe"  
SET reportgenerator="C:/Users/stefan/Desktop/ReportGenerator_5.0.0/netcoreapp3.1/ReportGenerator.exe"

SET sourcedir = "D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCosts"
SET targetargs="D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCosts\DetermineShippingCosts\bin\Debug\netcoreapp3.1\DetermineShippingCostsTest.exe"
SET coveragefile=Coverage.xml  
SET coveragedir="D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCosts\coverage"

SET reportfile = index.htm
SET reportdir = "D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCosts\report"


REM Run Opencover Prompt
%opencover% -target:%targetargs% -output:%coveragefile% -register:user

REM Run openCover ReportGenerator
%ReportGenerator% -reports:%coveragefile% -targetdir:%reportdir%/%reportfile% -sourcedir:%souredir% -verbosity:Error

REM Open the report
start "report" %sourcedir%/reportdir/reportfile


REM Adjust pathways to your own to your situation.
REM Run OpenCover - Manual - Run in openCover console
Opencover.Console.exe -target:"D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCosts\DetermineShippingCostsTest\bin\Debug\net5.0\DetermineShippingCosts.exe" -output:"D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCosts\coverage.xml" -register:user

REM Run ReportGenerator - Manual - Run CMD in ReportGenerator root.
ReportGenerator.exe -reports:"D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCosts\coverage.xml" -targetdir:"D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCosts\report" sourcedirs:"D:\Avans\Deeltijd\Jaar2\Periode2\Kwaliteit_Testen\Projecten\DetermineShippingCostsTest"

REM Open index.htm in coverage