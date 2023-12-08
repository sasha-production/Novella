using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyDialogs = Game.Data.Dialogs;

namespace Game.View
{
    public class Choise : MonoBehaviour
    {
        [SerializeField] private Canvas _self;
        [SerializeField] private Transform _parrent;
        [SerializeField] private ChoiseButton _prefabs;

        private ChoiseButton tmp;

        public void Show() => _self.enabled = true;
        public void Add(MyDialogs.ChoiseElement choiseElement)
        {
            tmp = Instantiate(_prefabs, _parrent);
            tmp.Show(choiseElement);
        }
        public void Hide() => _self.enabled = false;

    }
}
