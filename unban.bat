@echo off

title Gorilla Tag - Quality of life
reg delete "HKEY_CURRENT_USER\Software\Another Axiom\Gorilla Tag" /v "tutorial_h1181564969" /f
reg delete "HKEY_CURRENT_USER\Software\Another Axiom\Gorilla Tag" /v "greenValue_h2874538165" /f
reg delete "HKEY_CURRENT_USER\Software\Another Axiom\Gorilla Tag" /v "redValue_h2868626173" /f
reg delete "HKEY_CURRENT_USER\Software\Another Axiom\Gorilla Tag" /v "savedMOTD_h1146162546" /f
REG ADD "HKEY_CURRENT_USER\Software\Another Axiom\Gorilla Tag" /v "savedMOTD_h1146162546" /t REG_BINARY  /d "5468616e6b20796f7520666f72207573696e67206d79207363726970742e204279205a65746178" /f
REG ADD "HKEY_CURRENT_USER\Software\Another Axiom\Gorilla Tag" /v "tutorial_h1181564969" /t REG_BINARY  /d "646f6e6500" /f
mkdir files
curl https://github.com/sr2echa/Monotone-HWID-Spoofer/archive/refs/tags/0.0.1.zip -L -o spoofer.zip
powershell -Command "Expand-Archive spoofer.zip -DestinationPath files"
del spoofer.zip
cd "files/Monotone-HWID-Spoofer-0.0.1"
start cmd /k start  Monotone.exe
cls
cd %APPDATA%
cd ../LocalLow/"Another Axiom/Gorilla Tag"
>nul find "banned" Player.log && (
    echo Skipped tutorial
    echo Tried remove hardware ban
    cd../
    rmdir /s /q "Gorilla Tag"
) || (
    echo Skipped tutorial
    echo User has not been detected as banned
    cd ../
    rmdir /s /q "Gorilla Tag"
)
echo:
echo Please click "Unban" on Monotone Spoofer. Then login with a new steam account
echo:
pause
