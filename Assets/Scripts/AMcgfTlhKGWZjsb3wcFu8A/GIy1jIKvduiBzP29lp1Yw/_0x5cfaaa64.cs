using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x5cfaaa64 : MonoBehaviour
{
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x82dcc8ef = this.gameObject.GetComponent<_0x5cfaaa64>();
    }

    private Touch? _0x61ae4f0d()
    {
        if (!_0xa4f22d18.Instance._0x81e7c22d)
            return null;
        foreach (Touch _0xb494d611 in Touch.activeTouches)
            if (_0xb494d611.ended)
                if (this._0x50165d7c(_0xb494d611))
                    return _0xb494d611;
        return null;
    }

    private Touch? _0x911a70f0(Bounds _0x43da45fe, TouchPhase _0x55e3929f)
    {
        if (!_0xa4f22d18.Instance._0x81e7c22d)
            return null;
        foreach (Touch _0x1226ee9b in Touch.activeTouches)
            if (_0x1226ee9b.phase == _0x55e3929f)
            {
                Vector3 _0xecb9a050 = Camera.main.ScreenToWorldPoint(_0x1226ee9b.screenPosition);
                Vector3 _0xb43bbf3f = new(_0xecb9a050.x, _0xecb9a050.y, _0x43da45fe.center.z);
                if (_0x43da45fe.Contains(_0xb43bbf3f) && this._0x50165d7c(_0x1226ee9b))
                    return _0x1226ee9b;
            }

        return null;
    }

    private Touch? _0xf5923721(Bounds _0x1b2f73e0)
    {
        if (!_0xa4f22d18.Instance._0x81e7c22d)
            return null;
        foreach (Touch _0x4c724fed in Touch.activeTouches)
            if (_0x4c724fed.ended)
            {
                Vector3 _0x961f88db = Camera.main.ScreenToWorldPoint(_0x4c724fed.screenPosition);
                Vector3 _0x8e11d02f = new(_0x961f88db.x, _0x961f88db.y, _0x1b2f73e0.center.z);
                if (_0x1b2f73e0.Contains(_0x8e11d02f) && this._0x50165d7c(_0x4c724fed))
                    return _0x4c724fed;
            }

        return null;
    }

    private bool _0x50165d7c(Touch? _0x2f88c52f)
    {
        if (!_0x2f88c52f.HasValue)
            return false;
        Vector3 _0x8c08945b = Camera.main.ScreenToWorldPoint(_0x2f88c52f.Value.screenPosition);
        Vector3 _0xc4a629f7 = _0x8c08945b;
        _0xc4a629f7.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xc4a629f7))
            return true;
        _0x2f88c52f = null;
        return false;
    }

    private void _0x3088da1e(Touch? _0x2d3fa248)
    {
        if (!_0xa4f22d18.Instance._0x81e7c22d)
        {
            _0x2d3fa248 = null;
            return;
        }

        int _0xd716c1dd = _0x2d3fa248.Value.touchId;
        _0x2d3fa248 = Touch.activeTouches.FirstOrDefault(_0x82228584 => _0x82228584.touchId == _0xd716c1dd);
        if (!this._0x50165d7c(_0x2d3fa248.Value))
            _0x2d3fa248 = null;
    }

    public BoxCollider2D CameraTouchBounds;
    private Touch? _0x43287032(Bounds _0x0e092b49)
    {
        if (!_0xa4f22d18.Instance._0x81e7c22d)
            return null;
        foreach (Touch _0x14360c22 in Touch.activeTouches)
            if (!_0x14360c22.ended)
            {
                Vector3 _0x7103c5be = Camera.main.ScreenToWorldPoint(_0x14360c22.screenPosition);
                Vector3 _0x328a7f12 = new(_0x7103c5be.x, _0x7103c5be.y, _0x0e092b49.center.z);
                if (_0x0e092b49.Contains(_0x328a7f12) && this._0x50165d7c(_0x14360c22))
                    return _0x14360c22;
            }

        return null;
    }

    private static _0x5cfaaa64 _0x82dcc8ef;
    private Touch? _0x57740c8e()
    {
        if (!_0xa4f22d18.Instance._0x81e7c22d)
            return null;
        foreach (Touch _0x844a1103 in Touch.activeTouches)
            if (!_0x844a1103.ended)
                if (this._0x50165d7c(_0x844a1103))
                    return _0x844a1103;
        return null;
    }

    private bool _0xe9951f37(Touch? _0x21a47581, Bounds _0xb9a0a904, TouchPhase _0xbcfae4cc)
    {
        if (!_0xa4f22d18.Instance._0x81e7c22d)
        {
            _0x21a47581 = null;
            return false;
        }

        if (_0x21a47581 != null)
            if (_0x21a47581.Value.phase == _0xbcfae4cc)
            {
                Vector3 _0xca31e6a2 = Camera.main.ScreenToWorldPoint(_0x21a47581.Value.screenPosition);
                Vector3 _0x82b45008 = new(_0xca31e6a2.x, _0xca31e6a2.y, _0xb9a0a904.center.z);
                if (_0xb9a0a904.Contains(_0x82b45008) && this._0x50165d7c(_0x21a47581.Value))
                    return true;
            }

        return false;
    }
}