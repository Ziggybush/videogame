using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using videogame.Classes;
using videogame.Races;

namespace videogame
{
    public class CharacterCreation
    {
        public static async Task CreateCharacter()
        {

            await TextEffects.TypeWriteAsync("\"(Army Captain) Next prisoner... STEP FORWARD!!!\"\n");

            await TextEffects.TypeWriteAsync("\x1b[31mCreate your character\x1b[0m\n");

            foreach (var race in Character.AvailableRaces)
            {
                await TextEffects.TypeWriteAsync($"{race}");
            }
            string raceChoice = await TextEffects.Ask("\n\x1b[31mChoose a race\x1b[0m");

            await TextEffects.TypeWriteAsync($"\n\"(Army Captain) So, what is a {raceChoice} like you doing out here?\"\n");

            foreach (var className in ClassRegistry.AvailableClasses)
            {
                await TextEffects.TypeWriteAsync($"{className}");
            }
            string classChoice = await TextEffects.Ask("\n\x1b[31mChoose a class\x1b[0m");

            string usernameChoice = string.Empty;

            if (classChoice.Equals("Warrior"))
            {
                usernameChoice = await TextEffects.Ask($"\n\"(Army Captain) You were attacking our army soldiers? At least you've got balls where you lack ability. State your name Warrior.\"");
            }
            else if (classChoice.Equals("Mage"))
            {
                usernameChoice = await TextEffects.Ask($"\n\"(Army Captain) What were you thinking going around shooting off magic like that? Honestly... you didn't cause much trouble. With magic like that I could replace you with a lantern. Well, regardless of your incompetence, you broke the law. State your name Mage.\"");
            }
            else if (classChoice.Equals("Thief"))
            {
                usernameChoice = await TextEffects.Ask($"\n\"(Army Captain) So you were caught loitering around our army camp? Pitiful. State your name Thief.\"");
            }

            await TextEffects.TypeWriteAsync($"\n\"(Army Captain) {usernameChoice}... is it?\"\n");

            Character player = raceChoice switch
            {
                "Human" => new Human(usernameChoice, classChoice),
                "Dark Elf" => new Dark_Elf(usernameChoice, classChoice),
                "High Elf" => new High_Elf(usernameChoice, classChoice),
                "Barbarian" => new Barbarian(usernameChoice, classChoice),
                _ => throw new ArgumentException("Invalid race selected")
            };

            PlayerStats stats = new PlayerStats();
            await stats.showPlayerStats(player);
        }
    }
}
