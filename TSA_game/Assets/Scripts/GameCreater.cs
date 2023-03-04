using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameCreater : MonoBehaviour 
{
    private int playerCount;
    private string[] playerCharacters;
    public void HandleInputData(int val)
    {
        playerCount = val + 2;
    }
    public void locations()
    {
        string[] tavern = {"Musician", "Bartender", "Drunk", "Tavern Keeper", "Security Guard", "Dancer" };
        string[] throneRoom = { "King/Queen", "Courier", "Jester", "Royale Bodyguard", "Royale Advisor", "Royale Servant" };
        string[] market = { "Shopkeeper", "Tax Collector", "Coachman", "Traveling Merchant", "Peasant", "Smith" };
        string[] inn = { "Innkeeper", "Maid/manservant", "Traveler", "Bard", "Brewer", "Cook"};
        string[] mines = { "Pick Sharpener", "Miner", "Lift Operator", "Water Boy", "Crystal Inspector", "Canary Holder" };
        string[] forges = { "Blacksmith", "Apprentice", "Coal Runner", "Customer", "Swordsman", "Bellows Worker" };
        string[] bountyBoard = { "Guild representative", "Famous Adventurer", "Adventurer wanna-be", "Wizzard", "Half-ling", "Archer" };
        string[] docks = { "Ship Captain", "Barnacle Boy", "Merchant", "Fisher", "Net Mender", "Docking Master" };
        string[] church = { "Innkeeper", "Worshipper", "Orphan", "Deacon", "Singer", "Paladin" };
        string[] graveyard = { "Mortician", "Vampire", "Gravedigger", "Necromancer", "Corpse", "Ghost" };
        string[] gallows = { "Executioner", "Priest", "Guards", "Citizen", "Condemned", "Physician" };
        string[] barracks = { "Quartermaster", "Cook", "Recruit", "Platoon Leader", "Drunk", "Trainer" };
        string[] boat = { "Captain", "First Mate", "Cook", "Quartermaster", "Cartographer", "Carpenter" };
        string[] witchHut = { "Witch", "Broom", "Cat", "Raven", "Shrunken Head", "Customer" };
        string[] palaceDungeon = { "Guard", "Drunk", "Madman", "Witch", "Thief", "Prisoner" };

        object[] location = {tavern, throneRoom, market, inn, mines, forges, bountyBoard,
            docks, church, graveyard, gallows, barracks, boat, witchHut, palaceDungeon};
    }
    public void chooseLocation()
    {

    }
}
