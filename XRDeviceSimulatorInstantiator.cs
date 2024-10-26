using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

public class XRDeviceSimulatorInstantiator : MonoBehaviour
{
#if UNITY_EDITOR
    [SerializeField] private XRDeviceSimulator deviceSimulatorPrefab;
    private void Awake() => DontDestroyOnLoad(Instantiate(deviceSimulatorPrefab.gameObject));
#endif
}
