using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace SK_AdminCommands.Commands

{


    public class Heal : IRocketCommand
    {


        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "heal";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "sk.heal" };

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
                            user.Heal(100);
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("PlayerHealed", user.DisplayName, player.DisplayName), SK_AdminCommands.Instance.MessageColor);
                        }

                        else
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("InvalidPlayer"), SK_AdminCommands.Instance.MessageColor);
                        break;

                    default:
                        
                        player.Heal(100);
                        UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("Healed"), SK_AdminCommands.Instance.MessageColor);
                        break;


                }

            }

            }


            }
}










