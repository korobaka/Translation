using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Hungarian
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Bot requires permission \" Embed Links \"",
                AdminOnly = "You are not a server admin", //Rework
                PlayerNotFound = "Player {0} not found",
                ApiError = "API Error",
                UnknownItemID = "Cannot find item name or ID",
                UnknownMob = "Cannot find mob name",
                EnterIP = "Enter an IP",
                InvalidIP = "Invalid ip",
                Cooldown = "You are on cooldown for 1 mins!",
                EnableQuery = "Minecraft server does not have enable-query set in server.properties",
                ListNoServers = "This community has no servers listed",
                UnknownArg = "Unknown argument do",
                TextLimit = "Text cannot be more than 22 letters/numbers"
            },

            Main = new TMain
            {
                Commands = new List<string>
                {
                     "[ mc/bot ]( Bot Invite/Info/Stats/Links )",
                    "[ mc/quiz ]( Minecraft quiz :D )",
                    "[ mc/colors ]( MC color codes )",
                    "[ mc/uuid (Player) ]( Player UUID )",
                    "[ mc/ping (IP) ]( Ping a server )",
                    "[ mc/list ]( List community servers )",
                    "[ mc/wiki ]( Wiki for Items/Mobs/Enchants/Potions )",
                    "[ mc/version ]( Minecraft version info )",
                    "[ mc/skin (Player) ]( Player skin )",
                    "[ mc/names (Player) ]( MC account name history )",
                    "[ mc/status ]( Mojang status )",
                    "[ mc/get (Text) ]( Get an achievement )",
                    "[ mc/minime (Player) ]( Minify player skin )",
                    "[ mc/playing ]( People playing Minecraft )",
                    "[ mc/hypixel (Player) ]( Hypixel player stats )",
                    "[ mc/admin ]( Community admin commands )",
                    "[ mc/invite ]( Get the bot invite )"
                },
                HelpFooter = "There are some hidden commands aswell ;)",
                MultiMC = "MultiMC allows you to manage and launch multiple versions with easy forge/mods installation",
                SkinEditor = "Online Skin Editor",
                PleaseWait = "Please wait while I ping",
                ServerAdminUse = "Guild administrators should use", // Rework
                SkinArgs = "(Player) | head | cube | full | steal",
                StoleSkin = "Stole a skin",
                NameOnlyOne = "Player {0} only has 1 name on records",
                PlayingMinecraft = "People playing Minecraft",
                Hi = "Hi",
                BotDesc = "If you have any issue, suggestions or language translations please contact me"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hey, you found a secret command :D",
                MinecraftClassic = "Minecraft classic was the second phase of developent in 2009 that allowed players to play in the browser using java on the minecraft.net website which was primarly used to build things",
                Forgecraft = "Forgecraft is the set of private whitelisted servers for mod developers to gather and beta-test their mods in a private environment. Many YouTubers and live-streamers also gather on the server to interact with the mod developers, help play-test the mods, and create videos to let the general public know what the mod developers are doing.",
                Bukkit = "RIP Bukkit you will be missed along with other server solutions...",
                Direwolf20 = "Direwolf20 is a popular youtuber known for his lets plays and mod tutorials on modded minecraft. He also plays on a private server called Forgecraft with a bunch of mod developers and other youtubers with his friends Soaryn and Pahimar",
                Herobrine = "Always watching you...",
                Entity303 = "A minecraft creepy pasta of a former Mojang employee who was fired by Notch and now want revenge",
                Israphel = "The best youtube minecraft series that will never die in our hearts... 2010 - 2012 RIP Yogscast",
                Notch = "Minecraft was created by Notch aka Markus Persson"
            },

            Wiki = new TWiki
            {
                Blocks = "Blocks",
                Unknown = "Unknown",
                Player = "Player",
                Players = "Players",
                Attack = "Attack",
                Easy = "Easy",
                Hard = "Hard",
                Health = "Health",
                Height = "Height",
                Width = "Width",
            },

            Admin = new TAdmin
            {
                Commands = new List<string>
                {
                    "[ mc/lang ]( Set the community language )",
                    "[ mc/addserver ]( Add a MC server to this guild list )",
                    "[ mc/delserver ]( Remove a MC server from this guild list )",
                    "[ mc/setprefix ]( Set Custom Prefix )",
                    "[ mc/resetprefix ]( Remove Custom Prefix )"
                },
                WantTranslation = "Want a language translates? Contact",
                ChangeLang = "Change Community Language",
                UseList = "Use mc/list for a list of this guilds minecraft servers",
                AddServer = "Enter a tag, ip and name",
                AddServerAdded = "Added server {0} to the guild list",
                AddServerAlready = "This server is already on the list",
                DelServerEnter = "Delete a server with",
                DelServerNone = "This server is not on the list",
                DelServerDeleted = "Removed server {0} from the guild list",
                PrefixReset = "Reset server prefix"
            }

        };
    }
}
