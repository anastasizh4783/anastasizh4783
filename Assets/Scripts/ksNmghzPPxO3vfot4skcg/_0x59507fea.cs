using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// A tilt pad. A Button only reports a click, and this control needs press AND
// release, so the pad takes the two UGUI pointer interfaces instead. Those carry no
// names, so symbol renaming cannot break them, and the pad is therefore not a
// Button and needs no onClick wiring.
public sealed class _0x59507fea : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private _0xf2136a7c _0x7df427d1;
    private void _0xa1b8aad5(bool _0xbd20788b)
    {
        if (this._0x718a50b9 != null)
        {
            this._0x718a50b9.color = _0xbd20788b ? _0x3edf515c.Sun : this._0x152408c8;
        }

        if (this._0xf3ed3a79 != null)
        {
            this._0xf3ed3a79.color = _0xbd20788b ? _0x3edf515c.SlateSoft : this._0xe04857ee;
        }

        this.transform.localScale = _0xbd20788b ? new Vector3(0.96f, 0.96f, 1f) : Vector3.one;
    }

    private Image _0x718a50b9;
    private Image _0xf3ed3a79;
    public void _0xb96b1f17(_0xf2136a7c _0x5948ac18, float _0x393bb78d, Image _0xa3f12970, Image _0x03d391b6)
    {
        this._0x7df427d1 = _0x5948ac18;
        this._0x3e61a6ef = _0x393bb78d;
        this._0x718a50b9 = _0xa3f12970;
        this._0xf3ed3a79 = _0x03d391b6;
        this._0x152408c8 = _0xa3f12970 == null ? _0x3edf515c.Sun : _0xa3f12970.color;
        this._0xe04857ee = _0x03d391b6 == null ? _0x3edf515c.SlateDeep : _0x03d391b6.color;
    }

    private float _0x3e61a6ef;
    private Color _0xe04857ee;
    public void OnPointerDown(PointerEventData _0xe3aeb463)
    {
        if (this._0x7df427d1 != null)
        {
            this._0x7df427d1._0x6981918c(this._0x3e61a6ef);
        }

        this._0xa1b8aad5(true);
    }

    public void OnPointerUp(PointerEventData _0x26786c9d)
    {
        if (this._0x7df427d1 != null)
        {
            this._0x7df427d1._0x03051705(this._0x3e61a6ef);
        }

        this._0xa1b8aad5(false);
    }

    private Color _0x152408c8;
    private void OnDisable()
    {
        if (this._0x7df427d1 != null)
        {
            this._0x7df427d1._0x03051705(this._0x3e61a6ef);
        }

        this._0xa1b8aad5(false);
    }
}