using System.Collections.Generic;
using UnityEngine;

// The whole shape of one delivery run: how the belt tilts, when plumes come down,
// which nest holds which egg and where the stations sit. Everything here is produced
// by RunPlanGenerator from a seed (rule C.11) and read back by RunSolver, so the
// length that gets proven is the length that ships.
public sealed class _0x12a0c0f8
{
    public const float NestShallow = 0.27f;
    public List<PlumeDrop> Plumes;
    public struct PlumeDrop
    {
        public float Seconds;
        public float CatchDegrees;
        public float LaneOffset;
    }

    public const float CatchWindowDegrees = 4f;
    public int Stations;
    public List<float> StationSeconds;
    public const float FixedStep = 0.02f;
    public int Required;
    public const float SafeHalfBase = 0.50f;
    // -- model constants, shared by the live run and by the simulation -------
    public const float GravityPush = 1.90f;
    public int RouteIndex;
    public _0x12a0c0f8()
    {
        this.Slopes = new List<SlopeStep>();
        this.Plumes = new List<PlumeDrop>();
        this.StationSeconds = new List<float>();
        this.NestStiffness = new float[3]
        {
            NestDeep,
            NestMid,
            NestShallow
        };
    }

    public float RunSeconds;
    public const float TiltRate = 20f;
    public struct SlopeStep
    {
        public float StartSeconds;
        public float Degrees;
    }

    public const float NestMid = 0.38f;
    public const float PlumeWarningSeconds = 1.8f;
    public const float LevelRate = 10f;
    public const float TravelClamp = 0.85f;
    public const float SafeHalfPerPlume = 0.12f;
    public int SpeedIndex;
    // Belt slope in degrees at a moment of the run, ramped between steps so the
    // escalation is felt rather than snapped.
    public float _0xf740272b(float _0xba0d65b5)
    {
        if (this.Slopes.Count == 0)
        {
            return 0f;
        }

        float _0xa6dbde34 = this.Slopes[0].Degrees;
        float _0x731b6a69 = this.Slopes[0].Degrees;
        float _0x16947868 = 0f;
        for (int _0x7982ed55 = 0; _0x7982ed55 < this.Slopes.Count; _0x7982ed55++)
        {
            if (this.Slopes[_0x7982ed55].StartSeconds > _0xba0d65b5)
            {
                break;
            }

            _0x731b6a69 = _0xa6dbde34;
            _0xa6dbde34 = this.Slopes[_0x7982ed55].Degrees;
            _0x16947868 = this.Slopes[_0x7982ed55].StartSeconds;
        }

        float _0x1d0fcd4b = Mathf.Clamp01((_0xba0d65b5 - _0x16947868) / RampSeconds);
        return Mathf.Lerp(_0x731b6a69, _0xa6dbde34, _0x1d0fcd4b);
    }

    public const float TiltMax = 15f;
    public const float NestDeep = 0.52f;
    public int Seed;
    public const float SafeHalfCap = 0.74f;
    public const float BoostSeconds = 6.0f;
    public float[] NestStiffness;
    public const float CrackSeconds = 1.35f;
    public const float RampSeconds = 3.0f;
    public int _0xda38f1fa(float _0xe16a608c)
    {
        int _0x9fedda03 = 0;
        for (int _0x8531406e = 0; _0x8531406e < this.StationSeconds.Count; _0x8531406e++)
        {
            if (this.StationSeconds[_0x8531406e] <= _0xe16a608c)
            {
                _0x9fedda03++;
            }
        }

        return _0x9fedda03;
    }

    public List<SlopeStep> Slopes;
    public const float Damping = 0.55f;
    public const float SurvivalFloorSeconds = 62f;
    public const float MinHoldSeconds = 0.35f;
}