using UnityEngine;

public class Test2 : MonoBehaviour
{
    public Transform objecToTransform;
    public Camera gameCamera;

    // Update is called once per frame
    void Update()
    {
        Ray ray = gameCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {
            objecToTransform.position = hitInfo.point;
            objecToTransform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
        }
    }
}
