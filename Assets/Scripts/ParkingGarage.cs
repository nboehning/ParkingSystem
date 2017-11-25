using UnityEngine;
using UnityEngine.UI;

public struct Level
{
    public int numberOfSpots;
    public int spotsFilled;
    public bool isFull;
}

public class ParkingGarage : MonoBehaviour
{

    public static Level[] parkingLevels = new Level[3];
    public static int spotsPerLevel = 20;
    public static bool isFull;

    void Start()
    {
        for (int i = 0; i < parkingLevels.Length; i++)
        {
            parkingLevels[i].numberOfSpots = spotsPerLevel;
        }
    }

    public static void Park(int level)
    {
        parkingLevels[level - 1].spotsFilled++;

        CheckLevel(level);
    }

    public static void Exit(int level)
    {
        parkingLevels[level - 1].spotsFilled--;

        CheckLevel(level);
    }

    private static void CheckLevel(int level)
    {
        if (parkingLevels[level - 1].spotsFilled == parkingLevels[level - 1].numberOfSpots)
        {
            parkingLevels[level - 1].isFull = true;
            ParkingGarage.isFull = true;

            for (int i = 0; i < parkingLevels.Length; i++)
            {
                if (!parkingLevels[i].isFull)
                {
                    ParkingGarage.isFull = false;
                    break;
                }
            }
        }
        else
        {
            parkingLevels[level - 1].isFull = false;
        }

        UpdateSignals(level);
    }

    private static void UpdateSignals(int level)
    {
        Text textCompUI = null;

        switch (level)
        {
            case 1:
                textCompUI = GameObject.Find("LevelOneSpots").GetComponent<Text>(); 
                break;
            case 2:
                textCompUI = GameObject.Find("LevelTwoSpots").GetComponent<Text>();
                break;
            case 3:
                textCompUI = GameObject.Find("LevelThreeSpots").GetComponent<Text>();
                break;
        }

        if (ParkingGarage.isFull)
        {
            GameObject.Find("GarageStatus").GetComponent<Text>().text = "Full";
            GameObject.Find("GarageStatus").GetComponent<Text>().color = Color.red;
        } else
        {
            GameObject.Find("GarageStatus").GetComponent<Text>().text = "Open";
            GameObject.Find("GarageStatus").GetComponent<Text>().color = Color.green;
        }

        textCompUI.text = (parkingLevels[level - 1].numberOfSpots - parkingLevels[level - 1].spotsFilled).ToString();
    }

}
