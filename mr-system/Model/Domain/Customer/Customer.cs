using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Customer : INotifyPropertyChanged
{
    public Customer(string cvr = "", string firstName = "", string lastName = "", string email = "", string phone = "", string address = "", string areaCode = "")
    {
        Key = -1;
        Cvr = cvr;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Adress = address;
        AreaCode = areaCode;
    }

    public int Key { get; set; }

    public string Cvr { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string Adress { get; set; }

    public string AreaCode { get; set; }

    public string Information { get; set; }

    
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

