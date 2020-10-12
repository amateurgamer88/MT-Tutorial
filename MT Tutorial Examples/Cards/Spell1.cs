using System;
using System.Collections.Generic;
using System.Text;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI;
using static MonsterTrainModdingAPI.Constants.VanillaCardPoolIDs;
using MonsterTrainModdingAPI.Constants;

namespace MT_Tutorial_Examples.Cards
{
    class Spell1
    {

        //unique ID (GUID can make this unique from other same name cards)
        public static string ID = TestPlugin.GUID + "Spell 1";

        public static void Make()
        {
            // Basic Card Stats 
            CardDataBuilder railyard = new CardDataBuilder
            {
                //Name of the card
                Name = "Tutorial Spell",
                //Description of what this card does (effect0.power references a value so you don't have to description all the time)
                Description = "Deal [effect0.power] damage",
                //Ember cost of this card
                Cost = 1,
                //rarity of this card (Starter, Common, Uncommon and Rare)
                Rarity = CollectableRarity.Common,
                //Pick the clan for this card (clanless for this card)
                ClanID = VanillaClanIDs.Awoken,
                //path to the picture for this card
                AssetPath = "assets/amateur.png",
                //card pool this card belongs to
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                //what does this card do?
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        //card does damage here (you can add statuses like rage and sap too)
                        EffectStateType = VanillaCardEffectTypes.CardEffectDamage,
                        //how much dmg?
                        ParamInt = 5,
                        //what is targeted by the card? the entire room in this case
                        TargetMode = TargetMode.Room,
                        //does it affect your units, enemy units or both?
                        TargetTeamType = Team.Type.Monsters,
                    },

                },
            };

            //Do this to complete the card building
            railyard.BuildAndRegister();

        }



    }
}
