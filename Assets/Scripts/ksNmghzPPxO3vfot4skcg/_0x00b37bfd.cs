using UnityEngine;

// Two numeric predicates run on every generated plan BEFORE it is played, with the
// same integrator the live run uses.
//
//  PassiveSurvival  - how long a run lasts with the tray never touched. Rule C.5
//                     wants at least 60 s so the capture window (first gameplay
//                     frame around 16 s, last around 32 s) always lands on real
//                     gameplay; the generator demands 62 s to keep a margin.
//  IsDeliverable    - a model courier with a 180 ms reaction, holding the pad that
//                     reduces the mismatch between belt and tray, must finish with
//                     at least the required number of eggs intact.
public static class _0x00b37bfd
{
    public static float PassiveSurvival(_0x12a0c0f8 _0xa63b13a4)
    {
        return Simulate(_0xa63b13a4, false).EndedAt;
    }

    public static Outcome Simulate(_0x12a0c0f8 _0xe119ca6a, bool _0xdf0bc6ca)
    {
        float[] _0xad215a06 = new float[3];
        float[] _0x75c1a529 = new float[3];
        float[] _0x1a7aba2e = new float[3];
        bool[] _0xd5c5e1e3 = new bool[3];
        float _0xea21177c = 0f;
        float _0xb5c07da2 = -1f;
        int _0x603c8b8a = 0;
        int _0x5dea8430 = 0;
        float _0x13d9eb24 = 0f;
        float _0xc5908b09 = 0f;
        float _0x43878a5b = 0f;
        float _0xc25e46e0 = -1f;
        while (_0x43878a5b < _0xe119ca6a.RunSeconds)
        {
            float _0xb59d9af5 = _0xe119ca6a._0xf740272b(_0x43878a5b);
            if (_0xdf0bc6ca)
            {
                _0x13d9eb24 -= _0x12a0c0f8.FixedStep;
                if (_0x13d9eb24 <= 0f)
                {
                    _0x13d9eb24 = ReactionSeconds;
                    float _0x88aec2b3 = _0xb59d9af5 - _0xea21177c;
                    _0xc5908b09 = Mathf.Abs(_0x88aec2b3) < DeadBandDegrees ? 0f : Mathf.Sign(_0x88aec2b3);
                }
            }
            else
            {
                _0xc5908b09 = 0f;
            }

            if (_0xc5908b09 > 0.5f || _0xc5908b09 < -0.5f)
            {
                _0xea21177c = Mathf.Clamp(_0xea21177c + (_0xc5908b09 * _0x12a0c0f8.TiltRate * _0x12a0c0f8.FixedStep), -_0x12a0c0f8.TiltMax, _0x12a0c0f8.TiltMax);
            }
            else if (_0xea21177c > 0f)
            {
                _0xea21177c = Mathf.Max(0f, _0xea21177c - (_0x12a0c0f8.LevelRate * _0x12a0c0f8.FixedStep));
            }
            else if (_0xea21177c < 0f)
            {
                _0xea21177c = Mathf.Min(0f, _0xea21177c + (_0x12a0c0f8.LevelRate * _0x12a0c0f8.FixedStep));
            }

            while (_0x5dea8430 < _0xe119ca6a.Plumes.Count && _0xe119ca6a.Plumes[_0x5dea8430].Seconds <= _0x43878a5b)
            {
                _0x12a0c0f8.PlumeDrop _0x7e0d5620 = _0xe119ca6a.Plumes[_0x5dea8430];
                _0x5dea8430++;
                if (Mathf.Abs(_0xea21177c - _0x7e0d5620.CatchDegrees) <= _0x12a0c0f8.CatchWindowDegrees)
                {
                    _0x603c8b8a++;
                    _0xb5c07da2 = Mathf.Max(_0xb5c07da2, _0x43878a5b) + _0x12a0c0f8.BoostSeconds;
                }
            }

            float _0x7e75fdaf = SafeHalf(_0xb5c07da2, _0x43878a5b);
            float _0x12decca3 = _0x12a0c0f8.GravityPush * Mathf.Sin((_0xb59d9af5 - _0xea21177c) * Mathf.Deg2Rad);
            int _0xde99a283 = 0;
            for (int _0x0bf0094f = 0; _0x0bf0094f < 3; _0x0bf0094f++)
            {
                if (_0xd5c5e1e3[_0x0bf0094f])
                {
                    continue;
                }

                float _0xe206c3f3 = _0x12decca3 - (_0xe119ca6a.NestStiffness[_0x0bf0094f] * _0xad215a06[_0x0bf0094f]) - (_0x12a0c0f8.Damping * _0x75c1a529[_0x0bf0094f]);
                _0x75c1a529[_0x0bf0094f] += _0xe206c3f3 * _0x12a0c0f8.FixedStep;
                _0xad215a06[_0x0bf0094f] += _0x75c1a529[_0x0bf0094f] * _0x12a0c0f8.FixedStep;
                if (_0xad215a06[_0x0bf0094f] > _0x12a0c0f8.TravelClamp)
                {
                    _0xad215a06[_0x0bf0094f] = _0x12a0c0f8.TravelClamp;
                    _0x75c1a529[_0x0bf0094f] = 0f;
                }
                else if (_0xad215a06[_0x0bf0094f] < -_0x12a0c0f8.TravelClamp)
                {
                    _0xad215a06[_0x0bf0094f] = -_0x12a0c0f8.TravelClamp;
                    _0x75c1a529[_0x0bf0094f] = 0f;
                }

                if (Mathf.Abs(_0xad215a06[_0x0bf0094f]) > _0x7e75fdaf)
                {
                    _0x1a7aba2e[_0x0bf0094f] += _0x12a0c0f8.FixedStep;
                    if (_0x1a7aba2e[_0x0bf0094f] >= _0x12a0c0f8.CrackSeconds)
                    {
                        _0xd5c5e1e3[_0x0bf0094f] = true;
                    }
                }
                else
                {
                    _0x1a7aba2e[_0x0bf0094f] = 0f;
                }

                if (!_0xd5c5e1e3[_0x0bf0094f])
                {
                    _0xde99a283++;
                }
            }

            if (_0xde99a283 == 0)
            {
                _0xc25e46e0 = _0x43878a5b;
                break;
            }

            _0x43878a5b += _0x12a0c0f8.FixedStep;
        }

        Outcome _0x7454e815;
        _0x7454e815.EndedAt = _0xc25e46e0 >= 0f ? _0xc25e46e0 : _0xe119ca6a.RunSeconds;
        _0x7454e815.Lost = _0xc25e46e0 >= 0f;
        _0x7454e815.Intact = 0;
        for (int _0xc691720f = 0; _0xc691720f < 3; _0xc691720f++)
        {
            if (!_0xd5c5e1e3[_0xc691720f])
            {
                _0x7454e815.Intact++;
            }
        }

        _0x7454e815.Caught = _0x603c8b8a;
        return _0x7454e815;
    }

    public static float SafeHalf(float _0xdede8392, float _0x79945e04)
    {
        if (_0xdede8392 <= _0x79945e04)
        {
            return _0x12a0c0f8.SafeHalfBase;
        }

        int _0x7fb06d02 = Mathf.Clamp(Mathf.CeilToInt((_0xdede8392 - _0x79945e04) / _0x12a0c0f8.BoostSeconds), 1, 2);
        return Mathf.Min(_0x12a0c0f8.SafeHalfCap, _0x12a0c0f8.SafeHalfBase + (_0x7fb06d02 * _0x12a0c0f8.SafeHalfPerPlume));
    }

    private const float DeadBandDegrees = 0.6f;
    public struct Outcome
    {
        public float EndedAt;
        public bool Lost;
        public int Intact;
        public int Caught;
    }

    public static bool IsDeliverable(_0x12a0c0f8 _0xda60b320)
    {
        Outcome _0x0fa35ad3 = Simulate(_0xda60b320, true);
        return !_0x0fa35ad3.Lost && _0x0fa35ad3.Intact >= _0xda60b320.Required;
    }

    private const float ReactionSeconds = 0.18f;
}