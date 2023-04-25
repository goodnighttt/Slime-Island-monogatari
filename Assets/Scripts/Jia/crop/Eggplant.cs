using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eggplant : BaseCrop
{
    public override int lifeTime => 70;

    public List<GameObject> prefabs = new List<GameObject>();
    public GameObject tempCrop;

    public int Lv = 0;
    // Start is called before the first frame update
    void Start()
    {
        tempCrop = Instantiate<GameObject>(prefabs[0], transform.position, Quaternion.identity, null);
        Invoke("upgrade", lifeTime);
    }

    private void upgrade()
    {
        //ɾȥԭ����ģ�ͣ���ʵ���������ģ��
        Lv = 1;
        Destroy(tempCrop.gameObject);
        tempCrop = Instantiate<GameObject>(prefabs[1], transform.position += new Vector3(0, 1f, 0), Quaternion.Euler(-90, 0, 0), null);

        //�ջ�

    }
}