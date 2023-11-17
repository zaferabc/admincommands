using Rocket.API;
using Rocket.API.Collections;
using Rocket.Core.Commands;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SK_AdminCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK_AdminCommands
{
    public class SK_AdminCommands : RocketPlugin<SK_AdminCommandsConfig>
    {

        public static SK_AdminCommands Instance;

        public UnityEngine.Color MessageColor { get; private set; }


        protected override void Load()
        {
            SK_AdminCommands.Instance = this;
            MessageColor = UnturnedChat.GetColorFromName(Configuration.Instance.MessageColor, UnityEngine.Color.red);
            Rocket.Core.Logging.Logger.Log("SK_AdminCommands plugin active!");
            Rocket.Core.Logging.Logger.Log("Would you like more free plugins? Join now: https://discord.gg/y3rYs7ZXFs");

        }

        protected override void Unload()
        {
            Rocket.Core.Logging.Logger.Log("SK_AdminCommands plugin disabled!");
            Rocket.Core.Logging.Logger.Log("Would you like more free plugins? Join now: https://discord.gg/y3rYs7ZXFs");

        }

        public override TranslationList DefaultTranslations => new TranslationList()
        {
            { "InvalidPlayer", "Sorry, I could not find the player. Try again."},
            { "PlayerSpeed", "Player {0} speed is now {1}." },
            { "SpeedMessage", "Your speed is now {0}. Enjoy!" },
            { "PlayerJump", "Player {0} Jump Power is now {1}." },
            { "JumpMessage", "Your Jump Power is now {0}. Enjoy!" },
            { "BleedUsage", "Correct usage: /broke [player]"},
            { "UserBleeding", "{0} is now BLEEDING!"},
            { "UserNotBleeding", "{0} is no longer BLEEDING."},
            { "BrokeUsage",  "Correct usage: /broke [player]"},
            { "UserBroken", "{0} has now BROKEN BONES!"},
            { "FixedBones", "{0} BONES are now fixed."},
            { "FreezeUsage", "Correct usage: /freeze [player]" },
            { "PlayerFrozen", "Player {0} is now frozen." },
            { "FrozenBy", "You were frozen by {0}."},
            { "FreezeUsage",  "Correct usage: /freeze [player]"},
            { "UnFreezeUsage", "Correct usage: /unfreeze [player]" },
            { "UnPlayerFrozen", "Player {0} is now unfrozen." },
            { "UnFrozenBy", "You were unfrozen by {0}."},
            { "UnFreezeUsage",  "Correct usage: /unfreeze [player]"},
            { "GotGod", "{0} has got GOD from {1}!" },
            { "PlayerLostGod", "{0} GOD has been removed." },
            { "AdminLostGod", "You dont have GOD anymore." },
            { "AdminGotGod", "You have GOD now!" },
            { "AdminGravity", "Your Gravity is now {0}. Enjoy!" },
            { "PlayerGravity", "Player {0} Gravity is now {1}." },
            { "PlayerGravityMessage", "You gravity is now {0}. Enjoy!" },
            { "Healed", "Your health is now 100." },
            { "PlayerHealed", "{0} was healed by {1}!" },
            { "Vanish", "You are Vanished now!" },
            { "NotVanish", "You are no longer Vanished." },
            { "GotVanished", "Player {0} has got Vanish from {1}."},
            { "NoMoreVanished", "Player {0} Vanish has been taken." }


};


    };




}











