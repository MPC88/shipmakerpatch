# shipmakerpatch
Patch for Fairgon's ship maker unity project https://github.com/Fairgon/ship_maker

Current version:  
- Adds not sellable flag.  
- Adds bonus value entry.  
- Adds custom bonus: Lateral Injectors - allows rolling at the cost of % of hit points based on ship mass.
- Removes invalid bonus "117.SB_DroneMods_Dmg_+8%"
  
To install, download the repository (code<> -> download.zip):  
1. Copy the "Assets" folder into the Fairgon's existing Unity project.  Replace all files when prompted.  
2. deploymentfiles contains 2 .dll files.  User will have to place these into their .\BepInEx\plugins\ folder in order to use your mod.

The update RedRoadster.dll will continue to support ships made with previous verisons, however:  
- Ships made prior to 2.1 with a non read/write enabled icon texture will now work, but the icon will be replaced with a box.  This is due to a change made in the base game (the ship map icons).  
- Ships made with the previous shipmaker Unity project will have to have bonuses re-added when opened in the new project.
  
The value of a bonus should be comma separated value of each parameter.  For example:		
bonusName = 001.SB_Armor  
bonusValue = 10, 0.3  
gives +10 armor, +30% armor   (parameter1 = armor bonus, parameter2 = armor mod)  
  
You must make an entry for all parameters for a bonus (even if it's zero, false or similar).  If your value entry is invalid, the default bonus value will be used.  
  
This spreadsheet provides more information:      
https://docs.google.com/spreadsheets/d/1Y73L7JTdmD8JNqmLiuLUWSW_v-u8-2jE94TtuIjZV4Q/edit?usp=sharing  
