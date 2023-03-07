using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;


public class GameCreater : MonoBehaviour 
{

    public TextMeshProUGUI locationLabel;
    public Image locationImage;
    public TextMeshProUGUI characterLabel;

    public List<Sprite> locationImages;

    private string[] possibleLocations = new string[] { "barracks", "boat", "bountyBoard", "church", "docks", "forges", "gallows", "graveyard", "inn", "market", "mines", "palaceDungeon", "tavern", "throneRoom", "witchHut" };


    private int playerCount = 3;
    private string[] playerCharacters;

    private string currentLocation;
    private int spyIndex;

    private int currentShowingRole = -1;

     
    public void HandleInputData(int val)
    {
        playerCount = val + 3;
        print("handle input data " + val);
    }

        
    public void GameSetup()
    {
        Dictionary<string, List<string>> locations = new Dictionary<string, List<string>>()
        {
            { "barracks", new List<string>() { "Quartermaster", "Cook", "Recruit", "Platoon Leader", "Drunk", "Trainer" } },
            { "boat", new List<string>() { "Captain", "First Mate", "Cook", "Quartermaster", "Cartographer", "Carpenter" } },
            { "bountyBoard", new List<string>() {  "Guild representative", "Famous Adventurer", "Adventurer wanna-be", "Wizzard", "Half-ling", "Archer" } },
            { "church", new List<string>() { "Priest", "Worshipper", "Orphan", "Deacon", "Singer", "Paladin" } },
            { "docks", new List<string>() { "Ship Captain", "Barnacle Boy", "Merchant", "Fisher", "Net Mender", "Docking Master" } },
            { "forges", new List<string>() { "Blacksmith", "Apprentice", "Coal Runner", "Customer", "Swordsman", "Bellows Worker" } },
            { "gallows", new List<string>() { "Executioner", "Priest", "Guards", "Citizen", "Condemned", "Physician" } },
            { "graveyard", new List<string>() { "Mortician", "Vampire", "Gravedigger", "Necromancer", "Corpse", "Ghost" } },
            { "inn", new List<string>() { "Innkeeper", "Maid/manservant", "Traveler", "Bard", "Brewer", "Cook" } },
            { "market", new List<string>() { "Shopkeeper", "Tax Collector", "Coachman", "Traveling Merchant", "Peasant", "Smith" } },
            { "mines", new List<string>() {  "Pick Sharpener", "Miner", "Lift Operator", "Water Boy", "Crystal Inspector", "Canary Holder" } },
            { "palaceDungeon", new List<string>() { "Guard", "Drunk", "Madman", "Witch", "Thief", "Prisoner" } },
            { "tavern", new List<string>() {"Musician", "Bartender", "Drunk", "Tavern Keeper", "Security Guard", "Dancer" } },
            { "throneRoom", new List<string>() { "King/Queen", "Courier", "Jester", "Royale Bodyguard", "Royale Advisor", "Royale Servant" } },
            { "witchHut", new List<string>() {  "Witch", "Broom", "Cat", "Raven", "Shrunken Head", "Customer" } },
        };

        currentLocation = locations.Keys.ElementAt(Random.Range(0, locations.Count));
        spyIndex = Random.Range(0, playerCount);
        playerCharacters = new string[playerCount];

        for (int i = 0; i < playerCount; i++)
        {
            if (i == spyIndex)
            {
                string assignment = locations[currentLocation][Random.Range(0, locations[currentLocation].Count)];
                playerCharacters[i] = assignment;
                locations[currentLocation].Remove(assignment);
            }
            else
            {
                playerCharacters[i] = "Weasel";
            }
        }

        AssignRoles();
    }

    public void AssignRoles()
    {
        currentShowingRole++;
        print(playerCharacters);
        print("weasle index " + spyIndex);
        print("current " + currentShowingRole);

        if (currentShowingRole != spyIndex)
        {
            locationImage.enabled = true;
            locationImage.sprite = locationImages[System.Array.IndexOf(possibleLocations, currentLocation)];
            locationLabel.text = currentLocation;
        }
        else
        {
            locationImage.enabled = false;
            locationLabel.text = "";
        }

        characterLabel.text = playerCharacters[currentShowingRole];
        print("role " + playerCharacters[currentShowingRole]);

        if (currentShowingRole == playerCount - 1)
        {
            print("FINISH");
        }
    }
}
