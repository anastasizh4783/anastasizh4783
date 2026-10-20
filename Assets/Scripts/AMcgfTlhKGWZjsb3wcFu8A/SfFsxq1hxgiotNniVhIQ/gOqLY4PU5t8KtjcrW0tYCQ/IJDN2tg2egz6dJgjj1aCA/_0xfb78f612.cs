using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xfb78f612 : MonoBehaviour
{
    public bool IsLoadCurrentScene;
    public Button Button;
    public int LoadSceneId;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0xa4f22d18.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0xa4f22d18.Instance.LoadSceneByIndex(this.LoadSceneId));
    }
}