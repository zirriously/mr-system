using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Customer
{

    private double _cvr;
    private string _navn;
    private string _att;
    private string _adresse;
    private double _postnr;
    private double _tlf;
    private string _email;
    private string _info;
    private string _forventetLevering;

    public Customer(double cvr, string navn, string att, string adresse, double postnr, double tlf, string email, string info, string forventetlevering)
    {
        _cvr = cvr;
        _navn = navn;
        _att = att;
        _adresse = adresse;
        _postnr = postnr;
        _tlf = tlf;
        _email = email;
        _info = info;
        _forventetLevering = forventetlevering;

    }

    public double Cvr
    {
        get { return _cvr; }
        set { _cvr = value; }
    }

    public string Navn
    {
        get { return _navn; }
        set { _navn = value; }
    }

    public string Att
    {
        get { return _att; }
        set { _att = value; }
    }

    public string Adresse
    {
        get { return _adresse; }
        set { _adresse = value; }
    }

    public double PostNummer
    {
        get { return _postnr; }
        set { _postnr = value; }
    }

    public double TelefonNummer
    {
        get { return _tlf; }
        set { _tlf = value; } 
    }

    public string EmailAddresse
    {
        get { return _email; }
        set { _email = value; }
    }
    public string Information
    {
        get { return _info; }
        set { _info = value; }
    }

    public string ForventetLevering
    {
        get { return _forventetLevering; }
        set { _forventetLevering = value; }
    }
}

