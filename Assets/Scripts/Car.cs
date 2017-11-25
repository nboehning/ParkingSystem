using System.Text;
using UnityEngine;

public class Car : MonoBehaviour
{

    public string licensePlate;

    void Start()
    {
        licensePlate = GenerateLicensePlate();
    }

    private string GenerateLicensePlate()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        StringBuilder builder = new StringBuilder();

        int plateLength = Random.Range(6, 8);

        for (int i = 0; i < plateLength; i++)
        {
            char c = chars[(int) Random.Range(0, chars.Length)];
            builder.Append(c);
        }

        return builder.ToString();
    }
}
