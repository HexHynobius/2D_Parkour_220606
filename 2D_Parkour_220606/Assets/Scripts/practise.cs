using UnityEngine;

namespace hyno
{
    public class practise : MonoBehaviour
    {
        

        [SerializeField]
        private Camera cam;
        [SerializeField]
        private SphereCollider sph;
        [SerializeField]
        private Transform sph_pos;
        [SerializeField]
        private Transform cap;

        [SerializeField]
        private Transform cube;
        [SerializeField]
        private Rigidbody cap_rig;

        private void Start()
        {
            //取得
            print(cam.depth);
            print(sph.radius);


            //存放
            cam.backgroundColor = Random.ColorHSV();
            cap.localScale=new Vector3(3,2,1);
        }

        private void Update()
        {
            cube.RotateAround(sph_pos.position,new Vector3(0, 0, 1), 180 * Time.deltaTime);
            cap_rig.AddForce(new Vector2(0,1));
        }
    }

}

