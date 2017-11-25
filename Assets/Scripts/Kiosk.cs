using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Kiosk : MonoBehaviour  {
    public Text setLPText;                  // Only used as a workaround in unity
    public static Text licensePlateText;
    public Text setAmtDueText;              // Only used as a workaround in unity
    public static Text amountDueText;
    public Text setConfMsgText;             // Only used as a workaround in unity
    public static Text confirmationMsgText;

    private void Awake()
    {
        licensePlateText = setLPText;
        amountDueText = setAmtDueText;
        confirmationMsgText = setConfMsgText;
    }

    public static void DisplayAmountDue(double amountDue, string licensePlate)
    {
        confirmationMsgText.text = "";
        licensePlateText.text = "License Plate: " + licensePlate;
        amountDueText.text = "Amount Due: " + amountDue.ToString("C", CultureInfo.CurrentCulture);
        Debug.Log("Amount due: " + amountDue.ToString("C", CultureInfo.CurrentCulture));
    }

    public void MakePayment()
    {
        licensePlateText.text = "";
        amountDueText.text = "";
        confirmationMsgText.text = "You have successfully paid";
    }

}
