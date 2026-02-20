using UnityEngine;

public class CameraControlExam06 : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public float offset;
    public Camera targetCamera;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 player1Pos = player1.transform.position;
        Vector3 player2Pos = player2.transform.position;

        // Student code ...
        float ScreenSize = targetCamera.orthographicSize * Screen.width / Screen.height;
        Debug.Log(ScreenSize);

        float zPos = player1Pos.z - player2Pos.z;
        targetCamera.orthographicSize = zPos;


        if (targetCamera.orthographicSize < 0)
        {
            targetCamera.orthographicSize = targetCamera.orthographicSize * -1;
        }

        //Camera move to middle of 2 players
        targetCamera.transform.position = new Vector3((player2Pos.x + player1Pos.x) / 2, targetCamera.transform.position.y, (player2Pos.z - player1Pos.z) / 2);

        //ScreenScale
    }
}
