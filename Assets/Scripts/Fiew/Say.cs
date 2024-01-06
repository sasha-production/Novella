using TMPro;
using UnityEngine;
using MyDialogs = Game.Data.Dialogs;
using UnityEngine.SceneManagement;
using UnityEditor.Build.Content;
using UnityEngine.UI;

namespace Game.View
{
    public class Say : MonoBehaviour
    {
        [SerializeField] private MyDialogs _dialogs;
        [SerializeField] private TextMeshProUGUI _name;
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] public Choise _choise;  //Choise _choise  // pr
        [SerializeField] private TextMeshProUGUI _questionCounter;
        [SerializeField] private Button _returnButton;
        private int _index;
        private int counter = 3;
        private void Start()
        {
            if (_dialogs != null)
                NextDialog();
        }
        
        public void NextDialog()
        {
            
            if (_index == _dialogs.Get.Length)
                return;
            _name.SetText(_dialogs.Get[_index].Name);
            _text.SetText(_dialogs.Get[_index].Text);
            SetCounter();
            SetReturnButtonColor();
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
                    //Destroy(child.gameObject);
                    child.gameObject.SetActive(false);
                }

                foreach (MyDialogs.ChoiseElement element in _dialogs.Get[_index].choises)
                {
                    _choise.Add(element, this);
                    _choise.gameObject.SetActive(true);
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
            if (_index == _dialogs.Get.Length)
            {
                SceneManager.LoadScene((int) SceneNames.Scenes.Novell1Scene);
                /*_index = 0;
                Resources.Load<MyDialogs>("Data/MainQuestions");
                Debug.Log(_dialogs.name);
                Start();*/
            }
        }

        private void SetCounter()
        {
            counter += _dialogs.Get[_index].Number;
            _questionCounter.text = counter.ToString();
        }

        private void SetReturnButtonColor()
        {
            if (_dialogs.name.EndsWith("End"))
            {
                _returnButton.GetComponent<CanvasGroup>().alpha = 1;
            }
        }
    }
}