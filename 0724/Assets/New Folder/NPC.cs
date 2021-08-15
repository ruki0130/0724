using UnityEngine;

public class NPC : MonoBehaviour
{
    private void Start()
    {
        PropBuy(0);
        UpdateMission(0);
    }

    /// <summary>
    /// 對話
    /// </summary>
    /// <param name="Chat">對話內容</param>
    private void Talk(string Chat)
    {
        print("對話" + Chat);
    }

    /// <summary>
    /// 開啟商店
    /// </summary>
    /// <returns></returns>
    public bool ShopOpen( )
    {
        return true;
      
    }

    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="PropPrice"></param>
    /// <returns></returns>
    public void PropBuy(int PropPrice = 100)
    {
        print("購買道具" + PropPrice);
    }

    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="Number">任務編號</param>
    public void GetMission(int Number)
    {
        print("任務編號" + Number );
    }

    /// <summary>
    /// 任務更新
    /// </summary>
    /// <param name="Props">獲得任務道具數量</param>
    /// <returns></returns>
    private void UpdateMission(int Props = 1)
    {
        print("獲得任務道具數量" + Props);
    }

    /// <summary>
    /// 完成任務
    /// </summary>
    /// <param name="Number">任務編號</param>
    /// <returns></returns>
    private bool FinishMission(int Number)
    {
        return false;
    }
}
