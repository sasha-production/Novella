using System;
using UnityEngine;

namespace Game.Data
{
    [CreateAssetMenu(menuName ="Game/Data/" + nameof(Dialogs))]

    public class Dialogs : ScriptableObject
    {
        [System.Serializable]
        public class Dialog
        {
            [SerializeField] private string _name;
            [SerializeField][TextArea(5, 10)] private string _text;
            [SerializeField] private int _number;
            [SerializeField] private ChoiseElement[] _choises;            


            public string Name => _name;
            public string Text => _text;
            public ChoiseElement[] choises => _choises;
            public int Number => _number;
        }

        [System.Serializable]
        public class ChoiseElement  // хранит текст кнопки и следующий ресурс диалога
        {
            [SerializeField] private string _text;
            [SerializeField] private Dialogs _dialogs;

            public string Text => _text;
            public Dialogs Dialogs => _dialogs;
        }

        [SerializeField] public Dialog[] _dialogs;
        public Dialog[] Get => _dialogs;
    }
}

