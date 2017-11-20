using System;

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

    public override string ToString()
    {
        return "License plate: " + LicensePlate + ", Time in: " + TimeIn + ", Time out: " + TimeOut;
    }
}
