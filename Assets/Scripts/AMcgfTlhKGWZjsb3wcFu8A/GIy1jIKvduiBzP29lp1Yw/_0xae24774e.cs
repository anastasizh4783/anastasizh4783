using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xc1e39607;

public class _0xae24774e : MonoBehaviour
{
    public void _0x5826703b()
    {
        this.LastPopIndexes.RemoveAll(_0x851763cb => _0x851763cb == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x6a384f5d();
        else
            this._0x2e2888c9(this.LastPopIndexes.Last());
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    private void _0x9ce9f0ba()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public void _0x2e2888c9(int _0x1090429e)
    {
        this.CurrentPopIndex = _0x1090429e;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xa9bda215(true);
        this._0xd63164a5();
        this.Pops[_0x1090429e].Show();
        foreach (GameObject _0x38c346d0 in this.GameObjectsToHide)
            _0x38c346d0.SetActive(false);
    }

    public List<_0x23c3e20b> Pops;
    private void _0xa9bda215(bool _0x5b58a6e9 = false)
    {
        for (int _0xeeae09d5 = 0; _0xeeae09d5 < this.Pops.Count; ++_0xeeae09d5)
            if (this.Pops[_0xeeae09d5] != null && !(_0xeeae09d5 == this.CurrentPopIndex && _0x5b58a6e9))
                this.Pops[_0xeeae09d5]._0x1eefddef();
    }

    public int CurrentPopIndex;
    private void _0xd63164a5()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public List<int> LastPopIndexes = new();
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xae24774e>();
    }

    public _0x23c3e20b _0x5067a266(int _0x861367d4)
    {
        return this.Pops[_0x861367d4];
    }

    public GameObject BlurBackground;
    public List<GameObject> GameObjectsToHide;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x23c3e20b _0x6b19067a in this.Pops)
            if (_0x6b19067a != null)
                _0x6b19067a.gameObject.SetActive(true);
    }

    public void _0x6a384f5d()
    {
        this.LastPopIndexes.Clear();
        this._0xa9bda215();
        foreach (GameObject _0xc886a74a in this.GameObjectsToHide)
            if (_0xc886a74a != null)
                _0xc886a74a.SetActive(true);
        this._0x9ce9f0ba();
    }

    public float ScaleDuration = 0.4f;
    public static _0xae24774e Instance;
}