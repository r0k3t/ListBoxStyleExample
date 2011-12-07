using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;

namespace ListBoxStyleExample
{
  public class MainWindowViewModel : NotificationObject
  {
    private Contact selectedContact;
    private ObservableCollection<Contact> contacts;
    public MainWindowViewModel()
    {
      Contacts = new ObservableCollection<Contact>();
      Contacts.Add(new Contact { Email = "knagorski@gmail.com", Phone = "202-344-1277", Name = "Ken Nagorski" });
      Contacts.Add(new Contact { Email = "fred@gmail.com", Phone = "330-555-1277", Name = "Fred Nobody" });
      Contacts.Add(new Contact { Email = "luser@gmail.com", Phone = "342-671-5567", Name = "L. User" });
      Contacts.Add(new Contact { Email = "ralph@gmail.com", Phone = "404-223-5012", Name = "Ralph Ralphie" });
    }

    public ObservableCollection<Contact> Contacts
    {
      get { return contacts; }
      set
      {
        contacts = value;
        RaisePropertyChanged(() => Contacts);
      }
    }

    public Contact SelectedContact
    {
      get { return selectedContact; }
      set
      {
        selectedContact = value;
        RaisePropertyChanged(() => SelectedContact);
      }
    }
  }

  public class Contact
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

  }
}
