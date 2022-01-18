using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using Yu_Gi_Oh.Models;

namespace Yu_Gi_Oh.Context
{
    public class ContestContext : DbContext
    {
        public ContestContext()
        {
            Players = new List<Player>();
            Participants = new List<Participant>();
            Decks = new List<Deck>();
            Archetypes = new List<Archetype>();
            Games = new List<Game>();
            Contests = new List<ContestPlay>();
            Rounds = new List<List<Round>>();
            ClassificationRound = new List<ClassificationRound>();
            EliminationRound = new List<EliminationRound>();

            _rd = new Random();


            #region DecksReplet

            Decks = new List<Deck>
         {
            new Deck{   DeckName = "Foes of Fortune" , MainDeck = 40 , SideDeck = 0, ExtraDeck = 15, ArchetypeName = "Fortune Lady", PlayerNumber = 1},
            new Deck{   DeckName = "Lo Bueno De Ser Normal" , MainDeck = 55 , SideDeck = 3, ExtraDeck = 15, ArchetypeName = "Mixed", PlayerNumber = 2},
            new Deck{   DeckName = "SPYRAL" , MainDeck = 40 , SideDeck = 15, ExtraDeck = 5, ArchetypeName = "Spyral", PlayerNumber = 3},
            new Deck{   DeckName = "GADGET V1" , MainDeck =  43, SideDeck = 2, ExtraDeck = 0, ArchetypeName = "Gadget", PlayerNumber = 4},
            new Deck{   DeckName = "CHAOS, The endless nigthmare" , MainDeck =  40, SideDeck = 4, ExtraDeck = 0, ArchetypeName = "Chaos Dragon", PlayerNumber = 5},
            new Deck{   DeckName = "RICE" , MainDeck = 50 , SideDeck = 10, ExtraDeck = 10, ArchetypeName = "B.E.S.", PlayerNumber = 6},
            new Deck{   DeckName = "Hada-Negacion" , MainDeck =  40, SideDeck = 1, ExtraDeck = 15, ArchetypeName = "Fortune Fairy", PlayerNumber = 7},
            new Deck{   DeckName = "Mayakashi Deckout" , MainDeck =  40, SideDeck = 10 , ExtraDeck = 15, ArchetypeName = "Mayakashi", PlayerNumber = 8},
            new Deck{   DeckName = "Neos" , MainDeck =  40, SideDeck = 0, ExtraDeck = 0, ArchetypeName = "Neos", PlayerNumber = 9},
            new Deck{   DeckName = "Hieratic Guardragon" , MainDeck =  40, SideDeck = 0, ExtraDeck = 10, ArchetypeName = "Hieratic", PlayerNumber = 10},
            new Deck{   DeckName = "Hieratic Guardragon - El dojo del duelista" , MainDeck =  40, SideDeck = 0, ExtraDeck = 5, ArchetypeName = "Hieratic", PlayerNumber = 11},
            new Deck{   DeckName = "Endymion Mythical" , MainDeck =  40, SideDeck = 0, ExtraDeck = 7, ArchetypeName = "Endymion", PlayerNumber = 12},
            new Deck{   DeckName = "Red Dragon Archfiend" , MainDeck =  44, SideDeck = 3, ExtraDeck = 4, ArchetypeName = "Archfiend", PlayerNumber = 13},
            new Deck{   DeckName = "Dinomist" , MainDeck =  40, SideDeck = 0, ExtraDeck = 2, ArchetypeName = "Dinomist", PlayerNumber = 14},
            new Deck{   DeckName = "Digital Bug" , MainDeck =  56, SideDeck = 0, ExtraDeck = 10, ArchetypeName = "Digital Bug", PlayerNumber = 15},
            new Deck{   DeckName = "Duston" , MainDeck =  41, SideDeck = 2, ExtraDeck = 3, ArchetypeName = "Duston", PlayerNumber = 16},
            new Deck{   DeckName = "Gravekeeper" , MainDeck = 40 , SideDeck = 0, ExtraDeck = 15, ArchetypeName = "Gravekeeper", PlayerNumber = 17},
            new Deck{   DeckName = "Dragunity Guardragon" , MainDeck =  45, SideDeck = 0, ExtraDeck = 5, ArchetypeName = "Dragunity", PlayerNumber = 18},
            new Deck{   DeckName = "Amazoness" , MainDeck =  40, SideDeck = 0, ExtraDeck = 15, ArchetypeName = "Amazoness", PlayerNumber = 19},
            new Deck{   DeckName = "Gishki" , MainDeck =  40, SideDeck = 0, ExtraDeck = 15, ArchetypeName = "Gishki", PlayerNumber = 20},
            new Deck{   DeckName = "Gusto Windwitch" , MainDeck =  52, SideDeck = 2, ExtraDeck = 6, ArchetypeName = "Gusto", PlayerNumber = 21},
            new Deck{   DeckName = "Speedroid" , MainDeck =  40, SideDeck = 0, ExtraDeck = 9, ArchetypeName = "Speedroid", PlayerNumber = 22},
            new Deck{   DeckName = "Dark Magician" , MainDeck = 40 , SideDeck = 5, ExtraDeck = 15, ArchetypeName = "Dark Magician", PlayerNumber = 23},
            new Deck{   DeckName = "Aromage" , MainDeck =  43, SideDeck = 0, ExtraDeck = 0, ArchetypeName = "Aromage", PlayerNumber = 24},
            new Deck{   DeckName = "Melodious Trickstar" , MainDeck =  45, SideDeck = 5, ExtraDeck = 4, ArchetypeName = "Melodious", PlayerNumber = 25},
            new Deck{   DeckName = "Lair of Darkness" , MainDeck =  44, SideDeck = 1, ExtraDeck = 4, ArchetypeName = "Dark World", PlayerNumber = 26},
            new Deck{   DeckName = "Mayakashi" , MainDeck = 47, SideDeck = 5, ExtraDeck = 5, ArchetypeName = "Koa'ki Meiru", PlayerNumber = 27},
            new Deck{   DeckName = "Magician of Chaos" , MainDeck =  42, SideDeck = 2, ExtraDeck = 3, ArchetypeName = "Dark Magician", PlayerNumber = 28},
            new Deck{   DeckName = "Neo Espacial" , MainDeck =  45, SideDeck = 4, ExtraDeck = 15, ArchetypeName = "Neos", PlayerNumber = 29},
            new Deck{   DeckName = "Cyber Dragon" , MainDeck =  40, SideDeck = 15, ExtraDeck = 15, ArchetypeName = "Cyber Dragon", PlayerNumber = 30},
            new Deck{   DeckName = "Scrap" , MainDeck =  40, SideDeck = 0, ExtraDeck = 15, ArchetypeName = "Scrap", PlayerNumber = 31},
            new Deck{   DeckName = "Blue-Eyes Guardragon" , MainDeck =  50, SideDeck = 15, ExtraDeck = 10, ArchetypeName = "Blue-Eyes", PlayerNumber = 32},
            new Deck{   DeckName = "Painter" , MainDeck = 45, SideDeck = 3, ExtraDeck = 4, ArchetypeName = "Toon", PlayerNumber = 33},
            new Deck{   DeckName = "Pendulum Magician" , MainDeck = 45, SideDeck = 3, ExtraDeck = 5, ArchetypeName = "Dark Magician", PlayerNumber = 34},
            new Deck{   DeckName = "Tierra de Destierro" , MainDeck =  40, SideDeck = 4, ExtraDeck = 0, ArchetypeName = "Landstar", PlayerNumber = 35},
            new Deck{   DeckName = "Witchcrafter" , MainDeck =  45, SideDeck = 0, ExtraDeck = 12, ArchetypeName = "Witchcrafter", PlayerNumber = 36},
            new Deck{   DeckName = "Exodia Stall v.2" , MainDeck =  40, SideDeck = 0, ExtraDeck = 15, ArchetypeName = "Exodia", PlayerNumber = 37},
            new Deck{   DeckName = "Silent Monsters" , MainDeck =  40, SideDeck = 0, ExtraDeck = 0, ArchetypeName = "Zombie", PlayerNumber = 38},
            new Deck{   DeckName = "Evil Eye" , MainDeck =  49, SideDeck = 8, ExtraDeck = 4, ArchetypeName = "Evil Eye", PlayerNumber = 39},
            new Deck{   DeckName = "Rokket Guardragon" , MainDeck =  50, SideDeck = 0, ExtraDeck = 5, ArchetypeName = "Rokket", PlayerNumber = 40},
            new Deck{   DeckName = "Mago del Caos Negro" , MainDeck =  43, SideDeck = 6, ExtraDeck = 7, ArchetypeName = "Dark Magician", PlayerNumber = 41},
            new Deck{   DeckName = "Ballpark Insect" , MainDeck =  45, SideDeck = 0, ExtraDeck = 12, ArchetypeName = "Insektor", PlayerNumber = 42},
            new Deck{   DeckName = "Iyrilusc" , MainDeck =  41, SideDeck = 3, ExtraDeck = 4, ArchetypeName = "Chrysalis", PlayerNumber = 43},
            new Deck{   DeckName = "Exodia Stall v.1" , MainDeck =  40, SideDeck = 0, ExtraDeck = 9, ArchetypeName = "Exodia", PlayerNumber = 44},
            new Deck{   DeckName = "Velociroid" , MainDeck =  44, SideDeck = 2, ExtraDeck = 5, ArchetypeName = "Roid", PlayerNumber = 45},
            new Deck{   DeckName = "PK Blackwing" , MainDeck =  43, SideDeck = 3, ExtraDeck = 2, ArchetypeName = "Blackwing", PlayerNumber = 46},
            new Deck{   DeckName = "Cyberdark" , MainDeck =  40, SideDeck = 0, ExtraDeck = 11, ArchetypeName = "Cyber Dark", PlayerNumber = 47},
            new Deck{   DeckName = "Paleozoics" , MainDeck =  45, SideDeck = 4, ExtraDeck = 15, ArchetypeName = "Paleozoic", PlayerNumber = 48},
            new Deck{   DeckName = "Danger!" , MainDeck =  43, SideDeck = 1, ExtraDeck = 11, ArchetypeName = "Thunder", PlayerNumber = 49},
            new Deck{   DeckName = "True Dracos" , MainDeck =  48, SideDeck = 3, ExtraDeck = 12, ArchetypeName = "Monarch", PlayerNumber = 50},
            new Deck{   DeckName = "Magician" , MainDeck =  49, SideDeck = 5, ExtraDeck = 6, ArchetypeName = "Mist Valley", PlayerNumber = 51},
            new Deck{   DeckName = "Burning Abyss" , MainDeck = 43, SideDeck = 5, ExtraDeck = 12, ArchetypeName = "Burning Abyss", PlayerNumber = 52},
            new Deck{   DeckName = "Los Seis Samurais" , MainDeck =  42, SideDeck = 0, ExtraDeck = 15, ArchetypeName = "Six Samurai", PlayerNumber = 53},
            new Deck{   DeckName = "Invencible" , MainDeck =  60, SideDeck = 15, ExtraDeck = 15, ArchetypeName = "Mixed", PlayerNumber = 54},
            new Deck{   DeckName = "DAD Destrudo" , MainDeck =  46, SideDeck = 10, ExtraDeck = 8, ArchetypeName = "Constellar", PlayerNumber = 55},
            new Deck{   DeckName = "Arpia Burn" , MainDeck =  49, SideDeck = 4, ExtraDeck = 15, ArchetypeName = "Harpie", PlayerNumber = 56},
            new Deck{   DeckName = "Cadena Lavalval" , MainDeck =  52, SideDeck = 4, ExtraDeck = 2, ArchetypeName = "Laval", PlayerNumber = 57},
            new Deck{   DeckName = "Espada de Luz" , MainDeck =  53, SideDeck = 5, ExtraDeck = 13, ArchetypeName = "Lightsworn", PlayerNumber = 58},
            new Deck{   DeckName = "Exodia Destiny" , MainDeck =  40, SideDeck = 6, ExtraDeck = 15, ArchetypeName = "Exodia", PlayerNumber = 59},
            new Deck{   DeckName = "Exodia Dragón" , MainDeck =  41, SideDeck = 8, ExtraDeck = 10, ArchetypeName = "Exodia", PlayerNumber = 60},
            new Deck{   DeckName = "Exodia Juego de la Gallina" , MainDeck =  45, SideDeck = 4, ExtraDeck = 5, ArchetypeName = "Exodia", PlayerNumber = 61},
            new Deck{   DeckName = "Naturaleza Hermosa" , MainDeck =  47, SideDeck = 4, ExtraDeck = 15, ArchetypeName = "Naturia", PlayerNumber = 62},
            new Deck{   DeckName = "Explosión Mágica" , MainDeck =  47, SideDeck = 3, ExtraDeck = 7, ArchetypeName = "Monarch", PlayerNumber = 63},
            new Deck{   DeckName = "Volcanic Burn" , MainDeck =  42, SideDeck = 3, ExtraDeck = 2, ArchetypeName = "Volcanic", PlayerNumber = 64},
            new Deck{   DeckName = "Predaplants" , MainDeck =  58, SideDeck = 2, ExtraDeck = 8, ArchetypeName = "Predaplant", PlayerNumber = 65},
            new Deck{   DeckName = "Nurse Burn" , MainDeck =  55, SideDeck = 4, ExtraDeck = 5, ArchetypeName = "Madolche", PlayerNumber = 66},
            new Deck{   DeckName = "Initial Nigthmare Troubador" , MainDeck =  48, SideDeck = 0, ExtraDeck = 10, ArchetypeName = "Symphonic Warrior", PlayerNumber = 67},
            new Deck{   DeckName = "Igknight" , MainDeck =  42, SideDeck = 3, ExtraDeck = 0, ArchetypeName = "Igknight", PlayerNumber = 68},
            new Deck{   DeckName = "Greed" , MainDeck =  45, SideDeck = 3, ExtraDeck = 14, ArchetypeName = "Koala", PlayerNumber = 69},
            new Deck{   DeckName = "Gem-Knight" , MainDeck =  47, SideDeck = 5, ExtraDeck = 12, ArchetypeName = "Gem-Knight", PlayerNumber = 70},
            new Deck{   DeckName = "Ogresa de la Mente Malgishki" , MainDeck = 40, SideDeck = 0, ExtraDeck = 13, ArchetypeName = "Gishki", PlayerNumber = 71},
            new Deck{   DeckName = "Bujinta" , MainDeck = 47, SideDeck = 0, ExtraDeck = 8, ArchetypeName = "Bujin", PlayerNumber = 72},
            new Deck{   DeckName = "Malanoche" , MainDeck = 48, SideDeck = 15, ExtraDeck = 2, ArchetypeName = "Maldoche", PlayerNumber = 73},
            new Deck{   DeckName = "Repetto" , MainDeck = 46, SideDeck = 5, ExtraDeck = 4, ArchetypeName = "Geargia", PlayerNumber = 74},
            new Deck{   DeckName = "Green" , MainDeck = 40, SideDeck = 3, ExtraDeck = 4, ArchetypeName = "Plants", PlayerNumber = 75},
            new Deck{   DeckName = "Grimorio" , MainDeck = 47, SideDeck = 3, ExtraDeck = 2, ArchetypeName = "Spellbook", PlayerNumber = 76},
            new Deck{   DeckName = "Puño de Fuego" , MainDeck = 43, SideDeck = 1, ExtraDeck = 4, ArchetypeName = "Fire Fist", PlayerNumber = 77},
            new Deck{   DeckName = "Chronos" , MainDeck = 45, SideDeck = 10, ExtraDeck = 10, ArchetypeName = "Chronomaly", PlayerNumber = 78},
            new Deck{   DeckName = "LS" , MainDeck = 42, SideDeck = 2, ExtraDeck = 4, ArchetypeName = "Lightsworn", PlayerNumber = 79},
            new Deck{   DeckName = "Merma" , MainDeck = 48, SideDeck = 4, ExtraDeck = 2, ArchetypeName = "Mermail", PlayerNumber = 80},
            new Deck{   DeckName = "Arias Superpoderosas" , MainDeck = 51, SideDeck = 9, ExtraDeck = 10, ArchetypeName = "Harpie", PlayerNumber = 81},
            new Deck{   DeckName = "Dragoera" , MainDeck = 54, SideDeck = 4, ExtraDeck = 3, ArchetypeName = "Dragon Variants", PlayerNumber = 82},
            new Deck{   DeckName = "Dragones del Caos" , MainDeck = 46, SideDeck = 12, ExtraDeck = 6, ArchetypeName = "Chaos Dragon", PlayerNumber = 83},
            new Deck{   DeckName = "Caballero Noble" , MainDeck = 48, SideDeck = 4, ExtraDeck = 5, ArchetypeName = "Noble Knight", PlayerNumber = 83},
            new Deck{   DeckName = "Drabernético" , MainDeck = 48, SideDeck = 0, ExtraDeck = 15, ArchetypeName = "Cyber Dragon", PlayerNumber = 82},
            new Deck{   DeckName = "Photon" , MainDeck = 56, SideDeck = 3, ExtraDeck = 4, ArchetypeName = "Photon", PlayerNumber = 81},
            new Deck{   DeckName = "Embusteros" , MainDeck = 59, SideDeck = 8, ExtraDeck = 7, ArchetypeName = "Ghostrick", PlayerNumber = 80},
            new Deck{   DeckName = "Karakuri v.2" , MainDeck = 41, SideDeck = 6, ExtraDeck = 7, ArchetypeName = "Karakuri", PlayerNumber = 79},
            new Deck{   DeckName = "HAtic" , MainDeck = 45, SideDeck = 2, ExtraDeck = 1, ArchetypeName = "Hieratic", PlayerNumber = 78},
            new Deck{   DeckName = "Artefactos Poderosos" , MainDeck = 46, SideDeck = 7, ExtraDeck = 15, ArchetypeName = "Artifact", PlayerNumber = 77},
            new Deck{   DeckName = "Mecha Phantom Beast" , MainDeck = 44, SideDeck = 2, ExtraDeck = 10, ArchetypeName = "Mecha Phantom Beast", PlayerNumber = 76},
            new Deck{   DeckName = "Boxer" , MainDeck = 57, SideDeck = 8, ExtraDeck = 4, ArchetypeName = "Battlin'Boxer", PlayerNumber = 75},
            new Deck{   DeckName = "Spirit" , MainDeck = 40, SideDeck = 6, ExtraDeck = 6, ArchetypeName = "Spirit Deck", PlayerNumber = 74},
            new Deck{   DeckName = "Rey de Fuego" , MainDeck = 46, SideDeck = 11, ExtraDeck = 9, ArchetypeName = "Fire King", PlayerNumber = 73},
            new Deck{   DeckName = "Mundo Oscuro" , MainDeck = 59, SideDeck = 0, ExtraDeck = 14, ArchetypeName = "Dark World", PlayerNumber = 72},
            new Deck{   DeckName = "T.G. v.3" , MainDeck = 42, SideDeck = 4, ExtraDeck = 3, ArchetypeName = "T.G.", PlayerNumber = 71},
            new Deck{   DeckName = "Parcs" , MainDeck = 52, SideDeck = 3, ExtraDeck = 4, ArchetypeName = "Scrap", PlayerNumber = 70},
            new Deck{   DeckName = "A-M" , MainDeck = 60, SideDeck = 8, ExtraDeck = 7, ArchetypeName = "Anti-Meta", PlayerNumber = 69},
            new Deck{   DeckName = "Infernal" , MainDeck = 45, SideDeck = 0, ExtraDeck = 4, ArchetypeName = "Infernity", PlayerNumber = 68},
            new Deck{   DeckName = "Bestias Gladiadoras" , MainDeck = 43, SideDeck = 11, ExtraDeck = 12, ArchetypeName = "Gladiator Beast", PlayerNumber = 67},
            new Deck{   DeckName = "Alas Negras" , MainDeck = 40, SideDeck = 15, ExtraDeck = 10, ArchetypeName = "Blackwing", PlayerNumber = 66},
            new Deck{   DeckName = "Inspector Gadget" , MainDeck = 42, SideDeck = 6, ExtraDeck = 4, ArchetypeName = "Gadget", PlayerNumber = 65},
            new Deck{   DeckName = "Stellar" , MainDeck = 53, SideDeck = 8, ExtraDeck = 5, ArchetypeName = "Constellar", PlayerNumber = 64},
            new Deck{   DeckName = "Agentes" , MainDeck = 44, SideDeck = 4, ExtraDeck = 4, ArchetypeName = "Agent", PlayerNumber = 63},
            new Deck{   DeckName = "Evil Deck" , MainDeck = 45, SideDeck = 4, ExtraDeck = 7, ArchetypeName = "Evilswarm", PlayerNumber = 62},
            new Deck{   DeckName = "Vía Láctea" , MainDeck = 43, SideDeck = 5, ExtraDeck = 0, ArchetypeName = "Galaxy", PlayerNumber = 61},
            new Deck{   DeckName = "Walking Dead" , MainDeck = 50, SideDeck = 0, ExtraDeck = 3, ArchetypeName = "Zombie", PlayerNumber = 60},
            new Deck{   DeckName = "Hd" , MainDeck = 60, SideDeck = 3, ExtraDeck = 5, ArchetypeName = "Hunder", PlayerNumber = 59},
            new Deck{   DeckName = "KWatt" , MainDeck = 46, SideDeck = 8, ExtraDeck = 4, ArchetypeName = "Watt", PlayerNumber = 58},
            new Deck{   DeckName = "Máquinas Antiguas" , MainDeck = 54, SideDeck = 6, ExtraDeck = 5, ArchetypeName = "Ancient Gear", PlayerNumber = 57},
            new Deck{   DeckName = "Tanuki v.1" , MainDeck = 42, SideDeck = 13, ExtraDeck = 15, ArchetypeName = "Tanuki", PlayerNumber = 56},
            new Deck{   DeckName = "Heraldic The Best" , MainDeck = 45, SideDeck = 9, ExtraDeck = 9, ArchetypeName = "Heraldic", PlayerNumber = 55},
            new Deck{   DeckName = "Koa'ki Meiru" , MainDeck = 43, SideDeck = 6, ExtraDeck = 4, ArchetypeName = "Koa'ki Meiru", PlayerNumber = 54},
            new Deck{   DeckName = "Bulbasaur" , MainDeck = 45, SideDeck = 5, ExtraDeck = 6, ArchetypeName = "Evolsaur", PlayerNumber = 53},
            new Deck{   DeckName = "Sharknado" , MainDeck = 50, SideDeck = 0, ExtraDeck = 10, ArchetypeName = "Shark", PlayerNumber = 52},
            new Deck{   DeckName = "Cadenas" , MainDeck = 56, SideDeck = 8, ExtraDeck = 9, ArchetypeName = "Chain Beat", PlayerNumber = 51},
            new Deck{   DeckName = "Horror" , MainDeck = 47, SideDeck = 2, ExtraDeck = 4, ArchetypeName = "Umbral Horror", PlayerNumber = 50},
            new Deck{   DeckName = "Malvado" , MainDeck = 55, SideDeck = 4, ExtraDeck = 3, ArchetypeName = "Malefic", PlayerNumber = 49},
            new Deck{   DeckName = "Arch" , MainDeck = 43, SideDeck = 7, ExtraDeck = 6, ArchetypeName = "Archfiend", PlayerNumber = 48},
            new Deck{   DeckName = "GO HERO!" , MainDeck = 45, SideDeck = 15, ExtraDeck = 15, ArchetypeName = "HERO Variants", PlayerNumber = 47},
            new Deck{   DeckName = "Physics" , MainDeck = 47, SideDeck = 12, ExtraDeck = 5, ArchetypeName = "Physics", PlayerNumber = 46},
            new Deck{   DeckName = "Cadenas Incendiarias" , MainDeck = 43, SideDeck = 7, ExtraDeck = 4, ArchetypeName = "Chain Burn", PlayerNumber = 45},
            new Deck{   DeckName = "Ventisca" , MainDeck = 47, SideDeck = 11, ExtraDeck = 4, ArchetypeName = "Wind-Up", PlayerNumber = 44},
            new Deck{   DeckName = "Gogogo" , MainDeck = 46, SideDeck = 13, ExtraDeck = 6, ArchetypeName = "Gogogo", PlayerNumber = 43},
            new Deck{   DeckName = "X-Saber" , MainDeck = 45, SideDeck = 5, ExtraDeck = 6, ArchetypeName = "X-Saber", PlayerNumber = 42},
            new Deck{   DeckName = "Synchron Deck" , MainDeck = 49, SideDeck = 9, ExtraDeck = 6, ArchetypeName = "Synchron", PlayerNumber = 41},
            new Deck{   DeckName = "LLamarada" , MainDeck = 45, SideDeck = 13, ExtraDeck = 8, ArchetypeName = "Hazy Flame", PlayerNumber = 40},
            new Deck{   DeckName = "La Trampa" , MainDeck = 44, SideDeck = 5, ExtraDeck = 6, ArchetypeName = "Traptrix", PlayerNumber = 39},
            new Deck{   DeckName = "Flamvell Lord" , MainDeck = 60, SideDeck = 9, ExtraDeck = 8, ArchetypeName = "Flamvell", PlayerNumber = 38},
            new Deck{   DeckName = "Pingüinos Al Ataque" , MainDeck = 51, SideDeck = 10, ExtraDeck = 14, ArchetypeName = "Penguins", PlayerNumber = 37},
            new Deck{   DeckName = "Dark Web" , MainDeck = 48, SideDeck = 12, ExtraDeck = 8, ArchetypeName = "Cyber Dark", PlayerNumber = 36},
            new Deck{   DeckName = "Number C" , MainDeck = 45, SideDeck = 1, ExtraDeck = 3, ArchetypeName = "Number C", PlayerNumber = 35},
            new Deck{   DeckName = "Just Junk" , MainDeck = 48, SideDeck = 5, ExtraDeck = 6, ArchetypeName = "Junk Doppel", PlayerNumber = 34},
            new Deck{   DeckName = "Worm worm worm" , MainDeck = 43, SideDeck = 14, ExtraDeck = 6, ArchetypeName = "Worm", PlayerNumber = 33},
            new Deck{   DeckName = "Transylvania" , MainDeck = 46, SideDeck = 6, ExtraDeck = 4, ArchetypeName = "Vampire", PlayerNumber = 32},
            new Deck{   DeckName = "Number" , MainDeck = 49, SideDeck = 12, ExtraDeck = 12, ArchetypeName = "Number", PlayerNumber = 31},
            new Deck{   DeckName = "Barreras de Hielo" , MainDeck = 47, SideDeck = 4, ExtraDeck = 5, ArchetypeName = "Ice Barrier", PlayerNumber = 30},
            new Deck{   DeckName = "Pinocho" , MainDeck = 51, SideDeck = 10, ExtraDeck = 6, ArchetypeName = "Gimmick Puppet", PlayerNumber = 29},
            new Deck{   DeckName = "Glass" , MainDeck = 41, SideDeck = 9, ExtraDeck = 4, ArchetypeName = "Crystal Beast", PlayerNumber = 28},
            new Deck{   DeckName = "Garu" , MainDeck = 42, SideDeck = 4, ExtraDeck = 8, ArchetypeName = "Ninja", PlayerNumber = 27},
            new Deck{   DeckName = "Lady Gaga" , MainDeck = 43, SideDeck = 7, ExtraDeck = 3, ArchetypeName = "Gagaga", PlayerNumber = 26},
            new Deck{   DeckName = "My Utopia" , MainDeck = 41, SideDeck = 1, ExtraDeck = 14, ArchetypeName = "Utopia", PlayerNumber = 25},
            new Deck{   DeckName = "Shin" , MainDeck = 45, SideDeck = 2, ExtraDeck = 13, ArchetypeName = "Shinra", PlayerNumber = 24},
            new Deck{   DeckName = "Dodo" , MainDeck = 47, SideDeck = 3, ExtraDeck = 12, ArchetypeName = "Dododo", PlayerNumber = 23},
            new Deck{   DeckName = "Odin" , MainDeck = 46, SideDeck = 4, ExtraDeck = 11, ArchetypeName = "Nordic", PlayerNumber = 22},
            new Deck{   DeckName = "Jurrac" , MainDeck = 52, SideDeck = 5, ExtraDeck = 10, ArchetypeName = "Jurrac", PlayerNumber = 21},
            new Deck{   DeckName = "Fabled" , MainDeck = 53, SideDeck = 6, ExtraDeck = 9, ArchetypeName = "Fabled", PlayerNumber = 20},
            new Deck{   DeckName = "Morph" , MainDeck = 45, SideDeck = 7, ExtraDeck = 8, ArchetypeName = "Morphtronic", PlayerNumber = 19},
            new Deck{   DeckName = "ET" , MainDeck = 47, SideDeck = 8, ExtraDeck = 7, ArchetypeName = "Alien", PlayerNumber = 18},
            new Deck{   DeckName = "Señora Del Destino" , MainDeck = 60, SideDeck = 9, ExtraDeck = 6, ArchetypeName = "Fortune Lady", PlayerNumber = 17},
            new Deck{   DeckName = "Hombre Batería" , MainDeck = 54, SideDeck = 10, ExtraDeck = 5, ArchetypeName = "Batteryman", PlayerNumber = 16},
            new Deck{   DeckName = "Arácnide" , MainDeck = 45, SideDeck = 11, ExtraDeck = 4, ArchetypeName = "Spider", PlayerNumber = 15},
            new Deck{   DeckName = "Nimble" , MainDeck = 42, SideDeck = 12, ExtraDeck = 3, ArchetypeName = "Nimble", PlayerNumber = 14},
            new Deck{   DeckName = "Nube" , MainDeck = 43, SideDeck = 13, ExtraDeck = 2, ArchetypeName = "Cloudian", PlayerNumber = 13},
            new Deck{   DeckName = "Scorpion" , MainDeck = 42, SideDeck = 14, ExtraDeck = 1, ArchetypeName = "Dark Scorpion", PlayerNumber = 12},
            new Deck{   DeckName = "Cadenas de Hierro" , MainDeck = 60, SideDeck = 0, ExtraDeck = 8, ArchetypeName = "Iron Chain", PlayerNumber = 11},
            new Deck{   DeckName = "Bounzer" , MainDeck = 58, SideDeck = 1, ExtraDeck = 9, ArchetypeName = "Bounzer", PlayerNumber = 10},
            new Deck{   DeckName = "Guardian" , MainDeck = 56, SideDeck = 2, ExtraDeck = 10, ArchetypeName = "Guardian", PlayerNumber = 9},
            new Deck{   DeckName = "Inmato" , MainDeck = 54, SideDeck = 3, ExtraDeck = 11, ArchetypeName = "Inmato", PlayerNumber = 8},
            new Deck{   DeckName = "Vylon v.1" , MainDeck = 52, SideDeck = 4, ExtraDeck = 4, ArchetypeName = "Vylon", PlayerNumber = 7},
            new Deck{   DeckName = "Majestic People" , MainDeck = 50, SideDeck = 5, ExtraDeck = 6, ArchetypeName = "Majestic", PlayerNumber = 6},
            new Deck{   DeckName = "Inmortal & Invencible" , MainDeck = 48, SideDeck = 6, ExtraDeck = 4, ArchetypeName = "Earthbound Inmortal", PlayerNumber = 5},
            new Deck{   DeckName = "Ojama Way" , MainDeck = 46, SideDeck = 7, ExtraDeck = 7, ArchetypeName = "Ojama", PlayerNumber = 4},
            new Deck{   DeckName = "Yubel & lebuY" , MainDeck = 44, SideDeck = 8, ExtraDeck = 3, ArchetypeName = "Yubel", PlayerNumber = 3},
            new Deck{   DeckName = "Aliado de la Justicia" , MainDeck = 42, SideDeck = 9, ExtraDeck = 5, ArchetypeName = "Ally of Justice", PlayerNumber = 2},
            new Deck{   DeckName = "Reptiles" , MainDeck = 40, SideDeck = 10, ExtraDeck = 3, ArchetypeName = "Reptillianne", PlayerNumber = 1},
            new Deck{   DeckName = "Venom" , MainDeck = 40, SideDeck = 11, ExtraDeck = 7, ArchetypeName = "Venom", PlayerNumber = 1},
            new Deck{   DeckName = "Amazonas" , MainDeck = 41, SideDeck = 12, ExtraDeck = 4, ArchetypeName = "Amazoness", PlayerNumber = 10},
            new Deck{   DeckName = "Malicevorous v.3" , MainDeck = 42, SideDeck = 13, ExtraDeck = 1, ArchetypeName = "Malicevorous", PlayerNumber = 2},
            new Deck{   DeckName = "God Horus" , MainDeck = 43, SideDeck = 14, ExtraDeck = 12, ArchetypeName = "Horus the Black Flame", PlayerNumber = 20},
            new Deck{   DeckName = "Fuerza Arcana" , MainDeck = 44, SideDeck = 15, ExtraDeck = 0, ArchetypeName = "Arcana Force", PlayerNumber = 3},
            new Deck{   DeckName = "Nitro Golpe" , MainDeck = 45, SideDeck = 15, ExtraDeck = 0, ArchetypeName = "Nitro", PlayerNumber = 30},
            new Deck{   DeckName = "Tensei Slime" , MainDeck = 46, SideDeck = 14, ExtraDeck = 12, ArchetypeName = "Slime", PlayerNumber = 4},
            new Deck{   DeckName = "Cartoon" , MainDeck = 47, SideDeck = 13, ExtraDeck = 13, ArchetypeName = "Toon", PlayerNumber = 40},
            new Deck{   DeckName = "Genex 2.0" , MainDeck = 48, SideDeck = 12, ExtraDeck = 15, ArchetypeName = "Genex", PlayerNumber = 5},
            new Deck{   DeckName = "Golden Sun" , MainDeck = 49, SideDeck = 11, ExtraDeck = 15, ArchetypeName = "Djinn", PlayerNumber = 50},
            new Deck{   DeckName = "Fossil" , MainDeck = 50, SideDeck = 10, ExtraDeck = 2, ArchetypeName = "Fossil", PlayerNumber = 6},
            new Deck{   DeckName = "Granel" , MainDeck = 51, SideDeck = 9, ExtraDeck = 4, ArchetypeName = "Granel", PlayerNumber = 60},
            new Deck{   DeckName = "Meklord v.7" , MainDeck = 52, SideDeck = 8, ExtraDeck = 4, ArchetypeName = "Meklord", PlayerNumber = 7},
            new Deck{   DeckName = "Toy Story" , MainDeck = 53, SideDeck = 7, ExtraDeck = 5, ArchetypeName = "Toy", PlayerNumber = 70},
            new Deck{   DeckName = "Comadrejas" , MainDeck = 54, SideDeck = 6, ExtraDeck = 11, ArchetypeName = "Wisel", PlayerNumber = 8},
            new Deck{   DeckName = "Yomi Dany" , MainDeck = 55, SideDeck = 5, ExtraDeck = 10, ArchetypeName = "Yomi", PlayerNumber = 80},
            new Deck{   DeckName = "Ryuu" , MainDeck = 56, SideDeck = 4, ExtraDeck = 14, ArchetypeName = "Ryuusei", PlayerNumber = 9},
            new Deck{   DeckName = "Queen" , MainDeck = 57, SideDeck = 3, ExtraDeck = 13, ArchetypeName = "Allure Queen", PlayerNumber = 79},
            new Deck{   DeckName = "Asesinos" , MainDeck = 58, SideDeck = 2, ExtraDeck = 12, ArchetypeName = "Assassin", PlayerNumber = 10},
            new Deck{   DeckName = "Espada de Bambú" , MainDeck = 59, SideDeck = 1, ExtraDeck = 4, ArchetypeName = "Bamboo Sword", PlayerNumber = 23},
            new Deck{   DeckName = "Mariposa" , MainDeck = 60, SideDeck = 0, ExtraDeck = 2, ArchetypeName = "Butterfly", PlayerNumber = 25},
            new Deck{   DeckName = "Butterspy Attack" , MainDeck = 60, SideDeck = 0, ExtraDeck = 9, ArchetypeName = "Butterspy", PlayerNumber = 43},
            new Deck{   DeckName = "Gato" , MainDeck = 59, SideDeck = 1, ExtraDeck = 8, ArchetypeName = "Cat", PlayerNumber = 66},
            new Deck{   DeckName = "Clear v.1" , MainDeck = 58, SideDeck = 2, ExtraDeck = 6, ArchetypeName = "Clear", PlayerNumber = 57},
            new Deck{   DeckName = "Héroes al Rescate" , MainDeck = 57, SideDeck = 3, ExtraDeck = 7, ArchetypeName = "Comics Hero", PlayerNumber = 4},
            new Deck{   DeckName = "Ángeles Cibernéticos" , MainDeck = 56, SideDeck = 4, ExtraDeck = 8, ArchetypeName = "Cyber Angel", PlayerNumber = 1},
            new Deck{   DeckName = "Legolas" , MainDeck = 55, SideDeck = 5, ExtraDeck = 9, ArchetypeName = "Elf", PlayerNumber = 34},
            new Deck{   DeckName = "Poison Ivy" , MainDeck = 54, SideDeck = 6, ExtraDeck = 10, ArchetypeName = "Ivy", PlayerNumber = 83},
            new Deck{   DeckName = "Chester" , MainDeck = 53, SideDeck = 7, ExtraDeck = 11, ArchetypeName = "Jester", PlayerNumber = 81},
            new Deck{   DeckName = "Robot Chatarra" , MainDeck = 52, SideDeck = 8, ExtraDeck = 12, ArchetypeName = "Junk Robot", PlayerNumber = 45},
            new Deck{   DeckName = "Magneto" , MainDeck = 51, SideDeck = 9, ExtraDeck = 13, ArchetypeName = "Magnet", PlayerNumber = 44},
            new Deck{   DeckName = "Motor Full Power" , MainDeck = 50, SideDeck = 10, ExtraDeck = 14, ArchetypeName = "Motor", PlayerNumber = 32},
            new Deck{   DeckName = "Reactor Nuclear" , MainDeck = 49, SideDeck = 11, ExtraDeck = 15, ArchetypeName = "Reactor", PlayerNumber = 17},
            new Deck{   DeckName = "R-Genex The Terror" , MainDeck = 48, SideDeck = 12, ExtraDeck = 15, ArchetypeName = "R-Genex", PlayerNumber = 1},
            new Deck{   DeckName = "Skiel" , MainDeck = 47, SideDeck = 13, ExtraDeck = 13, ArchetypeName = "Skiel", PlayerNumber = 3},
            new Deck{   DeckName = "Sphere" , MainDeck = 46, SideDeck = 14, ExtraDeck = 10, ArchetypeName = "Sphere", PlayerNumber = 5},
            new Deck{   DeckName = "Esfinge" , MainDeck = 45, SideDeck = 15, ExtraDeck = 8, ArchetypeName = "Sphinx", PlayerNumber = 7},
            new Deck{   DeckName = "Mensaje Espiritual" , MainDeck = 44, SideDeck = 15, ExtraDeck = 7, ArchetypeName = "Spirit Message", PlayerNumber = 9},
            new Deck{   DeckName = "Serafínes" , MainDeck = 43, SideDeck = 14, ExtraDeck = 5, ArchetypeName = "Star Seraph", PlayerNumber = 11},
            new Deck{   DeckName = "El Señor del Tiempo" , MainDeck = 42, SideDeck = 13, ExtraDeck = 4, ArchetypeName = "Timelord", PlayerNumber = 13},
            new Deck{   DeckName = "Valkirias" , MainDeck = 41, SideDeck = 12, ExtraDeck = 3, ArchetypeName = "Valkyrie", PlayerNumber = 15},
            new Deck{   DeckName = "Payasos" , MainDeck = 40, SideDeck = 11, ExtraDeck = 2, ArchetypeName = "Clown Control", PlayerNumber = 17},
            new Deck{   DeckName = "Mixto" , MainDeck = 42, SideDeck = 0, ExtraDeck = 6, ArchetypeName = "Mixed", PlayerNumber = 19},
            new Deck{   DeckName = "Malvado y Peligroso" , MainDeck = 46, SideDeck = 1, ExtraDeck = 5, ArchetypeName = "Mixed", PlayerNumber = 21},
            new Deck{   DeckName = "Heroes Elementales" , MainDeck = 44, SideDeck = 2, ExtraDeck = 3, ArchetypeName = "Elemental Hero", PlayerNumber = 23},
            new Deck{   DeckName = "Fuera de esta Dimensión" , MainDeck = 43, SideDeck = 3, ExtraDeck = 1, ArchetypeName = "D.D.", PlayerNumber = 25},
            new Deck{   DeckName = "Peligro" , MainDeck = 46, SideDeck = 4, ExtraDeck = 2, ArchetypeName = "Danger!", PlayerNumber = 27},
            new Deck{   DeckName = "Blue-Eyes Dragon" , MainDeck = 45, SideDeck = 5, ExtraDeck = 3, ArchetypeName = "Blue-Eyes", PlayerNumber = 29},
            new Deck{   DeckName = "Mago del Aroma" , MainDeck = 42, SideDeck = 6, ExtraDeck = 5, ArchetypeName = "Aromage", PlayerNumber = 31},
            new Deck{   DeckName = "Dragones Armados" , MainDeck = 43, SideDeck = 7, ExtraDeck = 6, ArchetypeName = "Armed Dragon", PlayerNumber = 32},
            new Deck{   DeckName = "Valhala" , MainDeck = 48, SideDeck = 8, ExtraDeck = 5, ArchetypeName = "Valkyrie", PlayerNumber = 33},
            new Deck{   DeckName = "Ragnarok" , MainDeck = 47, SideDeck = 9, ExtraDeck = 3, ArchetypeName = "Aesir", PlayerNumber = 35},
            new Deck{   DeckName = "Villanos" , MainDeck = 45, SideDeck = 10, ExtraDeck = 2, ArchetypeName = "Evil Hero", PlayerNumber = 37},
            new Deck{   DeckName = "Familia Poseída" , MainDeck = 41, SideDeck = 11, ExtraDeck = 6, ArchetypeName = "Familiar-Possessed", PlayerNumber = 39},
            new Deck{   DeckName = "Soy el Dueño del Tiempo" , MainDeck = 40, SideDeck = 12, ExtraDeck = 5, ArchetypeName = "Timelord", PlayerNumber = 41},
            new Deck{   DeckName = "El regreso de Gaia" , MainDeck = 40, SideDeck = 13, ExtraDeck = 6, ArchetypeName = "Gaia", PlayerNumber = 43},
            new Deck{   DeckName = "Universo" , MainDeck = 59, SideDeck = 14, ExtraDeck = 3, ArchetypeName = "Star Seraph", PlayerNumber = 45},
            new Deck{   DeckName = "Zubat" , MainDeck = 49, SideDeck = 15, ExtraDeck = 4, ArchetypeName = "Zubaba", PlayerNumber = 47},
            new Deck{   DeckName = "Virgo y sus Amigos" , MainDeck = 48, SideDeck = 15, ExtraDeck = 5, ArchetypeName = "Zoodiac", PlayerNumber = 49},
            new Deck{   DeckName = "Saint Seiya" , MainDeck = 46, SideDeck = 14, ExtraDeck = 3, ArchetypeName = "Zoodiac", PlayerNumber = 51},
            new Deck{   DeckName = "Zebstrika" , MainDeck = 43, SideDeck = 13, ExtraDeck = 2, ArchetypeName = "Zefra", PlayerNumber = 53},
            new Deck{   DeckName = "Yosenju v.2" , MainDeck = 54, SideDeck = 12, ExtraDeck = 0, ArchetypeName = "Yosenju", PlayerNumber = 55},
            new Deck{   DeckName = "Yang Zing v.3" , MainDeck = 54, SideDeck = 11, ExtraDeck = 1, ArchetypeName = "Yang Zing", PlayerNumber = 57},
            new Deck{   DeckName = "El Legado del Mundo" , MainDeck = 42, SideDeck = 10, ExtraDeck = 2, ArchetypeName = "World Legacy", PlayerNumber = 59},
            new Deck{   DeckName = "World Chalice v.1" , MainDeck = 42, SideDeck = 9, ExtraDeck = 12, ArchetypeName = "World Chalice", PlayerNumber = 61},
            new Deck{   DeckName = "Salem" , MainDeck = 42, SideDeck = 8, ExtraDeck = 10, ArchetypeName = "Witchcrafter", PlayerNumber = 63},
            new Deck{   DeckName = "Brujería del Este" , MainDeck = 45, SideDeck = 7, ExtraDeck = 11, ArchetypeName = "Witchcrafter", PlayerNumber = 65},
            new Deck{   DeckName = "Bruja del Viento" , MainDeck = 45, SideDeck = 6, ExtraDeck = 13, ArchetypeName = "Windwitch", PlayerNumber = 67},
            new Deck{   DeckName = "Vendread Revenge" , MainDeck = 45, SideDeck = 5, ExtraDeck = 10, ArchetypeName = "Vendread", PlayerNumber = 69},
            new Deck{   DeckName = "Vassal v.2" , MainDeck = 40, SideDeck = 4, ExtraDeck = 9, ArchetypeName = "Vassal", PlayerNumber = 68},
            new Deck{   DeckName = "U.A." , MainDeck = 40, SideDeck = 3, ExtraDeck = 13, ArchetypeName = "U.A.", PlayerNumber = 71},
            new Deck{   DeckName = "Crepúsculo" , MainDeck = 40, SideDeck = 2, ExtraDeck = 11, ArchetypeName = "Twilightsworn", PlayerNumber = 73},
            new Deck{   DeckName = "The King of the Seven Kingdoms" , MainDeck = 60, SideDeck = 1, ExtraDeck = 12, ArchetypeName = "True King", PlayerNumber = 75},
            new Deck{   DeckName = "Truco de Estrella" , MainDeck = 60, SideDeck = 0, ExtraDeck = 11, ArchetypeName = "Trickstar", PlayerNumber = 77},
            new Deck{   DeckName = "Tin Ma Rin" , MainDeck = 59, SideDeck = 0, ExtraDeck = 10, ArchetypeName = "Tindangle", PlayerNumber = 79},
            new Deck{   DeckName = "EL Clima y sus Tempestades" , MainDeck = 58, SideDeck = 1, ExtraDeck = 2, ArchetypeName = "The Weather", PlayerNumber = 81},
            new Deck{   DeckName = "Acero Inoxidable" , MainDeck = 57, SideDeck = 2, ExtraDeck = 2, ArchetypeName = "Steelswarm", PlayerNumber = 83},
            new Deck{   DeckName = "Deck Horror Story" , MainDeck = 56, SideDeck = 3, ExtraDeck = 3, ArchetypeName = "Subterror", PlayerNumber = 2},
            new Deck{   DeckName = "Samurai Pesado" , MainDeck = 55, SideDeck = 4, ExtraDeck = 2, ArchetypeName = "Superheavy Samurai", PlayerNumber = 4},
            new Deck{   DeckName = "Sylveon" , MainDeck = 54, SideDeck = 5, ExtraDeck = 3, ArchetypeName = "Sylvan", PlayerNumber = 6},
            new Deck{   DeckName = "Tellar Knight" , MainDeck = 53, SideDeck = 6, ExtraDeck = 5, ArchetypeName = "Tellarknight", PlayerNumber = 8},
            new Deck{   DeckName = "Caster" , MainDeck = 52, SideDeck = 7, ExtraDeck = 5, ArchetypeName = "Spellcaster", PlayerNumber = 14},
            new Deck{   DeckName = "Spyral v.2" , MainDeck = 51, SideDeck = 8, ExtraDeck = 5, ArchetypeName = "Spyral", PlayerNumber = 16},
            new Deck{   DeckName = "Velocidad" , MainDeck = 50, SideDeck = 9, ExtraDeck = 6, ArchetypeName = "Speedroid", PlayerNumber = 18},
            new Deck{   DeckName = "Asesino del Cielo" , MainDeck = 49, SideDeck = 10, ExtraDeck = 6, ArchetypeName = "Sky Striker", PlayerNumber = 20},
            new Deck{   DeckName = "Sirviente de la Calavera" , MainDeck = 48, SideDeck = 11, ExtraDeck = 5, ArchetypeName = "Skull Servant", PlayerNumber = 24},
            new Deck{   DeckName = "Espadachín Silencioso" , MainDeck = 47, SideDeck = 12, ExtraDeck = 2, ArchetypeName = "Silent Swordsman", PlayerNumber = 26},
            new Deck{   DeckName = "Magos del Silencio" , MainDeck = 46, SideDeck = 13, ExtraDeck = 3, ArchetypeName = "Silent Magician", PlayerNumber = 67},
            new Deck{   DeckName = "Las Salamandrasson Grandiosas" , MainDeck = 45, SideDeck = 14, ExtraDeck = 2, ArchetypeName = "Salamangreat", PlayerNumber = 66},
            new Deck{   DeckName = "Muñecas Tenebrosas" , MainDeck = 44, SideDeck = 15, ExtraDeck = 4, ArchetypeName = "Shaddoll", PlayerNumber = 25},
            new Deck{   DeckName = "Pájaros Blancos" , MainDeck = 43, SideDeck = 15, ExtraDeck = 5, ArchetypeName = "Shinobird", PlayerNumber = 48},
            new Deck{   DeckName = "Shiranui The Dog" , MainDeck = 42, SideDeck = 14, ExtraDeck = 6, ArchetypeName = "Shiranui", PlayerNumber = 44},
            new Deck{   DeckName = "Rosa Diamante" , MainDeck = 41, SideDeck = 13, ExtraDeck = 9, ArchetypeName = "Rose", PlayerNumber = 34},
            new Deck{   DeckName = "Cohete y más cohetes" , MainDeck = 40, SideDeck = 12, ExtraDeck = 10, ArchetypeName = "Rokket", PlayerNumber = 32},
            new Deck{   DeckName = "Roid the Comeback" , MainDeck = 40, SideDeck = 11, ExtraDeck = 12, ArchetypeName = "Roid", PlayerNumber = 36},
            new Deck{   DeckName = "Princesa Vidente" , MainDeck = 41, SideDeck = 10, ExtraDeck = 12, ArchetypeName = "Prediction Princess", PlayerNumber = 38},
            new Deck{   DeckName = "Bestias y Rituales" , MainDeck = 42, SideDeck = 9, ExtraDeck = 13, ArchetypeName = "Ritual Beast", PlayerNumber = 34},
            new Deck{   DeckName = "Levántate Campana" , MainDeck = 43, SideDeck = 8, ExtraDeck = 12, ArchetypeName = "Risebell", PlayerNumber = 37},
            new Deck{   DeckName = "Dragones de Ojos Rojos" , MainDeck = 44, SideDeck = 7, ExtraDeck = 10, ArchetypeName = "Red-Eyes", PlayerNumber = 52},
            new Deck{   DeckName = "Los Dinosaurios del Camino" , MainDeck = 45, SideDeck = 6, ExtraDeck = 9, ArchetypeName = "Raidraptor", PlayerNumber = 54},
            new Deck{   DeckName = "Qli v.2" , MainDeck = 46, SideDeck = 5, ExtraDeck = 7, ArchetypeName = "Qli", PlayerNumber = 56},
            new Deck{   DeckName = "PSYduck" , MainDeck = 47, SideDeck = 4, ExtraDeck = 6, ArchetypeName = "PSY-Framegear", PlayerNumber = 14},
            new Deck{   DeckName = "Plantas Carnívorsas y Depredadoras" , MainDeck = 48, SideDeck = 3, ExtraDeck = 5, ArchetypeName = "Predaplant", PlayerNumber = 56},
            new Deck{   DeckName = "Niños Jocosos" , MainDeck = 49, SideDeck = 2, ExtraDeck = 4, ArchetypeName = "Prank-Kids", PlayerNumber = 76},
            new Deck{   DeckName = "Una Espiral Fantasma" , MainDeck = 50, SideDeck = 1, ExtraDeck = 3, ArchetypeName = "Phantasm Spiral", PlayerNumber = 78},
            new Deck{   DeckName = "Perfom" , MainDeck = 51, SideDeck = 0, ExtraDeck = 3, ArchetypeName = "Perfomapal", PlayerNumber = 82},
            new Deck{   DeckName = "Perfomage v.2" , MainDeck = 52, SideDeck = 1, ExtraDeck = 2, ArchetypeName = "Perfomage", PlayerNumber = 74},
            new Deck{   DeckName = "Parsh" , MainDeck = 53, SideDeck = 3, ExtraDeck = 1, ArchetypeName = "Parshath", PlayerNumber = 72},
            new Deck{   DeckName = "Era Paleozoica" , MainDeck = 54, SideDeck = 5, ExtraDeck = 4, ArchetypeName = "Paleozoic", PlayerNumber = 68},
            new Deck{   DeckName = "Orcust , La Venganza" , MainDeck = 55, SideDeck = 7, ExtraDeck = 3, ArchetypeName = "Orcust", PlayerNumber = 62},
            new Deck{   DeckName = "Ojos Extraños" , MainDeck = 56, SideDeck = 9, ExtraDeck = 13, ArchetypeName = "Odd-Eyes", PlayerNumber = 3},
            new Deck{   DeckName = "El Imperio de Nephthys" , MainDeck = 57, SideDeck = 11, ExtraDeck = 12, ArchetypeName = "Nephthys", PlayerNumber = 1},
            new Deck{   DeckName = "El Neo Espacio" , MainDeck = 58, SideDeck = 13, ExtraDeck = 10, ArchetypeName = "Neo-Spacian", PlayerNumber = 66},
            new Deck{   DeckName = "Nekroz" , MainDeck = 59, SideDeck = 15, ExtraDeck = 11, ArchetypeName = "Nekroz", PlayerNumber = 80},
            new Deck{   DeckName = "Bestias Místicas , Su Secreto" , MainDeck = 60, SideDeck = 15, ExtraDeck = 15, ArchetypeName = "Mystical Beast", PlayerNumber = 60},
            new Deck{   DeckName = "Metafísica" , MainDeck = 60, SideDeck = 10, ExtraDeck = 14, ArchetypeName = "Metaphys", PlayerNumber = 49},
            new Deck{   DeckName = "Enemigos Metálicos" , MainDeck = 59, SideDeck = 12, ExtraDeck = 13, ArchetypeName = "Metalfoes", PlayerNumber = 51},
            new Deck{   DeckName = "Caballeros Mekk" , MainDeck = 58, SideDeck = 14, ExtraDeck = 12, ArchetypeName = "Mekk-Knight", PlayerNumber = 5},
            new Deck{   DeckName = "Melodía" , MainDeck = 57, SideDeck = 12, ExtraDeck = 11, ArchetypeName = "Melodius", PlayerNumber = 43},
            new Deck{   DeckName = "Mayakashi Return" , MainDeck = 56, SideDeck = 13, ExtraDeck = 8, ArchetypeName = "Mayakashi", PlayerNumber = 24},
            new Deck{   DeckName = "Poderosos Magos" , MainDeck = 55, SideDeck = 11, ExtraDeck = 7, ArchetypeName = "Magician", PlayerNumber = 26},
            new Deck{   DeckName = "Mosqueteros Mágicos" , MainDeck = 54, SideDeck = 5, ExtraDeck = 6, ArchetypeName = "Magical Musket", PlayerNumber = 35},
            new Deck{   DeckName = "Magos del Destierro Vengativos" , MainDeck = 53, SideDeck = 7, ExtraDeck = 7, ArchetypeName = "Magician", PlayerNumber = 8},
            new Deck{   DeckName = "Canto Lírico" , MainDeck = 52, SideDeck = 6, ExtraDeck = 0, ArchetypeName = "Lyrilusc", PlayerNumber = 83},
            new Deck{   DeckName = "Luz de Luna" , MainDeck = 51, SideDeck = 5, ExtraDeck = 6, ArchetypeName = "Lunalight", PlayerNumber = 34},
            new Deck{   DeckName = "Rayo de Luz" , MainDeck = 50, SideDeck = 6, ExtraDeck = 8, ArchetypeName = "Lightray", PlayerNumber = 63},
            new Deck{   DeckName = "Kraken" , MainDeck = 49, SideDeck = 8, ExtraDeck = 0, ArchetypeName = "Krawler", PlayerNumber = 80},
            new Deck{   DeckName = "Kozmopolitan" , MainDeck = 48, SideDeck = 7, ExtraDeck = 9, ArchetypeName = "Kozmo", PlayerNumber = 24},
            new Deck{   DeckName = "¿Invocados?" , MainDeck = 47, SideDeck = 7, ExtraDeck = 7, ArchetypeName = "Invoked", PlayerNumber = 67},
            new Deck{   DeckName = "Tractores del Infinito" , MainDeck = 46, SideDeck = 6, ExtraDeck = 6, ArchetypeName = "Infinitrack", PlayerNumber = 81},
            new Deck{   DeckName = "Roid Infernales" , MainDeck = 45, SideDeck = 5, ExtraDeck = 3, ArchetypeName = "Infernoid", PlayerNumber = 57},
            new Deck{   DeckName = "Encanto Imperial" , MainDeck = 44, SideDeck = 4, ExtraDeck = 2, ArchetypeName = "Impcantation", PlayerNumber = 59},
            new Deck{   DeckName = "Caballero Ígneo" , MainDeck = 43, SideDeck = 6, ExtraDeck = 3, ArchetypeName = "Igknight", PlayerNumber = 13},
            new Deck{   DeckName = "Tú Serás Mi Héroe" , MainDeck = 42, SideDeck = 8, ExtraDeck = 6, ArchetypeName = "Heroic", PlayerNumber = 15},
            new Deck{   DeckName = "Grovyle" , MainDeck = 41, SideDeck = 9, ExtraDeck = 5, ArchetypeName = "Graydle", PlayerNumber = 16},
            new Deck{   DeckName = "Go Yo" , MainDeck = 40, SideDeck = 7, ExtraDeck = 4, ArchetypeName = "Goyo", PlayerNumber = 18},
        };

            #endregion


            #region PlayersReplet

            #region Players
            Players = new List<Player>
            {
                new Player
                {
                    PlayerNumber = 1,
                    PlayerName = "Manuel Aguilar Gutierrez",
                    PlayerAddress = "Calzada de Luyano",
                    Municipality = "10 de Octubre",
                    Province = "La Habana",
                    PhoneNumber = "76484321",
                },
                new Player
                {
                    PlayerNumber = 2,
                    PlayerName = "Anabel Gonzalez Prieto",
                    PlayerAddress = "Calzada de Zapata",
                    Municipality = "Plaza",
                    Province = "La Habana",
                    PhoneNumber = "76224510"
                },
                new Player
                {
                    PlayerNumber = 3,
                    PlayerName = "Alexander Labrada Dominguez",
                    PlayerAddress = "Calzada del Cerro",
                    Municipality = "Cerro",
                    Province = "La Habana",
                    PhoneNumber = "76987623"
                },
                new Player
                {
                    PlayerNumber = 4,
                    PlayerName = "Luis Alberto Lopez Enriquez",
                    PlayerAddress = "Ave 3ra % 42 y 44",
                    Municipality = "Playa",
                    Province = "La Habana",
                    PhoneNumber = "72029413"
                },
                new Player
                {
                    PlayerNumber = 5,
                    PlayerName = "Luis Enrique Lopez Cueva",
                    PlayerAddress = "Ave 27a % 222 y 224",
                    Municipality = "La Lisa",
                    Province = "La Habana",
                    PhoneNumber = "72678546"
                },
                new Player
                {
                    PlayerNumber = 6,
                    PlayerName = "Juan Miguel Torres Hernandez",
                    PlayerAddress = "Ave 7ma % 60 y 62",
                    Municipality = "Playa",
                    Province = "La Habana",
                    PhoneNumber = "72072604"
                },
                new Player
                {
                    PlayerNumber = 7,
                    PlayerName = "Madelys Hernandez Hernandez",
                    PlayerAddress = "Ave 41 % 124 y 126",
                    Municipality = "Marianao",
                    Province = "La Habana",
                    PhoneNumber = "72435846"
                },
                new Player
                {
                    PlayerNumber = 8,
                    PlayerName = "Jose Alejandro Amat Navarrete",
                    PlayerAddress = "Ave 25 % 250 y 260",
                    Municipality = "La Lisa",
                    Province = "La Habana",
                    PhoneNumber = "72677421"
                },
                new Player
                {
                    PlayerNumber = 9,
                    PlayerName = "Alexis Pupo Rodriguez",
                    PlayerAddress = "Ave 13 % 68 y 70",
                    Municipality = "Playa",
                    Province = "La Habana",
                    PhoneNumber = "72071246"
                },
                new Player
                {
                    PlayerNumber = 10,
                    PlayerName = "Adrian Jimenez Garcia",
                    PlayerAddress = "Calzada de Infanta",
                    Municipality = "Centro Habana",
                    Province = "La Habana",
                    PhoneNumber = "72698741"
                },
                new Player
                {
                    PlayerNumber = 11,
                    PlayerName = "David Castillo Guerrero",
                    PlayerAddress = "Calle Belascoaín",
                    Municipality = "Centro Habana",
                    Province = "La Habana",
                    PhoneNumber = "77542145"
                },
                new Player
                {
                    PlayerNumber = 12,
                    PlayerName = "Ismelis Suarez Jimenez",
                    PlayerAddress = "Calle Línea % A y B",
                    Municipality = "Plaza",
                    Province = "La Habana",
                    PhoneNumber = "76488854"
                },
                new Player
                {
                    PlayerNumber = 13,
                    PlayerName = "Sheyla Cueto Cruz",
                    PlayerAddress = "Avenida de Acosta",
                    Municipality = "Guanabacoa",
                    Province = "La Habana",
                    PhoneNumber = "74875354"
                },
                new Player
                {
                    PlayerNumber = 14,
                    PlayerName = "Alejandro Cuevas Barreto",
                    PlayerAddress = "Calzada de Diez de Octubre",
                    Municipality = "10 de Octubre",
                    Province = "La Habana",
                    PhoneNumber = "76412532"
                },
                new Player
                {
                    PlayerNumber = 15,
                    PlayerName = "Humberto Frias Brito",
                    PlayerAddress = "Ave 51 % 220 y 222",
                    Municipality = "La Lisa",
                    Province = "La Habana",
                    PhoneNumber = "72726307"
                },
                new Player
                {
                    PlayerNumber = 16,
                    PlayerName = "Carlos Alberto Sainz Alvarez",
                    PlayerAddress = "Calle 222 % ave 25 y ave 27",
                    Municipality = "La Lisa",
                    Province = "La Habana",
                    PhoneNumber = "72698745"
                },
                new Player
                {
                    PlayerNumber = 17,
                    PlayerName = "Andres Junco Hechevarria",
                    PlayerAddress = "Ave 31 % 160 y 162",
                    Municipality = "Marianao",
                    Province = "La Habana",
                    PhoneNumber = "72785421"
                },
                new Player
                {
                    PlayerNumber = 18,
                    PlayerName = "Nicolas Fonseca Suarez",
                    PlayerAddress = "Malecón",
                    Municipality = "La Habana Vieja",
                    Province = "La Habana"
                },
                new Player
                {
                    PlayerNumber = 19,
                    PlayerName = "Juan Carlos Verdecia Montes",
                    PlayerAddress = "Avenida Carlos III",
                    Municipality = "Centro Habana",
                    Province = "La Habana"
                },
                new Player
                {
                    PlayerNumber = 20,
                    PlayerName = "Alfredo Polo Pupo",
                    PlayerAddress = "Calle 100 % 51 y 49",
                    Municipality = "Marianao",
                    Province = "La Habana"
                },
                new Player
                {
                    PlayerNumber = 21,
                    PlayerName = "Francisco Ibarra Cueto",
                    PlayerAddress = "Avenida Paseo",
                    Municipality = "Plaza",
                    Province = "La Habana"
                },
                new Player
                {
                    PlayerNumber = 22,
                    PlayerName = "Raul Alejandro Mora Loynaz",
                    PlayerAddress = "Calle Infanta",
                    Municipality = "Centro Habana",
                    Province = "La Habana"
                },
                new Player
                {
                    PlayerNumber = 23,
                    PlayerName = "Ariel Huerta Herrera",
                    PlayerAddress = "Ave 43 % 180 y 190",
                    Municipality = "La Lisa",
                    Province = "La Habana",
                    PhoneNumber = "72728536"
                },
                new Player
                {
                    PlayerNumber = 24,
                    PlayerName = "Andres Manuel Lottie Hernandez",
                    PlayerAddress = "Avenida de Santa Catalina",
                    Municipality = "10 de Octubre",
                    Province = "La Habana"
                },
                new Player
                {
                    PlayerNumber = 25,
                    PlayerName = "Daniel Ruiz Reyes",
                    PlayerAddress = "Plaza del Carmen",
                    Municipality = "Camagüey",
                    Province = "Camagüey",
                    PhoneNumber = "32289562"
                },
                new Player
                {
                    PlayerNumber = 26,
                    PlayerName = "Abel Cruz Moreno",
                    PlayerAddress = "Carretera Central",
                    Municipality = "Esmeralda",
                    Province = "Camagüey",
                    PhoneNumber = "32254122"
                },
                new Player
                {
                    PlayerNumber = 27,
                    PlayerName = "Carlos Javier Verdecie Mijenez",
                    PlayerAddress = "Carretera Central",
                    Municipality = "Céspedes",
                    Province = "Camagüey",
                    PhoneNumber = "32241146"
                },
                new Player
                {
                    PlayerNumber = 28,
                    PlayerName = "Ana Camila Figueroa Tejeda",
                    PlayerAddress = "Avenida Finlay",
                    Municipality = "Florida",
                    Province = "Camagüey",
                    PhoneNumber = "32211475"
                },
                new Player
                {
                    PlayerNumber = 29,
                    PlayerName = "Marcos Alexander Guzman Moreno",
                    PlayerAddress = "Avenida 26  de Julio",
                    Municipality = "Nuevitas",
                    Province = "Camagüey",
                    PhoneNumber = "32256245"
                },
                new Player
                {
                    PlayerNumber = 30,
                    PlayerName = "Fidel Martinez Polvorosa",
                    PlayerAddress = "Avenida de los Mártires",
                    Municipality = "Santa Lucía",
                    Province = "Camagüey",
                    PhoneNumber = "32243467"
                },
                new Player
                {
                    PlayerNumber = 31,
                    PlayerName = "Ryosuke Tsujimura",
                    PlayerAddress = "Sendai",
                    Municipality = "Prefectura de Miyagi",
                    Province = "Töhoku",
                    PhoneNumber = "816534652"
                },
                new Player
                {
                    PlayerNumber = 32,
                    PlayerName = "Ryan Yu",
                    PlayerAddress = "Tsu",
                    Municipality = "Prefectura de Mie",
                    Province = "Kinki",
                    PhoneNumber = "817654321"
                },
                new Player
                {
                    PlayerNumber = 33,
                    PlayerName = "Ryota Kagei",
                    PlayerAddress = "Tokushima",
                    Municipality = "Prefectura de Tokushima",
                    Province = "Shikoku",
                    PhoneNumber = "819234567"
                },
                new Player
                {
                    PlayerNumber = 34,
                    PlayerName = "Akira Hasegawa",
                    PlayerAddress = "Yokohama",
                    Municipality = "Prefectura de Kanagawa",
                    Province = "Kantö",
                    PhoneNumber = "812345671"
                },
                new Player
                {
                    PlayerNumber = 35,
                    PlayerName = "Louis Takashi Hinkison",
                    PlayerAddress = "Killarney",
                    Municipality = "Condado de Kerry",
                    Province = "Munster",
                    PhoneNumber = "353546787"
                },
                new Player
                {
                    PlayerNumber = 36,
                    PlayerName = "Taishi Okamoto",
                    PlayerAddress = "Morioka",
                    Municipality = "Prefectura de Iwate",
                    Province = "Töhoku",
                    PhoneNumber = "813676654"
                },
                new Player
                {
                    PlayerNumber = 37,
                    PlayerName = "Ryuhei Arikawa",
                    PlayerAddress = "Kanazawa",
                    Municipality = "Prefectura de Ishikawa",
                    Province = "Chübu",
                    PhoneNumber = "813344256"
                },
                new Player
                {
                    PlayerNumber = 38,
                    PlayerName = "Seung-Chul Jung",
                    PlayerAddress = "Sisadan",
                    Municipality = "Andong",
                    Province = "Gyeongsang del Norte",
                    PhoneNumber = "823456763"
                },
                new Player
                {
                    PlayerNumber = 39,
                    PlayerName = "Low Weng Fong",
                    PlayerAddress = "Distrito Dongpo",
                    Municipality = "Meishan",
                    Province = "Sichuan",
                    PhoneNumber = "864512356"
                },
                new Player
                {
                    PlayerNumber = 40,
                    PlayerName = "Wang Chia Ching",
                    PlayerAddress = "Condado Renshou",
                    Municipality = "Meishan",
                    Province = "Sichuan",
                    PhoneNumber = "864115236"
                },
                new Player
                {
                    PlayerNumber = 41,
                    PlayerName = "Gabriel Vargas",
                    PlayerAddress = "Guadalajara",
                    Municipality = "Guadalajara",
                    Province = "Jalisco",
                    PhoneNumber = "526437829"
                },
                new Player
                {
                    PlayerNumber = 42,
                    PlayerName = "Isaiah Joseph",
                    PlayerAddress = "Covent Garden",
                    Municipality = "Westminster",
                    Province = "Londres",
                    PhoneNumber = "446756787"
                },
                new Player
                {
                    PlayerNumber = 43,
                    PlayerName = "Jesse Kotton",
                    PlayerAddress = "Chelsea",
                    Municipality = "Kensington y Chelsea",
                    Province = "Londres",
                    PhoneNumber = "445678112"
                },
                new Player
                {
                    PlayerNumber = 44,
                    PlayerName = "Walter Jule",
                    PlayerAddress = "Camberwell",
                    Municipality = "Southwark",
                    Province = "Londres"
                },
                new Player
                {
                    PlayerNumber = 45,
                    PlayerName = "Brian Rayos",
                    PlayerAddress = "Plaza Rocha",
                    Municipality = "La Plata",
                    Province = "Buenos Aires",
                    PhoneNumber = "546564635"
                },
                new Player
                {
                    PlayerNumber = 46,
                    PlayerName = "Ryan Levine",
                    PlayerAddress = "Langdon",
                    Municipality = "Cavalier",
                    Province = "Dakota del Norte"
                },
                new Player
                {
                    PlayerNumber = 47,
                    PlayerName = "Alejandro García",
                    PlayerAddress = "San Pedro",
                    Municipality = "San Pedro",
                    Province = "Coahuila de Zaragoza",
                    PhoneNumber = "523453245"
                },
                new Player
                {
                    PlayerNumber = 48,
                    PlayerName = "Roger Guzmán",
                    PlayerAddress = "Santa Rita",
                    Municipality = "Acatic",
                    Province = "Jalisco"
                },
                new Player
                {
                    PlayerNumber = 49,
                    PlayerName = "Jeferson Salas",
                    PlayerAddress = "Chatom",
                    Municipality = "Condado de Washington",
                    Province = "Alabama"
                },
                new Player
                {
                    PlayerNumber = 50,
                    PlayerName = "Galileo de Obaldia",
                    PlayerAddress = "Plaza Moreno",
                    Municipality = "La Plata",
                    Province = "Buenos Aires",
                    PhoneNumber = "546578943"
                },
                new Player
                {
                    PlayerNumber = 51,
                    PlayerName = "Luke Parkes",
                    PlayerAddress = "Leyton",
                    Municipality = "Waltham Forest",
                    Province = "Londres",
                    PhoneNumber = "443212345"
                },
                new Player
                {
                    PlayerNumber = 52,
                    PlayerName = "Darren Stephenson",
                    PlayerAddress = "Arjeplog",
                    Municipality = "Arjeplog",
                    Province = "Norrbotten",
                    PhoneNumber = "465463743"
                },
                new Player
                {
                    PlayerNumber = 53,
                    PlayerName = "Francesco Simoncelli",
                    PlayerAddress = "Celio",
                    Municipality = "Centro Storico",
                    Province = "Roma",
                    PhoneNumber = "394357521"
                },
                new Player
                {
                    PlayerNumber = 54,
                    PlayerName = "Matteo Mordanini",
                    PlayerAddress = "Tor San Giovanni",
                    Municipality = "Monte Sacro",
                    Province = "Roma",
                    PhoneNumber = "394674321"
                },
                new Player
                {
                    PlayerNumber = 55,
                    PlayerName = "Loan Cité-Mielle",
                    PlayerAddress = "Avenida de los Campos Elíseos",
                    Municipality = "París",
                    Province = "Isla de Francia",
                    PhoneNumber = "330134457"
                },
                new Player
                {
                    PlayerNumber = 56,
                    PlayerName = "Joshua Schmidt",
                    PlayerAddress = "Moscú",
                    Municipality = "Moscú",
                    Province = "Distrito Federal Central",
                    PhoneNumber = "749632546"
                },
                new Player
                {
                    PlayerNumber = 57,
                    PlayerName = "Poe Jiang",
                    PlayerAddress = "Distrito Yaohai",
                    Municipality = "Hefei",
                    Province = "Anhui",
                    PhoneNumber = "867549087"
                },
                new Player
                {
                    PlayerNumber = 58,
                    PlayerName = "Bohdan Temnyk",
                    PlayerAddress = "Baganuur",
                    Municipality = "Ulán Bator",
                    Province = "Ulán Bator",
                    PhoneNumber = "976112345"
                },
                new Player
                {
                    PlayerNumber = 59,
                    PlayerName = "Naoki Shitagaki",
                    PlayerAddress = "Aomori",
                    Municipality = "Prefectura de Aomori",
                    Province = "Töhoku",
                    PhoneNumber = "813546574"
                },
                new Player
                {
                    PlayerNumber = 60,
                    PlayerName = "Yuto Koizumi",
                    PlayerAddress = "Toyama",
                    Municipality = "Prefectura de Toyama",
                    Province = "Chübu",
                    PhoneNumber = "813245321"
                },
                new Player
                {
                    PlayerNumber = 61,
                    PlayerName = "Ryo Kaneta",
                    PlayerAddress = "Binondo",
                    Municipality = "Manila",
                    Province = "Gran Manila",
                    PhoneNumber = "630098765"
                },
                new Player
                {
                    PlayerNumber = 62,
                    PlayerName = "Kyong-Min Kim",
                    PlayerAddress = "Distrito Paldal",
                    Municipality = "Suwon",
                    Province = "Gyeonggi",
                    PhoneNumber = "824563786"
                },
                new Player
                {
                    PlayerNumber = 63,
                    PlayerName = "Wu Hung Wei",
                    PlayerAddress = "Victoria",
                    Municipality = "Victoria",
                    Province = "Hong Kong",
                    PhoneNumber = "868523456"
                },
                new Player
                {
                    PlayerNumber = 64,
                    PlayerName = "Charley Futch III",
                    PlayerAddress = "Hauptplatz",
                    Municipality = "Villach",
                    Province = "Carintia",
                    PhoneNumber = "430424231"
                },
                new Player
                {
                    PlayerNumber = 65,
                    PlayerName = "William Candia",
                    PlayerAddress = "Springfield",
                    Municipality = "Condado de Sangamon",
                    Province = "Illinois"
                },
                new Player
                {
                    PlayerNumber = 66,
                    PlayerName = "Alan Martínez",
                    PlayerAddress = "Los Remedios",
                    Municipality = "Sevilla",
                    Province = "Andalucía",
                    PhoneNumber = "345668431"
                },
                new Player
                {
                    PlayerNumber = 67,
                    PlayerName = "Diego Romero",
                    PlayerAddress = "Huerta de Murcia",
                    Municipality = "Murcia",
                    Province = "Región de Murcia",
                    PhoneNumber = "345678908"
                },
                new Player
                {
                    PlayerNumber = 68,
                    PlayerName = "Kai Heidinger",
                    PlayerAddress = " Zona Söderort , Distrito Farsta",
                    Municipality = "Estocolmo",
                    Province = "Provincia de Estocolmo",
                    PhoneNumber = "460867854"
                },
                new Player
                {
                    PlayerNumber = 69,
                    PlayerName = "Aidan Appel",
                    PlayerAddress = "Soukbunar",
                    Municipality = "Centar",
                    Province = "Cantón de Sarajevo",
                    PhoneNumber = "387456321"
                },
                new Player
                {
                    PlayerNumber = 70,
                    PlayerName = "James English",
                    PlayerAddress = "Hoddle Grid",
                    Municipality = "Melbourne",
                    Province = "Victoria",
                    PhoneNumber = "615478964"
                },
                new Player
                {
                    PlayerNumber = 71,
                    PlayerName = "Timmy Chiew",
                    PlayerAddress = "Barrio de Karaköy",
                    Municipality = "Estambul",
                    Province = "Estambul"
                },
                new Player
                {
                    PlayerNumber = 72,
                    PlayerName = "Takahiro Hamada",
                    PlayerAddress = "Machiya",
                    Municipality = "Arakawa",
                    Province = "Tokio",
                    PhoneNumber = "813452145"
                },
                new Player
                {
                    PlayerNumber = 73,
                    PlayerName = "Ryoichi Kitahata",
                    PlayerAddress = "Kasai",
                    Municipality = "Edogawa",
                    Province = "Tokio",
                    PhoneNumber = "815438765"
                },
                new Player
                {
                    PlayerNumber = 74,
                    PlayerName = "Riki Yamamoto",
                    PlayerAddress = "Akabira",
                    Municipality = "Sorachi",
                    Province = "Hokkaido",
                    PhoneNumber = "814567891"
                },
                new Player
                {
                    PlayerNumber = 75,
                    PlayerName = "Yeom-Jun Lee",
                    PlayerAddress = "Condado de Boseong",
                    Municipality = "Muan",
                    Province = "Jeolla del Sur",
                    PhoneNumber = "822321234"
                },
                new Player
                {
                    PlayerNumber = 76,
                    PlayerName = "Roy Svinik",
                    PlayerAddress = "Izhevsk",
                    Municipality = "Udmurtia",
                    Province = "Volga",
                    PhoneNumber = "734124532"
                },
                new Player
                {
                    PlayerNumber = 77,
                    PlayerName = "Warizmi Thayib",
                    PlayerAddress = "Centro Cultural Kabwat",
                    Municipality = "Lusaka",
                    Province = "Lusaka",
                    PhoneNumber = "260014565"
                },
                new Player
                {
                    PlayerNumber = 78,
                    PlayerName = "Alex Cheung",
                    PlayerAddress = "Isla de Shamian",
                    Municipality = "Cantón",
                    Province = "Guandong",
                    PhoneNumber = "860205221"
                },
                new Player
                {
                    PlayerNumber = 79,
                    PlayerName = "Josh Cooper",
                    PlayerAddress = "Hollywood",
                    Municipality = "Los Ángeles",
                    Province = "California",
                    PhoneNumber = "196598256"
                },
                new Player
                {
                    PlayerNumber = 80,
                    PlayerName = "Jason Chu",
                    PlayerAddress = "Delta del río de Las Perlas",
                    Municipality = "Cantón",
                    Province = "Guandong",
                    PhoneNumber = "860204534"
                },
                new Player
                {
                    PlayerNumber = 81,
                    PlayerName = "Charlie Whyborne",
                    PlayerAddress = "Baldía",
                    Municipality = "Distrito de Karachi",
                    Province = "Sind",
                    PhoneNumber = "920023456"
                },
                new Player
                {
                    PlayerNumber = 82,
                    PlayerName = "Miguel Alberto Moura Azevedo",
                    PlayerAddress = "Comuna Manrique",
                    Municipality = "Medellín",
                    Province = "Antioquía",
                    PhoneNumber = "574325676"
                },
                new Player
                {
                    PlayerNumber = 83,
                    PlayerName = "Marjo Jahaj",
                    PlayerAddress = "Zona 1 Ward B",
                    Municipality = "Bombay",
                    Province = "Maharashtra",
                    PhoneNumber = "910022541"
                }
            };

            foreach (var player in Players)
            {
                player.DecksName = new List<string>();
                for (int i = 0; i < Decks.Count; i++)
                {
                    if (Decks[i].PlayerNumber == player.PlayerNumber)
                    {
                        player.DecksName.Add(Decks[i].DeckName);
                    }
                }
            }
            #endregion

            #endregion


            #region ContestsReplet

            Contests = new List<ContestPlay>
            {
                new ContestPlay {ContestName = "Yu-Gi-Oh! Championship Series Milan 2018", ContestNumber = 0, ContestDate = new DateTime(2018,12,8,8,30,0),ContestAddress = "Malpensa Fiere,Via XI Settembre, 16,21052, Busto Arsizio VA,Italy"},
                new ContestPlay {ContestName = "Yu-Gi-Oh! Championship Series Dusseldorf 2019", ContestNumber = 1, ContestDate = new DateTime(2019,2,23,9,0,0),ContestAddress = "Dusseldorf Congress Sport & Event,Stockumer Kirchstraße 61,40474 Düsseldorf,Germany."},
                new ContestPlay {ContestName = "Yu-Gi-Oh! Championship Series London 2018", ContestNumber = 2,ContestDate = new DateTime(2018,10,27,10,0,0),ContestAddress = "MCM Comic Con London ExCel,London 1 Western Gateway,Royal Victoria Dock London, E16 1XL"},
                new ContestPlay {ContestName = "Yu-Gi-Oh! Championship Series Utrecht 2018" ,ContestNumber = 3, ContestDate = new DateTime(2018,09,22,20,30,0),ContestAddress = "Hal 1,Jaarbeurs,Beatrixgebouw,Jaarbeursplein 1,3521 AL,Utrecht,The Netherlands."}
            };

            int pCountTotal = _rd.Next(60, 81);
            int pCount0 = pCountTotal/4;

            int roundCount = 3;
            int cRoundCount = pCount0 == 10 ? 1 : (pCount0 <= 20 ? 2 : 3);

            for (int i = 0; i < Contests.Count; i++)
            {
                Contests[i].RoundNumber = new List<int>();
                for (int j = 1; j < cRoundCount + roundCount + 1; j++)
                    Contests[i].RoundNumber.Add(j);
            }

            #endregion


            #region ParticipantsReplet           

            //classification round
            int lastContestName = 0;

            foreach (var contest in Contests)
            {
                bool[] mask = new bool[Players.Count];
                int number = Participants.Count + 1;
                int initContest = Participants.Count;

                int pCount = pCount0;

                while (pCount > 0)
                {
                    int take = _rd.Next(0, Players.Count);
                    if (mask[take]) continue;

                    Participants.Add(new Participant { PlayerNumber = Players[take].PlayerNumber });
                    Participants[Participants.Count - 1].ParticipantNumber = number++;
                    Participants[Participants.Count - 1].ContestName = contest.ContestName;

                    int d = _rd.Next(0, Players[take].DecksCount);
                    Participants[Participants.Count - 1].DeckName = Players[take].DecksName[d];

                    mask[take] = true;
                    pCount--;
                }
                
                //classification rounds replet in Contests
                ParticipantsInContestReplet(initContest, Participants.Count - 1, lastContestName++);
            }

            #endregion


            #region ArchetypesReplet

            Archetypes = new List<Archetype>
        {
            new Archetype { ArchetypeName = "Bujin"},
            new Archetype { ArchetypeName = "Madolche"},
            new Archetype { ArchetypeName = "Geargia"},
            new Archetype { ArchetypeName = "Plants"},
            new Archetype { ArchetypeName = "Spellbook"},
            new Archetype { ArchetypeName = "Fire Fist"},
            new Archetype { ArchetypeName = "Chronomaly"},
            new Archetype { ArchetypeName = "Lightsworn"},
            new Archetype { ArchetypeName = "Mermail"},
            new Archetype { ArchetypeName = "Harpie"},
            new Archetype { ArchetypeName = "Dragon Variants"},
            new Archetype { ArchetypeName = "Chaos Dragon"},
            new Archetype { ArchetypeName = "Noble Knight"},
            new Archetype { ArchetypeName = "Cyber Dragon"},
            new Archetype { ArchetypeName = "Gravekeeper's"},
            new Archetype { ArchetypeName = "Photon"},
            new Archetype { ArchetypeName = "Ghostrick"},
            new Archetype { ArchetypeName = "Karakuri"},
            new Archetype { ArchetypeName = "Hieratic"},
            new Archetype { ArchetypeName = "Artifact"},
            new Archetype { ArchetypeName = "Mecha Phantom Beast"},
            new Archetype { ArchetypeName = "Monarch"},
            new Archetype { ArchetypeName = "Battlin'Boxer"},
            new Archetype { ArchetypeName = "Spirit Deck"},
            new Archetype { ArchetypeName = "Fire King"},
            new Archetype { ArchetypeName = "Dark World"},
            new Archetype { ArchetypeName = "T.G."},
            new Archetype { ArchetypeName = "Scrap"},
            new Archetype { ArchetypeName = "Anti-Meta"},
            new Archetype { ArchetypeName = "Infernity"},
            new Archetype { ArchetypeName = "Gladiator Beast"},
            new Archetype { ArchetypeName = "Blackwing"},
            new Archetype { ArchetypeName = "Gadget"},
            new Archetype { ArchetypeName = "Constellar"},
            new Archetype { ArchetypeName = "Agents"},
            new Archetype { ArchetypeName = "Evilswarm"},
            new Archetype { ArchetypeName = "Galaxy"},
            new Archetype { ArchetypeName = "Zombie"},
            new Archetype { ArchetypeName = "Hunder"},
            new Archetype { ArchetypeName = "Six Samurai"},
            new Archetype { ArchetypeName = "Watt"},
            new Archetype { ArchetypeName = "Inzektor"},
            new Archetype { ArchetypeName = "Ancient Gear"},
            new Archetype { ArchetypeName = "Tanuki"},
            new Archetype { ArchetypeName = "Heraldic"},
            new Archetype { ArchetypeName = "Koa'ki Meiru"},
            new Archetype { ArchetypeName = "Evolsaur"},
            new Archetype { ArchetypeName = "Shark"},
            new Archetype { ArchetypeName = "Laval"},
            new Archetype { ArchetypeName = "Chain Beat"},
            new Archetype { ArchetypeName = "Umbral Horror"},
            new Archetype { ArchetypeName = "Malefic"},
            new Archetype { ArchetypeName = "Archfiend"},
            new Archetype { ArchetypeName = "Frog"},
            new Archetype { ArchetypeName = "HERO Variants"},
            new Archetype { ArchetypeName = "Psychics"},
            new Archetype { ArchetypeName = "Chain Burn"},
            new Archetype { ArchetypeName = "Wind-Up"},
            new Archetype { ArchetypeName = "Gogogo"},
            new Archetype { ArchetypeName = "Gusto"},
            new Archetype { ArchetypeName = "Dragunity"},
            new Archetype { ArchetypeName = "X-Saber"},
            new Archetype { ArchetypeName = "Synchron"},
            new Archetype { ArchetypeName = "Rank Up Magic"},
            new Archetype { ArchetypeName = "Rock stun"},
            new Archetype { ArchetypeName = "Hazy Flame"},
            new Archetype { ArchetypeName = "Traptrix"},
            new Archetype { ArchetypeName = "Flamwell"},
            new Archetype { ArchetypeName = "Penguins"},
            new Archetype { ArchetypeName = "Cyber Dark"},
            new Archetype { ArchetypeName = "Duston"},
            new Archetype { ArchetypeName = "Dark Magician"},
            new Archetype { ArchetypeName = "Thunder"},
            new Archetype { ArchetypeName = "Number C"},
            new Archetype { ArchetypeName = "Junk Doppel"},
            new Archetype { ArchetypeName = "Naturia"},
            new Archetype { ArchetypeName = "Worm"},
            new Archetype { ArchetypeName = "Vampire"},
            new Archetype { ArchetypeName = "Number"},
            new Archetype { ArchetypeName = "Ice Barrier"},
            new Archetype { ArchetypeName = "Gimmick Puppet"},
            new Archetype { ArchetypeName = "Crystal Beast"},
            new Archetype { ArchetypeName = "Ninja"},
            new Archetype { ArchetypeName = "Gagaga"},
            new Archetype { ArchetypeName = "Utopia"},
            new Archetype { ArchetypeName = "Shinra"},
            new Archetype { ArchetypeName = "Dododo"},
            new Archetype { ArchetypeName = "Nordic"},
            new Archetype { ArchetypeName = "Jurrac"},
            new Archetype { ArchetypeName = "Fabled"},
            new Archetype { ArchetypeName = "Volcanic"},
            new Archetype { ArchetypeName = "Mist Valley"},
            new Archetype { ArchetypeName = "Morphtronic"},
            new Archetype { ArchetypeName = "Alien"},
            new Archetype { ArchetypeName = "Fortune Lady"},
            new Archetype { ArchetypeName = "Gem-Knight"},
            new Archetype { ArchetypeName = "Exodia"},
            new Archetype { ArchetypeName = "Battery man"},
            new Archetype { ArchetypeName = "Spider"},
            new Archetype { ArchetypeName = "Roid"},
            new Archetype { ArchetypeName = "Nimble"},
            new Archetype { ArchetypeName = "Cloudian"},
            new Archetype { ArchetypeName = "Dark Scorpion"},
            new Archetype { ArchetypeName = "ZW -"},
            new Archetype { ArchetypeName = "Iron Chain"},
            new Archetype { ArchetypeName = "Bounzer"},
            new Archetype { ArchetypeName = "Guardian"},
            new Archetype { ArchetypeName = "Inmato"},
            new Archetype { ArchetypeName = "Vylon"},
            new Archetype { ArchetypeName = "Fortune Fairy"},
            new Archetype { ArchetypeName = "Majestic"},
            new Archetype { ArchetypeName = "Resonator"},
            new Archetype { ArchetypeName = "Neos"},
            new Archetype { ArchetypeName = "EarthBound Inmortal"},
            new Archetype { ArchetypeName = "Gishki"},
            new Archetype { ArchetypeName = "Ojama"},
            new Archetype { ArchetypeName = "Yubel"},
            new Archetype { ArchetypeName = "Ally of Justice"},
            new Archetype { ArchetypeName = "Reptillianne"},
            new Archetype { ArchetypeName = "Vehicroid"},
            new Archetype { ArchetypeName = "Venom"},
            new Archetype { ArchetypeName = "Amazoness"},
            new Archetype { ArchetypeName = "Malicevorous"},
            new Archetype { ArchetypeName = "Horus the Black Flame"},
            new Archetype { ArchetypeName = "Arcana Force"},
            new Archetype { ArchetypeName = "Nitro"},
            new Archetype { ArchetypeName = "Slime"},
            new Archetype { ArchetypeName = "Toon"},
            new Archetype { ArchetypeName = "Genex"},
            new Archetype { ArchetypeName = "Djinn"},
            new Archetype { ArchetypeName = "Fossil"},
            new Archetype { ArchetypeName = "Granel"},
            new Archetype { ArchetypeName = "Koala"},
            new Archetype { ArchetypeName = "Meklord"},
            new Archetype { ArchetypeName = "Symphonic Warrior"},
            new Archetype { ArchetypeName = "Toy"},
            new Archetype { ArchetypeName = "Wisel"},
            new Archetype { ArchetypeName = "Yomi"},
            new Archetype { ArchetypeName = "Satelaknights"},
            new Archetype { ArchetypeName = "Ryuusei"},
            new Archetype { ArchetypeName = "Allure Queen"},
            new Archetype { ArchetypeName = "Assassin"},
            new Archetype { ArchetypeName = "B.E.S."},
            new Archetype { ArchetypeName = "Bamboo Sword"},
            new Archetype { ArchetypeName = "Butterfly"},
            new Archetype { ArchetypeName = "Butterspy"},
            new Archetype { ArchetypeName = "Cat"},
            new Archetype { ArchetypeName = "Chrysalis"},
            new Archetype { ArchetypeName = "Clear"},
            new Archetype { ArchetypeName = "Comics Hero"},
            new Archetype { ArchetypeName = "Cyber Angel"},
            new Archetype { ArchetypeName = "Elf"},
            new Archetype { ArchetypeName = "Ivy"},
            new Archetype { ArchetypeName = "Jester"},
            new Archetype { ArchetypeName = "Junk Robot"},
            new Archetype { ArchetypeName = "Landstar"},
            new Archetype { ArchetypeName = "Magnet"},
            new Archetype { ArchetypeName = "Motor"},
            new Archetype { ArchetypeName = "Reactor"},
            new Archetype { ArchetypeName = "R-Genex"},
            new Archetype { ArchetypeName = "Skiel"},
            new Archetype { ArchetypeName = "Sphere"},
            new Archetype { ArchetypeName = "Sphinx"},
            new Archetype { ArchetypeName = "Spirit Message"},
            new Archetype { ArchetypeName = "Star Seraph"},
            new Archetype { ArchetypeName = "Timelord"},
            new Archetype { ArchetypeName = "Valkyrie"},
            new Archetype { ArchetypeName = "Clown Control"},
                 new Archetype { ArchetypeName = "Aesir"},
            new Archetype { ArchetypeName = "Abyss Actor"},
            new Archetype { ArchetypeName = "Altergeist"},
            new Archetype { ArchetypeName = "Amorphage"},
            new Archetype { ArchetypeName = "Acuaaqctress"},
            new Archetype { ArchetypeName = "Armed Dragon"},
            new Archetype { ArchetypeName = "Aromage"},
            new Archetype { ArchetypeName = "Assault Mode"},
            new Archetype { ArchetypeName = "Atlantean"},
            new Archetype { ArchetypeName = "Black Luster"},
            new Archetype { ArchetypeName = "Blue-Eyes"},
            new Archetype { ArchetypeName = "Burning Abyss"},
            new Archetype { ArchetypeName = "Buster Blade"},
            new Archetype { ArchetypeName = "Chaos"},
            new Archetype { ArchetypeName = "Chemicritter"},
            new Archetype { ArchetypeName = "Cipher"},
            new Archetype { ArchetypeName = "Crusadia"},
            new Archetype { ArchetypeName = "Cryston"},
            new Archetype { ArchetypeName = "Cubic"},
            new Archetype { ArchetypeName = "Cyber"},
            new Archetype { ArchetypeName = "D/D/"},
            new Archetype { ArchetypeName = "Danger!"},
            new Archetype { ArchetypeName = "D.D."},
            new Archetype { ArchetypeName = "Deskbot"},
            new Archetype { ArchetypeName = "Darklord"},
            new Archetype { ArchetypeName = "Destiny Hero"},
            new Archetype { ArchetypeName = "Digital Bug"},
            new Archetype { ArchetypeName = "Dinomist"},
            new Archetype { ArchetypeName = "Dinowrestler"},
            new Archetype { ArchetypeName = "Dracoslayer"},
            new Archetype { ArchetypeName = "Dragon Ruler"},
            new Archetype { ArchetypeName = "Edge Imp"},
            new Archetype { ArchetypeName = "Elemental Hero"},
            new Archetype { ArchetypeName = "Elementsaber"},
            new Archetype { ArchetypeName = "Empowered Warrior"},
            new Archetype { ArchetypeName = "Endymion"},
            new Archetype { ArchetypeName = "Evil Eye"},
            new Archetype { ArchetypeName = "Evil Hero"},
            new Archetype { ArchetypeName = "Evoltile"},
            new Archetype { ArchetypeName = "F.A."},
            new Archetype { ArchetypeName = "Familiar-Possessed"},
            new Archetype { ArchetypeName = "Fluffal"},
            new Archetype { ArchetypeName = "Frightfur"},
            new Archetype { ArchetypeName = "Fure Hire"},
            new Archetype { ArchetypeName = "Gaia"},
            new Archetype { ArchetypeName = "Ganbara"},
            new Archetype { ArchetypeName = "Goblin"},
            new Archetype { ArchetypeName = "Gorgonic"},
            new Archetype { ArchetypeName = "Gouki"},
            new Archetype { ArchetypeName = "Goyo"},
            new Archetype { ArchetypeName = "Graydle"},
            new Archetype { ArchetypeName = "Heroic"},
            new Archetype { ArchetypeName = "Igknight"},
            new Archetype { ArchetypeName = "Impcantation"},
            new Archetype { ArchetypeName = "Infernoid"},
            new Archetype { ArchetypeName = "Infinitrack"},
            new Archetype { ArchetypeName = "Invoked"},
            new Archetype { ArchetypeName = "Kaiju"},
            new Archetype { ArchetypeName = "Kozmo"},
            new Archetype { ArchetypeName = "Krawler"},
            new Archetype { ArchetypeName = "Lightray"},
            new Archetype { ArchetypeName = "Lunalight"},
            new Archetype { ArchetypeName = "Lyrilusc"},
            new Archetype { ArchetypeName = "Magical Musket"},
            new Archetype { ArchetypeName = "Magician"},
            new Archetype { ArchetypeName = "Mayakashi"},
            new Archetype { ArchetypeName = "Melodious"},
            new Archetype { ArchetypeName = "Mekk-Knight"},
            new Archetype { ArchetypeName = "Metalfoes"},
            new Archetype { ArchetypeName = "Metaphys"},
            new Archetype { ArchetypeName = "Mystical Beast"},
            new Archetype { ArchetypeName = "Nekroz"},
            new Archetype { ArchetypeName = "Neo-Spacian"},
            new Archetype { ArchetypeName = "Nephthys"},
            new Archetype { ArchetypeName = "Odd-Eyes"},
            new Archetype { ArchetypeName = "Orcust"},
            new Archetype { ArchetypeName = "Paleozoic"},
            new Archetype { ArchetypeName = "Parshath"},
            new Archetype { ArchetypeName = "Performage"},
            new Archetype { ArchetypeName = "Perfomapal"},
            new Archetype { ArchetypeName = "Phantasm Spiral"},
            new Archetype { ArchetypeName = "Prank-Kids"},
            new Archetype { ArchetypeName = "Predaplant"},
            new Archetype { ArchetypeName = "PSY-Framegear"},
            new Archetype { ArchetypeName = "Qli"},
            new Archetype { ArchetypeName = "Raidraptor"},
            new Archetype { ArchetypeName = "Red-Eyes"},
            new Archetype { ArchetypeName = "Risebell"},
            new Archetype { ArchetypeName = "Ritual Beast"},
            new Archetype { ArchetypeName = "Prediction Princess"},
            new Archetype { ArchetypeName = "Roid"},
            new Archetype { ArchetypeName = "Rokket"},
            new Archetype { ArchetypeName = "Rose"},
            new Archetype { ArchetypeName = "Shiranui"},
            new Archetype { ArchetypeName = "Shinobird"},
            new Archetype { ArchetypeName = "Shaddoll"},
            new Archetype { ArchetypeName = "Salamangreat"},
            new Archetype { ArchetypeName = "Silent Magician"},
            new Archetype { ArchetypeName = "Silent Swordsman"},
            new Archetype { ArchetypeName = "Skull Servant"},
            new Archetype { ArchetypeName = "Sky Striker"},
            new Archetype { ArchetypeName = "Speedroid"},
            new Archetype { ArchetypeName = "Spyral"},
            new Archetype { ArchetypeName = "Spellcaster"},
            new Archetype { ArchetypeName = "Tellarknight"},
            new Archetype { ArchetypeName = "Sylvan"},
            new Archetype { ArchetypeName = "Superheavy Samurai"},
            new Archetype { ArchetypeName = "Subterror"},
            new Archetype { ArchetypeName = "Steelswarm"},
            new Archetype { ArchetypeName = "The Weather"},
            new Archetype { ArchetypeName = "Tindangle"},
            new Archetype { ArchetypeName = "Trickstar"},
            new Archetype { ArchetypeName = "True King"},
            new Archetype { ArchetypeName = "Twilightsworn"},
            new Archetype { ArchetypeName = "U.A."},
            new Archetype { ArchetypeName = "Vassal"},
            new Archetype { ArchetypeName = "Vendread"},
            new Archetype { ArchetypeName = "Windwitch"},
            new Archetype { ArchetypeName = "Witchcrafter"},
            new Archetype { ArchetypeName = "World Chalice"},
            new Archetype { ArchetypeName = "World Legacy"},
            new Archetype { ArchetypeName = "Yang Zing"},
            new Archetype { ArchetypeName = "Yosenju"},
            new Archetype { ArchetypeName = "Zefra"},
            new Archetype { ArchetypeName = "Zoodiac"},
            new Archetype { ArchetypeName = "Zubaba"},
            new Archetype { ArchetypeName = "Mixed"},
        };

            #endregion


            #region GamesReplet

            var c_roundControl = new List<List<Tuple<bool,int>>>();

            for (int i = 0; i < Contests.Count; i++)
            {
                int iGame;
                c_roundControl.Add(new List<Tuple<bool, int>>());
                MatchSimulate(cRoundCount, c_roundControl[c_roundControl.Count - 1], i, out iGame);
                GameSimulate(c_roundControl[c_roundControl.Count - 1], i, iGame);
            }

            #endregion


            #region RoundsReplet
            
            int k = 0;
            int roundCurrent = 0;
            int cRound = 1;
            int eRound = 1;

            int cRoundCurrent = 0;
            int eRoundCurrent = 0;

            foreach (var c in Contests)
            {
                Rounds.Add(new List<Round>());

                int round = 1;
                int rC = roundCount;
                int cRC = cRoundCount;

                while (rC + cRC > 0)
                {
                    if (cRC > 0)
                    {
                        Rounds[Rounds.Count - 1].Add(new Round { RoundNumber = round, Type = Models.Type.Classification, ClassificationRoundNumber = cRound.ToString() });
                        ClassificationRound.Add(new ClassificationRound {RoundNumber = round++ , ClassificationRoundNumber = cRound.ToString() });
                        cRound++;
                        cRC--;
                    }
                    else
                    {
                        Rounds[Rounds.Count - 1].Add(new Round { RoundNumber = round, Type = Models.Type.Elimination, EliminationRoundNumber = eRound.ToString() });
                        EliminationRound.Add(new EliminationRound { RoundNumber = round++ ,EliminationRoundNumber = eRound.ToString() });
                        eRound++;
                        rC--;
                    }
                }

                //games in Classification Round and Elimination Round
                int last = c_roundControl[k][0].Item2;
                int c_index = cRoundCurrent;
                int e_index = eRoundCurrent;
                bool chains = false;

                int c_indexSave = c_index;

                ClassificationRound[c_index].GamesClassification = new List<int>();
                ClassificationRound[c_index].Participant_Puntuation = new List<Tuple<int, int>>();

                EliminationRound[e_index].GamesElimination = new List<int>();

                for (int i = 0; i < c_roundControl[k].Count; i++)
                {
                    if (c_roundControl[k][i].Item1)
                    {
                        if (last != c_roundControl[k][i].Item2)
                        {
                            c_index++;

                            ClassificationRound[c_index].GamesClassification = new List<int>();
                            ClassificationRound[c_index].Participant_Puntuation = new List<Tuple<int, int>>();

                            last = c_roundControl[k][i].Item2;
                        }
                        ClassificationRound[c_index].GamesClassification.Add(Games[i + (k * c_roundControl[k].Count)].GameNumber);
                    }
                    else
                    {
                        if (!chains)
                        {
                            last = c_roundControl[k][i].Item2;
                            chains = true;
                        }
                        else if (last != c_roundControl[k][i].Item2)
                        {
                            e_index++;
                            EliminationRound[e_index].GamesElimination = new List<int>();

                            last = c_roundControl[k][i].Item2;
                        }
                        EliminationRound[e_index].GamesElimination.Add(Games[i + (k * c_roundControl[k].Count)].GameNumber);
                    }
                }

                int c_indexLastSave = c_index;

                //part_punt in c_round replet
                Participants_PuntuationRepletForEachClassificationRound(c_indexSave, c_indexLastSave);

                //games for each round replet
                int pivot = k * c_roundControl[k].Count;
                for (int i = 0; i < Rounds[roundCurrent].Count; i++)
                {
                    Rounds[roundCurrent][i].GameNumber = new List<int>();
                    Rounds[roundCurrent][i].ParticipantsNumber = new List<int>();

                    for (int j = pivot; j < (k + 1) * c_roundControl[k].Count; j++)
                    {
                        if (c_roundControl[k][j % c_roundControl[k].Count].Item2 != Rounds[roundCurrent][i].RoundNumber)
                        {
                            pivot = j;
                            break;
                        }
                        Rounds[roundCurrent][i].GameNumber.Add(Games[j].GameNumber);
                        Rounds[roundCurrent][i].ParticipantsNumber.Add(Games[j].ParticipantsNumber[0]);
                        Rounds[roundCurrent][i].ParticipantsNumber.Add(Games[j].ParticipantsNumber[1]);
                    }
                }
                
                k++;
                roundCurrent++;

                cRoundCurrent = ClassificationRound.Count;
                eRoundCurrent = EliminationRound.Count;
            }
            

            #endregion
            
        }

       
        public List<Player> Players { get; set; }

        public List<Participant> Participants { get; set; }

        public List<Deck> Decks { get; set; }

        public List<Archetype> Archetypes { get; set; }

        public List<ContestPlay> Contests { get; set; }

        public List<List<Round>> Rounds { get; set; }

        public List<ClassificationRound> ClassificationRound { get; set; }

        public List<EliminationRound> EliminationRound { get; set; }

        public List<Game> Games { get; set; }
        

        #region Tools


        private Random _rd;


        #region Ranking

        public List<Tuple<int,int>> Participant_Puntuation { get; set; }

        #endregion


        private void ParticipantsInContestReplet(int initContest, int lastContest, int contest)
        {
            if (Contests[contest].ParticipantsNumber == null) Contests[contest].ParticipantsNumber = new List<int>();

            for (int i = initContest; i < lastContest + 1; i++)
            {
                Contests[contest].ParticipantsNumber.Add(Participants[i].ParticipantNumber);
            }
        }


        #region Game Tools

        private void MatchSimulate(int cRoundCount, List<Tuple<bool,int>> c_roundControl, int c, out int iGame)
        {
            var gameTemp = new List<Game>();

            for (int i = 0; i < Contests[c].ParticipantsNumber.Count; i++)
            {
                for (int j = i + 1; j < Contests[c].ParticipantsNumber.Count; j++)
                {
                    int[] p = { Contests[c].ParticipantsNumber[i], Contests[c].ParticipantsNumber[j] };

                    int result = _rd.Next(0, 4);
                    int[] r0 = { result, 3 - result };

                    gameTemp.Add(new Game { ParticipantsNumber = p, Results = r0 });
                }
            }

            bool[] mask = new bool[gameTemp.Count];
            int count = Games.Count == 0 ? 1 : Games[Games.Count - 1].GameNumber + 1;

            iGame = Games.Count;

            while(Games.Count - iGame < gameTemp.Count)
            {
                int take = _rd.Next(0, gameTemp.Count);
                if (mask[take]) continue;

                Games.Add(gameTemp[take]);
                Games[Games.Count - 1].GameNumber = count++;
                mask[take] = true;
            }

            //cRoundReplet
            int split = (Games.Count - iGame) / cRoundCount;
            int r = 1;
            for (int i = 0; i < Games.Count - iGame; i++)
            {
                c_roundControl.Add(new Tuple<bool, int>(true, r));

                if ((i + 1) % split == 0 && r < cRoundCount) r++;
            }
        }

        private void GameSimulate(List<Tuple<bool,int>> c_roundControl, int contest, int iGame)
        {
            //position of classification table
            Participant_PuntuationReplet(contest, iGame);
            
            //select the winners for each contest
            //repeat op
            int repeat = 3;
            int r = c_roundControl[c_roundControl.Count - 1].Item2 + 1;
            int count = 8;
            

            var winners = new List<int>();
            for (int i = 0, j = Participant_Puntuation.Count - 1; i < 8 ; i++, j--)
            {
                winners.Add(Participant_Puntuation[i].Item1);
            }

            while (repeat > 0)
            {
                int roundPivot = Games.Count;
                GamesSelect(winners);

                for (int i = roundPivot; i < Games.Count; i++)
                {
                    c_roundControl.Add(new Tuple<bool, int>(false, r));
                }

                //select winners
                winners = WinnersSelect(count / 2);

                if (winners.Count == 1)
                {
                    //winner
                    break;
                }
                
                r++;
                repeat--;
                count /= 2;
               
            }

        }

        private void ParticipantsInContestReplet1(int partNumberMax, int count, int contest)
        {
            int partNumber0 = partNumberMax - count + 1;
            for (int i = partNumber0; i < partNumberMax + 1; i++)
            {
                Contests[contest].ParticipantsNumber.Add(i);
            }
        }

        private List<int> WinnersSelect(int count)
        {
            var winners = new List<int>();

            for (int i = Games.Count - 1, j = count; j > 0; i--, j--)
            {
                if (Games[i].Results[0] > Games[i].Results[1]) winners.Add(Games[i].ParticipantsNumber[0]);
                else winners.Add(Games[i].ParticipantsNumber[1]);
            }

            return winners;
        }

        private void GamesSelect(List<int> winners)
        {
            bool[] mask = new bool[winners.Count];
            int gameNumber = Games[Games.Count - 1].GameNumber + 1;
            int count = winners.Count;

            while(count > 1)
            {
                //first participant select
                int p0 = _rd.Next(0, winners.Count);
                if (mask[p0]) continue;

                mask[p0] = true;

                //second participant select
                int p1 = -1;
                while(p1 == -1)
                {
                    p1 = _rd.Next(0, winners.Count);
                    if (mask[p1])
                    {
                        p1 = -1;
                        continue;
                    }

                    mask[p1] = true;
                }

                int r0 = _rd.Next(0, 4);
                int[] p = { winners[p0], winners[p1] };
                int[] r = { r0, 3 - r0 };

                Games.Add(new Game { GameNumber = gameNumber++, ParticipantsNumber = p, Results = r });

                count -= 2;
            }
        }

        private void Participant_PuntuationReplet(int c, int iGame)
        {
            Participant_Puntuation = new List<Tuple<int, int>>();
            var p_p = new List<Tuple<int, int>>();

            bool[] mediumSelect = new bool[Games.Count];
            bool[] completeSelect = new bool[Games.Count];

            for (int i = 0; i < Contests[c].ParticipantsNumber.Count; i++)
            {
                int p = 0;
                for (int j = iGame; j < Games.Count; j++)
                {
                    if (completeSelect[j]) continue;

                    bool p0 = false;
                    bool p1 = false;
                    if (Contests[c].ParticipantsNumber[i] == Games[j].ParticipantsNumber[0]) p0 = true;
                    else if (Contests[c].ParticipantsNumber[i] == Games[j].ParticipantsNumber[1]) p1 = true;

                    if (p0 || p1)
                    {
                        if (p0) p += Games[j].Results[0];
                        else p += Games[j].Results[1];

                        if (mediumSelect[j]) completeSelect[j] = true;
                        else mediumSelect[j] = true;
                    }
                }
                p_p.Add(new Tuple<int, int>(Contests[c].ParticipantsNumber[i], p));
            }

            //order by
            QuickSort1(p_p, 0, p_p.Count - 1);
            for (int i = 0; i < p_p.Count; i++)
            {
                Participant_Puntuation.Add(p_p[i]);
            }
        }


        #region QuickSort
        
        private void QuickSort1(List<Tuple<int, int>> p_p, int p, int r)
        {
            if (p < r)
            {
                int q = Partition1(p_p, p, r);
                QuickSort1(p_p, p, q);
                QuickSort1(p_p, q + 1, r);
            }
        }

        private int Partition1(List<Tuple<int, int>> p_p, int p, int r)
        {
            int x = p_p[p].Item2;
            int i = p - 1;
            int j = r + 1;

            while (true)
            {
                do j--; while (x < p_p[j].Item2);
                do i++; while (x > p_p[i].Item2);

                if (i < j)
                {
                    var temp = new Tuple<int, int>(p_p[i].Item1, p_p[i].Item2);
                    p_p[i] = new Tuple<int, int>(p_p[j].Item1, p_p[j].Item2);
                    p_p[j] = new Tuple<int, int>(temp.Item1, temp.Item2);
                }
                else return j;
            }
        }


        #endregion

        #endregion


        #region Classification Round

        private void Participants_PuntuationRepletForEachClassificationRound(int c0, int cf)
        {
            for (int i = c0; i < cf + 1; i++)
            {
                ClassificationRound[i].Participant_Puntuation = new List<Tuple<int, int>>();
                ClassificationRound[i].Participant_Puntuation.AddRange(Participant_PuntuationReplet1(ClassificationRound[i].GamesClassification));
            }
            
        }

        private List<Tuple<int, int>> Participant_PuntuationReplet1(List<int> g)
        {
            var p_p = new List<Tuple<int, int>>();
            var participants = ParticipantsReplet(g);

            bool[] mediumSelect = new bool[g.Count];
            bool[] completeSelect = new bool[g.Count];

            for (int i = 0; i < participants.Count; i++)
            {
                int p = 0;
                for (int j = 0; j < g.Count; j++)
                {
                    if (completeSelect[j]) continue;

                    bool p0 = false;
                    bool p1 = false;
                    if (participants[i] == Games[g[j] - 1].ParticipantsNumber[0]) p0 = true;
                    else if (participants[i] == Games[g[j] - 1].ParticipantsNumber[1]) p1 = true;

                    if (p0 || p1)
                    {
                        if (p0) p += Games[g[j] - 1].Results[0];
                        else p += Games[g[j] - 1].Results[1];

                        if (mediumSelect[j]) completeSelect[j] = true;
                        else mediumSelect[j] = true;
                    }
                }
                p_p.Add(new Tuple<int, int>(participants[i], p));
            }

            //order by
            QuickSort1(p_p, 0, p_p.Count - 1);
            return p_p;
        }

        private List<int> ParticipantsReplet(List<int> g)
        {
            var p = new List<int>();
            for (int i = 0; i < g.Count; i++)
            {
                if (!p.Contains(Games[g[i] - 1].ParticipantsNumber[0])) p.Add(Games[g[i] - 1].ParticipantsNumber[0]);
                if (!p.Contains(Games[g[i] - 1].ParticipantsNumber[1])) p.Add(Games[g[i] - 1].ParticipantsNumber[1]);
            }
            return p;
        }

        #endregion

        #endregion

        public System.Data.Entity.DbSet<Yu_Gi_Oh.Models.ClassificationRound> ClassificationRounds { get; set; }

        public System.Data.Entity.DbSet<Yu_Gi_Oh.Models.EliminationRound> EliminationRounds { get; set; }
    }

}