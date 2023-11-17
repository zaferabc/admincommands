using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace SK_AdminCommands.Commands

{


    public class Broke : IRocketCommand
    {


        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "broke";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "sk.broke" };

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
                            user.Broken = !user.Broken;

                            if (user.Broken == true)
                            {
                                UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("UserBroken", user.DisplayName), SK_AdminCommands.Instance.MessageColor);
                            }

                            if (user.Broken == false)
                            {
                                UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("FixedBones", user.DisplayName), SK_AdminCommands.Instance.MessageColor);
                            }



                        }
                        else
                            UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("InvalidPlayer"), SK_AdminCommands.Instance.MessageColor);

                        break;
                    default:
                        UnturnedChat.Say(caller, SK_AdminCommands.Instance.Translate("BrokeUsage"), SK_AdminCommands.Instance.MessageColor);
                        break;

                }

            }

        }


    }
}
