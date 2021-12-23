using UnityEngine.InputSystem;
using UnityEngine;

public class ActionAssetEnabler : MonoBehaviour
{
    [SerializeField]
    InputActionAsset m_ActionAsset;
    public InputActionAsset actionAsset
    {
        get => m_ActionAsset;
        set => m_ActionAsset = value;
    }

    private void OnEnable()
    {
        if(m_ActionAsset != null)
        {
            m_ActionAsset.Enable();
        }
    }

}