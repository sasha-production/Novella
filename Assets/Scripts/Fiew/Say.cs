using Game.Data;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using MyDialogs = Game.Data.Dialogs;

namespace Game.View
{
    public class Say : MonoBehaviour
    {
        [SerializeField] private MyDialogs _dialogs;
        [SerializeField] private TextMeshProUGUI _name;
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private Choise _choise;  //Choise _choise

        private int _index;
        private void Start()
        {
            if (_dialogs != null)
                NextDialog();
        }

        // Update is called once per frame
        public void NextDialog()
        {
            if (_index == _dialogs.Get.Length)
                return;
            _name.SetText(_dialogs.Get[_index].Name);
            _text.SetText(_dialogs.Get[_index].Text);
            Debug.Log(_dialogs.Get[_index].Text);
            _index++;
            ChoiseCreate();
            _index++;
        }

        private void ChoiseCreate()
        {
            if (_dialogs.Get[_index].choises.Length != 0)
            {
                foreach (MyDialogs.ChoiseElement element in _dialogs.Get[_index].choises)
                {
                    _choise.Add(element, this);
                }
            }
        }
        public void Choise(ChoiseButton choiceButton)
        {
            _index = 0;
            _dialogs = choiceButton.Dialogs;
            choiceButton.Hide();
            _choise.Hide();
        }
    }
}