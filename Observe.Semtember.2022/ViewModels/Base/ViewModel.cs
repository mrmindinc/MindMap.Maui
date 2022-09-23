namespace MindMap.ViewModels.Base
{
    public class ViewModel : BindableObject
    {
        public virtual Task InitializeAsync(object navigationData) => Task.FromResult(false);
        public API.Mind API
        {
            get;
        }
        public ViewModel() => API = new API.Mind(Contact.Url);
    }
}