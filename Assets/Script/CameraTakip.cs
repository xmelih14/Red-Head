
using UnityEngine;

public class CameraTakip : MonoBehaviour
{
    public GameObject player;
    public Vector3 cameratakip;
    public Vector3 playerpossion;
    private Vector3 velocity = Vector3.zero;
    public float fallingSpeed = 0.3F;

    private void LateUpdate()
    {
        playerpossion = player.transform.position + cameratakip;
        transform.position = Vector3.SmoothDamp(transform.position, playerpossion, ref velocity, fallingSpeed);
    }

}
