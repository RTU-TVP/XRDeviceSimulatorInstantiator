using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

public class XRDeviceSimulatorInstantiator : MonoBehaviour
{
#if UNITY_EDITOR
    [SerializeField] private XRDeviceSimulator deviceSimulatorPrefab;

    private static bool _isInstantiate;

    private void Awake()
    {
        if (!_isInstantiate)
        {
            DontDestroyOnLoad(Instantiate(deviceSimulatorPrefab.gameObject));

            _isInstantiate = true;
        }
    }
#endif
}