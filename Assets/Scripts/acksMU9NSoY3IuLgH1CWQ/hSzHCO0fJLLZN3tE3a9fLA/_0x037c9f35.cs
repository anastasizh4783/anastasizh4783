using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x037c9f35 : MonoBehaviour
{
    private Image _0x718a2b48;
    private void Update()
    {
        this._0x2e48fbdc();
    }

    private void _0x2e48fbdc()
    {
        if (this._0x718a2b48.canvasRenderer.GetColor() != this._0xdff47b0b.canvasRenderer.GetColor())
            this._0xdff47b0b.canvasRenderer.SetColor(this._0x718a2b48.canvasRenderer.GetColor());
    }

    private TMP_Text _0xdff47b0b;
}