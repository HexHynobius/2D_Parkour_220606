using UnityEngine;

namespace hyno
{
    public class APIStatic : MonoBehaviour
    {
        //�m��
        Vector3 a = new Vector3(1, 1, 1);
        Vector3 b = new Vector3(22, 22, 22);
        
        private void Start()
        {
            //get
            print("�H��" + (Random.value*100).ToString("00") );
            print("�L��" + Mathf.Infinity);
            print(Mathf.PI);
            //set
            Cursor.visible = false;
            Physics2D.gravity = new Vector2(0, -9.8f);
            Time.timeScale = 2;

            float range = Random.Range(1f, 100f);
            print("�H��" + range);

            //�m��
            print(Camera.allCamerasCount);
            print(Application.platform);
            Physics.sleepThreshold = 10;
            Time.timeScale = 0.5f;
            Application.OpenURL("https://unity.com/");


        }
        private void Update()
        {
            //�m��
            print(Input.anyKey);
            print(Time.time);
            print(Time.timeSinceLevelLoad);
            print(Mathf.FloorToInt(9.999f));
            print(Vector3.Distance(a,b));
            print(Input.GetKey("Space"));
        }



    }

}
