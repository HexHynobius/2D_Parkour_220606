using UnityEngine;

namespace hyno
{
    public class SystemJump : MonoBehaviour
    {
        #region ��ư�

        [SerializeField, Header("���D����"), Tooltip("�o�O���⪺���D����"), Range(100, 1000)]
        private float heightJump = 650;
        [SerializeField, Header("�ˬd�a�O�ؤo")]
        private Vector3 v3CheckGroundSize=Vector3.one;
        [SerializeField, Header("�ˬd�a�O�첾")]
        private Vector3 v3CheckGroundOffset;
        [SerializeField, Header("�ˬd�a�O�C��")]
        private Color colorCheckGround =new Color(1,0,0.2f,0.5f);
        [SerializeField, Header("�ˬd�a�O�ϼh")]
        private LayerMask layerCheckGround;
        [SerializeField, Header("���D�ʵe�Ѽ�")]
        private string nameJump= "�}����";
        [SerializeField, Header("���D����")]
        private AudioClip soundJump;



        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        private bool isGround;
        private AudioSource aud;

        #endregion

        #region �ƥ�

        //ø�s�ϥ�
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


        #region �\��
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
                //���񭵮�
                aud.PlayOneShot(soundJump, Random.Range(0.7f, 1.5f));
            }
        }

        //�ˬd�a�O
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
