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
            [101] = "What is the occupation of your character? Fighter, Magician, Thief, or Archer?",
            [102] = "Invalid input. Please enter one of the following: Fighter, Magician, Thief, or Archer.",
            [103] = "You have chosen {0} and your weapon is {1}.",
            [104] = "Weapon ASCII Art: {0}",
            [105] = "What is the race of your character? Elf, Human, Dwarf, or Halfling?",
            [106] = "Invalid input. Please enter one of the following: Elf, Human, Dwarf, or Halfling.",
            [107] = "You have chosen {0} as your race.",
            [108] = "Next, we are going to roll for strength. Type ‘roll’",
            [109] = "Invalid input. Please type 'roll' to roll for strength.",
            [110] = "Next, we will roll for agility. Type ‘roll’",
            [111] = "Invalid input. Please type 'roll' to roll for agility.",
            [112] = "Next, we will roll for health points. Type ‘roll’",
            [113] = "Invalid input. Please type 'roll' to roll for health points.",
            [114] = "Your character stats are: Strength: {0}, Agility: {1}, Health: {2}",
            [115] = "Name: ",
            [116] = "Race: ",
            [117] = "Occupation: ",
            [118] = "Strength: ",
            [119] = "Agility: ",
            [120] = "Health: ",
            [121] = "Weapon: ",
            [122] = "--- Final Stats ---",
            
            // Game Menu
            [201] = "Welcome to Choose Your Adventure Game",
            [202] = "Choose: 1. Create Character or 2. Exit. Type '1' or '2'",
            [203] = "Invalid input. Please enter '1' or '2'.",
            [204] = "Exiting game...",
            [205] = "Character creation starting...",
            [206] = "What is your name?",
            [209] = "Character successfully created!",

            // Combat
            [301] = "Missed me, breath of a gnat!",
            [302] = "Is that all you've got? I've seen kittens with more fire in their paws!",
            [303] = "Try harder, human! You're making me yawn!",
            [304] = "Maybe if you squinted harder, you'd actually hit something!",
            [305] = "Ow! That actually stung a bit!",
            [306] = "Impressive! You might actually be worth toasting...",
            [307] = "That... was unexpected. But I assure you, it won't happen again.",
            [308] = "Well, I'll be! You have more bite than I thought!",

            [310] = "You prepare yourself to attack the dragon with your weapon. As a {0}, you withdraw your {1}. You attack.",
            [311] = "You missed {0}.",
            [312] = "{0} successfully defended your attack.",
            [313] = "The dragon failed to defend your attack. Your weapon delivers {0} damage points. The dragon’s health points is now {1}.",
            [314] = "With the last words of 'Arggh', you have defeated the dragon.",
            [315] = "{0} hits you.",
            [316] = "You successfully defended the attack.",
            [317] = "The dragon's attack delivers {0} damage points. Your health points is now {1}.",
            [318] = "You hastily retreat licking your wounds...",
            [319] = "Options: “r” for retreat and “a” for attack",
            [320] = "You have been defeated.",
            [321] = "{0} attacks you!",
            [322] = "The dragon missed you.",
            [323] = "You hit {0}."
        };

        AllLanguages["French"] = new Dictionary<int, string>
        {
            [101] = "Quelle est la profession de votre personnage ? Guerrier, Magicien, Voleur ou Archer ?",
            [102] = "Entrée invalide. Veuillez entrer : Guerrier, Magicien, Voleur ou Archer.",
            [103] = "Vous avez choisi {0} et votre arme est {1}.",
            [104] = "Art ASCII de l'arme : {0}",
            [105] = "Quelle est la race de votre personnage ? Elfe, Humain, Nain ou Halfelin ?",
            [106] = "Entrée invalide. Veuillez entrer : Elfe, Humain, Nain ou Halfelin.",
            [107] = "Vous avez choisi {0} comme race.",
            [108] = "Jetons maintenant pour la force. Tapez 'roll'",
            [109] = "Entrée invalide. Tapez 'roll' pour lancer le dé de force.",
            [110] = "Jetons maintenant pour l'agilité. Tapez 'roll'",
            [111] = "Entrée invalide. Tapez 'roll' pour lancer le dé d'agilité.",
            [112] = "Jetons maintenant pour les points de santé. Tapez 'roll'",
            [113] = "Entrée invalide. Tapez 'roll' pour lancer le dé de santé.",
            [114] = "Statistiques : Force : {0}, Agilité : {1}, Santé : {2}",
            [115] = "Nom: ",
            [116] = "Course: ",
            [117] = "Profession: ",
            [118] = "Force:",
            [119] = "Agilité: ",
            [120] = "Santé: ",
            [121] = "Arme: ",
            [122] = "--- Statistiques Finales ---",
            
            [201] = "Bienvenue dans le jeu Choisissez Votre Aventure",
            [202] = "Choisissez : 1. Créer un personnage ou 2. Quitter. Tapez '1' ou '2'",
            [203] = "Entrée invalide. Veuillez taper '1' ou '2'.",
            [204] = "Sortie du jeu...",
            [205] = "Création du personnage en cours...",
            [206] = "Quel est votre nom ?",
            [209] = "Personnage créé avec succès !",

            [301] = "Tu m'as raté, souffle de moustique !",
            [302] = "C'est tout ? J'ai vu des chatons plus féroces !",
            [303] = "Essaie plus fort, humain ! Tu me fais bailler !",
            [304] = "Peut-être qu'en louchant, tu atteindrais quelque chose !",
            [305] = "Aïe ! Ça a piqué un peu !",
            [306] = "Impressionnant ! Tu vaux peut-être la peine d'être rôti...",
            [307] = "C'était... inattendu. Mais ça n'arrivera plus.",
            [308] = "Eh bien ! Tu es plus coriace que prévu !",

            [310] = "Vous vous préparez à attaquer le dragon avec votre arme. En tant que {0}, vous brandissez votre {1}. Vous attaquez.",
            [311] = "Vous avez manqué {0}.",
            [312] = "{0} a défendu avec succès votre attaque.",
            [313] = "Le dragon n’a pas pu se défendre. Votre arme inflige {0} points de dégâts. Les points de vie du dragon sont maintenant {1}.",
            [314] = "Avec les derniers mots 'Arggh', vous avez vaincu le dragon.",
            [315] = "{0} vous frappe.",
            [316] = "Vous avez défendu avec succès l'attaque.",
            [317] = "L'attaque du dragon inflige {0} points de dégâts. Vos points de vie sont maintenant {1}.",
            [318] = "Vous battez en retraite en léchant vos blessures...",
            [319] = "Options : « r » pour retraite et « a » pour attaque",
            [320] = "Vous avez été vaincu.",
            [321] = "{0} vous attaque !",
            [322] = "Le dragon t'a manqué.",
            [323] = "Tu as frappé {0}."
        };

        AllLanguages["Spanish"] = new Dictionary<int, string>
        {
            [101] = "¿Cuál es la ocupación de tu personaje? ¿Luchador, Mago, Ladrón o Arquero?",
            [102] = "Entrada no válida. Introduzca: Luchador, Mago, Ladrón o Arquero.",
            [103] = "Has elegido {0} y tu arma es {1}.",
            [104] = "Arte ASCII del arma: {0}",
            [105] = "¿Cuál es la raza de tu personaje? ¿Elfo, Humano, Enano o Halfling?",
            [106] = "Entrada no válida. Introduzca: Elfo, Humano, Enano o Halfling.",
            [107] = "Has elegido {0} como raza.",
            [108] = "A continuación, tiraremos por fuerza. Escribe 'roll'",
            [109] = "Entrada no válida. Escribe 'roll' para tirar fuerza.",
            [110] = "Ahora tiraremos por agilidad. Escribe 'roll'",
            [111] = "Entrada no válida. Escribe 'roll' para tirar agilidad.",
            [112] = "Ahora tiraremos por puntos de salud. Escribe 'roll'",
            [113] = "Entrada no válida. Escribe 'roll' para tirar salud.",
            [114] = "Tus estadísticas: Fuerza: {0}, Agilidad: {1}, Salud: {2}",
            [115] = "Nombre: ",
            [116] = "Carrera: ",
            [117] = "Ocupación: ",
            [118] = "Fortaleza: ",
            [119] = "Agilidad: ",
            [120] = "Salud: ",
            [121] = "Arma: ",
            [122] = "--- Estadísticas Finales ---",

            [201] = "Bienvenido al juego Elige Tu Aventura",
            [202] = "Elige: 1. Crear personaje o 2. Salir. Escribe '1' o '2'",
            [203] = "Entrada no válida. Escribe '1' o '2'.",
            [204] = "Saliendo del juego...",
            [205] = "Iniciando la creación del personaje...",
            [206] = "¿Cómo te llamas?",
            [209] = "¡Personaje creado exitosamente!",

            [301] = "¡Me fallaste, aliento de mosquito!",
            [302] = "¿Eso es todo? ¡He visto gatitos más feroces!",
            [303] = "¡Intenta más fuerte, humano! ¡Me estás dando sueño!",
            [304] = "¡Tal vez si entrecerraras los ojos, podrías acertar!",
            [305] = "¡Ay! ¡Eso dolió un poco!",
            [306] = "¡Impresionante! Quizás valga la pena quemarte...",
            [307] = "Eso fue... inesperado. Pero no volverá a pasar.",
            [308] = "¡Vaya! ¡Tienes más fuerza de la que pensaba!",

            [310] = "Te preparas para atacar al dragón con tu arma. Como {0}, sacas tu {1}. Atacas.",
            [311] = "Fallaste a {0}.",
            [312] = "{0} defendió con éxito tu ataque.",
            [313] = "El dragón no pudo defenderse. Tu arma inflige {0} puntos de daño. Los puntos de salud del dragón ahora son {1}.",
            [314] = "Con las últimas palabras de 'Arggh', has derrotado al dragón.",
            [315] = "{0} te golpea.",
            [316] = "Has defendido con éxito el ataque.",
            [317] = "El ataque del dragón inflige {0} puntos de daño. Tus puntos de salud ahora son {1}.",
            [318] = "Te retiras rápidamente lamiendo tus heridas...",
            [319] = "Opciones: “r” para retirada y “a” para ataque",
            [320] = "Has sido derrotado.",
            [321] = "{0} te ataca!",
            [322] = "El dragón te extrañó.",
            [323] = "Golpeaste a {0}."
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
