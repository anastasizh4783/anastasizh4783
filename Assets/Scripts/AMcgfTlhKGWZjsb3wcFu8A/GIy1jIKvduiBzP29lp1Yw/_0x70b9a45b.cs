using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x70b9a45b : MonoBehaviour
{
    private int _0x72c67fd2 => this.CustomTargetScore + _0xa4f22d18._0x84a193a9._0x7962ccf3 * 10;

    public int CustomTargetScore = 10;
    public List<Button> HomeButtons = new();
    private void _0x7907097e()
    {
        this.TimerText.ForEach(_0x2e329cb6 => _0x2e329cb6.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x1f1d7668._0xe5147f2b(new byte[6] { 183, 183, 134, 224, 169, 169 }, 218)));
    }

    private void _0x41c39623()
    {
        if (this.ScoreCurrent > _0xa4f22d18._0x84a193a9._0xa13bdbe0)
            _0xa4f22d18._0x84a193a9._0xa13bdbe0 = this.ScoreCurrent;
        if (_0x784d6ccb.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x72c67fd2)
                this._0x37046371();
    }

    private void _0xbff7b8b2()
    {
        if (_0x784d6ccb.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x2e329cb6 => _0x2e329cb6.text = $"{this.ScoreCurrent}/{this._0x72c67fd2}");
        else
            this.ScoreText.ForEach(_0x2e329cb6 => _0x2e329cb6.text = $"{this.ScoreCurrent}");
    }

    [HideInInspector]
    public bool IsGameEnd;
    public int CustomTimeInitial = 30;
    private int _0xa352978e => this.ScoreCurrent;

    public List<Button> PauseButtons = new();
    private void Awake()
    {
        _0x22a7456a = this.gameObject.GetComponent<_0x70b9a45b>();
    }

    public List<TMP_Text> LevelNumberText = new();
    public void _0xf0037e51()
    {
        _0xa4f22d18.Instance._0x0c134fc0(true);
        _0xa4f22d18.Instance.LoadSceneByIndex(_0xc1e39607._0xfa7cc12d.SCENE_0);
    }

    [HideInInspector]
    public int TimeLeft;
    private void _0xbf802774()
    {
        this.IsGameEnd = true;
        _0xa4f22d18.IsAfterLevelComplete = true;
    }

    [HideInInspector]
    public int CurrentGameIndex;
    public void _0x6c06bec4(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xbff7b8b2();
            this._0x41c39623();
        }
    }

    public List<TMP_Text> ScoreText = new();
    public void _0x65be634d()
    {
        if (_0x784d6ccb.Instance.IsOnlyWinGameEndEnabled)
            this._0x37046371();
        if (!this.IsGameEnd)
        {
            this._0xbf802774();
            _0xa4f22d18.IsAfterLevelComplete = false;
            _0xa4f22d18.IsAfterLevelFailed = true;
            _0x23c3e20b _0xd7e4513a = _0xae24774e.Instance._0x5067a266(_0xc1e39607._0x35d20a44.LOSE).GetComponent<_0x23c3e20b>();
            if (_0x784d6ccb.Instance.IsCheckScoreEnabled)
                _0xd7e4513a.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x72c67fd2}";
            else
                _0xd7e4513a.ContentMainText.text = $"{this.ScoreCurrent}";
            _0xd7e4513a.ContentAdditionalText.text = $"{0}";
            _0xc1e39607._0x537ecd0a._0x7ae1d3ca += 0;
            _0xae24774e.Instance._0x2e2888c9(_0xc1e39607._0x35d20a44.LOSE);
        }
    }

    [HideInInspector]
    public int ScoreCurrent;
    private int _0xf4bc340c => this.CustomTimeInitial + _0xa4f22d18._0x84a193a9._0x7962ccf3 * 10;

    public void _0x37046371()
    {
        if (!this.IsGameEnd)
        {
            this._0xbf802774();
            _0xa4f22d18.IsAfterLevelComplete = true;
            _0xa4f22d18.IsAfterLevelFailed = false;
            _0x23c3e20b _0x25ce84a6 = _0xae24774e.Instance._0x5067a266(_0xc1e39607._0x35d20a44.WIN).GetComponent<_0x23c3e20b>();
            if (_0x784d6ccb.Instance.IsCheckScoreEnabled)
                _0x25ce84a6.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x72c67fd2}";
            else
                _0x25ce84a6.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x784d6ccb.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xc1e39607._0x537ecd0a._0x7ae1d3ca)
                    _0xc1e39607._0x537ecd0a._0x7ae1d3ca = this.ScoreCurrent;
                _0x25ce84a6.ContentAdditionalText.text = $"{_0xc1e39607._0x537ecd0a._0x7ae1d3ca}";
            }
            else
            {
                _0x25ce84a6.ContentAdditionalText.text = $"{this._0xa352978e}";
                _0xc1e39607._0x537ecd0a._0x7ae1d3ca += this._0xa352978e;
            }

            if (_0x784d6ccb.Instance.IsLevelIncrementOnWin)
                ++_0xa4f22d18._0x84a193a9._0x7962ccf3;
            _0xae24774e.Instance._0x2e2888c9(_0xc1e39607._0x35d20a44.WIN);
        }
    }

    public List<TMP_Text> TimerText = new();
    private static _0x70b9a45b _0x22a7456a;
    public List<TMP_Text> SubtitleText = new();
    private void _0x327e4f66()
    {
        if (this.ScoreCurrent >= this._0x72c67fd2)
            this._0x37046371();
        else
            this._0x65be634d();
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xf4bc340c;
        this.CurrentGameIndex = _0xa4f22d18.Instance._0x1a25e84a;
        foreach (Button _0x67a31f14 in this.HomeButtons)
            _0x67a31f14.onClick.AddListener(() =>
            {
                this._0xf0037e51();
            });
        foreach (Button _0x1dfa3f39 in this.PauseButtons)
            _0x1dfa3f39.onClick.AddListener(() =>
            {
                _0xa4f22d18.Instance._0x0c134fc0(false);
                _0xae24774e.Instance._0x2e2888c9(_0xc1e39607._0x35d20a44.PAUSE);
            });
        this._0xbff7b8b2();
        this.LevelNumberText.ForEach(_0x2e329cb6 => _0x2e329cb6.text = $"LVL {_0xa4f22d18._0x84a193a9._0x7962ccf3 + 1}");
        if (_0x784d6ccb.Instance.IsTimerEnabled)
        {
            this._0x7907097e();
            this.StartCoroutine(this._0x0e752948());
        }
    }

    private IEnumerator _0x0e752948()
    {
        this._0x7907097e();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0xa4f22d18.Instance._0x1a25e84a == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0xa4f22d18.Instance._0x81e7c22d)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x7907097e();
            }
        }

        if (!this.IsGameEnd)
            this._0x65be634d();
    }
}

internal static class _0x1f1d7668
{
    internal static string _0xe5147f2b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}