using TMPro;
using UnityEngine;
using MyDialogs = Game.Data.Dialogs;
using UnityEngine.SceneManagement;
using UnityEditor.Build.Content;

namespace Game.View
{
    public class Say : MonoBehaviour
    {
        [SerializeField] private MyDialogs _dialogs;
        [SerializeField] private TextMeshProUGUI _name;
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] public Choise _choise;  //Choise _choise  // pr

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
            //Debug.Log(_index);
            ChoiseCreate();
            _index++;
            
        }

        private void ChoiseCreate()
        {
            if (_dialogs.Get[_index].choises.Length != 0)
            {
                _choise.Show();
                foreach (Transform child in _choise._parrent)
                {
                    Destroy(child.gameObject);
                }
                //Debug.Log(_dialogs.Get[_index].choises.Length);
                foreach (MyDialogs.ChoiseElement element in _dialogs.Get[_index].choises)
                {
                    _choise.Add(element, this);
                }
            }
        }
        public void Choise(ChoiseButton choiceButton)  // создает кнопки на экране
        {
            _index = 0;
            _dialogs = choiceButton.Dialogs;
            choiceButton.Hide();
            _choise.Hide();
        }

        public void BackToMainQuestion()
        {
            if (_dialogs.name.EndsWith("End") && _index == _dialogs.Get.Length )
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}