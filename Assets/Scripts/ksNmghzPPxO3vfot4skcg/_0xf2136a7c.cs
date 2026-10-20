using UnityEngine;

// The carry tray: its tilt is the only thing the player controls. Holding a pad
// turns the tray at a fixed rate, letting go lets it level itself. A press always
// counts for at least RunPlan.MinHoldSeconds so a single quick tap still produces a
// visible swing (the review capture only ever taps).
public sealed class _0xf2136a7c : MonoBehaviour
{
    public float _0x1d2692d4
    {
        get
        {
            return this._0x43645041;
        }
    }

    public void _0x10d1973c(Camera _0x15f3b652, Sprite _0x5fbfdf8a, Sprite _0x689e9bf5)
    {
        float width = _0xf21ad269.ScreenWidth(_0x15f3b652);
        float _0x6914e7d2 = _0xf21ad269.HalfHeight(_0x15f3b652);
        this._0x43645041 = width * _0xf21ad269.TrayWidth;
        this._0x3c1b3efe = _0xf21ad269.Make(this.transform, _0x81982475._0x472e4bc7(new byte[8] { 49, 23, 4, 28, 55, 0, 22, 17 }, 101), _0x689e9bf5, _0xf21ad269.TrayShadowOrder, width * _0xf21ad269.ShadowWidth);
        this._0x3c1b3efe.transform.localPosition = new Vector3(0f, _0x6914e7d2 * _0xf21ad269.ShadowHeight, 0f);
        this._0x3c1b3efe.color = _0x3edf515c.WithAlpha(_0x3edf515c.Ink, 0.30f);
        this._0x0a20f0cf = _0xf21ad269.Make(this.transform, _0x81982475._0x472e4bc7(new byte[9] { 198, 228, 247, 247, 252, 209, 247, 228, 252 }, 133), _0x5fbfdf8a, _0xf21ad269.TrayOrder, this._0x43645041);
        this._0x0a20f0cf.transform.localPosition = new Vector3(0f, _0x6914e7d2 * _0xf21ad269.TrayHeight, 0f);
    }

    public void _0x411ae765()
    {
        this._0xe6a7f649 = 0f;
    }

    public Transform _0xac0a4720
    {
        get
        {
            return this._0x0a20f0cf == null ? this.transform : this._0x0a20f0cf.transform;
        }
    }

    private SpriteRenderer _0x0a20f0cf;
    public void _0x6981918c(float _0x2d5b70c0)
    {
        if (this._0x4393f67e)
        {
            return;
        }

        this._0xe6a7f649 = _0x2d5b70c0;
        this._0xa63311e9 = _0x2d5b70c0;
        this._0x446ba8fc = _0x12a0c0f8.MinHoldSeconds;
    }

    private float _0xe6a7f649;
    public void _0x03051705(float _0x853f7d68)
    {
        if (Mathf.Abs(this._0xe6a7f649 - _0x853f7d68) < 0.01f)
        {
            this._0xe6a7f649 = 0f;
        }
    }

    private SpriteRenderer _0x3c1b3efe;
    private float _0x2c18789d;
    // Set while the round is not running, so a pad press cannot steer a paused belt.
    public bool _0x4393f67e { get; set; }

    public bool _0xcfcfefee
    {
        get
        {
            return this._0xcc25ac2a() != 0f;
        }
    }

    public void _0x26109cc2(float _0x75ee1301)
    {
        if (this._0x0a20f0cf != null)
        {
            this._0x0a20f0cf.transform.localRotation = Quaternion.Euler(0f, 0f, _0x75ee1301 >= 0f ? -42f : 42f);
        }
    }

    private float _0x43645041;
    private float _0x446ba8fc;
    private float _0xcc25ac2a()
    {
        if (this._0xe6a7f649 < -0.5f || this._0xe6a7f649 > 0.5f)
        {
            return this._0xe6a7f649;
        }

        return this._0x446ba8fc > 0f ? this._0xa63311e9 : 0f;
    }

    private float _0xa63311e9;
    public float _0x2b25ba4e
    {
        get
        {
            return this._0x2c18789d;
        }
    }

    public void _0x2e07f020(float step)
    {
        if (this._0x446ba8fc > 0f)
        {
            this._0x446ba8fc -= step;
        }

        float _0x2c3e82de = this._0xcc25ac2a();
        if (_0x2c3e82de < -0.5f || _0x2c3e82de > 0.5f)
        {
            this._0x2c18789d = Mathf.Clamp(this._0x2c18789d + (_0x2c3e82de * _0x12a0c0f8.TiltRate * step), -_0x12a0c0f8.TiltMax, _0x12a0c0f8.TiltMax);
        }
        else if (this._0x2c18789d > 0f)
        {
            this._0x2c18789d = Mathf.Max(0f, this._0x2c18789d - (_0x12a0c0f8.LevelRate * step));
        }
        else if (this._0x2c18789d < 0f)
        {
            this._0x2c18789d = Mathf.Min(0f, this._0x2c18789d + (_0x12a0c0f8.LevelRate * step));
        }

        if (this._0x0a20f0cf != null)
        {
            this._0x0a20f0cf.transform.localRotation = Quaternion.Euler(0f, 0f, -this._0x2c18789d);
        }
    }
}

internal static class _0x81982475
{
    internal static string _0x472e4bc7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}