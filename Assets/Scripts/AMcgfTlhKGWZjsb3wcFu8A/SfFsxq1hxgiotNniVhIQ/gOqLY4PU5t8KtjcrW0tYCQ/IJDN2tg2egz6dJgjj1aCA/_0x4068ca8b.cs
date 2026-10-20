using UnityEngine;
using UnityEngine.UI;

public class _0x4068ca8b : MonoBehaviour
{
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0xa4f22d18.Instance._0x0c134fc0(this.IsPhysicsRunOnClick));
    }

    public bool IsPhysicsRunOnClick;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
}