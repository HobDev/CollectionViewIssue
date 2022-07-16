
using System.Windows.Input;

namespace CollectionViewIssue
{
    public class MainViewModel
    {
        public ICommand GameSelectedCommand
        {
            get;
            set;
        }
        public List<Game> AllGames { get; set; }
        public MainViewModel()
        {
            AllGames = new List<Game>()
            {
                new Game{Name="Badminton"},
                new Game{Name="Archery"},
                new Game{Name="Baseball"}
            };

            GameSelectedCommand = new Command(async () => await GameSelected());
        }

        async Task GameSelected()
        {

        }
    }
}
