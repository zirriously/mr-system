using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Customer : INotifyPropertyChanged

{
   

    public Customer(string navn, string email, double tlf, string adresse)
    {
        Key = -1;
        Navn = navn;
        EmailAddresse = email;
        TelefonNummer = tlf;
        Adresse = adresse;

    }

    public int Key { get; set; }
    public double Cvr { get; set; }

    public string Navn { get; set; }

    public string Att { get; set; }

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

