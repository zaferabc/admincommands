using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace SK_AdminCommands.Commands

{


    public class Command : IRocketCommand
    {


        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "bleed";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "sk.bleed" };

        public void Execute(IRocketPlayer caller, string[] args)
        {
            {
                var player = (UnturnedPlayer)caller;
                switch (args.Length)
                {
                    case 1:
                        var user = UnturnedPlayer.FromName(args[0]);
                        var name = user.DisplayName;
                        if (user != null)
                        {
                            user.Bleeding = !user.Bleeding;

                            if (user.Bleeding == true)
                            {
                                UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("UserBleeding", name), SK_AdminCommands.Instance.MessageColor);
                            }

                            if (user.Bleeding == false)
                            {
                                UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("UserNotBleeding", name), SK_AdminCommands.Instance.MessageColor);
                            }


                        }
                        else
                        UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("InvalidPlayer"), SK_AdminCommands.Instance.MessageColor);
                        
                        break;
                    default:
                        UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("BleedUsage"), SK_AdminCommands.Instance.MessageColor);
                        break;

                }

            }

        }


    }
}

