using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KioskController : MonoBehaviour {

    const double PAY_RATE = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void CalculatePayment(Customer customer)
    {
        TimeSpan duration = customer.TimeOut - customer.TimeIn;
        double hours = duration.TotalHours;

        double payment = hours * PAY_RATE;

        Kiosk.DisplayAmountDue(payment, customer.LicensePlate);
    }
}
