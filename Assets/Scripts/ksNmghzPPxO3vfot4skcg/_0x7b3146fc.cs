using UnityEngine;

// One plume sliding down its slanted guide. It is caught when the tray is tilted
// to within RunPlan.CatchWindowDegrees of the plume's marked angle at the moment it
// reaches the tray line - which is exactly the tilt that puts the eggs at risk.
public sealed class _0x7b3146fc : MonoBehaviour
{
    public void _0x85f7a9eb()
    {
        if (this._0xb12b70f6 != null)
        {
            this._0xb12b70f6.gameObject.SetActive(false);
        }
    }

    public float _0x57ce7669
    {
        get
        {
            return this._0xdb07d761;
        }
    }

    private float _0xdb07d761;
    public void _0xd4266769(SpriteRenderer _0x98cdbdf5, float _0xf468c96e, float _0x85a2f714, float _0x58adc8aa, float _0xff52cb53, float _0x68c9a19f, float _0x8d7b7e3b)
    {
        this._0xb12b70f6 = _0x98cdbdf5;
        this._0xdb07d761 = _0x68c9a19f;
        this._0x13d80fa2 = _0xff52cb53;
        this._0x569e4434 = false;
        _0xf21ad269.Dress(this._0xb12b70f6, null, _0xf21ad269.PlumeOrder, _0xf468c96e);
        this._0xb12b70f6.color = _0x3edf515c.Sun;
        this._0xb12b70f6.transform.localPosition = new Vector3(_0x85a2f714, _0x58adc8aa, 0f);
        this._0x27457e32 = (_0x58adc8aa - _0xff52cb53) / Mathf.Max(0.4f, _0x8d7b7e3b);
        this._0x8339ed76 = -_0x68c9a19f * 0.012f;
    }

    // Returns true on the frame the plume reaches the tray line.
    public bool _0x012ceb20(float step)
    {
        if (this._0x569e4434 || this._0xb12b70f6 == null)
        {
            return false;
        }

        Vector3 _0x9051524d = this._0xb12b70f6.transform.localPosition;
        _0x9051524d.y -= this._0x27457e32 * step;
        _0x9051524d.x += this._0x8339ed76 * this._0x27457e32 * step * 6f;
        this._0xb12b70f6.transform.localPosition = _0x9051524d;
        this._0xb12b70f6.transform.localRotation = Quaternion.Euler(0f, 0f, this._0xdb07d761);
        if (_0x9051524d.y <= this._0x13d80fa2)
        {
            this._0x569e4434 = true;
            return true;
        }

        return false;
    }

    private float _0x27457e32;
    private SpriteRenderer _0xb12b70f6;
    private bool _0x569e4434;
    public bool _0xcdfd0478
    {
        get
        {
            return this._0x569e4434;
        }
    }

    private float _0x8339ed76;
    private float _0x13d80fa2;
}