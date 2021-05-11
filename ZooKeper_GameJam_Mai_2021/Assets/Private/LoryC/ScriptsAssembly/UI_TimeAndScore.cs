using UnityEngine;
using UnityEngine.UI;

public class UI_TimeAndScore : MonoBehaviour
{
    #region Public Members

    #endregion


    #region Unity API

    private void Update()
    {
        _timerText.text = $"{_timerScript.Value :0.0}";

        if(_timerScript.Value < 5f)
        {
            _timerText.color = Color.red;
        }

        _meatText.text = $"{_meatCounter.Value:0} / {_meatMax.Value} Meats";

        _vegetableText.text = $"{_vegetableCounter.Value:0} / {_vegetableMax.Value} Vegetables";
    }

    #endregion


    #region Private And Protected
    [Header("Timer")]
    [SerializeField]
    private FloatVariable _timerScript;
    [SerializeField]
    private Text _timerText;

    [Header("Meat")]
    [SerializeField]
    private IntVariable _meatCounter;
    [SerializeField]
    private Text _meatText;
    [SerializeField]
    private IntVariable _meatMax;

    [Header("Vegetable")]
    [SerializeField]
    private IntVariable _vegetableCounter;
    [SerializeField]
    private Text _vegetableText;
    [SerializeField]
    private IntVariable _vegetableMax;

    #endregion
}