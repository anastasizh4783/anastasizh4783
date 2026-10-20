using UnityEngine;

// One egg in one nest. The nest stiffness decides how firmly it is held: the
// shallow nest lets go first, the deep one last. The integrator is the same one
// RunSolver uses, so the survival time proven before the run is the one played.
public sealed class _0x25132405 : MonoBehaviour
{
    private float _0x28c37811;
    private Sprite _0x52971515;
    private bool _0xa6d3378f;
    public float _0x2023eccf
    {
        get
        {
            return this._0xac368baa;
        }
    }

    private float _0xde35cb92;
    private float _0xac368baa;
    private float _0xd5537577;
    private void _0x7c99132a()
    {
        if (this._0x63eb8a30 == null)
        {
            return;
        }

        this._0x63eb8a30.transform.localPosition = new Vector3(this._0xd5537577 + this._0xac368baa, this._0x3bc0d72c, 0f);
    }

    public float _0x9b9d6409(float _0xba692b75)
    {
        if (_0xba692b75 <= 0.001f)
        {
            return 0f;
        }

        return Mathf.Clamp01(Mathf.Abs(this._0xac368baa) / _0xba692b75);
    }

    private float _0xb16cfa2e;
    private float _0x94cf9578;
    public void _0x89e81a1e(SpriteRenderer _0x0ef2ecc8, Sprite _0x0b5a3777, Sprite _0x04b3bbf3, float _0x1dbf22b8, float _0xf8b41960, float _0x23e090ba, float _0xbf2697cd)
    {
        this._0x63eb8a30 = _0x0ef2ecc8;
        this._0x97161bbb = _0x0b5a3777;
        this._0x52971515 = _0x04b3bbf3;
        this._0xd5537577 = _0x1dbf22b8;
        this._0x3bc0d72c = _0xf8b41960;
        this._0x28c37811 = _0x23e090ba;
        this._0xde35cb92 = _0xbf2697cd;
        this._0xac368baa = 0f;
        this._0xb16cfa2e = 0f;
        this._0x94cf9578 = 0f;
        this._0xa6d3378f = false;
        _0xf21ad269.Dress(this._0x63eb8a30, this._0x97161bbb, _0xf21ad269.EggOrder, _0xbf2697cd);
        this._0x7c99132a();
    }

    public float _0xb47591ee
    {
        get
        {
            return this._0x28c37811;
        }
    }

    private Sprite _0x97161bbb;
    // Returns true on the step where this egg breaks.
    public bool _0x85b9a7f7(float _0xa6455ef0, float _0x74b2883a, float step)
    {
        if (this._0xa6d3378f)
        {
            return false;
        }

        float _0x66568705 = _0xa6455ef0 - (this._0x28c37811 * this._0xac368baa) - (_0x12a0c0f8.Damping * this._0xb16cfa2e);
        this._0xb16cfa2e += _0x66568705 * step;
        this._0xac368baa += this._0xb16cfa2e * step;
        if (this._0xac368baa > _0x12a0c0f8.TravelClamp)
        {
            this._0xac368baa = _0x12a0c0f8.TravelClamp;
            this._0xb16cfa2e = 0f;
        }
        else if (this._0xac368baa < -_0x12a0c0f8.TravelClamp)
        {
            this._0xac368baa = -_0x12a0c0f8.TravelClamp;
            this._0xb16cfa2e = 0f;
        }

        bool _0xdf0c50f7 = false;
        if (Mathf.Abs(this._0xac368baa) > _0x74b2883a)
        {
            this._0x94cf9578 += step;
            if (this._0x94cf9578 >= _0x12a0c0f8.CrackSeconds)
            {
                this._0xa6d3378f = true;
                _0xdf0c50f7 = true;
                _0xf21ad269.Dress(this._0x63eb8a30, this._0x52971515, _0xf21ad269.EggOrder, this._0xde35cb92);
                if (this._0x63eb8a30 != null)
                {
                    this._0x63eb8a30.color = _0x3edf515c.WithAlpha(Color.white, 0.75f);
                }
            }
        }
        else
        {
            this._0x94cf9578 = 0f;
        }

        this._0x7c99132a();
        return _0xdf0c50f7;
    }

    private SpriteRenderer _0x63eb8a30;
    private float _0x3bc0d72c;
    public bool _0xfa1b93ec
    {
        get
        {
            return this._0xa6d3378f;
        }
    }

    public Vector3 _0xab80941e
    {
        get
        {
            return this._0x63eb8a30 == null ? Vector3.zero : this._0x63eb8a30.transform.position;
        }
    }
}