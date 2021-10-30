# SBCalc
Old small app to generate SBK (Secure Burn Key) for some Acer Iconia Device

Using a leak file (Pica_Func.dll) from Acer.
We're calling managed code from it to generate the SBK based on CPUID's device.

How to compile on Ubuntu:
```bash
$ sudo apt-get install mono-complete
$ xbuild /p:Configuration=Debug /p:TargetFrameworkVersion=v4.5 /p:TargetFrameworkProfile="" SBCalc.csproj
```

To run application file you need wine
Example:
```bash
$ cat run.bat
SBCalc.exe
pause
$ env WINEPREFIX="/home/vyurin/prefix32" WINEARCH=win32 wineconsole run.bat
```

Unfortunately application don't worked under Windows 10
```cmd
C:\>SBCalc.exe

C:\>
```
