using System;
using System.Collections.Generic;

public class Customer
{
    private string _nameCustomer;
    private Address _adress;

    public Customer(string nameCustomer, Address adress)
    {
        _nameCustomer = nameCustomer;
        _adress = adress;
    }

    public bool LiveInUSA()
    {
        return _adress.IsInUSA();
    }

    public string GetName()
    {
        return _nameCustomer;
    }

    public Address GetAddress()
    {
        return _adress;
    }
    
}