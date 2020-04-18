# receiver2-qol-fixes

Receiver 2 Quality of Life Fixes

# Features

## Current features

- Disable 'accidentally shooting leg when fast holstering' mechanic.
- Remove demoting of ranks on death.
- Remove 'Tap W to sprint'

# Setup

## Install

1. **DOWNLOAD** `Wolfire.Receiver2.dll` from the [**releases tab**](https://github.com/aBARICHELLO/receiver2-qol-fixes/releases/) in this repository.
2. Drop the downloaded DLL into `\SteamLibrary\steamapps\common\Receiver 2\Receiver2_Data\Managed\` replacing the original file.

To uninstall the mod simply ask for Steam to check the files on the game's property panel.

## Compiling

To generate this DLL yourself first you need to download [dnSpy](https://github.com/0xd4d/dnSpy), decompile the game's `Wolfire.Receiver2.dll` and apply the patch file to the decompiled sources. After that use 'Save Module' to generate a new DLL replacing the game's original one.

# Game notes

There's unused code included in the game indicating that some of these features were prototyped, scrapped or planned for a future release.

- Agents with randomized male and female names
- Difficulty settings
- VR Support
- Gun attachments
- A handheld tape player
- Different types of robots:
  - sniper
  - sneak
  - bomb
  - camera
  - ceiling turret
  - power leech
- Boss fights (gunship)
