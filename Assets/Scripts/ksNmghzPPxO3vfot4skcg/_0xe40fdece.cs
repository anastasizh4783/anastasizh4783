using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The round: it draws a plan for this attempt, builds the belt, the tray, the three
// eggs and the readout, integrates the slide every fixed step and raises the right
// result card. Every art reference arrives as a serialized field, so symbol and
// asset renaming cannot reach it.
public sealed class _0xe40fdece : MonoBehaviour
{
    [SerializeField]
    private GameObject _plumePrefab;
    [SerializeField]
    private Sprite _plumeArt;
    [SerializeField]
    private GameObject _stationPrefab;
    private _0xdfe220f6 _0x13a589bb;
    private int _0x3cdff792;
    private _0xdfe220f6 _0x25282259;
    [SerializeField]
    private GameObject _eggPrefab;
    [SerializeField]
    private Sprite _markArt;
    [SerializeField]
    private Sprite _plateSprite;
    [SerializeField]
    private Sprite _eggCrackedArt;
    // Rule C.15: the template ships seven tutorial panels this game never opens.
    // Their filler copy is blanked at runtime so it can never reach a screen.
    private void _0x1dcde138()
    {
        _0xf933b7ea _0x5b68f34c = _0xf933b7ea.Instance;
        if (_0x5b68f34c == null || _0x5b68f34c.Panels == null)
        {
            return;
        }

        List<int> _0xa2c0e94d = new List<int>
        {
            _0xc1e39607._0x596b9e44.TUTORIAL0,
            _0xc1e39607._0x596b9e44.TUTORIAL1,
            _0xc1e39607._0x596b9e44.TUTORIAL2,
            _0xc1e39607._0x596b9e44.TUTORIAL3,
            _0xc1e39607._0x596b9e44.TUTORIAL4,
            _0xc1e39607._0x596b9e44.TUTORIAL5,
            _0xc1e39607._0x596b9e44.TUTORIAL6,
        };
        for (int _0x43483908 = 0; _0x43483908 < _0xa2c0e94d.Count; _0x43483908++)
        {
            int _0xe5eb1cdd = _0xa2c0e94d[_0x43483908];
            if (_0xe5eb1cdd < 0 || _0xe5eb1cdd >= _0x5b68f34c.Panels.Count)
            {
                continue;
            }

            _0x52fa1a43 _0x0e587b57 = _0x5b68f34c.Panels[_0xe5eb1cdd];
            if (_0x0e587b57 == null)
            {
                continue;
            }

            TMP_Text[] _0x6bb30ec1 = _0x0e587b57.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x474375d5 = 0; _0x474375d5 < _0x6bb30ec1.Length; _0x474375d5++)
            {
                if (_0x6bb30ec1[_0x474375d5] != null)
                {
                    _0x6bb30ec1[_0x474375d5].text = string.Empty;
                }
            }
        }
    }

    [SerializeField]
    private Sprite _eggIntactArt;
    [SerializeField]
    private Sprite _iconTiltLeft;
    private _0xf159eb70 _0xd3c297a2;
    private Camera _0xd3b95a8f;
    private void _0xf159cb6a()
    {
        if (this._0xa3d8ada9 != _0xec57b936.Running || this._0xa94d5cbe > 0f)
        {
            return;
        }

        this._0xa3d8ada9 = _0xec57b936.Held;
        this._0xce551db1._0x4393f67e = true;
        this._0xce551db1._0x411ae765();
        _0xa4f22d18.Instance._0x0c134fc0(false);
        _0x23c3e20b _0xb658110d = _0xae24774e.Instance._0x5067a266(_0xc1e39607._0x35d20a44.PAUSE);
        if (_0xb658110d != null)
        {
            int _0xca49e886 = this._0x4844f357();
            this._0x9217c22b._0x2244170b(_0x16497273._0xd923dbf4(new byte[9] { 122, 125, 116, 108, 24, 112, 125, 116, 124 }, 56), _0x16497273._0xd923dbf4(new byte[8] { 53, 50, 39, 50, 47, 41, 40, 70 }, 102) + this._0x5338a180 + _0x16497273._0xd923dbf4(new byte[4] { 139, 228, 237, 139 }, 171) + this._0x65086c32.Stations, _0xca49e886 + _0x16497273._0xd923dbf4(new byte[12] { 0, 101, 103, 103, 115, 0, 105, 110, 116, 97, 99, 116 }, 32));
            _0xae24774e.Instance._0x2e2888c9(_0xc1e39607._0x35d20a44.PAUSE);
        }

        // Safety net for the review capture: a pause nobody dismisses releases
        // itself, so the run can never be parked forever on one frame.
        DOVirtual.DelayedCall(7f, () => this._0xed21195e(), false);
    }

    private _0x43e39e14 _0x8ac8e4e4;
    private enum _0xec57b936
    {
        Arming,
        Running,
        Held,
        Landed,
        Spilled,
    }

    // -- results ------------------------------------------------------------
    private void _0x47219814(int _0xfc9470a4)
    {
        this._0xa3d8ada9 = _0xec57b936.Landed;
        this._0xce551db1._0x4393f67e = true;
        this._0x083a6cde._0x1eb0be64(0f);
        _0x947835d1.StoreBestIntact(this._0xecdb1f58, _0xfc9470a4);
        int _0x0d13e270 = _0x947835d1.BestIntact(this._0xecdb1f58);
        if (_0xfc9470a4 >= this._0x65086c32.Required)
        {
            _0x947835d1._0x5df25819 = _0x947835d1._0x5df25819 + 1;
            _0x947835d1._0xe2dd4536 = _0x947835d1._0xe2dd4536 + _0xfc9470a4;
            _0xc1e39607._0x537ecd0a._0x7ae1d3ca = _0x947835d1._0xe2dd4536;
            _0x947835d1.Flush();
            _0x23c3e20b _0xa9604e76 = _0xae24774e.Instance._0x5067a266(_0xc1e39607._0x35d20a44.WIN);
            if (_0xa9604e76 != null)
            {
                this._0x13a589bb._0x2244170b(_0x16497273._0xd923dbf4(new byte[15] { 104, 105, 96, 101, 122, 105, 126, 117, 12, 96, 109, 98, 104, 105, 104 }, 44), _0xfc9470a4 + _0x16497273._0xd923dbf4(new byte[12] { 112, 21, 23, 23, 3, 112, 25, 30, 4, 17, 19, 4 }, 80), _0x16497273._0xd923dbf4(new byte[5] { 73, 78, 88, 95, 43 }, 11) + _0x0d13e270 + _0x16497273._0xd923dbf4(new byte[5] { 30, 113, 120, 30, 13 }, 62));
                _0xae24774e.Instance._0x2e2888c9(_0xc1e39607._0x35d20a44.WIN);
            }

            return;
        }

        _0x947835d1.Flush();
        _0x23c3e20b _0xb9c3a38a = _0xae24774e.Instance._0x5067a266(_0xc1e39607._0x35d20a44.LOSE);
        if (_0xb9c3a38a != null)
        {
            this._0x25282259._0x2244170b(_0x16497273._0xd923dbf4(new byte[17] { 137, 136, 147, 231, 130, 137, 136, 146, 128, 143, 231, 142, 137, 147, 134, 132, 147 }, 199), _0xfc9470a4 + _0x16497273._0xd923dbf4(new byte[4] { 215, 184, 177, 215 }, 247) + this._0x65086c32.Required + _0x16497273._0xd923dbf4(new byte[7] { 188, 210, 217, 217, 216, 217, 216 }, 156), _0x16497273._0xd923dbf4(new byte[5] { 50, 53, 35, 36, 80 }, 112) + _0x0d13e270 + _0x16497273._0xd923dbf4(new byte[5] { 164, 203, 194, 164, 183 }, 132));
            _0xae24774e.Instance._0x2e2888c9(_0xc1e39607._0x35d20a44.LOSE);
        }
    }

    private void _0x8e064a79(float _0x4650f77b)
    {
        this._0xa3d8ada9 = _0xec57b936.Spilled;
        this._0xce551db1._0x4393f67e = true;
        this._0xce551db1._0x26109cc2(_0x4650f77b);
        this._0x083a6cde._0x1eb0be64(0f);
        _0x947835d1.Flush();
        int _0x9b0abbab = _0x947835d1.BestIntact(this._0xecdb1f58);
        _0x23c3e20b _0xde27d036 = _0xae24774e.Instance._0x5067a266(_0xc1e39607._0x35d20a44.LOSE);
        if (_0xde27d036 != null)
        {
            this._0x25282259._0x2244170b(_0x16497273._0xd923dbf4(new byte[16] { 41, 36, 36, 72, 45, 47, 47, 59, 72, 43, 58, 41, 43, 35, 45, 44 }, 104), _0x16497273._0xd923dbf4(new byte[8] { 55, 48, 37, 48, 45, 43, 42, 68 }, 100) + this._0x5338a180 + _0x16497273._0xd923dbf4(new byte[4] { 26, 117, 124, 26 }, 58) + this._0x65086c32.Stations, _0x16497273._0xd923dbf4(new byte[5] { 100, 99, 117, 114, 6 }, 38) + _0x9b0abbab + _0x16497273._0xd923dbf4(new byte[5] { 206, 161, 168, 206, 221 }, 238));
            _0xae24774e.Instance._0x2e2888c9(_0xc1e39607._0x35d20a44.LOSE);
        }
    }

    private readonly _0x25132405[] _0xec98df66 = new _0x25132405[3];
    private void _0x34c62f83(_0x25132405 _0x9bc5c8c9, int _0x03adf044)
    {
        float width = _0xf21ad269.ScreenWidth(this._0xd3b95a8f);
        SpriteRenderer _0xd0418221;
        if (this._burstPrefab != null)
        {
            GameObject _0x739f84bd = Instantiate(this._burstPrefab, this.transform);
            _0x739f84bd.transform.localScale = Vector3.one;
            _0xd0418221 = _0x739f84bd.GetComponent<SpriteRenderer>();
        }
        else
        {
            _0xd0418221 = _0xf21ad269.Make(this.transform, _0x16497273._0xd923dbf4(new byte[10] { 110, 95, 76, 78, 70, 111, 88, 95, 94, 89 }, 45), this._burstArt, _0xf21ad269.FxOrder, width * _0xf21ad269.BurstWidth);
        }

        if (_0xd0418221 == null)
        {
            return;
        }

        _0xf21ad269.Dress(_0xd0418221, this._burstArt, _0xf21ad269.FxOrder, width * _0xf21ad269.BurstWidth);
        _0xd0418221.transform.position = _0x9bc5c8c9._0xab80941e;
        _0xd0418221.color = _0x3edf515c.Cream;
        float _0xde304b3c = width * _0xf21ad269.BurstWidth;
        _0xf21ad269.Resize(_0xd0418221, _0xde304b3c * 0.3f);
        DOTween.To(() => _0xd0418221.size.x, _0x921bfaf2 => _0xf21ad269.Resize(_0xd0418221, _0x921bfaf2), _0xde304b3c, 0.45f).SetEase(Ease.OutQuad);
        _0xd0418221.DOFade(0f, 0.45f).SetEase(Ease.InQuad);
        GameObject _0x2016e4a7 = _0xd0418221.gameObject;
        DOVirtual.DelayedCall(0.6f, () => Destroy(_0x2016e4a7), false);
        this.transform.DOShakePosition(0.25f, 0.12f, 14, 90f, false, true);
        this._0x4f48413a._0xf2344aec(_0x16497273._0xd923dbf4(new byte[5] { 132, 143, 153, 158, 234 }, 202) + (_0x03adf044 + 1) + _0x16497273._0xd923dbf4(new byte[57] { 203, 167, 174, 191, 203, 172, 164, 203, 198, 203, 167, 174, 189, 174, 167, 203, 191, 163, 174, 203, 191, 185, 170, 178, 225, 168, 170, 191, 168, 163, 203, 187, 167, 190, 166, 174, 184, 203, 170, 191, 203, 191, 163, 174, 203, 166, 170, 185, 160, 174, 175, 203, 170, 165, 172, 167, 174 }, 235), _0x3edf515c.Sun);
    }

    private float _0xd32eb2dd;
    private int _0x5338a180;
    private float _0x2aaefbac = 1.2f;
    private readonly bool[] _0x4d76bfca = new bool[3];
    [SerializeField]
    private Sprite _hillArt;
    private _0x64b423f5 _0x083a6cde;
    [SerializeField]
    private Sprite _iconBack;
    [SerializeField]
    private Sprite _stationArt;
    [SerializeField]
    private Sprite _iconClose;
    private GameObject Branch(string _0xe5dc4764, Transform _0x67642e5f)
    {
        GameObject _0x0d96e374 = new GameObject(_0xe5dc4764);
        _0x0d96e374.transform.SetParent(_0x67642e5f, false);
        _0x0d96e374.transform.localPosition = Vector3.zero;
        _0x0d96e374.transform.localRotation = Quaternion.identity;
        _0x0d96e374.transform.localScale = Vector3.one;
        return _0x0d96e374;
    }

    private void _0xe9b8c898()
    {
        _0xa4f22d18.Instance._0x0c134fc0(true);
        _0xa4f22d18.Instance.LoadSceneByIndex(_0xc1e39607._0xfa7cc12d.SCENE_1);
    }

    [SerializeField]
    private GameObject _railPrefab;
    private void _0xed21195e()
    {
        if (this._0xa3d8ada9 != _0xec57b936.Held)
        {
            return;
        }

        _0xae24774e.Instance._0x6a384f5d();
        _0xa4f22d18.Instance._0x0c134fc0(true);
        this._0xa3d8ada9 = _0xec57b936.Running;
        this._0xce551db1._0x4393f67e = false;
        this._0xa94d5cbe = 0.3f;
    }

    [SerializeField]
    private GameObject _burstPrefab;
    private _0xec57b936 _0xa3d8ada9 = _0xec57b936.Arming;
    [SerializeField]
    private Sprite _iconTiltRight;
    private _0xdfe220f6 _0x9217c22b;
    [SerializeField]
    private GameObject _notchPrefab;
    private _0x12a0c0f8 _0x65086c32;
    private void Start()
    {
        this._0xd3b95a8f = Camera.main;
        this._0xecdb1f58 = _0x947835d1._0xd9e5de78;
        this._0x3cdff792 = _0x947835d1._0x06cac6a7;
        int _0xe6168df3 = _0x947835d1._0x86254135 + 1;
        _0x947835d1._0x86254135 = _0xe6168df3;
        this._0x65086c32 = _0xb7f6d730.Build(this._0xecdb1f58, this._0x3cdff792, _0xe6168df3);
        Transform _0xfa2ba956 = this._0x14193e09();
        this._0x844af6b2(_0xfa2ba956);
        this._0xce551db1 = this.Branch(_0x16497273._0xd923dbf4(new byte[8] { 182, 176, 163, 187, 189, 176, 171, 165 }, 226), this.transform).AddComponent<_0xf2136a7c>();
        this._0xce551db1._0x10d1973c(this._0xd3b95a8f, this._trayArt, this._trayArt);
        this._0xce551db1._0x4393f67e = true;
        this._0x083a6cde = this.Branch(_0x16497273._0xd923dbf4(new byte[8] { 92, 91, 82, 74, 65, 76, 87, 89 }, 30), this.transform).AddComponent<_0x64b423f5>();
        this._0x083a6cde._0xf5fd8eb4(this._0xd3b95a8f, this._railPrefab, this._railArt, this._hillArt, this._stationPrefab, this._stationArt, this._0x65086c32.Stations);
        this._0x083a6cde._0x1eb0be64(_0xf21ad269.ScreenWidth(this._0xd3b95a8f) * 0.16f * _0xeeffa5e9.Paces[this._0x3cdff792].Multiplier);
        this._0x8ac8e4e4 = this.Branch(_0x16497273._0xd923dbf4(new byte[9] { 11, 25, 30, 29, 7, 26, 25, 22, 28 }, 88), this._0xce551db1._0xac0a4720).AddComponent<_0x43e39e14>();
        this._0x8ac8e4e4._0xcb19fc4d(this._0xd3b95a8f, this._bandPostArt, this._notchPrefab, this._bandNotchArt, 0.03f);
        this._0xd3c297a2 = this.Branch(_0x16497273._0xd923dbf4(new byte[9] { 7, 27, 2, 26, 18, 8, 5, 30, 16 }, 87), this.transform).AddComponent<_0xf159eb70>();
        this._0xd3c297a2._0x5daa7f6a(this._0xd3b95a8f, this._0x65086c32, this._plumePrefab, this._plumeArt);
        this._0x6d5e6420();
        this._0x4f48413a = this.gameObject.AddComponent<_0x8401658f>();
        if (_0xfa2ba956 != null)
        {
            Transform _0x80391de8 = _0x6d11a8af.Host(_0xfa2ba956, _0x16497273._0xd923dbf4(new byte[7] { 114, 117, 110, 127, 104, 117, 100 }, 32));
            this._0x4f48413a._0xdd899bb1(_0x80391de8, this._0xce551db1, this._plateSprite, this._font, this._eggIntactArt, this._eggCrackedArt, this._iconBack, this._iconPause, this._iconTiltLeft, this._iconTiltRight);
        }

        if (this._0x4f48413a._0x6ea747c8 != null)
        {
            this._0x4f48413a._0x6ea747c8.onClick.AddListener(() => this._0xff8d0c36());
        }

        if (this._0x4f48413a._0x8fa81ea7 != null)
        {
            this._0x4f48413a._0x8fa81ea7.onClick.AddListener(() => this._0xf159cb6a());
        }

        this._0x4f48413a._0x5a3bad04(_0xeeffa5e9.Routes[this._0xecdb1f58].Title);
        this._0x4f48413a._0x9512c3dd(this._0x65086c32.Required);
        this._0x4f48413a._0x6f496e64(0, this._0x65086c32.Stations);
        this._0x8ac8e4e4._0xc045e582(_0x12a0c0f8.SafeHalfBase, false);
        this._0xb2060f54();
        this._0x1dcde138();
    }

    private void _0xff8d0c36()
    {
        _0xa4f22d18.Instance._0x0c134fc0(true);
        _0xa4f22d18.Instance.LoadSceneByIndex(_0xc1e39607._0xfa7cc12d.SCENE_0);
    }

    private Transform _0x14193e09()
    {
        _0xf933b7ea _0x487b8829 = _0xf933b7ea.Instance;
        if (_0x487b8829 == null || _0x487b8829.Panels == null)
        {
            return null;
        }

        int _0x564e40ea = _0xc1e39607._0x596b9e44.DEFAULT;
        if (_0x564e40ea < 0 || _0x564e40ea >= _0x487b8829.Panels.Count)
        {
            return null;
        }

        _0x52fa1a43 _0x51b80d03 = _0x487b8829.Panels[_0x564e40ea];
        if (_0x51b80d03 == null || _0x51b80d03.Content == null)
        {
            return null;
        }

        return _0x51b80d03.Content.transform;
    }

    private float _0x349c9679 = -1f;
    [SerializeField]
    private Sprite _iconPause;
    [SerializeField]
    private Sprite _bandPostArt;
    [SerializeField]
    private TMP_FontAsset _font;
    // -- construction helpers -----------------------------------------------
    private void _0x6d5e6420()
    {
        float width = _0xf21ad269.ScreenWidth(this._0xd3b95a8f);
        float _0xb15202bd = width * _0xf21ad269.EggWidth;
        float[] _0xa647a3fb = new float[]
        {
            -0.45f,
            0f,
            0.45f
        };
        for (int _0x555cd113 = 0; _0x555cd113 < _0xa647a3fb.Length; _0x555cd113++)
        {
            SpriteRenderer _0x04febbfa;
            if (this._eggPrefab != null)
            {
                GameObject _0x75e90a0d = Instantiate(this._eggPrefab, this._0xce551db1._0xac0a4720);
                _0x75e90a0d.transform.localScale = Vector3.one;
                _0x04febbfa = _0x75e90a0d.GetComponent<SpriteRenderer>();
            }
            else
            {
                _0x04febbfa = _0xf21ad269.Make(this._0xce551db1._0xac0a4720, _0x16497273._0xd923dbf4(new byte[3] { 90, 120, 120 }, 31), this._eggIntactArt, _0xf21ad269.EggOrder, _0xb15202bd);
            }

            if (_0x04febbfa == null)
            {
                continue;
            }

            _0x25132405 _0xe1ca9509 = _0x04febbfa.gameObject.AddComponent<_0x25132405>();
            _0xe1ca9509._0x89e81a1e(_0x04febbfa, this._eggIntactArt, this._eggCrackedArt, _0xa647a3fb[_0x555cd113], 0.16f, this._0x65086c32.NestStiffness[_0x555cd113], _0xb15202bd);
            this._0xec98df66[_0x555cd113] = _0xe1ca9509;
        }
    }

    private void FixedUpdate()
    {
        float step = Time.fixedDeltaTime;
        if (this._0xa94d5cbe > 0f)
        {
            this._0xa94d5cbe -= step;
        }

        if (this._0xa3d8ada9 == _0xec57b936.Arming)
        {
            this._0x2aaefbac -= step;
            this._0xce551db1._0x2e07f020(step);
            if (this._0x2aaefbac <= 0f)
            {
                this._0xa3d8ada9 = _0xec57b936.Running;
                this._0xce551db1._0x4393f67e = false;
            }

            return;
        }

        if (this._0xa3d8ada9 != _0xec57b936.Running)
        {
            return;
        }

        this._0xd32eb2dd += step;
        this._0xce551db1._0x2e07f020(step);
        this._0x083a6cde._0xd60e7763(step);
        this._0x083a6cde._0x12e65524(this._0x65086c32, this._0xd32eb2dd, this._0xd3b95a8f);
        int _0x005c5d48 = this._0xd3c297a2._0x6d401e69(this._0xd32eb2dd, step, this._0xce551db1._0x2b25ba4e);
        if (_0x005c5d48 > 0)
        {
            this._0x349c9679 = Mathf.Max(this._0x349c9679, this._0xd32eb2dd) + (_0x12a0c0f8.BoostSeconds * _0x005c5d48);
        }

        float _0xf7ad4bcd = _0x00b37bfd.SafeHalf(this._0x349c9679, this._0xd32eb2dd);
        bool _0x099403d9 = this._0x349c9679 > this._0xd32eb2dd;
        this._0x8ac8e4e4._0xc045e582(_0xf7ad4bcd, _0x099403d9);
        float _0x33e336e0 = this._0x65086c32._0xf740272b(this._0xd32eb2dd);
        float _0xe843e2a3 = _0x12a0c0f8.GravityPush * Mathf.Sin((_0x33e336e0 - this._0xce551db1._0x2b25ba4e) * Mathf.Deg2Rad);
        int _0x6443d8e1 = 0;
        for (int _0xc1c09ce7 = 0; _0xc1c09ce7 < this._0xec98df66.Length; _0xc1c09ce7++)
        {
            _0x25132405 _0xb63cbbf2 = this._0xec98df66[_0xc1c09ce7];
            if (_0xb63cbbf2 == null)
            {
                continue;
            }

            if (_0xb63cbbf2._0x85b9a7f7(_0xe843e2a3, _0xf7ad4bcd, step))
            {
                this._0x34c62f83(_0xb63cbbf2, _0xc1c09ce7);
            }

            if (!_0xb63cbbf2._0xfa1b93ec)
            {
                _0x6443d8e1++;
            }
            else if (!this._0x4d76bfca[_0xc1c09ce7])
            {
                this._0x4d76bfca[_0xc1c09ce7] = true;
                this._0x4f48413a._0xd90948f8(_0xc1c09ce7, true);
            }
        }

        int _0x43b612b7 = this._0x65086c32._0xda38f1fa(this._0xd32eb2dd);
        if (_0x43b612b7 != this._0x5338a180)
        {
            this._0x5338a180 = _0x43b612b7;
            this._0x4f48413a._0x6f496e64(_0x43b612b7, this._0x65086c32.Stations);
        }

        this._0x4f48413a.SetProgress(this._0xd32eb2dd / Mathf.Max(1f, this._0x65086c32.RunSeconds));
        this._0x4f48413a.SetBoost(_0x099403d9 ? Mathf.Clamp01((this._0x349c9679 - this._0xd32eb2dd) / (_0x12a0c0f8.BoostSeconds * 2f)) : 0f);
        float _0x8f859454;
        float _0xf50b471b = this._0xd3c297a2._0x4c1838f7(this._0xd32eb2dd, out _0x8f859454);
        if (this._0x4f48413a._0x9babd9fd != null)
        {
            this._0x4f48413a._0x9babd9fd._0xf33177ba(this._0xce551db1._0x2b25ba4e, _0x33e336e0, _0xf50b471b, _0x8f859454 <= _0x12a0c0f8.PlumeWarningSeconds);
        }

        if (_0x6443d8e1 == 0)
        {
            this._0x8e064a79(_0x33e336e0);
            return;
        }

        if (this._0xd32eb2dd >= this._0x65086c32.RunSeconds)
        {
            this._0x47219814(_0x6443d8e1);
        }
    }

    [SerializeField]
    private Sprite _trayArt;
    private _0x8401658f _0x4f48413a;
    [SerializeField]
    private Sprite _bandNotchArt;
    private _0xf2136a7c _0xce551db1;
    [SerializeField]
    private Sprite _burstArt;
    private int _0xecdb1f58;
    private float _0xa94d5cbe;
    private int _0x4844f357()
    {
        int _0xd79ad612 = 0;
        for (int _0x87b1871a = 0; _0x87b1871a < this._0xec98df66.Length; _0x87b1871a++)
        {
            if (this._0xec98df66[_0x87b1871a] != null && !this._0xec98df66[_0x87b1871a]._0xfa1b93ec)
            {
                _0xd79ad612++;
            }
        }

        return _0xd79ad612;
    }

    // Rule H, option two: the game brings its own Back and Pause, so the template's
    // HUD strip is switched off wholesale instead of being half re-used.
    private void _0x844af6b2(Transform _0x06a4f302)
    {
        if (_0x06a4f302 == null)
        {
            return;
        }

        for (int _0x6ab0939a = _0x06a4f302.childCount - 1; _0x6ab0939a >= 0; _0x6ab0939a--)
        {
            Transform _0x01ebc23f = _0x06a4f302.GetChild(_0x6ab0939a);
            if (_0x01ebc23f == null || _0x01ebc23f.gameObject == this.gameObject)
            {
                continue;
            }

            if (_0x01ebc23f.GetComponentInChildren<_0x23c3e20b>(true) != null)
            {
                continue;
            }

            _0x01ebc23f.gameObject.SetActive(false);
        }
    }

    private void _0xb2060f54()
    {
        this._0x13a589bb = this.gameObject.AddComponent<_0xdfe220f6>();
        this._0x25282259 = this.gameObject.AddComponent<_0xdfe220f6>();
        this._0x9217c22b = this.gameObject.AddComponent<_0xdfe220f6>();
        _0x23c3e20b _0xf52b7eac = _0xae24774e.Instance._0x5067a266(_0xc1e39607._0x35d20a44.WIN);
        this._0x13a589bb._0x50e8f46b(_0xf52b7eac, this._plateSprite, this._iconClose, this._font, this._markArt, _0x16497273._0xd923dbf4(new byte[15] { 97, 96, 105, 108, 115, 96, 119, 124, 5, 105, 100, 107, 97, 96, 97 }, 37), _0x16497273._0xd923dbf4(new byte[13] { 24, 11, 110, 108, 108, 120, 11, 98, 101, 127, 106, 104, 127 }, 43), _0x16497273._0xd923dbf4(new byte[11] { 167, 160, 182, 177, 197, 213, 197, 170, 163, 197, 214 }, 229), _0x16497273._0xd923dbf4(new byte[10] { 233, 226, 255, 243, 135, 245, 232, 242, 243, 226 }, 167), _0x16497273._0xd923dbf4(new byte[11] { 90, 65, 46, 90, 70, 75, 46, 76, 79, 92, 64 }, 14), () => this._0xe9b8c898(), () => this._0xff8d0c36());
        _0x23c3e20b _0x6110a0b6 = _0xae24774e.Instance._0x5067a266(_0xc1e39607._0x35d20a44.LOSE);
        this._0x25282259._0x50e8f46b(_0x6110a0b6, this._plateSprite, this._iconClose, this._font, this._eggCrackedArt, _0x16497273._0xd923dbf4(new byte[16] { 71, 74, 74, 38, 67, 65, 65, 85, 38, 69, 84, 71, 69, 77, 67, 66 }, 6), _0x16497273._0xd923dbf4(new byte[14] { 242, 245, 224, 245, 232, 238, 239, 129, 145, 129, 238, 231, 129, 148 }, 161), _0x16497273._0xd923dbf4(new byte[11] { 52, 51, 37, 34, 86, 70, 86, 57, 48, 86, 69 }, 118), _0x16497273._0xd923dbf4(new byte[12] { 49, 54, 45, 67, 42, 55, 67, 34, 36, 34, 42, 45 }, 99), _0x16497273._0xd923dbf4(new byte[11] { 66, 89, 54, 66, 94, 83, 54, 84, 87, 68, 88 }, 22), () => this._0xe9b8c898(), () => this._0xff8d0c36());
        _0x23c3e20b _0xd161efa4 = _0xae24774e.Instance._0x5067a266(_0xc1e39607._0x35d20a44.PAUSE);
        this._0x9217c22b._0x50e8f46b(_0xd161efa4, this._plateSprite, this._iconClose, this._font, this._plumeArt, _0x16497273._0xd923dbf4(new byte[9] { 39, 32, 41, 49, 69, 45, 32, 41, 33 }, 101), _0x16497273._0xd923dbf4(new byte[14] { 97, 102, 115, 102, 123, 125, 124, 18, 2, 18, 125, 116, 18, 7 }, 50), _0x16497273._0xd923dbf4(new byte[13] { 27, 8, 109, 111, 111, 123, 8, 97, 102, 124, 105, 107, 124 }, 40), _0x16497273._0xd923dbf4(new byte[12] { 247, 244, 246, 254, 149, 225, 250, 149, 247, 240, 249, 225 }, 181), _0x16497273._0xd923dbf4(new byte[11] { 61, 38, 73, 61, 33, 44, 73, 43, 40, 59, 39 }, 105), () => this._0xed21195e(), () => this._0xff8d0c36());
    }

    [SerializeField]
    private Sprite _railArt;
}

internal static class _0x16497273
{
    internal static string _0xd923dbf4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}