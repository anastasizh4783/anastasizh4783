using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xc1e39607;

public class _0xf933b7ea : MonoBehaviour
{
    public List<_0x52fa1a43> Panels;
    private _0x52fa1a43 _0x11a28d80(int _0x39fcd885)
    {
        return this.Panels[_0x39fcd885];
    }

    public void _0x3a769aa4()
    {
        this.LastPanelIndexes.RemoveAll(_0x851763cb => _0x851763cb == this.CurrentPanelIndex);
        int _0x699f3f21 = this.LastPanelIndexes.Last();
        this._0x68247d48(_0x699f3f21);
        this._0xac36da5b(_0x699f3f21);
        this.CurrentPanelIndex = _0x699f3f21;
        this.Panels[_0x699f3f21].Show();
    }

    private void _0x68247d48(int _0xb88c23ed)
    {
        if (_0xb88c23ed == _0x596b9e44.SPLASH)
            _0x2561fcee.Instance._0x5445bb45();
        if (_0xa4f22d18.Instance._0x1a25e84a == _0xfa7cc12d.SCENE_0)
        {
        }
    }

    public float ScaleDuration = 0.4f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xf933b7ea>();
    }

    public void _0x2fd2a263(int _0x6ad6da78)
    {
        if (_0x6ad6da78 == _0x596b9e44.SPLASH && _0xa4f22d18.Instance._0x1a25e84a != _0xfa7cc12d.SCENE_0)
            _0x2561fcee.Instance._0x4f346730();
        if (_0xa4f22d18.Instance._0x1a25e84a != _0xfa7cc12d.SCENE_0)
        {
            if (_0x6ad6da78 == _0x596b9e44.SPLASH || _0x6ad6da78 == _0x596b9e44.TUTORIAL0)
                _0xa4f22d18.Instance._0x0c134fc0(false);
            else if (_0x6ad6da78 == _0x596b9e44.DEFAULT)
                _0xa4f22d18.Instance._0x0c134fc0(true);
        }
    }

    private void _0x9fe73fbc()
    {
        this._0x6720fdc0(_0x596b9e44.SPLASH);
        if (_0xa4f22d18.Instance._0x1a25e84a == _0xfa7cc12d.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x2561fcee.Instance.DefaultAnimationTime);
        }
    }

    public float StaticBlurMaterialInitialValue;
    public bool IsShowSplashOnStart = true;
    private void _0x9f830727(int _0x275f032f)
    {
        this.LastPanelIndexes.Add(_0x275f032f);
        this.CurrentPanelIndex = _0x275f032f;
        for (int _0xe176cc67 = 0; _0xe176cc67 < this.Panels.Count; _0xe176cc67++)
            if (_0xe176cc67 != _0x275f032f && this.Panels[_0xe176cc67] != null)
                this.Panels[_0xe176cc67]._0xcbf3bc6f();
    }

    public static _0xf933b7ea Instance;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public void _0x5472689a(int _0x8269cb48)
    {
        this._0x9f830727(_0x8269cb48);
        this._0x68247d48(_0x8269cb48);
        this.CurrentPanelIndex = _0x8269cb48;
        this.Panels[_0x8269cb48].Show();
    }

    private void _0x6720fdc0(int _0x2ea5b287)
    {
        this._0x9f830727(_0x2ea5b287);
        this._0x68247d48(_0x2ea5b287);
        this.CurrentPanelIndex = _0x2ea5b287;
        this.Panels[_0x2ea5b287]._0xb3a0e90b();
    }

    private void Start()
    {
        this._0x9fe73fbc();
    }

    public int CurrentPanelIndex;
    private void _0xac36da5b(int _0x5f4bdb32)
    {
        this.LastPanelIndexes.Add(_0x5f4bdb32);
        this.CurrentPanelIndex = _0x5f4bdb32;
        for (int _0x9a2ec9db = 0; _0x9a2ec9db < this.Panels.Count; _0x9a2ec9db++)
            if (_0x9a2ec9db != _0x5f4bdb32 && this.Panels[_0x9a2ec9db] != null)
                this.Panels[_0x9a2ec9db]._0xcbf3bc6f();
    }

    private void SwitchSplash()
    {
        if (_0x784d6ccb.Instance.IsTutorialEnabled && !_0xa4f22d18._0x84a193a9._0xb384774b)
            this._0x5472689a(_0x596b9e44.TUTORIAL0);
        else
            this._0x5472689a(_0x596b9e44.DEFAULT);
    }
}