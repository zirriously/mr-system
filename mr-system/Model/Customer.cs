using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Customer
{

    private int _cvr;
    private string _navn;
    private string _att;
    private double _adresse;
    private int _postnr;
    private int _tlf;
    private double _email;
    private double _info;
    private double _forventetLevering;

    public Customer(int cvr, string navn, string att, double _adresse, int postnr, int tlf, double email, double info, double forventetlevering)
    {
        _cvr = cvr;
        _navn = navn;
        _att = att;
        _adresse = adr;
        _postnr = postnr;
        _tlf = tlf;
        _email = email;
        _info = info;
        _forventetLevering = forlev;

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
        get { return _adr;}
        set { _adr = value;}
    }

    public string postnr
    {
        get { return _postnr; }
        set { _postnr = value; }
    }

    public string tlf
    {
        get { return _tlf; }
        set { _tlf = value; }
    }

    public string email
    {
        get { return _email; }
        set {_email = value; }
    }
    public string info
    {
        get { return _info; }
        set {_info = value; }
    }

    public string forLev
    {
        get { return _forLev; }
        set { _forLev = value; }
    }
}


