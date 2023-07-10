using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;  // 追加しましょう

public class CamRotScript : MonoBehaviour
{
    public GameObject cam_object; // Textオブジェクト
    public GameObject text_object; // Textオブジェクト
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
