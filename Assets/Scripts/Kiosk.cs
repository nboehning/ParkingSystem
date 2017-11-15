using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Kiosk : MonoBehaviour {

    public static Text licensePlateText;
    public static Text amountDueText;
    public static Text confirmationMsgText;

    void Start()
    {
        DisplayAmountDue(45.785f, "123456");
    }

    public static void DisplayAmountDue(double amountDue, string licensePlate)
    {
        licensePlateText.text = licensePlate;
        amountDueText.text = amountDue.ToString("C", CultureInfo.CurrentCulture);
    }

    public void MakePayment()
    {
        licensePlateText.text = "";
        amountDueText.text = "";
        confirmationMsgText.text = "You have successfully paid";
    }
}
