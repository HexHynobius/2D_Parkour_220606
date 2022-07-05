using UnityEngine;

namespace hyno
{
    public class SystemJump : MonoBehaviour
    {
        #region 資料區

        [SerializeField, Header("跳躍高度"), Tooltip("這是角色的跳躍高度"), Range(100, 1000)]
        private float heightJump = 650;
        [SerializeField, Header("檢查地板尺寸")]
        private Vector3 v3CheckGroundSize=Vector3.one;
        [SerializeField, Header("檢查地板位移")]
        private Vector3 v3CheckGroundOffset;
        [SerializeField, Header("檢查地板顏色")]
        private Color colorCheckGround =new Color(1,0,0.2f,0.5f);
        [SerializeField, Header("檢查地板圖層")]
        private LayerMask layerCheckGround;
        [SerializeField, Header("跳躍動畫參數")]
        private string nameJump= "開關跳";
        [SerializeField, Header("跳躍音效")]
        private AudioClip soundJump;



        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        private bool isGround;
        private AudioSource aud;

        #endregion

        #region 事件

        //繪製圖示
        private void OnDrawGizmos()
        {
            Gizmos.color = colorCheckGround;
            Gizmos.DrawCube(transform.position+v3CheckGroundOffset,v3CheckGroundSize);

        }



        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            aud = GetComponent<AudioSource>();
        }
        private void Start()
        {

        }

        private void Update()
        {
            JumpKey();
            CheckGround();
            UpdataAnimator();
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
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }
        }

        private void JumpForce()
        {
            if (clickJump && isGround)
            {
                rig.AddForce(new Vector2(0,heightJump));
                clickJump = false;
                //撥放音效
                aud.PlayOneShot(soundJump, Random.Range(0.7f, 1.5f));
            }
        }

        //檢查地板
        private void CheckGround()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundOffset, v3CheckGroundSize, 0,layerCheckGround);
            //print(hit.name);
            isGround = hit;
        }

        private void UpdataAnimator()
        {
            ani.SetBool(nameJump, !isGround);
        }

        #endregion


    }

}
