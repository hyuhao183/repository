using System;
using System.Collections.Generic;

namespace 扑克牌2
{
  public  class Program
    {
     
        public static void Main()
        {
            Console.WriteLine("扑克牌");
            TestPlay();
        }
            public static void TestPlay()
            {
                //产生扑克牌
               
                List<PaperCard> myCards = new List<PaperCard>();
                string[] strType = { "红桃", "黑桃", "梅花", "方块" };
                string[] strNumber = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
                PaperCard[] OtherCard = { new PaperCard("大王", ""), new PaperCard("小王", ""), new PaperCard("",""), new PaperCard(null,"") };

                for (int i = 0; i < strNumber.Length; i++)
                {
                    for (int j = 0; j < strType.Length; j++)
                    {
                        PaperCard p = new PaperCard(strType[j], strNumber[i]);
                        myCards.Add(p);
                    }
                }

                for (int j = 0; j < OtherCard.Length; j++)
                {
                    myCards.Add(OtherCard[j]);
                }

                //洗牌
                Console.WriteLine("正在洗牌...");
                Stack<PaperCard> stackCard = new Stack<PaperCard>();
                Random r = new Random();

                while (myCards.Count > 0)
                {
                    int iIndex = r.Next(0, myCards.Count);
                    stackCard.Push(myCards[iIndex]);
                    myCards.RemoveAt(iIndex);
                }



                //发牌
                Console.WriteLine("开始发牌...");
                List<User> listUser = new List<User>() {
                    new User("大师兄"),
                    new User("二师兄"),
                    new User("三师弟"),
                    new User("小白")
                };
           
           

                while (stackCard.Count > 0)
                {
                    for (int s = 0; s < listUser.Count; s++)
                    {
                        listUser[s].Add(stackCard.Pop());
                    }
                }

           



            Console.WriteLine("发牌完成！");

            foreach(var item in listUser)
            {
                item.Dd();
            }
            //看牌
            foreach (var item in listUser)
                {
                    item.Introduce();
              
                }
            }
        }
    
}
