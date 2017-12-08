using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Customer
{

    private int _cvr;
    private string _navn;
    private string _att;
    private string _adresse;
    private int _postnr;
    private int _tlf;
    private string _email;
    private string _info;
    private string _forventetLevering;

    public Customer(int cvr, string navn, string att, string adresse, int postnr, int tlf, string email, string info, string forventetlevering)
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

    public int cvr
    {
        get { return _cvr; }
        set { _cvr = value; }
    }

    public string navn
    {
        get { return _navn; }
        set { _navn = value; }
    }

    public string att
    {
        get { return _att; }
        set { _att = value; }
    }

    public string adr
    {
        get { return _adresse; }
        set { _adresse = value; }
    }

    public int postnr
    {
        get { return _postnr; }
        set { _postnr = value; }
    }

    public int tlf
    {
        get { return _tlf; }
        set { _tlf = value; }
    }

    public string email
    {
        get { return _email; }
        set { _email = value; }
    }
    public string info
    {
        get { return _info; }
        set { _info = value; }
    }

    public string forLev
    {
        get { return _forventetLevering; }
        set { _forventetLevering = value; }
    }
}

