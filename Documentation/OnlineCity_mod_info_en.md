OnlineCity - is a network game module for the RimWorld survival simulator. It allows multiple players to play on the same planet online.

After registration, you can create your own settlement and begin to develop alongside other participants. You are given the opportunity to monitor the progress of your neighbors, their settlements and caravans, but most importantly, you can provide each other with quite material assistance by transferring food, medicine, weapons or any other things, including settlers. For example, you can send your doctor to help in difficult times, and arrange for the doctor to be returned back after treatment. To transfer it is necessary only by all the rules of the game to collect a caravan and get to the goal! Also now you can beat off attacks on your settlement and capture the settlements of other players, giving commands to your colonists!

1. General description
2. Exchange between players
3. Other interaction
4. Attack on player settlements (PVP)
5. Installing the mod and how to start playing
6. Additional modifications
7. Server
8. Functions of the mod in the game
9. Possible problems
10. Other frequently asked questions

# 1. General description

This mod almost does not change the gameplay. All events, settlements of the NPC and game mechanics for each player are different and are not connected with each other. Thanks to this, the balance of the game, which was conceived by the developers, is not upset. What exactly is changing?

Your game is saved exclusively to the server and you can get into the network game only by clicking on the Network game button and entering the login and password. Autosaves occur every 15 minutes (can be changed in the settings) and when you exit the game. Important! Do not close the game using Alt-F4 or the operating system, in this case saving upon exit will not work and progress will be rolled back to the moment of the last successful saving. Use the menu to exit. If for one reason or another you want to play this game offline, you can do this by downloading the onlineCityTempLoad file, but your progress cannot be transferred to the server, you can only play offline. If you start the game in any way except by the Network game button, then the mod is completely turned off and does not work.

When playing online on the planet, settlements of other players appear. The appearance of the icons approximately shows the wealth of the settlement, and if they are online, the light will be on in the house. By clicking on them you can see what kind of player it is, whether it is online, what is the total cost of people and things in the settlement. Caravans of other players are also displayed.

Having equipped your caravan and reaching the settlement or player’s caravan, you can transfer any goods and pawns. In addition, caravans display the weight that they can still take. Transfer is carried out in one direction. That is, if you need to exchange goods, you must first agree on this in the chat and first one player must pass on what is needed, then the other player will give back. If the player is not online, then the goods will be transferred to him when he enters the game.

In the game, by clicking the Online button, you can open chat, settings, and more. On the first tab in the chat you can see a list of all players and those who are online. You can create new channels in the chat and add any players there. By right-clicking on any player, you can select the Information item, and see that the player wrote about himself how much he has been playing, when was the last time, a list of all his colonies and caravans, their value and total wealth.

For those who want more, you can set the Participate in PVP item on the Settings tab. After that, it will be possible to attack the settlements of players who also have this option turned on, and, of course, if they are also online.


# 2. Exchange between players

Transfer between players is possible only from the caravan. To transfer anything you need to select your usual caravan, right-click on the settlement or caravan of another player and select the item Exchange of goods. An intuitive window for selecting the item to transfer opens. You can transfer the player any amount of goods, animals and settlers. You can transfer as many times as you like, even if the player is offline.

Upon receipt of the transfer, a message will be issued, which will briefly list what is being transmitted and the opportunity to refuse it (in this case things will be destroyed). If the player agrees, then the transferred items will appear in the largest warehouse, in the name of which there are symbols "trad", if there is none, then in the largest warehouse with any name.

When transferring prisoners there is a nuance. They do not appear immediately in the prison, but in the warehouse in the form of a passive hostile pawn, without weapons that need to be captured and placed in the right prison on their own.

When the last pawn is transferred, the caravan will be disbanded, and the remaining items will be automatically added to the transfer. But you can leave some kind of animal, so that later an ally could return your colonists to this caravan from one animal.

When a settler is transferred, all his connections with other settlers are lost. So, do not be surprised at easy amnesia when your militants return after helping a neighbor :)

There is an unresolved issue of transferring pawns when using HardcoreSK. Maybe a similar problem will be with some other mods, is not yet known.


# 3. Other interaction

Pirates and warlike natives will gladly agree to work for a reward. In addition, by paying the required amount of gold, you can cause acid precipitation, set beetles, mechanoids, and so on. To trigger different events, find another player's settlement on the palnet, select it, and click on the Interact button.

Certain events can have a force of impact, such as raids and beetles. You can double, triple, etc. their number, relative to what the game itself generates for the settlement. As a rule, * 10 is very difficult to survive even for experienced players. The price of a call increases non-linearly with an increase in the level. Here is the general price per call formula:

(value_of_attacked_settlement / 100 000) ^ (2/3) * 100 * impact_power ^ (3/2)

Additional multiplier * 3 if it is a beetle summon. Multiplier * 2 for summoning industrial grade pirates. Multiplier * 5 for summoning mechanoids.

Takde a raid can be called not only on foot from the edge of the map, but also with a landing in the center (price * 1.4), or scattered landing (price * 1.5), while the cost of capsules will also be deducted by the game from the total cost of the raid.

These calculations may change over time, during balance adjustment. In addition, on the server, you can set the total price coefficient and the final cost of the attacking raid. You can also change the maximum force factor (default * 10).

The summoned raid will come to the goal when the player enters the game. If the raid is very large (the strength is more than 50% of the possible choice), then the settlers will notice its approach in half a day. After the attack, the next one will come no earlier than in a game day, but after how much it will be calculated using the following formula:

1 + impact_power * 0.16666 + 0.03333 * (attack_set_value / 100 000) = days delay before next event

There is novice defense: both the attacking player and his target must have a playtime of more than two years and a settlement cost of more than 100 000.

Events from different tabs can be called simultaneously. Each player can only trigger 1 event from each tab per player. But another player can also add his own event to the same target: in this case, they will be triggered in turn, keeping the delays. The total number of events in the queue cannot exceed 2.


# 4. Attack on player settlements (PVP)

Now, if you want, you can attack a foreign colony with your caravan. You will appear at the edge of the map in a random place. Then you can look at the enemy’s base, be horrified and retreat (all pawns near the edge of the map in this case will go to the caravan). Rob, if something can be carried away with you. Or capture the settlement, killing or knocking down all the enemy pawns.

Your colonists will attack the enemy colony in the form in which it is playing at the moment (of course, it must be online). True, the interiors of the premises will be closed until the doors or walls are broken. The attacking pawns are always in combat mode and accept commands to go to the position, shoot at the target and attack the target closely. They can also throw and pick up weapons, clothes and take or throw something from the inventory, they can also eat or drink something. Actually, the control possibilities end there: it turns out that only the main teams for fighting are available. For example, items such as Activate Artifacts do not work. Pawn behavior settings also do not work, for example, auto-attack is always on. Peaceful skills are not available in battle, that is, if you need to disassemble the wall and you have a wonderful miner, you still have to blow it up with a grenade or shoot from what is. All this, including the capture of pawns, can be done after the settlement is captured.

We should also say that the attacker manages the situation remotely. Because of what, his orders are executed, but he does not see the process of aiming and shooting. Movements also occur in jerks. It is sad that it did not work out to do everything smoothly. At the moment, I do not see the technical ability to make this mechanism better. In order to slightly compensate for the loss of control, the speed of movement of the pawns of the attacked is halved (the reduction takes effect a minute after the start of the battle in order to have time to take a position).

To attack, both you and the enemy in the Settings tab should have a checkmark "Participate in PVP". You can change it once a day. Also, for an attack, the value of people, animals and things of your caravan should not exceed a certain cost, which depends on the price of the settlement. If you encounter such a problem, you can split the caravan by removing animals from it or reducing the number of attackers. You can find out the exact cost of your caravan by clicking on your nickname in the chat and selecting the Information item, general information and information will be opened for each settlement and caravan separately. The server has a setting how many minutes a player cannot be attacked after the last attack. For example, on the official server it is 20 minutes.

If either side during the battle leaves the game, this will be tantamount to defeat and the player will lose the colony or the caravan that is attacking. For the other side, only the fact that hostile pawns will passively shoot back under the control of the AI game will change. If the attacker wants to retreat, then he can select the Retreat option in the menu, then those who are closer than 10 cells to any edge of the map will move to the caravan.

While PVP is in progress, half of the first speed is forcibly set. You can neither pause nor accelerate.

Time of day and climatic conditions are not synchronized. The current ones on the host act (the one being attacked).

Tamed animals from the caravan do not participate in the attack: they will appear at the edge of the map and will wait for you to stay or retreat with you.


If interested, here is the exact formula for the maximum price of an attacking caravan:
4 / (25/1000000 + 10 / colony wealth)
It turns out, for example, like this: the cost of a colony -> maximum for a caravan
100,000 -> 32,000

400,000 -> 80,000

1,000,000 -> 114,400

2,000,000 -> 133,332


There are a couple more issues that an attacker needs to consider.

There is always an auto attack, therefore, when a pawn stands, it begins to attack the target chosen by the AI, if the attack command was not given explicitly. Therefore, with a single-shot weapon, you need to be careful.

Occasionally, the command to go may be canceled or even a pawn may be afraid to start "running away" to the edge of the map. Check if pawns continue to execute commands.

Detailed pawn parameters such as inventory, health, needs, etc. are updated less frequently. When changing inventory or changing in health. In this case, the pawn is updated as a whole and the selection drops from it, if it has been allocated.

A target that is slain will not be selected by an auto attack and cannot be beaten closely, if you absolutely want to finish it, then shoot it.

The extreme position on the border of the map is not available due to the patch. The fact is that the AI of the game, seeing that the attacking pawn wants to leave and is already on the edge, immediately removes it. It turns out that things that have fallen to the very edge will be available only after the capture of the colony. There is also a problem associated with this: sometimes, when a pawn is located across the cell from the edge of the map, it gets stuck there and does not respond to commands. It has not yet been possible to fix this, but if this happened, then try to select a pawn and quickly click


# 5. Installing the mod and how to start playing

1) Have any RimWorld not lower than 1.1

2) Download the HugsLib and Harmony mod https://bit.ly/2PQjc6d Or from Workshop https://bit.ly/2KvHtbP

3) Download the OnlineCity mod itself. The latest version is in the discord https://discord.gg/5DzWrnR on the channel #news, or from Workshop https://steamcommunity.com/sharedfiles/filedetails/?id=1908437382

4) Open RimWorld, in “Mods” put a checkmark on Harmony, then Core, HugsLib, and only then other mods and OnlineCity (OnlineCity is best to be the last one). Click the close button. The game must restart.

5) In the main menu, click on the "Network Game" button. If it is not, then either the RimWorld version is not supported or the mod was not enabled correctly.

6) Create an account and enter it. Before doing this, make sure that there are no important data in the Mods folder, make a copy of it. The first login or registration on the server may take several minutes, depending on the server settings and Internet speed.

7) Select the desired landing site.

8) Pick / Create your own colonists. If possible, just in case you create in Prepare Carefully, save them.

9) Everything is ready! Welcome to Online City!

Additionally, it may be interesting:

In the ModsConfig.xml file, the list of mods should start with
    <li> brrainz.harmony </li>
    <li> ludeon.rimworld </li>
    <li> unlimitedhugs.hugslib </li>
And end (preferably at the very end):
    <li> aant.onlinecity </li>

	
Common problems:

* If your computer can barely handle RimWorld, then keep in mind that with this mod the memory requirement is slightly increased. It is recommended to play on a 64-bit operating system.

* The game is poorly stable with poor communication, if it is often torn, problems may occur.

* Check the mod version. This can be done by clicking Network game, and then What’s what, there will be a version in the first line.

* If it turns out to connect / register, and then the black screen or the game freezes, then try to wait a few minutes

* If you can’t register and writes that such a login is already taken, then try to use more than 3 characters in the username and password, and the login has more Latin letters. Also try just logging in, if you had a failure, then it may have occurred after you were registered.

* No password reset system. You can only start over. The server administrator also does not have this access, but he can delete your settlement to free up space.

* If all else fails, then try disabling other mods. If this helped, and the game started, then write to us which mod turned out to be incompatible.


# 6. Additional modifications

On the server there is an exact match mods setting. If it is enabled, the game’s Mods folder and the ModsConfig.xml file will be deleted and downloaded from the server. Be careful, and before entering the server for the first time, make sure that there is nothing valuable in the Mods folder! The presence of DLC Royality is not controlled and will not be downloaded from the server; you must install it yourself if it is required for the game on the server. Make sure you have one if you need one. If it is not needed for the server where you play, then before entering it is better to disable it. If the server does not need it, but you have it, then it will be correctly disabled. Further in the text, it is assumed that the setting is turned off and no synchronization occurs.

If synchronization is turned off, if the OnlineCity mod is not compatible with the version on the server, an error will be generated and you will need to update it yourself. Also turned off synchronization means that different people can have completely different sets of mods.

Watch carefully from which mods items to whom you pass. If both of you use the necessary modification, then there should be no problems. In other cases, the result is not predictable. Maybe a special property will simply be lost, or the item will simply disappear (most often this happens), but in some cases the game may completely break down (in this case, do not try to log in again after you have verified that the game is not working, and inform the server administrator, maybe he will be able to restore your previous save).

It is also highly recommended not to use modifications that change the landscape: the outline of the seas and mountains. Thus, your settlement for other players may be in the middle of the ocean or may be inaccessible. In any case, it is unpleasant to play on different planets. An exception is if you maintain contact with all players and agree that such mods and their settings will be the same for everyone.

If you will use the function of attacking players, then carefully read section 3. Attacking player settlements, it also tells about the dependence of additional modifications.

At the moment, there is only one incompatible mod: Save Our Ship 2

Potentially, OnlineCity is compatible with any other mods, but, of course, you need to be careful, especially when using large modpacks. It's funny that the mod is even compatible with Zetrith Multiplayer (except, perhaps, the PVP mode was not tested). After all, OnlineCity synchronizes the planet where everyone has their own settlement, and Zetrith Multiplayer is a cooperative of one settlement.


# 7. Server

!The information in this section is outdated, it is being updated in the process!

Unzip the archive with the server to any folder. After that, you need to create a subfolder of World, which will store all the game data.

Create a Settings.json file in the World folder (it can be opened with a simple notepad). Here is an example of its contents:
```

{
  "ServerName": "OnlineCity Server with modpack",
  "SaveInterval": 10000,
  "Port": 19019,
  "Description": "Official server OnlineCity with modpack",
  "IsModsWhitelisted": true,
  "DisableDevMode": true,
  "MinutesIntervalBetweenPVP": 20,
  "GeneralSettings": {
    "EnablePVP": false,
    "DisableGameSettings": false,
    "IncidentEnable": true,
    "IncidentCountInOffline": 2,
    "IncidentMaxMult": 10,
    "IncidentTickDelayBetween": 60000,
    "IncidentCostPrecent": 100,
    "IncidentPowerPrecent": 100,
    "EquableWorldObjects": false,
    "ExchengeEnable": false,
    "StartGameYear": -1
  },
  "ModsDirectory": "C:\\CityOnlineTest19019\\Mods",
  "ProtectingNovice": true,
  "DeleteAbandonedSettlements": false,
  "ModsConfigsDirectoryPath": "C:\\CityOnlineTest19019\\Config\\",
  "IgnoredLocalConfigFiles": [
    "KeyPrefs.xml",
    "Knowledge.xml",
    "LastPlayedVersion.txt",
    "Prefs.xml"
  ],
  "IgnoredLocalModFiles": [ ]
}
```

ServerName and Description - the name and description of the server, while not used anywhere, is not necessary.

SaveInterval - the frequency in ms at which the server will save new data, if any, it is better not to change the default value of 10000.

Port - the most important parameter, the port on which your server is running, by default 19019.

IsModsWhitelisted - if exact mod matching is used, then set to true, otherwise false.

ModsDirectory - if IsModsWhitelisted is set to true, then there is a folder that will be copied to each client in its Mods folder, otherwise the value is ignored. More details below.

ModsConfigsDirectoryPath - if IsModsWhitelisted is true, then, similarly to ModsDirectory, you should specify the folder with mods settings. More details below.

DisableDevMode - whether the developer mode will be disabled when players enter online.

MinutesIntervalBetweenPVP - after an attack on one player by another, he cannot be attacked for a given number of minutes. You can put, for example, 0 or 20.

ProtectingNovice - Protection of novice players from attack, as well as a ban on transferring goods from new settlements.

DeleteAbandonedSettlements - The server will automatically delete undeveloped settlements that have not been played for a long time.

GeneralSettings - A hierarchy of settings existing for technical needs, within it, the settings are as important as the rest.

EnablePVP - Enable the mode of attacking players against each other online with limited control

DisableGameSettings - Disallow changing the settings of the narrator and modifications in the game

IncidentEnable - are incidents allowed (actions on the Interaction button on foreign settlements)

IncidentCountInOffline - How many incidents are allowed in the queue (from one player in any case only one)

IncidentMaxMult - Maximum odds. the forces of incidents

IncidentTickDelayBetween - Minimum pause between incidents in ticks (1 day = 60000)

IncidentCostPrecent - Percentage hiring cost modifier

IncidentPowerPrecent - Percentage raid strength modifier

ExchengePrecentWealthForIncident - How much the cost of things on the exchange, in orders and on the account will affect game incidents (how much silver per 1000 silver of the cost of things. For example, 1200 is 120%, 20% more influence on the raid from things moved to the server)

StartGameYear - Assign the starting year in the game instead of 5500

IgnoredLocalConfigFiles - The names of the configuration files to ignore. The rest will be synchronized with the server folder specified in ModsConfigsDirectoryPath if IsModsWhitelisted is true.

IgnoredLocalModFiles - The ending of ignored file names from the mods folder. The rest will be synchronized with the server folder specified in ModsDirectory if IsModsWhitelisted is true.

EquableWorldObjects - the functionality is not ready yet, you should delete the line or put false.

ExchengeEnable - the functionality is not ready yet, you should delete the line or put false.


Check that you have .NET Core 3.1 installed before starting: https://dotnet.microsoft.com/download/dotnet-core/current/runtime

Run ServerOnlineCity.exe. The console should open, which is the server. The output to it is duplicated to the log files in the World folder.

In order for people to be able to connect to it, you need to open port 19019 (or the one specified in Port).

When the server starts up, the "World" folder will be created in the folder with it. The first person to register on the server through the game will be considered an administrator. Special commands and developer mode are available to him, even if he is turned off by the server settings. At the first login / registration, the administrator will be asked to select the world seed, the percentage of the world filled in and the complexity of the game (simple / normal / difficult). The script and the narrator are always the same at startup. After that, the game will take several minutes, after which you will be returned to the main menu. Everything is ready! You can go again and as a regular player to create a settlement.

In *nix systems, the launch should also occur without problems, because The server is written in .NET Core 3.1.

There is also a Discord bot. You can read about its configuration separately here: https://github.com/AantCoder/OnlineCity/tree/dev/Source/DiscordChatBotServer


More details on how to configure the mode of exact matching mods.

To install everything correctly, configure your RimWorld so that all mods are taken from the Mods folder (not a single mod from Steam!). Check that everything works fine in a regular game. And copy your Mods folder to the server. You should have at least three folders (inside Mods): Harmony, HugsLib, OnlineCity.

After that, copy the ModsConfig.xml file from the game to the server in the World folder
%appdata%\..\LocalLow\Ludeon Studios\RimWorld by Ludeon Studios\Config
For example, I have it here:
"c:\Users\Ant\AppData\LocalLow\Ludeon Studios\RimWorld by Ludeon Studios\Config\ModsConfig.xml"


Some solutions to problems starting your server:

1. The server console is open and there are no errors
2. Try to enter the game from the same computer at localhost
3. Check that friends are joining at the right IP address (you can google "how to find my IP")
4. Forward port 19019 in the router (also google "how to open the port")
5. Verify that the firewall allows the use of connections, or disable it
6. Verify the version of the mod with the one who is connecting. This can be done by clicking Network game, and What’s what, there will be a version in the first line
7. The game is poorly stable with poor communication, if it is often torn, problems may occur.
8. If it turns out to connect / register, and then the black screen, then try to wait 5 minutes
9. If you are unable to register and writes that such a login is already taken, then try to use more than 3 characters in the login and password, and in the login more Latin letters


All player saves are in a subfolder of World\DataPlayers and have the name {player name}.dat {number}

{player name} is the player’s login, but some characters that are not allowed for the file name are replaced with the symbol _

{number} is the save history, 1 is the latest, 2 is the previous, 3 is the oldest

There are also situations when, instead of history, only the file {player name}.dat1 and {player name}.bak remains. This means that a return to a previous save is undesirable. For example, this happens after a player transfers something to another player in order to exclude endless transmission.

How can an administrator help a player?

If you delete the files {player name}.dat *, then the next time you enter the player will be asked to create a new settlement. However, it is better to use the command from the console /killhimplease {UserLogin}

If the player’s save is corrupted, you can delete the file {player name}.dat1 and rename the file {player name}.dat2 or {player name}.dat3 to this name

You can regularly delete settlements of players who have played less than a few gaming days and have not entered for a long time. To do this, in the game you can find their settlements on the map by the icon of the smallest house, click on them, then on the information i. Here you can see the total cost of the settlement (for example, if it is less than 30000) and when the user last visited. If you decide to remove the player, then use the command /killhimplease {UserLogin}
Or the server can do it itself by configuring DeleteAbandonedSettlements.

How to make sure that the player is who he claims to be? For example, if a player writes that his preservation is broken, and he asks to remove his settlement. In this case, ask him to try to enter the game right now. Then ask him to send you his logs for today. Then you can find the lines of his login to the server and compare the time with the logs on the server itself (keep in mind that there may be different time zones).


Blocking intruders.
In the World folder, you can create two files for the connection ban.
blockip.txt - IP addresses to be blocked. One line one IP, the last value can be written through the fraction 1.2.3.0/2 will add three IPs uploaded to .0, .1 and .2

blockkey.txt is a key ban. each player has unique keys. You can find them out from the logs by searching for "key=", there is something like this line:

Checked loginName key=hlw57jjSV5HacQbb9iiB@@@51b36et2ZBvBUkUztF+N

Each user has several keys and matching any of them is enough to block. Therefore, to ban by key, you need to add both to the file (each on a separate line). Keys are separated by three @@@ symbols, you do not need to write them.
When you first log in from new equipment, a special key 111@@@ is added

In both of these files, you can write comments that must go after the key or IP separated by a space


You can get a summary of all the players in the console by pressing the letter S. This will create a Players_date.csv file with a list of players, last login time and some game information. Here's a description of some of the columns:

LastOnlineDay - how many real days ago the player was online

BaseCount - current number of settlements

CaravanCount - the current number of caravans

MarketValue - the current value of the settlement

MarketValuePawn - the current value of the pawns

AttacksWonCount - how many incidents were directed at the player

AttacksInitiatorCount - how many incidents the player made on other players

ColonistsCount - how many colonists there are

ColonistsDownCount - how many of the colonists are off their feet

ColonistsBleedCount - how many of the colonists have bleed

PawnMaxSkill - how many colonists have 8 out of 12 skills of level 20. It should probably always be = 0. If it is equal to ColonistsCount, then this is definitely a cheat

KillsHumanlikes - How many player colonists killed other people

KillsMechanoids - how many player colonists killed mechanoids

KillsBestPawn - which colonist killed the most

Grants - rights on the server, "UsualUser" - regular user, "SuperAdmin. Moderator" - world creator (first registered)

IntruderKeys - keys by which you can ban and search for logins to which you enter from one computer

StartMarketValue - the price of the starting settlement

StartMarketValuePawn - price of starting pawns

MarketValueBy15Day - the maximum settlement value that the player has collected in 15 days

MarketValuePawnBy15Day - the maximum value of pawns that a player has collected in 15 days

MarketValueByHour - the maximum settlement value that a player has collected in 1 hour of play, excluding pause time

MarketValuePawnByHour - the maximum value of the pawns that the player has collected in 1 hour of play, excluding the pause time

TicksByHour - maximum number of ticks in one hour online (including pause time)

HourInGame - game time for the current colony, excluding pause time


Server logs are created automatically Log_data.txt, together with the file with incidents Incidents_month.csv. Several events are marked here for each incident:

NewIncident - fromLogin player ordered a raid on toLogin

SendMail - toLogin passed all the expectations from the past, and half a day of waiting before the attack for raids and the event started directly

DayAfterMail - a day has passed after the event, at this moment it is determined how long you need to wait more (or not more), it is convenient to see how much damage the raid did

End - the end of the wait, the event is fully completed and at this moment releases the queue.

Columns:

fromDay and toDay - what is the attacker's game day and target at this moment

worth - is the total cost of items and pawns. In separate columns for the entire account, in the worthTarget exactly the settlement of the target

delayAfterMail is how many days of delay were calculated (at the time of calculation, 1 day has already passed)


# 8. Functions of the mod in the game

Special commands are written in the chat (usually in any channel), and they will not be displayed in it. All such commands begin with a /

/grants add {UserLogin} Moderator - add user right.

/grants revoke {UserLogin} Moderator - revoke the user right.

/grants type {UserLogin} - view current user rights.

/killmyallplease - removes the save from the server, and all settlements and caravans from the map. Registration remains. At the next call, it will be proposed to create a new settlement. The function can also be called from the About tab by clicking the Start again button.

/killhimplease {UserLogin} - (admin only) is similar to /killmyallplease, but the specified player.

/everybodylogoff - (admin only) command for the server to shut down correctly. All online players are given a save and exit command. After calling the team, you need to monitor the server console: as soon as the activity of the players disappears and the server saves the data, the console can be turned off. It is not recommended to start with an active PVP session.

/createchat {Name} - creates a new chat with the specified name, also available in the chat interface

/addplayer {UserLogin} - adds a player to the current chat, also available in the chat interface

/renamechat {Name} - renames the current chat, also available in the chat interface

/exitchat - leaves the current chat, also available in the chat interface

/discord - for details see https://github.com/AantCoder/OnlineCity/tree/dev/Source/DiscordChatBotServer

/say {'player name'} {/color}* {'title'} {text} {continuation of the text} ... - sends a message to the player in the form of a game letter, available to the administrator.
*optional parameter color is defined by beginning with / Can be like this:
	/treatbig - red letter with sound
	/treatsmall - red letter
	/death - gray letter with sound
	/negative - yellow letter
	/positive - blue letter with sound
	/visitor - blue letter
	/neutral - gray letter (default)

/call {событие} {'player name'} {sId settlement target} {power}* {way of arrival}* {fraction}*
*optional for some events
the player's name is required in single quotes, for example: /call raid 'babur'

List of available events:
*	raid - calling a raid on a player. The choice of capacity is available, an integer from 1 to 10. The method of arrival and the choice of fraction are also available.
*	inf - summon beetles on the player's card. Power selection available
*	acid - acid rain challenge on player card
	
List of available arrival methods:
*	walk - arriving on foot from a random edge of the map
*	air - drop in drop pods to the player's home area
*	random - drop in capsules to random points on the map. Grants a highly dispersed raid
	
List of available factions:
*	tribe - a hostile Aboriginal faction. A huge number of people with primitive weapons
*	pirate - hostile faction of the industrial level of development. Soldiers with good firearms and rocket launchers as well as melee fighters will arrive
*	mech - fraction of mechanoids. Heavily armored, as a rule, arrive in small numbers. When quality is more important than quantity
	
Example:

/call raid 'babur' 143 8 random pirate

/call inf 'SSDExecutor' 23 4

/call acid 'Aant' 16

Note:

if the power, arrival method and fraction are not specified for the raid event, the default is called

/call raid {'player name'} 1 walk pirate


# 9. Possible problems

If the game crashes (the colony does not load or it is impossible to play due to errors), then you can contact the administrator and ask him to restore the game from the previous save. You can also restart the game under the same account.

There is an unresolved issue of transferring pawns when using HardcoreSK. Maybe a similar problem will be with some other mods, is not yet known.

If you tried to log into the server, but the game showed a message that not all files passed the test, then just go again. This is a normal situation. Or there have been some, possibly minor, changes in the modpack. Either something has changed in the Mods folder or the ModsConfig.xml file has been changed by your game.

After registration and login, mods can be downloaded and saved from the server. Sometimes this can take several minutes, during which the game may freeze or display a black screen. Try to wait up to 10 minutes. In some cases, when you first enter the server with downloading a large modpack with poor Internet speed, this can take a significantly longer time.

If you have already logged in and played on the server with the mods synchronized, then if after restarting the game click on the Mods main menu, then the next time you log into the server, the game will most likely restart. In fact, nothing has changed, but the game after opening the list of mods overwrites ModsConfig.xml and it can change a little. This is normal behavior, just click the Fashion button less often :)

There is a bug that is difficult to catch. Sometimes after transferring a settler to another player, a copy of it (a pawn with the same name, profession and skills) may appear in some event or ask to join the settlement. Do not agree, eyewitnesses say that this is a ghost that crashes the game! :)


# 10. Other frequently asked questions

> How to choose a game scenario?

The game scenario cannot be customized, but the narrator and difficulty can be changed immediately after starting through the settings. Initially, the game begins with the narrator Cassandra, a standard scenario of the Classic and the complexity that was set when creating the server.

> Is it possible to play together in one settlement?

You cannot play on one map, except for attacking another player’s settlement, but this is still not direct control. If you need this type of game, try Zetrith Multiplayer

> What happens to others when I pause?

Nothing :) The course of the game of all participants is independent. Each player on the map has his own game session, in which interaction with foreign settlements and caravans is added. For example, you can pause and see how other people's caravans move on the map (although it’s difficult to get to the time when another player goes by caravan).
But what an example of interaction may be: at the time of the attack, you can ask for help from a friend and pause the game, at that time he will come up as a caravan and transfer his settlers; after repulsing the attack, you can return the settlers in the same way. Or, for example, the one who came to the rescue can transfer all the pawns except one animal so that the caravan is not disbanded, then it will be possible to return the settlers immediately after repulsion, creating a new caravan from them and transferring them back to the friend’s caravan.

> Game freezes after authorization

It does not freeze, but it loads, just wait. The loading process can take up to ~ 5 - 10 minutes.

> How to find logs

Individual OnlineCity logs are written in: %appdata%\..\LocalLow\Ludeon Studios\RimWorld by Ludeon Studios\OnlineCity (this can be inserted into Explorer)

> How to remove your colony?

You need to open the Online window through the panel below or through the Menu in the game. Next, on the About Fashion tab, click Start Again.
The same action can be done by writing the command in the chat: /killmyallplease

> How often is the game saved?

The game is saved to the server once every 15 minutes, if you have not changed it on the Settings tab, it is also saved when you exit the game through the menu.
Using ALT + F4, you can roll back your colony to the last save.

> What should I do if I forget my password?

Unfortunately, there is no password recovery system. Try to remember and if access cannot be restored in any way, then ask the administrator to delete your colony in order to free up space on the planet and register a new user.

> Is developer mode available to other players?

It depends on the server settings. If the mode is disabled, then everyone except the administrator will not be able to put it. You can check it out yourself :)


References:

The main server address is: rimworld.online

Discord: https://discord.gg/5DzWrnR

Official VK mod group: https://vk.com/rimworldonline

Trello: https://trello.com/b/gXtWtDjy/onlinecity-mod-rimworld

GitHub: https://github.com/AantCoder/OnlineCity
