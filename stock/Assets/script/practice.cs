using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using UnityEngine;

public class practice : MonoBehaviour
{
    public class stock
    {
        public string stockName;
        public int startPrice;
        public int maxCount;
        public float probs;

        public int setPrice(){
            startPrice = Random.Range(1300, 150000);
            Debug.Log(stockName + "�� ���۰���" + startPrice + "�Դϴ�");
            return startPrice;
        }

        public void stocking(string name, int startPrice){

            int stockPrice = startPrice;
            float probs = 0.5f;
            for (int i = 0; i < 30; i++)
            {
                float del = Random.Range(-0.04f, 0.04f);
                probs += del;
                float ranVal = Random.value;  //0���� 1 ���� �� ����
                if (ranVal >= probs)
                {
                    stockPrice += 50;
                    Debug.Log(name + "�� �ְ� ��ȭ, �� �ְ�: " + stockPrice);
                }
                else
                {
                    stockPrice -= 50;
                    Debug.Log(name + "�� �ְ� ��ȭ, �� �ְ�: " + stockPrice);
                }
                Debug.Log("probs = " + probs + "    ranVal = " + ranVal);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        stock st1 = new stock();
        st1.stockName = "sasung";
        st1.stocking(st1.stockName, st1.setPrice());

        stock st2 = new stock();
        st2.stockName = "kingcacola";
        st2.stocking(st2.stockName, st2.setPrice());
    }

    // Update is called once per frame
    void Update()
    {

    }
}

