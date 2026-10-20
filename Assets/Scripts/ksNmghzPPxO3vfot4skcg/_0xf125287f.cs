using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

// Everything the menu scene needs doing to the template itself: the splash gets an
// abstract mark of its own and a darker wash so it never reads as the menu, and the
// seven tutorial panels this game never opens have their filler copy blanked at
// runtime (rule C.15). No game name appears anywhere - the mark is a ring and an egg
// silhouette, pure shape.
public sealed class _0xf125287f : MonoBehaviour
{
    [SerializeField]
    private TMP_FontAsset _font;
    private void _0x6c3a4373()
    {
        _0xf933b7ea _0x1bf6d1df = _0xf933b7ea.Instance;
        if (_0x1bf6d1df == null || _0x1bf6d1df.Panels == null)
        {
            return;
        }

        int _0xe1b58d5c = _0xc1e39607._0x596b9e44.SPLASH;
        if (_0xe1b58d5c < 0 || _0xe1b58d5c >= _0x1bf6d1df.Panels.Count)
        {
            return;
        }

        _0x52fa1a43 _0x7c844879 = _0x1bf6d1df.Panels[_0xe1b58d5c];
        if (_0x7c844879 == null || _0x7c844879.Content == null)
        {
            return;
        }

        Transform _0xfbac892e = _0x7c844879.Content.transform;
        List<Transform> _0xb3ac5448 = new List<Transform>();
        for (int _0xce1a7b02 = 0; _0xce1a7b02 < _0xfbac892e.childCount; _0xce1a7b02++)
        {
            _0xb3ac5448.Add(_0xfbac892e.GetChild(_0xce1a7b02));
        }

        _0x6d11a8af.Plate(_0xfbac892e, _0xd7c0b6c3._0x2a733ade(new byte[10] { 11, 40, 52, 57, 43, 48, 15, 57, 43, 48 }, 88), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1500f, 3000f), _0x3edf515c.Shade, null, 1f);
        RectTransform _0x11e24c93 = _0x6d11a8af.Node(_0xfbac892e, _0xd7c0b6c3._0x2a733ade(new byte[10] { 24, 59, 39, 42, 56, 35, 6, 42, 57, 32 }, 75), new Vector2(0.5f, 0.600f), Vector2.zero, new Vector2(420f, 420f));
        _0x6d11a8af.Picture(_0x11e24c93, _0xd7c0b6c3._0x2a733ade(new byte[10] { 224, 195, 223, 210, 192, 219, 225, 218, 221, 212 }, 179), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(420f, 420f), this._markArt, _0x3edf515c.Sun);
        RectTransform _0xef1e0c0d = _0x6d11a8af.Picture(_0x11e24c93, _0xd7c0b6c3._0x2a733ade(new byte[11] { 215, 244, 232, 229, 247, 236, 215, 236, 225, 232, 232 }, 132), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(170f, 170f), this._eggArt, _0x3edf515c.Cream).rectTransform;
        _0x6d11a8af.Label(_0xfbac892e, _0xd7c0b6c3._0x2a733ade(new byte[13] { 161, 130, 158, 147, 129, 154, 177, 147, 130, 134, 155, 157, 156 }, 242), new Vector2(0.5f, 0.170f), Vector2.zero, new Vector2(900f, 60f), _0xd7c0b6c3._0x2a733ade(new byte[16] { 246, 245, 251, 254, 243, 244, 253, 154, 238, 242, 255, 154, 248, 255, 246, 238 }, 186), 30f, _0x3edf515c.WithAlpha(_0x3edf515c.Cream, 0.85f), this._font, TextAlignmentOptions.Center);
        // The loading bar is the splash's only template child; push it back to the
        // front so nothing added here can cover it.
        for (int _0x874fe20c = 0; _0x874fe20c < _0xb3ac5448.Count; _0x874fe20c++)
        {
            if (_0xb3ac5448[_0x874fe20c] != null)
            {
                _0xb3ac5448[_0x874fe20c].SetAsLastSibling();
            }
        }

        _0x11e24c93.DOLocalRotate(new Vector3(0f, 0f, -360f), 9f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
        _0xef1e0c0d.DOLocalRotate(new Vector3(0f, 0f, 4f), 2.2f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).From(new Vector3(0f, 0f, -4f));
    }

    private void Start()
    {
        this._0x6c3a4373();
        this._0x1a2007ce();
    }

    // Rule C.15: panels TUTORIAL0..TUTORIAL6 ship with the template's filler copy and
    // this game never opens them, so their text is emptied rather than left to ride
    // along into a build. The panels stay in place - the controller addresses them by
    // index, so removing one would break navigation.
    private void _0x1a2007ce()
    {
        _0xf933b7ea _0x51416a38 = _0xf933b7ea.Instance;
        if (_0x51416a38 == null || _0x51416a38.Panels == null)
        {
            return;
        }

        List<int> _0x419fe119 = new List<int>
        {
            _0xc1e39607._0x596b9e44.TUTORIAL0,
            _0xc1e39607._0x596b9e44.TUTORIAL1,
            _0xc1e39607._0x596b9e44.TUTORIAL2,
            _0xc1e39607._0x596b9e44.TUTORIAL3,
            _0xc1e39607._0x596b9e44.TUTORIAL4,
            _0xc1e39607._0x596b9e44.TUTORIAL5,
            _0xc1e39607._0x596b9e44.TUTORIAL6,
        };
        for (int _0x6eb90bd9 = 0; _0x6eb90bd9 < _0x419fe119.Count; _0x6eb90bd9++)
        {
            int _0xaaa432c0 = _0x419fe119[_0x6eb90bd9];
            if (_0xaaa432c0 < 0 || _0xaaa432c0 >= _0x51416a38.Panels.Count)
            {
                continue;
            }

            _0x52fa1a43 _0xce282918 = _0x51416a38.Panels[_0xaaa432c0];
            if (_0xce282918 == null)
            {
                continue;
            }

            TMP_Text[] _0xd5462a9a = _0xce282918.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x224c5c64 = 0; _0x224c5c64 < _0xd5462a9a.Length; _0x224c5c64++)
            {
                if (_0xd5462a9a[_0x224c5c64] != null)
                {
                    _0xd5462a9a[_0x224c5c64].text = string.Empty;
                }
            }
        }
    }

    [SerializeField]
    private Sprite _eggArt;
    [SerializeField]
    private Sprite _markArt;
}

internal static class _0xd7c0b6c3
{
    internal static string _0x2a733ade(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}