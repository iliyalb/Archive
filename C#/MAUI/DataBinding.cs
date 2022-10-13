public class UserViewModel : INotifyPropertyChanged
{
    // Implementation
    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged(string name)
    {
        if (PropertyChanged == null)
        {
            return;
        }

        PropertyChanged(this, new ProperyChangedEventArgs(name));
    }

    // Verbose method
    private string firstname;
    public string FirstName
    {
        get
        {
            return firstname;
        }
        set
        {
            if (firstname == value)
            {
                return;
            }

            firstname = value;
            OnPropertyChanged("FirstName");
        }
    }

    /*
        // Binding
        Label firstName = new Label();
        firstName.SetBinding(Label.TextProperty, "FirstName");

        // Verbose binding
        Entry firstEntry = new Entry();
        firstEntry.SetBinding<UserViewModel>(Entry.TextProperty, vm => vm.FirstName, Binding);
    */

}