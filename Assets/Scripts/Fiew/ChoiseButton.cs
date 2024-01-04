using Game.View;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using MyDialogs = Game.Data.Dialogs;

public class ChoiseButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Button _self;
    [SerializeField] private Say _say;
    public MyDialogs Dialogs { get; private set; }
    public Say Say { set => _say = value; }
    public void Show(MyDialogs.ChoiseElement choiseElement)
    {
        _text.SetText(choiseElement.Text);
        Dialogs = choiseElement.Dialogs;
        _self.onClick.AddListener(() => _say.Choise(this));
    }

    public void Hide()
    {
        Destroy(gameObject);
    }
}
