# ERII_NoDamageMod
Welcome to a new age of Easy Red II modding! This simple gameplay mod is just a very small sample of what's possible, in this case it disables damage for all characters (including the player). Note that damage to emplacements, vehicles, buildings, and the like still occur. Additionally, bleeding is not disabled (though it won't damage you), nor are other damage effects (indicators, screen going grayscale for a moment) disabled.

## Gameplay Modding
Gameplay mods change, expand, remove, or add core gameplay elements. Effectively, you can do anything you want in code (theoretically)! For a guide on installing gameplay mods for Easy Red II, I recommend you follow this guide I put up on Steam (NOT YET PUBLISHED)

## Building from Source
More extensive details on building from source will be issued later. However, this is a standard .NET project setup for Visual Studio. It uses the official BepInEx 6.0 template, and adds the NuGet package for HarmonyX, and requires manual referencing of the game's Assembly-CSharp.dll, which BepInEx 6.0 automatically decompiles and places in /BepInEx/Interop. This official template uses .NET Standard 2.1, which is compatibile with .NET Standard 2.0 (the actual version likely used by the game). It is likely fine to develop a mod in any version of .NET Core or Framework compatible with .NET Standard 2.1, but beware issues that may arrise.

## Licensing
This project is protected under the BSD-3 Copyleft license. Effectively: Feel free to edit this mod as you wish. If you redistribute it, reproduce the LICENSE file with it, and give credit to me.
