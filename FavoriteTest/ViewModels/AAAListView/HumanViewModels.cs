using System;
using System.Collections.ObjectModel;
using FavoriteTest.Models.AAAListView;
using FavoriteTest.SAL.AAAListView;

namespace FavoriteTest.ViewModels.AAAListView
{
    public class HumanViewModels
    {
        private ObservableCollection<Human> _humans;
        public ObservableCollection<Human> Humans
        {
            get { return _humans; }
            set
            {
                _humans = value;
            }
        }

        public HumanViewModels()
        {
            Humans = new ObservableCollection<Human>();

            MyData1 _context = new MyData1();

            foreach (var human in _context.Humans)
            {
                Humans.Add(human);
            }
        }
    }
}
