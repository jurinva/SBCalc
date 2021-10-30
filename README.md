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
$ Z:\home\vyurin\Downloads\Github\SBCalc\bin\Debug>SBCalc.exe
Enter your CPUID:
380618743403597
0x17D81E00 0xCB15F601 0x8B5F1203 0xB0512103
```

Unfortunately application don't worked under Windows 10
```cmd
C:\>SBCalc.exe

C:\>
```
How to get CPUID
```bash
$ lsusb -v | grep -5 ACER | grep -i serial
Couldn't open device, some information will be missing
Couldn't open device, some information will be missing
Couldn't open device, some information will be missing
Couldn't open device, some information will be missing
Couldn't open device, some information will be missing
Couldn't open device, some information will be missing
Couldn't open device, some information will be missing
  iSerial                 3 380618743403597
```
