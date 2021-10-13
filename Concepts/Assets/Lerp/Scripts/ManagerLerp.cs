using UnityEngine;

public class ManagerLerp : MonoBehaviour
{
    public Transform cube;
    public Transform start, end;
    private float timer;
    private bool reverse;

    private void Update()
    {
        if (reverse)
        {
            if (cube.transform.position == start.position) reverse = false;
            timer -= Time.deltaTime;
        }
        else
        {
            if (cube.transform.position == end.position) reverse = true;
            timer += Time.deltaTime;
        }

        cube.transform.position = Vector3.Lerp(start.position, end.position, timer);
    }
}
