using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace SK_AdminCommands.Commands

{


    public class God : IRocketCommand
    {

        
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "god";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "sk.god" };

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
                               user.GodMode = !user.GodMode;
                            
                            if (user.GodMode == true)
                            {
                                UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("GotGod", user.DisplayName, player.DisplayName), SK_AdminCommands.Instance.MessageColor);
                                if (user.Broken == true)
                                {
                                    user.Broken = !user.Broken;
                                }
                            }
                            if (user.GodMode == false)
                            {
                                UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("PlayerLostGod", user.DisplayName), SK_AdminCommands.Instance.MessageColor);

                            }

                        }
                        else
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("InvalidPlayer"), SK_AdminCommands.Instance.MessageColor);
                        break;

                    default:
                        player.GodMode = !player.GodMode;
                        if (player.GodMode == false)
                        {
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("AdminLostGod"), SK_AdminCommands.Instance.MessageColor);
                        }

                        if (player.GodMode == true)
                        {
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("AdminGotGod"), SK_AdminCommands.Instance.MessageColor);

                        }




                        break;

                     


                }

            }

        }


    }
}









