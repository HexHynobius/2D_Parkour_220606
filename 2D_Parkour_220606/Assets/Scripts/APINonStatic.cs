using UnityEngine;

namespace hyno
{
    /// <summary>
    /// 非靜態 API
    /// </summary>
    public class APINonStatic : MonoBehaviour
    {
        [SerializeField]
        private GameObject turtle;
        [SerializeField]
        private Transform startPoint;

        private void Start()
        {
            //取得 非靜態屬性
            print(turtle.activeInHierarchy);
            print(turtle.layer);

            //設定 非靜態屬性
            turtle.tag = "Player";
            turtle.layer = 4;
            startPoint.position = new Vector3(0, -3, 0);
            

            //使用 非靜態方法
            turtle.SetActive(false);

        }

        private void Update()
        {
            startPoint.Translate(0.05f, 0, 0);
            startPoint.Rotate(0, 0, 1.5f);
        }


    }
}
