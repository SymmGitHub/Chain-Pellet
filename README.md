Chain Pellet is a WIP, so make sure to always back up your
PMW2 files before doing anything permanent!

## Credits:
Symm - Main Programmer and UI Design.
OnVar - PMW2 file documentation, creator of 'pmw2-utils', which I referenced for a lot of file-reading code, and answering my questions.
Crazy Otto - Beta Tester and documentation of old or unused assets in PMW2.

This README also serves as a manual, and it'll cover all the basics of modding PMW2 with the use of Chain Pellet. Chain Pellet is a W.I.P. multipurpose program meant to open and edit files found in PMW2, mainly versions found in the Gamecube version of the game (though other versions partially still work with Chain Pellet). This tool, as of now, has exclusively been played and tested through the use of the Dolphin Emulator and a rom of PMW2.

This is the very first main build of the tool, and as such, it may contain some bugs. Make sure to always back up your PMW2 files before doing anything permanent! But as of now, Chain Pellet is still capable of fully editing level scripts, level nodes, and even colors on 3D models.

I'll also be including a guide on how to extract files from the Gamecube version of PMW2 with the Dolphin Emulator and playing it modded using those open files.

## Additional Tools (Optional)
-- HxD 
HxD is one of many Hex Editors capable of editing any file's raw byte data.

-- Brawlbox
Brawlbox is a Wii/GCN file editor capable of editing .tpl texture files found in the game

https://github.com/libertyernie/brawltools/releases/tag/v0.78_h1

-- Audacity and MP-Audio-Toolchain
Audacity is a free audio file editor, and MP-Prime-Toolchain, (a series of tools made for the Gamecube version of Metroid Prime) can modify Aufacity to support the editing of PMW2's music files, (.dsp)

https://www.audacityteam.org/download/
https://github.com/toasterparty/mp-audio-toolchain/tree/main

## Extracting The Game Files and Playing Modded PMW2

To first get the files from Pac-Man World 2, you'll need a Gamecube rom of the game, and Dolphin. Open Dolphin and make sure your PMW2 rom is in the list of games in the center of the window. If it isn't, go to { Options > Configuration > Path } and add a pathway to the folder containing your rom.

With PMW2 in your list of games, right-click it and select 'Properties'. In the new window that opened, scroll to the far-right tab labelled 'Filesystem'. From there, right-click the top-most icon labelled 'Disc' and hit 'Extract Entire Disc'. Select the folder you want to extract the files to and you'll have the files open to edit with Chain Pellet.

If you want to play the game from these files at any point, click { File > Open } in the top left corner of Dolphin, and navigate to the extracted files. From there, open { DATA > sys > main.dol }and Dolphin will play PMW2 from those extracted files.

## Using Chain Pellet

With the extracted files of PMW2, now you can finally start using Chain Pellet to edit them. When opening the tool, there's three main sections. The Asset Hierarchy on the left, the Scene Editor on the right, and the empty space is for various file editors. To open a level, click { File > Open Rar } and select a PMW2 (.rar) file, on the Gamecube version of the game, you can find them in { DATA > files > netdata }. They should mostly be self explanatory, 'forest1.rar' is Pac-Village, 'snow4.rar' is Pinky's Revenge, 'ghost1.rar' is Haunted Boardwalk, and so on. 

There's also another (.rar) called 'pacman.rar' which contains everything relating to Pac-Man like his model and animations as well as globally used assets like Pac-Dots, Power Pellets, and fruit. Chain Pellet can open and edit this just like the level files.

Opening a level will extract the (.rar) file using a special, old version of WinRar, moving the files to a folder by ChainPellet.exe labelled 'ArchiveData', though you can change the extraction location at any time with { Settings > Set Extraction Path }. You can quickly open the folder from Chain Pellet by clicking the button labelled 'Open Archive Folder'.

The 'Tools' Menu at the top of the window contains various individual functions. 'Extract PMW2 Rar' and 'Create PMW2 Rar' Buttons allow you to convert a folder to and from a PMW2 rar file without needing to open it, and 'Refresh' reloads the Asset Hierarchy.

## Asset Hierarchy

On the left side of the window is the Asset Hierarchy, this displays all the files stored in a level file when opening a (.rar) file. Most files are color coordinated, with yellow marking a subfolder. You can click files to select them, and if there's an associated File Editor for that type of file, it'll appear in the center of the window. Only two exist as of this build, being the Script Editor for (.txt) files and the Model Color Editor for Model Files (.hxf/nxf). Double clicking any file in the Asset Hierarchy acts the same as if you'd have double clicked the file in your File Explorer, opening it in whatever program that file extension is associated with.

PMW2 has a folder where models, textures, and animations for objects used in the game are stored, in the GCN version, this is { DATA > files > netdata > objects }. Levels will have copies of files in these folders within each level as well, and those copies are what's displayed in game. If an asset is called by the game but doesn't exist in the level, PMW2 will usually use what's in the objects folder instead. (which also means you can edit how an object looks in one level without changing how it appears in other levels.)

In the Asset Hierarchy clicking on the 'Add Asset' button will prompt you to select a path to PMW2's object folder, and this will let you quickly copy files from the object folder into your extracted level. You can also press 'Delete Asset' to quickly remove files from your extracted data as well. The last button labelled 'Open Archive Folder' will just open the folder containing your extracted level in your File Explorer.

Above the buttons is a large textbox labelled 'Filter' which you can use to filter out which files are shown in the Asset Hierarchy, making it easier to navigate to whatever file you're looking for. When adding in text, the Asset Hierarchy will update to only show files containing the string of characters in your filter text, and you can use special characters to change how the Asset Hierarchy uses that filter.

( | ) - Separates one filter into multiple, the Asset Hierarchy will display only files that contain one or more of that filter text.
( ! ) - Reverses filter to hide any file that contains it instead of any file that doesn't.

For example, the filter: ( !nxf|!tpl ) will hide all the files that contain "nxf" and "tpl", and so it'll hide files with either of those extensions.

## PMW2 GCN Filetypes:
(.txt) - Text Files, used for Level Scripts (Script.txt) and In-Game Cutscenes/Dialogue (Cinema.txt) 

(.nxf) - 3D Model

(.hxf) - 3D Model, contains multiple (.nxf) files and may contain collision.

(.amf) - Animation file for a 3D model

(.tpl) - Texture

(.sf) - Level Scene

(.ccc) - Level Collision

(.h4m) - Prerendered Cutscene

(.dsp) - Mono Music Track, two are used to make Stereo Music

(.sam) - Sound Effect Bank, contains all sound effects for each level.

## Filetypes in other versions
(.pmi) - Texture (PS2)

(.vu1) - 3D Model (PS2)

(.dds) - Texture (PC)

(.ogg) - Sound Effect/Music (PC)

## Scene Editor
The right side of the window is the Scene Editor, it's the most complicated-looking part and so I'll be going over it thoroughly. When opening a level, Chain Pellet will check if a file named 'Level.sf' exists. This is the Scene file of the level, and it contains the majority of the level information, things like where level geometry models are placed, the coordinates of objects, pathways used for things like lines of Pac-Dots, etc.

the Textbox labelled 'Name' is where you can read and edit the level's internal name, this has no affect on anything to my knowledge, but it could be good for organization if you're making multiple versions of the same level. Version is the Scene file's update version, it's best to keep this as-is.

The 6 textboxes underneath are used for defining Scene Clumps within the level, but by my testing, doesn't have any visible effect on levels. You can only edit these values if you have the option enabled to regenerate Scene Clumps upon saving. [ Settings > Scene Editor > Regenerate Clumps On Save ]

On the left side of the Scene Editor is the Node List. PMW2 Scene Files contain a list of scene placement points I've nicknamed 'Nodes'. Nodes contain two names as well as Transformation coordinates. (Position, rotation, and scale). Nodes come in various different types, and depending on the type of Node, they can also store additional data within them. Here's some of the most important, and frequently used Node types:
-- Static: Places a model, '[Geometry Name].nxf' at the coordinates of the Node. Keep in mind that models of level geometry don't store collision, only the (.ccc) files do.
-- Point: Coordinates with a name, used most often by Level Scripts to place an object at the node's position. The Node's name usually ends in '_pnt'.
-- Bounding Box: used most for trigger areas, it creates an invisible box at it's position, it contains two additional points for offsetting two of the box's corners to control the size. The Node's name usually ends in '_bnd'.
-- Point Array: A Point that contains additional position coordinates, used for a few specific objects in Level Scripts.
-- Bezier: Used for curves and paths, most commonly used for Pac-Dot pathways and chains, the names typically end in '_nurbs'.

To edit a node, simply select one from the list, and you'll be able to edit that Node's data at the bottom of the Scene Editor. That Transformation Tab contains default information for every Node, and the Additional Data contains any special, type-specific information available for editing.

## Level Editing

When extracting a (.rar) file, if a file called 'Script.txt' exists, it's opened first in the center of the window. The majority of level editing can be done by editing this file, as it controls where most objects are placed. Level Scripts are made of various lines corresponding to different functions refered to as 'actions'. Here's a line for example:

msg_init action_makeCrate(crate1_pnt,0)

'msg' (Which I assume stands for message) defines when a line should be run, 'msg_init' tells the game to run that line when the level is first initialized. There are other message types, but this is the most commonly used one. 'action_makeCrate' is the type of action that's run. As you might expect, this creates a wooden crate, its parameters are defined in the parenthesis. 'crate1_pnt' corresponds to a Point Node in the Scene file, so the crate is spawned at crate1_pnt's coordinates. 0 is the crate type, 0 being the default wooden crate.

Depending on the action, they can also 'return' values that can be saved into custom variables. action_makeCrate will return the crate created by it. Here's the previous example, but altered so that the crate gets saved to a new variable called 'crate1':

crate1 = msg_init action_makeCrate(crate1_pnt,0)

Now you can use 'crate1' to reference the crate for other actions, such as hiding or showing objects with 'action_suspend' and 'action_unsuspend'.

Some objects created with scripts can be complex with their own subscripts. One of the most commonly used 'complex' objects are Butt-Bounce Switches.

switch1 = msg_init action_makeSwitch(switch1_pnt,5)
SCRIPT
     msg_buttbounce action_suspend(crate1)
     msg_reset action_unsuspend(crate1)
ENDSCRIPT

This example crates an orange, timed Butt-Bounce Switch. Once it's pressed, it'll hide the crate created earlier, and 5 seconds later, it'll reset and re-show it.
