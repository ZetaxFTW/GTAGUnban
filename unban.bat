@echo off
start cmd.exe /c mkdir files
curl https://github.com/sr2echa/Monotone-HWID-Spoofer/archive/refs/tags/0.0.1.zip -L -o spoofer.zip
powershell -Command "Expand-Archive spoofer.zip -DestinationPath files"
del spoofer.zip
cd %APPDATA%
cd ../LocalLow/"Another Axiom"
rmdir /s /q "Gorilla Tag"
echo Removing Another Axiom from registry
reg delete "HKEY_CURRENT_USER\Software\Another Axiom" /f
REG QUERY "HKEY_CURRENT_USER\Software\Another Axiom"
cls
echo Script completed. Please reboot your computer and use a VPN.
echo Good VPNs are: NordVPN, PrivatVPN, Surfshark. You can use free ones as well, but they are not guaranteed to work.
color A
echo Please start Monotone Spoofer now. You can find it under /files/Monotone-HWID-Spoofer-0.0.1/Monotone.exe
pause
