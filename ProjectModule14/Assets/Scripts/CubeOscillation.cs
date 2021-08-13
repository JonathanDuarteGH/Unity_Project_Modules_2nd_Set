using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOscillation : MonoBehaviour
{
    private Transform localRedCube;
    public Transform localBlueCube, localYellowCube;
    public float min = -3f, max = 3f, speed = 2.5f;

    // Start is called before the first frame update 
    public void Start()
    {
        localRedCube = gameObject.GetComponent<Transform>();
        localBlueCube = GetComponent<Transform>();
        localYellowCube = GetComponent<Transform>();
    }

    public void ConsoleLog()
    {
        Debug.Log("GameObject detected");
    }

    public void PingPongCalc()
    {
        Matrix4x4 worldRedCube = localRedCube.localToWorldMatrix;
        Matrix4x4 worldBlueCube = localBlueCube.localToWorldMatrix;
        Matrix4x4 worldYellowCube = localYellowCube.localToWorldMatrix;

        // transform.position = new Vector3 (Mathf.PingPong (Time*time * speed, 5), transform.position.y, transform.position.z);
        // transform.position = new Vector3 (transfprm.position.x, Mathf.PingPong (Time*time * speed, 3), transform.position.z);


    }

    // Update is called once per frame
    public void Update()
    {
        if (localRedCube != null)
        {
            ConsoleLog();
            PingPongCalc();
        }
    }
}
