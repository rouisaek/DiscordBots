namespace DiscordBot1.Models
{
    public static class CommandsHelpers
    {

        public static void LinkBeautify(Card obj, ref string race, ref string att)
        {
            switch (race)
            {
                case "Aqua":
                    race += " 💦";
                    break;
                case "Beast":
                    race += " 🐨";
                    break;
                case "Beast-Warrior":
                    race += " 🐼";
                    break;
                case "Dinosaur":
                    race += " 🐱‍🐉";
                    break;
                case "Dragon":
                    race += " 🐲";
                    break;
                case "Fish":
                    race += " 🐟";
                    break;
                case "Insect":
                    race += " 🐛";
                    break;
                case "Machine":
                    race += " 🤖";
                    break;
                case "Plant":
                    race += " 🌱";
                    break;
                case "Psychic":
                    race += " ☣";
                    break;
                case "Reptile":
                    race += " 🐊";
                    break;
                case "Rock":
                    race += " 🗿";
                    break;
                case "Spellcaster":
                    race += " 🧙‍♂️";
                    break;
                case "Thunder":
                    race += " ⚡";
                    break;
                case "Warrior":
                    race += " 🗡";
                    break;
                case "Winged Beast":
                    race += " 🦅";
                    break;
                case "Zombie":
                    race += " 💀";
                    break;
            }

            switch (att)
            {
                case "FIRE":
                    att += " 🔥";
                    break;
                case "WATER":
                    att += " 💧";
                    break;
                case "WIND":
                    att += " 🌪";
                    break;
                case "LIGHT":
                    att += " ⚡";
                    break;
                case "DARK":
                    att += " 🟣";
                    break;
                case "EARTH":
                    att += " 🗻";
                    break;
                case "DIVINE":
                    att += " ☀";
                    break;
                default:
                    break;
            }
        }

        public static void MonsterBeautify(Card obj, ref string level, ref string race, ref string att)
        {
            switch (race)
            {
                case "Aqua":
                    race += " 💦";
                    break;
                case "Beast":
                    race += " 🐨";
                    break;
                case "Beast-Warrior":
                    race += " 🐼";
                    break;
                case "Dinosaur":
                    race += " 🐱‍🐉";
                    break;
                case "Dragon":
                    race += " 🐲";
                    break;
                case "Fish":
                    race += " 🐟";
                    break;
                case "Insect":
                    race += " 🐛";
                    break;
                case "Machine":
                    race += " 🤖";
                    break;
                case "Plant":
                    race += " 🌱";
                    break;
                case "Psychic":
                    race += " ☣";
                    break;
                case "Reptile":
                    race += " 🐊";
                    break;
                case "Rock":
                    race += " 🗿";
                    break;
                case "Spellcaster":
                    race += " 🧙‍♂️";
                    break;
                case "Thunder":
                    race += " ⚡";
                    break;
                case "Warrior":
                    race += " 🗡";
                    break;
                case "Winged Beast":
                    race += " 🦅";
                    break;
                case "Zombie":
                    race += " 💀";
                    break;
            }

            switch (att)
            {
                case "FIRE":
                    att += " 🔥";
                    break;
                case "WATER":
                    att += " 💧";
                    break;
                case "WIND":
                    att += " 🌪";
                    break;
                case "LIGHT":
                    att += " ⚡";
                    break;
                case "DARK":
                    att += " 🟣";
                    break;
                case "EARTH":
                    att += " 🗻";
                    break;
                case "DIVINE":
                    att += " ☀";
                    break;
                default:
                    break;
            }

            for (int i = 0; i < obj.level; i++)
            {
                level += "⭐";
            }
        }

    }
}