using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Engine
{
    public class BaseNotification : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; // Event that is raised when a property changes
        protected virtual void OnPropertyChanged(string propertyName) // Method to raise the PropertyChanged event
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); // If there are any subscribers to the PropertyChanged event, invoke the event
        }
    }
}
