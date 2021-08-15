using UnityEngine;

public class NPC : MonoBehaviour
{
    private void Start()
    {
        PropBuy(0);
        UpdateMission(0);
    }

    /// <summary>
    /// ���
    /// </summary>
    /// <param name="Chat">��ܤ��e</param>
    private void Talk(string Chat)
    {
        print("���" + Chat);
    }

    /// <summary>
    /// �}�Ұө�
    /// </summary>
    /// <returns></returns>
    public bool ShopOpen( )
    {
        return true;
      
    }

    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="PropPrice"></param>
    /// <returns></returns>
    public void PropBuy(int PropPrice = 100)
    {
        print("�ʶR�D��" + PropPrice);
    }

    /// <summary>
    /// ���o����
    /// </summary>
    /// <param name="Number">���Ƚs��</param>
    public void GetMission(int Number)
    {
        print("���Ƚs��" + Number );
    }

    /// <summary>
    /// ���ȧ�s
    /// </summary>
    /// <param name="Props">��o���ȹD��ƶq</param>
    /// <returns></returns>
    private void UpdateMission(int Props = 1)
    {
        print("��o���ȹD��ƶq" + Props);
    }

    /// <summary>
    /// ��������
    /// </summary>
    /// <param name="Number">���Ƚs��</param>
    /// <returns></returns>
    private bool FinishMission(int Number)
    {
        return false;
    }
}
