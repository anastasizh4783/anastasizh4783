using UnityEngine;

// Every world size and height in this game is a FRACTION of the camera, never a
// literal (rule C.0): the 2D camera is orthographic size 5 in portrait, so the
// visible world is 10 units tall and 10 * aspect wide. Sorting orders are named
// constants inside the -19..-1 band so gameplay art always draws above the
// background canvas and below the Win / Lose / Pause pops (rule C.21).
public static class _0xf21ad269
{
    public const int FxOrder = -2;
    public const float HillsHeight = 0.220f;
    public const float PlumeTopHeight = 0.520f;
    public static void Resize(SpriteRenderer _0x89579286, float _0x6d519829)
    {
        if (_0x89579286 == null)
        {
            return;
        }

        float _0x87733793 = Mathf.Max(0.02f, _0x6d519829);
        _0x89579286.size = new Vector2(_0x87733793, _0x87733793);
    }

    public const int StationOrder = -12;
    public static float HalfHeight(Camera _0x8cf29c14)
    {
        return _0x8cf29c14 == null ? 5f : _0x8cf29c14.orthographicSize;
    }

    // widths as a fraction of the visible screen width
    public const float TrayWidth = 0.660f;
    public static float ScreenWidth(Camera _0x8eddd72a)
    {
        return HalfWidth(_0x8eddd72a) * 2f;
    }

    public const float BurstWidth = 0.152f;
    public const float BandHeight = -0.204f;
    // A world sprite: Sliced draw mode so m_Size is the single source of truth and
    // the object is exactly as big as the camera maths says, with the transform
    // scale left at one so the two mechanisms never fight (rule C.0).
    public static SpriteRenderer Make(Transform _0x586ef641, string _0xa2ee2a9f, Sprite _0x99d2ba97, int _0x227c2e59, float _0x2aab69a1)
    {
        GameObject _0x520c8967 = new GameObject(_0xa2ee2a9f);
        _0x520c8967.transform.SetParent(_0x586ef641, false);
        _0x520c8967.transform.localScale = Vector3.one;
        SpriteRenderer _0xd9df2984 = _0x520c8967.AddComponent<SpriteRenderer>();
        _0xd9df2984.sprite = _0x99d2ba97;
        _0xd9df2984.drawMode = SpriteDrawMode.Sliced;
        _0xd9df2984.sortingOrder = _0x227c2e59;
        Resize(_0xd9df2984, _0x2aab69a1);
        return _0xd9df2984;
    }

    public const float BandNotchWidth = 0.042f;
    // heights as a fraction of the visible half height
    public const float BeltHeight = -0.310f;
    public const float PlumeWidth = 0.104f;
    public const float StationWidth = 0.190f;
    public const float RailWidth = 0.118f;
    public static float HalfWidth(Camera _0x96650719)
    {
        float _0x6ba693e0 = HalfHeight(_0x96650719);
        float _0xd0a04bed = _0x96650719 == null ? 0.4615f : _0x96650719.aspect;
        return _0x6ba693e0 * _0xd0a04bed;
    }

    public const int EggOrder = -5;
    public const float TrayHeight = -0.210f;
    public static void SetAlpha(SpriteRenderer _0x9ba94f80, float _0x6cd35555)
    {
        if (_0x9ba94f80 == null)
        {
            return;
        }

        Color _0x039a1ff1 = _0x9ba94f80.color;
        _0x9ba94f80.color = new Color(_0x039a1ff1.r, _0x039a1ff1.g, _0x039a1ff1.b, _0x6cd35555);
    }

    public static void Dress(SpriteRenderer _0x69738012, Sprite _0xc0c7de1e, int _0x33f3dd70, float _0x0f04cfab)
    {
        if (_0x69738012 == null)
        {
            return;
        }

        if (_0xc0c7de1e != null)
        {
            _0x69738012.sprite = _0xc0c7de1e;
        }

        _0x69738012.drawMode = SpriteDrawMode.Sliced;
        _0x69738012.sortingOrder = _0x33f3dd70;
        _0x69738012.transform.localScale = Vector3.one;
        Resize(_0x69738012, _0x0f04cfab);
    }

    public const int RailOrder = -14;
    public const float ShadowHeight = -0.244f;
    public const float EggWidth = 0.098f;
    public const int TrayOrder = -7;
    public const float ShadowWidth = 0.620f;
    public const int TrayShadowOrder = -8;
    public const float BandPostWidth = 0.062f;
    public const float HillWidth = 0.560f;
    public const int BandOrder = -10;
    public const int BackdropOrder = -19;
    public const int HillsOrder = -17;
    public const float StationHeight = -0.150f;
    public const int PlumeOrder = -3;
}