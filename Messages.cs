using System;
using System.Collections.Generic;

public class Messages
{
    public string CurrentLanguage { get; set; } = "English";
    private Dictionary<string, Dictionary<int, string>> AllLanguages = new();

    public void ReadDictionary(string language)
    {
        CurrentLanguage = language;

        AllLanguages["English"] = new Dictionary<int, string>
        {
            // Character Creation
            [101] = "\nWhat is the occupation of your character? 1. Fighter, 2. Magician, 3. Thief, or 4. Archer?",
            [102] = "Invalid input. Please enter a number: 1. Fighter, 2. Magician, 3. Thief, or 4. Archer.",
            [103] = "You have chosen {0} and your weapon is {1}.",
            [104] = "Weapon ASCII Art: {0}",
            [105] = "\nWhat is the race of your character? 1. Elf, 2. Human, 3. Dwarf, or 4. Halfling?",
            [106] = "Invalid input. Please enter a number: 1. Elf, 2. Human, 3. Dwarf, or 4. Halfling.",
            [107] = "You have chosen {0} as your race.",
            [108] = "\nNext, we are going to roll for strength. Type ‘roll’",
            [109] = "Invalid input. Please type 'roll' to roll for strength.",
            [110] = "\nNext, we will roll for agility. Type ‘roll’",
            [111] = "Invalid input. Please type 'roll' to roll for agility.",
            [112] = "\nNext, we will roll for health points. Type ‘roll’",
            [113] = "Invalid input. Please type 'roll' to roll for health points.",
            [114] = "\nYour character stats are: Strength: {0}, Agility: {1}, Health: {2}",
            [115] = "Name: ",
            [116] = "Race: ",
            [117] = "Occupation: ",
            [118] = "Strength: ",
            [119] = "Agility: ",
            [120] = "Health: ",
            [121] = "Weapon: ",
            [122] = "Weapon ASCII Art: ",
            [123] = "\n--- Final Stats ---\n",
            
            // Game Menu
            [201] = "Welcome to Choose Your Adventure Game",
            [202] = "Choose: 1. Create Character or 2. Exit. Type '1' or '2'",
            [203] = "Invalid input. Please enter '1' or '2'.",
            [204] = "\nExiting game...",
            [205] = "Character creation starting...\n",
            [206] = "What is your name?",
            [209] = "\nCharacter successfully created!",

            // Combat
            [301] = "Missed me, breath of a gnat!\n",
            [302] = "Is that all you've got? I've seen kittens with more fire in their paws!\n",
            [303] = "Try harder, human! You're making me yawn!\n",
            [304] = "Maybe if you squinted harder, you'd actually hit something!\n",
            [305] = "Ow! That actually stung a bit!\n",
            [306] = "Impressive! You might actually be worth toasting...\n",
            [307] = "That... was unexpected. But I assure you, it won't happen again.\n",
            [308] = "Well, I'll be! You have more bite than I thought!\n",

            [310] = "\nYou prepare yourself to attack the dragon with your weapon. As a {0}, you withdraw your {1}. You attack.",
            [311] = "\nYou missed {0}.\n",
            [312] = "{0} successfully defended your attack.",
            [313] = "The dragon failed to defend your attack.\nYour weapon delivers {0} damage points. The dragon’s health points is now {1}.",
            [314] = "\nWith the dragon vanquished, you collect the horde of gold, return home, rich and famous. The End.",
            [315] = "{0} hits you.",
            [316] = "You successfully defended the attack.",

           // [317] = "The dragon's attack delivers {0} damage points. Your health points is now {1}.",
           // [318] = "You hastily retreat licking your wounds...",

            [317] = "The dragon's attack delivers {0} damage points. Your health points is now {1}.\n",
            [318] = "\nYou quickly retreat. You come home poor but alive to adventure another day. The End.",
            [319] = "Options: “r” for retreat and “a” for attack",
            [320] = "The dragon laughs as your eyesight fades. You are defeated. Your family mourns their loss. The End.",
            [321] = "{0} attacks you!",
            [322] = "The dragon missed you.\n",
            [323] = "\nYou hit {0}.",

            // Branches

            [401] = "\nYou are walking in the mountains...Enter 'n' for North. Enter 's' for South. Enter 'e' for exit game",
            [402] = "\nYou take the North path...The dragon has a hoard of gold behind it.",
            [403] = "\nYou take the South path...still bored.",


            [404] = "Your magic ring gives you the stats on the dragon.",
            [405] = "\nThe dragon says 'I am {0}. Leave or perish!",
            [406] = "\n--- {0}'s Stats ---\nStrength: {1}\nHealth: {2}\nAgility: {3}\nWeapon: {4} (Max Damage: {5})\n",
            [407] = "Invalid input. Please enter 'n', 's', or 'e'.",
            [408] = "Invalid input. Please enter 'r' or 'a'."
        };

        AllLanguages["French"] = new Dictionary<int, string>
        {
            [101] = "\nQuelle est la profession de votre personnage ? 1. Guerrier, 2. Magicien, 3. Voleur ou4. Archer",
            [102] = "Entrée invalide. Veuillez saisir un chiffre : 1. Guerrier, 2. Magicien, 3. Voleur, 4. Archer.",
            [103] = "Vous avez choisi {0} et votre arme est {1}.",
            [104] = "Art ASCII de l'arme : {0}",
            [105] = "\nQuelle est la race de votre personnage ? 1. Elfe, 2. Humain, 3. Nain ou 4. Halfelin ?",
            [106] = "Entrée invalide. Veuillez entrer un numéro : 1. Elfe, 2. Humain, 3. Nain ou 4. Halfelin.",
            [107] = "Vous avez choisi {0} comme race.",
            [108] = "\nJetons maintenant pour la force. Tapez 'roll'",
            [109] = "Entrée invalide. Tapez 'roll' pour lancer le dé de force.",
            [110] = "\nJetons maintenant pour l'agilité. Tapez 'roll'",
            [111] = "Entrée invalide. Tapez 'roll' pour lancer le dé d'agilité.",
            [112] = "\nJetons maintenant pour les points de santé. Tapez 'roll'",
            [113] = "Entrée invalide. Tapez 'roll' pour lancer le dé de santé.",
            [114] = "\nStatistiques : Force : {0}, Agilité : {1}, Santé : {2}",
            [115] = "Nom: ",
            [116] = "Course: ",
            [117] = "Profession: ",
            [118] = "Force:",
            [119] = "Agilité: ",
            [120] = "Santé: ",
            [121] = "Arme: ",
            [122] = "Art ASCII de l'arme : ",
            [123] = "\n--- Statistiques Finales ---\n",
            
            [201] = "Bienvenue dans le jeu Choisissez Votre Aventure",
            [202] = "Choisissez : 1. Créer un personnage ou 2. Quitter. Tapez '1' ou '2'",
            [203] = "Entrée invalide. Veuillez taper '1' ou '2'.",
            [204] = "Sortie du jeu...",
            [205] = "Création du personnage en cours...\n",
            [206] = "Quel est votre nom ?",
            [209] = "\nPersonnage créé avec succès !",

            [301] = "Tu m'as raté, souffle de moustique !\n",
            [302] = "C'est tout ? J'ai vu des chatons plus féroces !\n",
            [303] = "Essaie plus fort, humain ! Tu me fais bailler !\n",
            [304] = "Peut-être qu'en louchant, tu atteindrais quelque chose !\n",
            [305] = "Aïe ! Ça a piqué un peu !\n",
            [306] = "Impressionnant ! Tu vaux peut-être la peine d'être rôti...\n",
            [307] = "C'était... inattendu. Mais ça n'arrivera plus.\n",
            [308] = "Eh bien ! Tu es plus coriace que prévu !\n",

            [310] = "\nVous vous préparez à attaquer le dragon avec votre arme. En tant que {0}, vous brandissez votre {1}. Vous attaquez.",
            [311] = "\nVous avez manqué {0}.\n",
            [312] = "{0} a défendu avec succès votre attaque.",
            [313] = "Le dragon n’a pas pu se défendre.\nVotre arme inflige {0} points de dégâts. Les points de vie du dragon sont maintenant {1}.",
            [314] = "\nUne fois le dragon vaincu, vous récupérez la horde d'or et rentrez chez vous, riche et célèbre. Fin.",
            [315] = "{0} vous frappe.",
            [316] = "Vous avez défendu avec succès l'attaque.",
           // [317] = "L'attaque du dragon inflige {0} points de dégâts. Vos points de vie sont maintenant {1}.",
           // [318] = "Vous battez en retraite en léchant vos blessures...",
            [317] = "L'attaque du dragon inflige {0} points de dégâts. Vos points de vie sont maintenant {1}.\n",
            [318] = "\nVous vous retirez rapidement. Vous rentrez chez vous, pauvre, mais vivant, prêt à vivre une nouvelle aventure. Fin.",
            [319] = "Options : « r » pour retraite et « a » pour attaque",
            [320] = "Le dragon rit tandis que votre vue baisse. Vous êtes vaincu. Votre famille pleure sa perte. Fin.",
            [321] = "{0} vous attaque !",
            [322] = "Le dragon t'a manqué.\n",
            [323] = "\nTu as frappé {0}.",
            
            // Branches
            [401] = "\nVous marchez en montagne… Tapez « n » pour Nord. Tapez « s » pour Sud. Tapez « e » pour quitter le jeu.",
            [402] = "\nVous prenez le chemin du Nord... Le dragon a un trésor d'or derrière lui.",
            [403] = "\nVous prenez le chemin du Sud...toujours ennuyé.",

            [404] = "Votre anneau magique vous donne les statistiques du dragon.",
            [405] = "\nLe dragon dit : « Je suis {0}. Pars ou péris !", 
            [406] = "\n--- Statistiques de {0} ---\nForce : {1}\nSanté : {2}\nAgilité : {3}\nArme : {4} (Dégâts max : {5})\n",
            [407] = "Entrée non valide. Veuillez saisir « n », « s » ou « e ».",
            [408] = "Entrée non valide. Veuillez saisir « r » ou « a »."        
        };

        AllLanguages["Spanish"] = new Dictionary<int, string>
        {
            [101] = "\n¿Cuál es la ocupación de tu personaje? 1. Luchador, 2. Mago, 3. Ladrón 4. Arquero",
            [102] = "Entrada no válida. Introduzca un número: 1. Luchador, 2. Mago, 3. Ladrón, 4. Arquero.",
            [103] = "Has elegido {0} y tu arma es {1}.",
            [104] = "Arte ASCII del arma: {0}",
            [105] = "\n¿Cuál es la raza de tu personaje? 1. Elfo, 2. Humano, 3. Enano 4. Halfling?",
            [106] = "Entrada no válida. Introduzca: Elfo, Humano, Enano o Halfling.",
            [107] = "Has elegido {0} como raza.",
            [108] = "\nA continuación, tiraremos por fuerza. Escribe 'roll'",
            [109] = "Entrada no válida. Escribe 'roll' para tirar fuerza.",
            [110] = "\nAhora tiraremos por agilidad. Escribe 'roll'",
            [111] = "Entrada no válida. Escribe 'roll' para tirar agilidad.",
            [112] = "\nAhora tiraremos por puntos de salud. Escribe 'roll'",
            [113] = "Entrada no válida. Escribe 'roll' para tirar salud.",
            [114] = "\nTus estadísticas: Fuerza: {0}, Agilidad: {1}, Salud: {2}",
            [115] = "Nombre: ",
            [116] = "Carrera: ",
            [117] = "Ocupación: ",
            [118] = "Fortaleza: ",
            [119] = "Agilidad: ",
            [120] = "Salud: ",
            [121] = "Arma: ",
            [122] = "Arte ASCII del arma: ",
            [123] = "\n--- Estadísticas Finales ---\n",

            [201] = "Bienvenido al juego Elige Tu Aventura",
            [202] = "Elige: 1. Crear personaje o 2. Salir. Escribe '1' o '2'",
            [203] = "Entrada no válida. Escribe '1' o '2'.",
            [204] = "Saliendo del juego...",
            [205] = "Iniciando la creación del personaje...\n",
            [206] = "¿Cómo te llamas?",
            [209] = "\n¡Personaje creado exitosamente!",

            [301] = "¡Me fallaste, aliento de mosquito!\n",
            [302] = "¿Eso es todo? ¡He visto gatitos más feroces!\n",
            [303] = "¡Intenta más fuerte, humano! ¡Me estás dando sueño!\n",
            [304] = "¡Tal vez si entrecerraras los ojos, podrías acertar!\n",
            [305] = "¡Ay! ¡Eso dolió un poco!\n",
            [306] = "¡Impresionante! Quizás valga la pena quemarte...\n",
            [307] = "Eso fue... inesperado. Pero no volverá a pasar.\n",
            [308] = "¡Vaya! ¡Tienes más fuerza de la que pensaba!\n",

            [310] = "\nTe preparas para atacar al dragón con tu arma. Como {0}, sacas tu {1}. Atacas.",
            [311] = "\nFallaste a {0}.\n",
            [312] = "{0} defendió con éxito tu ataque.",
            [313] = "El dragón no pudo defenderse.\nTu arma inflige {0} puntos de daño. Los puntos de salud del dragón ahora son {1}.",
            [314] = "\nTras vencer al dragón, recoges la horda de oro y regresas a casa, rico y famoso. Fin.",
            [315] = "{0} te golpea.",
            [316] = "Has defendido con éxito el ataque.",

           // [317] = "El ataque del dragón inflige {0} puntos de daño. Tus puntos de salud ahora son {1}.",
           // [318] = "Te retiras rápidamente lamiendo tus heridas...",

            [317] = "El ataque del dragón inflige {0} puntos de daño. Tus puntos de salud ahora son {1}.\n",
            [318] = "\nTe retiras rápidamente. Regresas a casa pobre, pero con vida para la aventura de otro día. Fin.",
            [319] = "Opciones: “r” para retirada y “a” para ataque",
            [320] = "El dragón ríe mientras pierdes la vista. Estás derrotado. Tu familia llora su pérdida. Fin.",
            [321] = "{0} te ataca!",
            [322] = "El dragón te extrañó.\n",
            [323] = "\nGolpeaste a {0}.",

            // Branches
            [401] = "\nEstás caminando por las montañas... Introduce 'n' para el norte. Introduce 's' para el sur. Introduce 'e' para salir del juego.",
            [402] = "\nToma el camino del Norte... El dragón tiene un tesoro de oro detrás de él.",
            [403] = "\nToma el camino sur ... todavía aburrido.",

            [404] = "Tu anillo mágico te da las estadísticas del dragón.",
            [405] = "\nEl dragón dice: 'Soy {0}. ¡Vete o muere!'",
            [406] = "\n--- Estadísticas de {0} ---\nFuerza: {1}\nSalud: {2}\nAgilidad: {3}\nArma: {4} (Daño máx: {5})\n",
            [407] = "Entrada no válida. Por favor, introduzca 'n', 's' o 'e'.",
            [408] = "Entrada no válida. Por favor, introduzca 'r' o 'a'."
        };
    }

    public string GetMessage(int key)
    {
        if (AllLanguages.ContainsKey(CurrentLanguage) && AllLanguages[CurrentLanguage].ContainsKey(key))
        {
            return AllLanguages[CurrentLanguage][key];
        }

        // fallback to English
        if (AllLanguages.ContainsKey("English") && AllLanguages["English"].ContainsKey(key))
        {
            return AllLanguages["English"][key];
        }

        return $"[Missing message for key {key}]";
    }

    // This method is used to get the localized occupation map based on the current language.
    // It returns a dictionary where the key is the localized name of the occupation and the value is the enum value.
    public Dictionary<string, Occupation> GetLocalizedOccupationMap()
    {
        return CurrentLanguage switch
        {
            "French" => new Dictionary<string, Occupation>(StringComparer.OrdinalIgnoreCase)
            {
                ["Guerrier"] = Occupation.Fighter,
                ["Magicien"] = Occupation.Magician,
                ["Voleur"] = Occupation.Thief,
                ["Archer"] = Occupation.Archer
            },
            "Spanish" => new Dictionary<string, Occupation>(StringComparer.OrdinalIgnoreCase)
            {
                ["Luchador"] = Occupation.Fighter,
                ["Mago"] = Occupation.Magician,
                ["Ladrón"] = Occupation.Thief,
                ["Arquero"] = Occupation.Archer
            },
            _ => new Dictionary<string, Occupation>(StringComparer.OrdinalIgnoreCase)
            {
                ["Fighter"] = Occupation.Fighter,
                ["Magician"] = Occupation.Magician,
                ["Thief"] = Occupation.Thief,
                ["Archer"] = Occupation.Archer
            }
        };
    }
    
    // This method is used to get the localized race map based on the current language.
    // It returns a dictionary where the key is the localized name of the race and the value is the enum value.
    public Dictionary<string, Race> GetLocalizedRaceMap()
    {
        return CurrentLanguage switch
        {
            "French" => new Dictionary<string, Race>(StringComparer.OrdinalIgnoreCase)
            {
                ["Elfe"] = Race.Elf,
                ["Humain"] = Race.Human,
                ["Nain"] = Race.Dwarf,
                ["Halfelin"] = Race.Halfling
            },
            "Spanish" => new Dictionary<string, Race>(StringComparer.OrdinalIgnoreCase)
            {
                ["Elfo"] = Race.Elf,
                ["Humano"] = Race.Human,
                ["Enano"] = Race.Dwarf,
                ["Halfling"] = Race.Halfling
            },
            _ => new Dictionary<string, Race>(StringComparer.OrdinalIgnoreCase)
            {
                ["Elf"] = Race.Elf,
                ["Human"] = Race.Human,
                ["Dwarf"] = Race.Dwarf,
                ["Halfling"] = Race.Halfling
            }
        };
    }
       public string GetLocalizedOccupationLabel(Occupation occ)
    {
        return CurrentLanguage switch
        {
            "French" => occ switch
            {
                Occupation.Fighter => "Guerrier",
                Occupation.Magician => "Magicien",
                Occupation.Thief => "Voleur",
                Occupation.Archer => "Archer",
                _ => occ.ToString()
            },
            "Spanish" => occ switch
            {
                Occupation.Fighter => "Luchador",
                Occupation.Magician => "Mago",
                Occupation.Thief => "Ladrón",
                Occupation.Archer => "Arquero",
                _ => occ.ToString()
            },
            _ => occ.ToString()
        };
    }

    public string GetLocalizedRaceLabel(Race r)
    {
        return CurrentLanguage switch
        {
            "French" => r switch
            {
                Race.Elf => "Elfe",
                Race.Human => "Humain",
                Race.Dwarf => "Nain",
                Race.Halfling => "Halfelin",
                _ => r.ToString()
            },
            "Spanish" => r switch
            {
                Race.Elf => "Elfo",
                Race.Human => "Humano",
                Race.Dwarf => "Enano",
                Race.Halfling => "Halfling",
                _ => r.ToString()
            },
            _ => r.ToString()
        };
    }
}
