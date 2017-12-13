using System;
using System.ComponentModel;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Customer : INotifyPropertyChanged
{
    public Customer(Int64 cvr, string firstName, string lastname, string email, Int64 phone, string adress, double areaCode)
    {
        Key = -1;
        Cvr = cvr;
        FirstName = firstName;
        LastName = lastname;
        Email = email;
        Phone = phone;
        Adress = adress;
        AreaCode = areaCode;
    }

    public int Key { get; set; }

    public Int64 Cvr { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public Int64 Phone { get; set; }

    public string Adress { get; set; }

    public double AreaCode { get; set; }

    public string Information { get; set; }

    
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

