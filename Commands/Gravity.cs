using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace SK_AdminCommands.Commands

{


    public class Gravity : IRocketCommand
    {


        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "gravity";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "sk.gravity" };

        public void Execute(IRocketPlayer caller, string[] args)
        {
            {
                var player = (UnturnedPlayer)caller;
                switch (args.Length)
                {
                    case 1:

                        {
                            var papa1 = float.Parse(args[0]);
                            player.Player.movement.sendPluginGravityMultiplier(papa1);
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("AdminGravity", papa1), SK_AdminCommands.Instance.MessageColor);

                        }

                        break;

                    case 2:


                        var user = UnturnedPlayer.FromName(args[0]);
                        if (user != null)

                        {
                            var papa2 = float.Parse(args[1]);
                            user.Player.movement.sendPluginGravityMultiplier(papa2);
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("PlayerGravity", user.DisplayName, papa2), SK_AdminCommands.Instance.MessageColor);
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("PlayerGravityMessage", papa2), SK_AdminCommands.Instance.MessageColor);


                        }

                        else
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("InvalidPlayer"), SK_AdminCommands.Instance.MessageColor);

                        break;


                }
            }
        }




    }
}