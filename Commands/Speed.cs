﻿using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace SK_AdminCommands.Commands

{


    public class Speed : IRocketCommand
    {


        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "speed";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "sk.speed" };

        public void Execute(IRocketPlayer caller, string[] args)
        {
            {
                var player = (UnturnedPlayer)caller;
                switch (args.Length)
                {
                    case 1:

                        {
                            var papa1 = float.Parse(args[0]);
                            player.Player.movement.sendPluginSpeedMultiplier(papa1);
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("SpeedMessage", papa1), SK_AdminCommands.Instance.MessageColor);

                        }

                        break;

                    case 2:
                       
                       
                        var user = UnturnedPlayer.FromName(args[0]);
                        if (user != null)

                        {
                            var papa2 = float.Parse(args[1]);
                            user.Player.movement.sendPluginSpeedMultiplier(papa2);
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("PlayerSpeed", user.DisplayName, papa2), SK_AdminCommands.Instance.MessageColor);
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("SpeedMessage", papa2), SK_AdminCommands.Instance.MessageColor);


                        }

                        else
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("InvalidPlayer"), SK_AdminCommands.Instance.MessageColor);

                        break;


                }
            }
        }




    }
}