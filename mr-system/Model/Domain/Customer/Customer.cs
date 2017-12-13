using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Customer : INotifyPropertyChanged
{
    public Customer(string navn, string email, double tlf, string adresse)
    {
        Key = -1;
        ForNavn = navn;
        EmailAddresse = email;
        TelefonNummer = tlf;
        Adresse = adresse;
    }

    public int Key { get; set; }

    public double Cvr { get; set; }

    public string ForNavn { get; set; }

    public string LastName { get; set; }

    public string Adresse { get; set; }

    public double PostNummer { get; set; }

    public double TelefonNummer { get; set; }

    public string EmailAddresse { get; set; }

    public string Information { get; set; }

    public string ForventetLevering { get; set; }


    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

