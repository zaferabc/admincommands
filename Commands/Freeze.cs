using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace SK_AdminCommands.Commands

{


    public class Freeze : IRocketCommand
    {


        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "freeze";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "sk.freeze" };

        public void Execute(IRocketPlayer caller, string[] args)
        {
            {
                var player = (UnturnedPlayer)caller;
                switch (args.Length)
                {


                    case 1:


                        var user = UnturnedPlayer.FromName(args[0]);
                        if (user != null)

                        {
                   
                            user.Player.movement.sendPluginSpeedMultiplier(0);
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("PlayerFrozen", user.DisplayName), SK_AdminCommands.Instance.MessageColor);
                            UnturnedChat.Say(user, SK_AdminCommands.Instance.Translate("FrozenBy", player.DisplayName), SK_AdminCommands.Instance.MessageColor);
                        }

                        else

                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("InvalidPlayer"), SK_AdminCommands.Instance.MessageColor);

                        break;
                        default:
                        UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("FreezeUsage"), SK_AdminCommands.Instance.MessageColor);
                        break;


                }
            }
        }




    }
}



