using TMPro;
using UnityEngine;
using static _0xc1e39607;

public class _0x3385fd5f : MonoBehaviour
{
    public void _0xa00e67ac()
    {
        this.MoneyCountText.text = _0x537ecd0a._0x7ae1d3ca.ToString();
    }

    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x8ce87453;
            if (this.gameObject.TryGetComponent(out _0x8ce87453))
                this.MoneyCountText = _0x8ce87453;
        }

        this._0xa00e67ac();
    }
}