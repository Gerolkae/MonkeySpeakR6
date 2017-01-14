
Description
Monkeyspeak is a dragonspeak-like interpreter written in C# 4.5. Monkeyspeak has a light footprint, less than 100kb size. Runtime memory usage is small making it very friendly in mobile environments.

The project "Monkeyspeak" and it's development team is in no way affiliated with Dragon's Eye Productions. Monkeyspeak is free for life. Free as in FREE BEER!!
Basics
Monkeyspeak is a functional language. The Engine loads the script into a new Page that contains the Triggers. Triggers can be compared to functions since they are used to perform a function in Monkeyspeak. Triggers are assigned specific TriggerHandlers (delegates) that are executed whenever the engine detects that trigger. Only one TriggerHandler delegate is assigned per Trigger.
Features

    Native supported data types (string, double)
    Local variable scope per Page
    Multiple conditional statements using (1:##) triggers
    Default libraries Sys, IO, Math, Debug, Timers
    Easy to extend by extending AbstractBaseLibrary or attaching TriggerHandlerAttribute to a method
    Compilable scripts for faster loading or sending over the network
    Thread safe, can execute multiple pages asynchronously. (beta)
    EXE compiler (beta)


Important: Monkeyspeak's compiled file format is not compatible with Dragonspeak's compiled file format.
Cross-Platform
Untested on Mono but it contains no Win32 dependencies. Pure .Net baby! Tested it with the Mono Migration Analysis and it passed.

