using UnityEngine;
using MyDialogs = Game.Data.Dialogs;

namespace Game.View
{
    public class Choise : MonoBehaviour
    {
        [SerializeField] private Canvas _self;
        [SerializeField] public Transform _parrent;
        [SerializeField] private ChoiseButton _prefabs;

        private ChoiseButton tmp;
        public void Show()
        {
            _self.enabled = true;
        }
        public void Add(MyDialogs.ChoiseElement choiseElement, Say say)
        {
            tmp = Instantiate(_prefabs, _parrent);
            tmp.Say = say;
            tmp.Show(choiseElement);
        }
        public void Hide()
        {
            _self.enabled = false;
        }
    }
}
