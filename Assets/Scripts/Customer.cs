using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : IEquatable<Customer>
{

    public string LicensePlate { get; set; }
    public DateTime TimeIn { get; set; }
    public DateTime TimeOut { get; set; }



    public Customer(string licensePlate)
    {
        LicensePlate = licensePlate;
        TimeIn = DateTime.Now;
    }

    public bool Equals(Customer other)
    {
        return this.LicensePlate.Equals(other.LicensePlate);
    }
}
