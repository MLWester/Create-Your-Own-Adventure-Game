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
            [201] = "Welcome to Choose Your Adventure Game",
            [202] = "Choose: 1. Create Character or 2. Exit. Type '1' or '2'",
            [203] = "Invalid input. Please enter '1' or '2'.",
            [204] = "Exiting game...",
            [205] = "Character creation starting...",
            [206] = "What is your name?",
            [209] = "Character successfully created!",
            [301] = "Missed me, breath of a gnat!",
            [305] = "Ow! That actually stung a bit!"
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
            [201] = "Bienvenue dans le jeu Choisissez Votre Aventure",
            [202] = "Choisissez : 1. Créer un personnage ou 2. Quitter. Tapez '1' ou '2'",
            [203] = "Entrée invalide. Veuillez taper '1' ou '2'.",
            [204] = "Sortie du jeu...",
            [205] = "Création du personnage en cours...",
            [206] = "Quel est votre nom ?",
            [209] = "Personnage créé avec succès !",
            [301] = "Tu m'as raté, souffle de moustique !",
            [305] = "Aïe ! Ça a piqué un peu !"
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
            [201] = "Bienvenido al juego Elige Tu Aventura",
            [202] = "Elige: 1. Crear personaje o 2. Salir. Escribe '1' o '2'",
            [203] = "Entrada no válida. Escribe '1' o '2'.",
            [204] = "Saliendo del juego...",
            [205] = "Iniciando la creación del personaje...",
            [206] = "¿Cómo te llamas?",
            [209] = "¡Personaje creado exitosamente!",
            [301] = "¡Me fallaste, aliento de mosquito!",
            [305] = "¡Ay! ¡Eso dolió un poco!"
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
}
