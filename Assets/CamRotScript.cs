using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;  // �ǉ����܂��傤

public class CamRotScript : MonoBehaviour
{
    public GameObject cam_object; // Text�I�u�W�F�N�g
    public GameObject text_object; // Text�I�u�W�F�N�g
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text text = text_object.GetComponent<Text>();
        text.text = "pitch:" + cam_object.transform.rotation.x * -180 + "\nyaw:" + cam_object.transform.rotation.y * -180 + "\nroll:" + cam_object.transform.rotation.z * 180 + "\n";
    }
}
