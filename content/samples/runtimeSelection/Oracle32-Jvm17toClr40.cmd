@echo off

if %PROCESSOR_ARCHITECTURE%==AMD64 GOTO java
if %PROCESSOR_ARCHITEW6432%==AMD64 GOTO java
echo this asumes that you are running 64bit windows 
goto end

:java
if EXIST "c:\Program Files (x86)\Java\jdk1.7.0\bin\java.exe" GOTO run
echo this asumes that you have c:\Program Files (x86)\Java\jdk1.7.0\ installed
goto end

:run
"c:\Program Files (x86)\Java\jdk1.7.0\bin\java.exe" -cp ../../lib/jni4net.j-0.8.7.0.jar;target/classes Program v40

:end