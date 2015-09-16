namespace MaslowBox
{
    public class MainViewModel 
    {
        public MainViewModel()
        {
            Person = new PersonViewModel {FirstName = "Net", LastName = "Scape"};
        }
        public PersonViewModel Person { get; private set; }
    }
}
