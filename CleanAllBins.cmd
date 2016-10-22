FOR /F "tokens=*" %%G IN ('DIR /B /AD /S bin ^| find /V ".git" ^| find /V "TeamCity" ^| find /V "node_modules" ^| find /V "packages" ^| find /V "wwwroot" ^| find /V "typings"') DO RMDIR /S /Q "%%G"
FOR /F "tokens=*" %%G IN ('DIR /B /AD /S obj ^| find /V ".git" ^| find /V "TeamCity" ^| find /V "node_modules" ^| find /V "packages" ^| find /V "wwwroot" ^| find /V "typings"') DO RMDIR /S /Q "%%G"
exit 0
