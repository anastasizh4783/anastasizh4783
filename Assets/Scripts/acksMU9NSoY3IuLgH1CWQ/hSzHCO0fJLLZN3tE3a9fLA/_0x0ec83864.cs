using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x0ec83864 : MonoBehaviour
{
    private float _0x87d8c360 = 4;
    private float _0x539e2ba3 = 0.6f;
    private float _0x891e65d4 = 1.5f;
    private List<string> _0xd9000ae8 = new();
    private TMP_Text _0x17b91767;
    private AspectRatioFitter _0x5a85d009;
    private void Update()
    {
        int _0xdbd53091 = 1;
        if (this._0xd9000ae8.Count > 0)
        {
            string _0x7ee0ce5c = this._0x17b91767.text;
            foreach (string _0xf103d4d2 in this._0xd9000ae8)
                while (_0x7ee0ce5c.Contains(_0xf103d4d2))
                    _0x7ee0ce5c = _0x7ee0ce5c.Replace(_0xf103d4d2, "");
            _0xdbd53091 = _0x7ee0ce5c.Length;
        }
        else
        {
            _0xdbd53091 = this._0x17b91767.text.Length;
        }

        float _0x5d7c965e = Mathf.Clamp(this._0x537ca92a + this._0x539e2ba3 * _0xdbd53091, this._0x891e65d4, this._0x87d8c360);
        if (!Mathf.Approximately(this._0x5a85d009.aspectRatio, _0x5d7c965e))
            this._0x5a85d009.aspectRatio = _0x5d7c965e;
    }

    private float _0x537ca92a;
}