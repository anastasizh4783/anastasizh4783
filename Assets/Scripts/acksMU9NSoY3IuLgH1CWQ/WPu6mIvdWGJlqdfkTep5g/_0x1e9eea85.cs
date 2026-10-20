using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x1e9eea85 : MonoBehaviour
{
    private void _0xf2693c5c()
    {
        float _0x5559152a, _0xbe4a6667, _0xb24871a7, _0x31ef3ccf;
        if (this._0x51c24ce0 == _0x3f5a4913.Landscape)
            this._0xebe1796e.orthographicSize = 1f / this._0xebe1796e.aspect * this._0x0e8eda24 / 2f;
        else
            this._0xebe1796e.orthographicSize = this._0x0e8eda24 / 2f;
        this._0x020f7291 = 2f * this._0xebe1796e.orthographicSize;
        this._0x95a5b1d2 = this._0x020f7291 * this._0xebe1796e.aspect;
        float _0x2b0ead55 = this._0xebe1796e.transform.position.x;
        float _0xcb8f1742 = this._0xebe1796e.transform.position.y;
        _0x5559152a = _0x2b0ead55 - this._0x95a5b1d2 / 2;
        _0xbe4a6667 = _0x2b0ead55 + this._0x95a5b1d2 / 2;
        _0xb24871a7 = _0xcb8f1742 + this._0x020f7291 / 2;
        _0x31ef3ccf = _0xcb8f1742 - this._0x020f7291 / 2;
        this._0x670e67d3 = new Vector3(_0x5559152a, _0x31ef3ccf, 0);
        this._0x070277a4 = new Vector3(_0x2b0ead55, _0x31ef3ccf, 0);
        this._0x902d7ebe = new Vector3(_0xbe4a6667, _0x31ef3ccf, 0);
        this._0xbfbf6518 = new Vector3(_0x5559152a, _0xcb8f1742, 0);
        this._0xdb43912b = new Vector3(_0x2b0ead55, _0xcb8f1742, 0);
        this._0x10deb543 = new Vector3(_0xbe4a6667, _0xcb8f1742, 0);
        this._0x15009533 = new Vector3(_0x5559152a, _0xb24871a7, 0);
        this._0x5cb06875 = new Vector3(_0x2b0ead55, _0xb24871a7, 0);
        this._0x01d5c151 = new Vector3(_0xbe4a6667, _0xb24871a7, 0);
    }

    private float _0x020f7291 { get; set; }
    private Vector3 _0x01d5c151 { get; set; }
    private Vector3 _0xdb43912b { get; set; }

    private Color _0x891cf519 = Color.white;
    public enum _0x3f5a4913
    {
        Landscape,
        Portrait
    }

    private _0x3f5a4913 _0x51c24ce0 = _0x3f5a4913.Portrait;
    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x891cf519;
        Matrix4x4 _0xa18270c6 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xebe1796e.orthographic)
        {
            float _0x2eeb86ec = this._0xebe1796e.farClipPlane - this._0xebe1796e.nearClipPlane;
            float _0x05c93c71 = (this._0xebe1796e.farClipPlane + this._0xebe1796e.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x05c93c71), new Vector3(this._0xebe1796e.orthographicSize * 2 * this._0xebe1796e.aspect, this._0xebe1796e.orthographicSize * 2, _0x2eeb86ec));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xebe1796e.fieldOfView, this._0xebe1796e.farClipPlane, this._0xebe1796e.nearClipPlane, this._0xebe1796e.aspect);
        }

        Gizmos.matrix = _0xa18270c6;
    }

    private Vector3 _0xbfbf6518 { get; set; }
    private Vector3 _0x902d7ebe { get; set; }
    //public bool executeInUpdate;
    private float _0x95a5b1d2 { get; set; }

    private static _0x1e9eea85 _0xd042c34c;
    private Vector3 _0x670e67d3 { get; set; }

    private float _0x0e8eda24 = 1;
    private void Awake()
    {
        this._0xebe1796e = this.GetComponent<Camera>();
        _0xd042c34c = this;
        this._0xf2693c5c();
    }

    private Vector3 _0x15009533 { get; set; }
    private Vector3 _0x5cb06875 { get; set; }

    private new Camera _0xebe1796e;
    private Vector3 _0x10deb543 { get; set; }
    private Vector3 _0x070277a4 { get; set; }
}