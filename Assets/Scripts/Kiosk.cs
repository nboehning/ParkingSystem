using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Kiosk : MonoBehaviour {

    public static Text licensePlateText;
    public static Text amountDueText;
    public static Text confirmationMsgText;

    public static void DisplayAmountDue(double amountDue, string licensePlate)
    {
        //licensePlateText.text = licensePlate;
        //amountDueText.text = amountDue.ToString("C", CultureInfo.CurrentCulture);
        Debug.Log("Amount due: " + amountDue.ToString("C", CultureInfo.CurrentCulture));
    }

    public void MakePayment()
    {
        licensePlateText.text = "";
        amountDueText.text = "";
        confirmationMsgText.text = "You have successfully paid";
    }

}
