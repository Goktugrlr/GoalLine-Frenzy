using UnityEngine;

public class CamController : MonoBehaviour
{
    public Transform characterTransform;

    public Vector3 offset = new Vector3(0, 10, -5);

    void Start()
    {
        GetComponent<Transform>().rotation = Quaternion.Euler(12f, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }

    void Update()
    {
        GetComponent<Transform>().position = offset + characterTransform.position;
    }
}
