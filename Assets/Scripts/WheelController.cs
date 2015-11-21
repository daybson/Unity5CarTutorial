/**
    Criado por: Daybson Paisante
    Contato: daybson.paisante@outlook.com
    Visualizado em: https://github.com/daybson/Unity5CarTutorial
*/

using UnityEngine;

[RequireComponent(typeof(WheelCollider))]
public class WheelController : MonoBehaviour
{
    [SerializeField]
    private WheelCollider wheelCollider;
    [SerializeField]
    private Transform wheelMesh;
    [SerializeField]
    private bool receiveMotorTorque;
    [SerializeField]
    private bool receiveSteer;
    [SerializeField]
    private bool receiveBrake;
    public bool ReceiveSteer { get { return receiveSteer; } }
    public bool ReceiveTorque { get { return receiveMotorTorque; } }
    public bool ReceiveBrake { get { return receiveBrake; } }

    public WheelCollider WheelCollider
    {
        get
        {
            return wheelCollider;
        }
    }

    private void Awake()
    {
        wheelCollider = GetComponent<WheelCollider>();
    }

    private void FixedUpdate()
    {
        RotateMesh();
    }

    private void RotateMesh()
    {
        Quaternion quat;
        Vector3 position;
        WheelCollider.GetWorldPose(out position, out quat);
        wheelMesh.transform.position = position;
        wheelMesh.transform.rotation = quat;
    }
}
