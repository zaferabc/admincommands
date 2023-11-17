﻿using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace SK_AdminCommands.Commands

{


    public class Vanish : IRocketCommand
    {


        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "vanish";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "sk.vanish" };

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
                            user.VanishMode = !user.VanishMode;

                            if (user.VanishMode == true)
                            {
                                UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("GotVanished", user.DisplayName, player.DisplayName), SK_AdminCommands.Instance.MessageColor);
                            }

                            if (user.VanishMode == false)
                            {
                                UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("NoMoreVanished", user.DisplayName), SK_AdminCommands.Instance.MessageColor);

                            }

                        }
                        else
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("InvalidPlayer"), SK_AdminCommands.Instance.MessageColor);
                        break;

                    default:
                        player.VanishMode = !player.VanishMode;
                        if (player.VanishMode == false)
                        {
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("NotVanish"), SK_AdminCommands.Instance.MessageColor);
                        }

                        if (player.VanishMode == true)
                        {
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("Vanish"), SK_AdminCommands.Instance.MessageColor);
                        }







                        break;




                }

            }

        }


    }
}