@echo off

title Gorilla Tag - Quality of life
reg delete "HKEY_CURRENT_USER\Software\Another Axiom\Gorilla Tag" /f
REG ADD "HKEY_CURRENT_USER\Software\Another Axiom\Gorilla Tag" /v "savedMOTD_h1146162546" /t REG_BINARY  /d "5468616e6b20796f7520666f72207573696e67206d79207363726970742e204279205a65746178" /f
REG ADD "HKEY_CURRENT_USER\Software\Another Axiom\Gorilla Tag" /v "tutorial_h1181564969" /t REG_BINARY  /d "646f6e6500" /f