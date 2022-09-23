using System.Collections.ObjectModel;

namespace MindMap.ViewModels
{
    public class User : Base.ViewModel
    {
        public User()
        {
            OnLoadDataAsync();
        }
        public ObservableCollection<Models.AI> Users
        {
            set
            {
                users = value;
                OnPropertyChanged();
            }
            get => users;
        }
        async void OnLoadDataAsync()
        {
            if (await API.GetUsersAsync() is Models.AI[] models)
                users = new ObservableCollection<Models.AI>(models);
        }
        ObservableCollection<Models.AI> users;
    }
}