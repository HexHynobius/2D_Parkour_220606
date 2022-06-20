using UnityEngine; //引用Unity引擎命名空間(API)
namespace hyno
{
    /// <summary>
    /// 跑步系統
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region 資料區:資料保存
        //欄位 Field:
        //
        //


        
        [SerializeField, Header ("跑步速度"),Tooltip("這是角色的跑步速度"),Range(0,100)]
        private float speedRun = 3.5f;

        private Animator ani;
        private Rigidbody2D rig;

        #endregion

        #region 功能:系統方法

        private void Run()
        {
            rig.velocity = new Vector2(speedRun, rig.velocity.y);
        }


        #endregion

        #region 事件:程式入口
        //喚醒事件
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            
        }

        //開始事件:播放遊戲時執行一次
        private void Start()
        {
            //print("haro");
        }
        //更新事件:每秒約60次
        private void Update()
        {
            //print("更新");

            //
            Run();
        }
        #endregion




    }
}
