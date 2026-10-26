using UnityEngine;

public class RayVisualizer : MonoBehaviour {
    public LineRenderer lineRenderer;
    public float maxDistance = 50f;

    void Update() {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        lineRenderer.SetPosition(0, ray.origin);

        if (Physics.Raycast(ray, out hit, maxDistance)) {
            lineRenderer.SetPosition(1, hit.point);
        } else {
            lineRenderer.SetPosition(1, ray.origin + ray.direction * maxDistance);

        }

    }

}