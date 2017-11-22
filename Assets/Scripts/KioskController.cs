using System;
using UnityEngine;

public class KioskController {

    const double PAY_RATE = 100;

    public static void CalculatePayment(Customer customer)
    {
        TimeSpan duration = customer.TimeOut - customer.TimeIn;
        double hours = duration.TotalHours;

        double payment = hours * PAY_RATE;

        Kiosk.DisplayAmountDue(payment, customer.LicensePlate);
    }
}
