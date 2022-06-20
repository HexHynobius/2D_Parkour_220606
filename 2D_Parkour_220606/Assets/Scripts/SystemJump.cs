using UnityEngine;

namespace hyno
{
    public class SystemJump : MonoBehaviour
    {
        #region 資料區

        [SerializeField, Header("跳躍高度"), Tooltip("這是角色的跳躍高度"), Range(100, 1000)]
        private float heightJump = 650;

        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        #endregion

        #region 事件
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();

        }
        private void Start()
        {

        }

        private void Update()
        {
            JumpKey();
        }

        private void FixedUpdate()
        {
            JumpForce();
        }

        #endregion


        #region 功能
        private void JumpKey() 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                clickJump = true;
            }
        }

        private void JumpForce()
        {
            if (clickJump)
            {
                rig.AddForce(new Vector2(0,heightJump));
                clickJump = false;
            }
        }
        #endregion


    }

}
