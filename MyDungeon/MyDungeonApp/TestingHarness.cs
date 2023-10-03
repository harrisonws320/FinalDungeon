using MyDungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDungeonApp
{
    internal class TestingHarness
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("\n                       ENTER                            \n");
                Console.WriteLine("\n                                                        \n");
                Console.WriteLine("\n                   THE                                  \n");
                Console.WriteLine("\n                                                        \n");
                Console.WriteLine("\n                                                        \n");
                Console.WriteLine("\n                                                        \n");
                Console.WriteLine("\n                                                        \n");
                Console.WriteLine("\n                                                        \n");
                Console.WriteLine("\n                                           VOID         \n");
                Console.ReadLine();
                Console.Clear();

                Weapon w1 = new Weapon("\"Dread\": A bastard sword capable of renting shadows", 1, 10, 1, false, WeaponType.Bastard_Sword);
                Weapon w2 = new Weapon("\"Inoculator\": A rapier used to riddle the shadows with punctures", 1, 15, 1, false, WeaponType.Rapier);
                Weapon w3 = new Weapon("\"Dragon Slayer\": A 300-pound sharpened \"slab of steel\" that cleaves shadows", 3, 20, 2, true, WeaponType.Gattsu_Giant_Sword);
                Weapon w4 = new Weapon("\"Vicious\": A katana whose slashes hemorrhage shadows", 1, 15, 2, true, WeaponType.Katana);
                Weapon w5 = new Weapon("\"Abattoir\": A machete excellent for hacking up shadows", 2, 7, 1, false, WeaponType.Machete);
                Weapon w6 = new Weapon("Nihilism", 3, 15, 3, true, WeaponType.Nodachi);
                Weapon w7 = new Weapon("Soul Harvester", 1, 10, 5, false, WeaponType.Sickle);
                Weapon w8 = new Weapon("Apocalypse", 3, 15, 3, true, WeaponType.Warscythe);
                Weapon w9 = new Weapon("Red Scepter", 1, 10, 5, false, WeaponType.Morningstar);
                Weapon w10 = new Weapon("Death's Scythe", 3, 15, 3, true, WeaponType.Scythe);

                Monster m = new();
                //setup necessary resources
                Monster m1 = new("Stavrogin", "Demon of Despair", 50, 20, 70, 3, "Nihilism", w6);
                Monster m2 = new("Pope Bacon X", "Demon of Pestilence", 50, 20, 70, 2, "Soul Harvester", w7);
                Monster m3 = new("Zarathustra", "Demon of Tyranny", 50, 20, 70, 5, "Apocalypse", w9);
                Monster m4 = new("Pynchon", "Demon of Suffering", 50, 20, 70, 2, "Red Scepter", w9);
                Monster m5 = new("Milton", "Demon of Hopelessness", 50, 20, 70, 8, "Death's Scythe", w10);

                List<Player> players = new List<Player>
            {
                new Player("Soren de Silentio", "\"Dread\"", 70, 3, 60, Race.Aasimar, "Planetouched humanoids with celestial heritage and power", w1, 0),
                new Player("Vivian Darkbloom", "\"Inoculator\"", 80, 5, 35, Race.Celadrin, "Celestial elves with frail constitutions and remarkable speed", w2, 0),
                new Player("The Black Swordsman", "\"Dragon Slayer\"", 40, 7, 70, Race.Gattsu, "Humanoids descended from Goliaths and shades", w3, 0),
                new Player("Prince Harrow", "\"Vicious\"", 50, 5, 50, Race.Feyri, "Hybrid super creatures genetically engineered from inbreeding sun elves and depraved fiends", w4, 0),
                new Player("Cormac", "\"Abattoir\"", 75, 2, 60, Race.Tiefling, "Humanoid devils with enormous ram's horns and reptilian tales", w5, 0)
            };

                Console.WriteLine("\n***THE DEMON HUNTERS***\n");


                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {players[i].Name}");
                }

                int selectedPlayerIndex;

                while (true)
                {
                    Console.Write("\nInput the number of your chosen hunter to transmigrate into him:\n");
                    if (int.TryParse(Console.ReadLine(), out selectedPlayerIndex) && selectedPlayerIndex >= 1 && selectedPlayerIndex <= players.Count)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid player number.");

                    }
                }
                Console.Clear();
                Player selectedPlayer = players[selectedPlayerIndex - 1];
                Console.WriteLine("You have become " + selectedPlayer + "");
                Console.ReadLine();
                Console.Clear();

                //Console.WriteLine($"You have chosen {selectedPlayer} to enter the void.");
                // Console.ReadLine();
                // Console.Clear();

                Console.WriteLine("Your descent into the void begins. " +
                    "\nYou turn around and see no discernible exit,\n" +
                    "just darkness.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\nUnfortunately, there is no return.\n" +
                   "\nEven the demons can no longer navigate through the abyss.\n" +
               "\nThere was a demon who once grew weary of the void.\n" +
               "Through his imagination, he created the illusion of a magnificent kingdom.\n" +
               "Then he mistook the illusion for reality, so his eyes no longer saw reality.\n" +
               "\nWithin eternity, wandering in his imaginary kingdom, he forgot who he was.\n" +
               "Then believed he was God, and his vibrant fantasy synthesized with abysmal actuality,\n" +
               "so that his fellow demons, imprisoned in the abyss,\n" +
               "found themselves in what appeared to be a physical prison, which were imaginary rooms of his design.\n" +
               "\nThere were moments when he was enjoying his oneiric empire that he heard voices\n" +
               "he no longer recognized begging for the black expanse to which they were initially condemned,\n" +
               "preferring a boundless darkness to the confines of an ornate cell.\n" +
               "\nHowever, sometime within eternity, their desperation turned their minds inward.\n" +
               "They learned to manipulate the appearance--and occupants--of the room,\n" +
               "even though they still couldn't exit their \"rooms\".\n" +
               "They cherished illusory possibility over abysmal actuality,\n" +
               "and longed for a moment when a mortal creature would journey, once again, into hell.\n" +
               "\nIf they could consume the light of spirit--which is eternal--inside certain mortals,\n" +
               "they could enter the mortal as a dark spirit, rupture the synthesis,\n" +
               "and exchange positions with the mortal:\n" +
               "eternal darkness inside a mortal body, would transpose the demon to the world of life;\n" +
               "eternal light, unmoored from the body, would languish in abysmal eternity,\n" +
               "insensate, without a body, though eternally conscious as a spirit\n" +
               "of being crystalized in black nothingness!\n");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine(" looks on your dying body with delight. You grow incredibly weak, and there's a tremendous physical pain, like every cell in your body were experiencing a child birth. And it doesn't stop. And then there's the pain of the spirit The slow consumption of your planetouched spirt, your light is dying, devoid of anything celestial, and desperate and terrified, some pure animal feeling of terror, a wolf limping after his fleeing pack--but it's not just that. You are saying goodbye to your spirit in increments, and on your hands and knees you out as your spirit refuses to look back at you, it floats away away into the demons mouth which becomes a black nothing, you are not enveloped in darkness, you are darkness, you are in material conscious of a living self, whose body was harvested of spirit: your light was extracted like a spider were feasting on you, it was consumed and subsumed by the darkness--that which in the demon qualifies him as eternal--has swallowed up your spirit, that which bound you to the eternal, so you became nothing but a temporal body and the vestiges of a stolen spirit--a rotting body without a spirit, an eternal spirit that has been separated and swallowed--and thus preserved in the darkness of the demon--THE BRIGHTER THE LIGHT THE DARKER THE SHADOW GOES BOTH WAYS--a rotting body, the remains are a consciousness that existed in the physical--the temporal--a an eternal spirit whose substance and been stolen, whose eternal remains are an eternal consciousness whose sense of self is rooted in the temporal. ");

                Console.WriteLine("You hear a voice in a pitch you can't attribute to any creature you've encountered\n" +
                    "in reality or in the world of texts and spoken tales...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Hello, my name is Tofu, the talking dog.");
                Console.ReadLine();
                Console.WriteLine("I am the narrator and spectator of your expedition into the abyss,\n" +
                                        "but don't worry...");
                Console.ReadLine();
                string greeting = @"



            




























            You'll never see me.";
                Console.WriteLine(greeting);
                Console.ReadLine();
                Console.Clear();
                Console.Write("And what is your name? ");
                string name = Console.ReadLine().ToUpper();
                Console.Clear();
                Console.WriteLine("\nYour name is " + name + "?! ");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\nWell, of course it is, heh-heh...\n" +
                 name + " is in my \"guest book\" right here!");
                Console.WriteLine("Welcome, " + name + "!" +
                "\nThough, I'm afraid this won't be very pleasant, heh-heh..." +
                "\nAre you still breathing? Speak to me...");
                string answer = Console.ReadLine().ToUpper();
                Console.Clear();
                Console.WriteLine(answer + " is all you have to say!");
                Console.ReadLine();
                Console.WriteLine("Well, " + name + ", you've certainly impressed me!\n" +
                    "I thought this infernal darkness would've swallowed you up by now...\n" +
                    "\nYou ARE a mere mortal, right?!\n" +
                    "Apparently, not.\n" +
                    "There must be some light in you!\n" +
                    "You see, the brighter the light, the darker the shadow...\n");
                Console.Write("Do you understand?\n");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("For this reason you are desired!\n" +
                    "To enhance the darkness of the Abyss!\n" +
                    "Though I am appalled that " + name + " would be some planetouched vessel of light!\n");
                Console.Write("Are you still listening?!\n");
                Console.ReadLine();
                Console.WriteLine("Because " + name + " sounds more like\n" +
                    "a kind of grotesque insect or an apocalyptic pestilence,\n" +
                    "not a hero whom some poet will immortalize in verse...\n" +
                    "ANSWER ME!\n");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("I see...\n" +
                "Everything will reveal itself in time.\n" +
                "Heh-Heh...unless you go to a \"place\" outside of time...\n");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("So, " + name + ", which demon awaits your company?\n");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\nEnter the abyss and find out...\n");
                Console.ReadLine();
                Console.Clear();


                string[] monsters = {

             "Stavrogin: A slender demon enfolded within his shiny batwings, hanging upside down and motionless\n" +
             "from an enormous chandelier...",

             "Pope Bacon X: An emaciated demon, pale as a fish belly, with clipped wings,\n" +
             "wrapped in his massive beard teeming with vermin.\n" +
             "He is lying in the fetal position and shivering in a puddle of putrid liquid in the corner.",

             "Zarathustra: A colossal demon afflicted with disease, though robust.\n" +
             "He flexes his muscles as he performs aerial acrobatics with\n" +
             "his massive batwings, carrying him in a way that is both terrifying and graceful.",

             "Pynchon: A hideous demon completely enshrouded in fragrant purple smoke.\n" +
             "His unfathomable ugliness is palpable, so that the cloud\n" +
             "only obscures his visibility,\n" +
             "yet the presence of his stiletto fangs jutting from his yawning maw\n" +
             "are still discernible.",

             "Milton: A transparent blind demon fading in and out of darkness...\n",
              };

                Random randomMonsters = new Random();
                int randomIndex = randomMonsters.Next(monsters.Length);//this will select a random number from the array
                string monster = monsters[randomIndex];
                Console.WriteLine(monster);
                string monsterName = monster.Substring(0, monster.IndexOf(':'));//colon refers to the colon after each demon name
                Console.ReadLine();
                Console.Clear();


                Console.WriteLine("You hear Tofu shout to you:\n" +
                    "Quick! Say your demon's name to destroy him!\n");
                string chosenDemon = Console.ReadLine();

                if (chosenDemon == monsterName)
                {
                    Console.WriteLine("You call out " + monsterName + "'s name, and appear in " + monsterName + "'s " + "chamber.\n" +
                        monsterName + " turns his head and stares at you with lugubrious eyes.\n" +
                        "He says: You said my name. I am yours and you are mine.\n");
                }
                else
                {
                    Console.WriteLine("That's not my name! My name is " + monsterName + "!\n" +
                        "Even arch-angels sitting in heaven would say " + monsterName + " if I demanded it!\n" +
                        "Say my name! Say, " + monsterName + "! SAY IT!\n");
                };

                Console.WriteLine("\nTofu shouts: Oh, this should be good!\n");
                Console.WriteLine("\nYou realize Demon " + monsterName + " doesn't hear Tofu speak.\n" +
                    "Only you do.\n");
                Console.WriteLine("You think to yourself: I wonder if we can communicate" +
                    " \"telepathically,\" for lack of a better word.\n");
                Console.WriteLine("\nTofu says: I told you I was narrating you! What did you expect?!\n" +
                    "So, say something to him!!\n");
                string yourAnswer = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(monsterName + " speaks: There was a rumor that a man in red robes\n" +
                    "journeyed through hell and left, unscathed.\n");
                Console.Write("What was his name?");
                string hisName = Console.ReadLine();
                if (hisName == "Dante")
                {
                    Console.WriteLine("Yes, that was his name. You don't seem cowardly like him. He needed a guide.\n" +
                        "But I'm sure you're weak, like any mortal. I see you have a weapon...\n" +
                        "HAHAHA, is that some charm to give you hope.\n" +
                        "What good do you think that will do here...\n");
                }//end if
                else
                {

                    Console.WriteLine("His name was Dante. He was a terrified mortal who kept fainting with terror.\n" +
                        "His mortal weakness and cowardice put us to shame!\n" +
                        "If he hadn't had that guide with him, he would be imprisoned here for eternity, like you will be.\n" +
                        "HAHAHA, you thought that puny blade would protect you from ME?!");
                }

            }
        }
}
