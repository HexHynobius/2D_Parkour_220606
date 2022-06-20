using UnityEngine; //�ޥ�Unity�����R�W�Ŷ�(API)
namespace hyno
{
    /// <summary>
    /// �]�B�t��
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ��ư�:��ƫO�s
        //��� Field:
        //
        //


        
        [SerializeField, Header ("�]�B�t��"),Tooltip("�o�O���⪺�]�B�t��"),Range(0,100)]
        private float speedRun = 3.5f;

        private Animator ani;
        private Rigidbody2D rig;

        #endregion

        #region �\��:�t�Τ�k

        private void Run()
        {
            rig.velocity = new Vector2(speedRun, rig.velocity.y);
        }


        #endregion

        #region �ƥ�:�{���J�f
        //����ƥ�
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            
        }

        //�}�l�ƥ�:����C���ɰ���@��
        private void Start()
        {
            //print("haro");
        }
        //��s�ƥ�:�C���60��
        private void Update()
        {
            //print("��s");

            //
            Run();
        }
        #endregion




    }
}
