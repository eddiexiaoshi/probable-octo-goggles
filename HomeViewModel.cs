using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Project2.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged


    {
        private Query _query;
        public string _message;

        private Query Query{

            get {
                return _query;
                  }
            set {
                _query = value;
                OnPropertyChanged();
            }

        }

        public string Message {
            get
            { return _message; }

            set {
                _message = value;
                OnPropertyChanged();
            }
        }

        public Command SaveCommand {

            get {
                return new Command(() =>
               {
                   Message = "Your Information:" + Query.Name + "," + Query.Education +","+ Query.Contact + "was successfully saved! We will contact you soon.";

               });
                
            }
        }

        

        public HomeViewModel()
        {
            Query = new Query
            {
                Name = "Lucy",
                Education = "Bachelor of Information Technology",
                Contact = "0402814122"
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
