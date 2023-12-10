using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using XNode;

namespace Game.View
{

    public class NewSay : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] private NodeGraph _dialogs;
        [SerializeField] private TextMeshProUGUI _name;
        [SerializeField] private TextMeshProUGUI _text;

        private int _index;
        private void Start()
        {
            if (_dialogs != null)
            {
                NextDialog();
            }
        }
        public void NextDialog()
        {

            if (_index == _dialogs.nodes.Count)
            {
                return;
            }
            switch (_dialogs.nodes[_index])
            {
                case Dialog dialog:
                    _name.SetText(dialog.Name);
                    _text.SetText(dialog.Text);
                    break;
            }
            _index++;
        }
    }
}
