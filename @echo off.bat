@echo off
set DATE=%date:~6,4%-%date:~3,2%-%date:~0,2%
set HEURE=%time:~0,2%-%time:~3,2%
set NOM_FICHIER=mediatek86_%DATE%_%HEURE%.sql
"C:\wamp64\bin\mysql\mysql8.0.31\bin\mysqldump.exe" -u root mediatek86 > "C:\sauvegardes\%NOM_FICHIER%"
echo Sauvegarde effectuée : %NOM_FICHIER%