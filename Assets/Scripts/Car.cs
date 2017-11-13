using System.Text;
using UnityEngine;

public class Car : MonoBehaviour
{

    public string licensePlate;

    private void Start()
    {
        GenerateLicensePlate();
    }

    private void GenerateLicensePlate()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        StringBuilder builder = new StringBuilder();

        int plateLength = Random.Range(6, 8);

        for (int i = 0; i < plateLength; i++)
        {
            char c = chars[(int) Random.Range(0, 36)];
            builder.Append(c);
        }

        licensePlate = builder.ToString();
    }
}
