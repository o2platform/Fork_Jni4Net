@echo off
rem set JAVA_HOME=C:\Program Files\Java\jdk1.5.0_20

if not exist target\build-sources\generated-sources\META-INF\ mkdir jni4net.tested.n\target\build-sources\generated-sources\META-INF\
echo [assembly: System.Reflection.AssemblyVersion("0.8.1.0")] > jni4net.tested.n\target\build-sources\generated-sources\META-INF\AssemblyInfo.cs 

if not exist jni4net.test.n\target\build-sources\generated-sources\META-INF\ mkdir jni4net.test.n\target\build-sources\generated-sources\META-INF\
echo [assembly: System.Reflection.AssemblyVersion("0.8.1.0")] > jni4net.test.n\target\build-sources\generated-sources\META-INF\AssemblyInfo.cs 

jni4net.proxygen\target\proxygen.exe tools\proxygen\tested.proxygen.xml 

