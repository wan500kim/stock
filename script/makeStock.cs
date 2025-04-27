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
            startPrice = startPrice - (startPrice % 10);
            Debug.Log(stockName + "�� ���۰��� " + startPrice + "�Դϴ�");
            return startPrice;
        }

        public int setMaxCount(int startPrice)
        {
            maxCount = 5000000 / startPrice;
            Debug.Log(stockName + "�� �� �ֽ� ������ " + maxCount + "�� �Դϴ�");
            return maxCount;
        }

        public void stocking(string name, int startPrice){

            int stockPrice = startPrice;
            float probs = 0.5f;
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

    stock st1 = new stock();
    stock st2 = new stock();

    // Start is called before the first frame update
    void Start()
    {

        st1.stockName = "sasung";
        st1.setPrice();
        st1.setMaxCount(st1.startPrice);

        st2.stockName = "kingcacola";
        st2.setPrice();
        st2.setMaxCount(st2.startPrice);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        st2.stocking(st2.stockName, st2.startPrice);
        st1.stocking(st1.stockName, st1.startPrice);
    }
}
