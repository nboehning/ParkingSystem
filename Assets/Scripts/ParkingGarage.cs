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
    public static Text[] levelSignalTexts;
    public static Text garageSignalText;

    void Start()
    {
        for (int i = 0; i < parkingLevels.Length; i++)
        {
            parkingLevels[i].numberOfSpots = spotsPerLevel;
            levelSignalTexts[i].text = spotsPerLevel.ToString();
        }


    }

    public static void Park(int level)
    {
        parkingLevels[level].spotsFilled++;

        CheckLevel(level);
    }

    public static void Exit(int level)
    {
        parkingLevels[level].spotsFilled--;

        CheckLevel(level);
    }

    private static void CheckLevel(int level)
    {
        if (parkingLevels[level].spotsFilled == parkingLevels[level].numberOfSpots)
        {
            parkingLevels[level].isFull = true;
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
            parkingLevels[level].isFull = false;
        }

        UpdateSignals(level);
    }

    private static void UpdateSignals(int level)
    {
        levelSignalTexts[level].text = (parkingLevels[level].numberOfSpots - parkingLevels[level].spotsFilled).ToString();
    }

}
