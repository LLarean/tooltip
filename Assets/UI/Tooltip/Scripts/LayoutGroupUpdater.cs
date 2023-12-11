using UnityEngine;
using UnityEngine.UI;

public class LayoutGroupUpdater : MonoBehaviour
{
    [SerializeField] private RectTransform _rectTransform;

    [ContextMenu("UpdateLayout")]
    private void UpdateLayout()
    {
        LayoutRebuilder.ForceRebuildLayoutImmediate(_rectTransform);
    }
}