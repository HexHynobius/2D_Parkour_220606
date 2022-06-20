using UnityEngine;

namespace hyno
{
    /// <summary>
    /// �D�R�A API
    /// </summary>
    public class APINonStatic : MonoBehaviour
    {
        [SerializeField]
        private GameObject turtle;
        [SerializeField]
        private Transform startPoint;

        private void Start()
        {
            //���o �D�R�A�ݩ�
            print(turtle.activeInHierarchy);
            print(turtle.layer);

            //�]�w �D�R�A�ݩ�
            turtle.tag = "Player";
            turtle.layer = 4;
            startPoint.position = new Vector3(0, -3, 0);
            

            //�ϥ� �D�R�A��k
            turtle.SetActive(false);

        }

        private void Update()
        {
            startPoint.Translate(0.05f, 0, 0);
            startPoint.Rotate(0, 0, 1.5f);
        }


    }
}
