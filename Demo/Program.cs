using System;

namespace Demo
{
    //step 0 Declaration
    public delegate int CstmFun(string q);


    internal class Program
    {
        #region ex3
        public static List<int> FindOdds(List<int> list)
        {
            List<int> result = new List<int>();
            foreach (int i in list)
            {
                if(list.Count>0)
                if (i % 2 == 1) result.Add(i);
            }
            return result;
        } 
        #endregion

        static void Main(string[] args)
        {

            #region intro
            ///Delegate is a c# feature
            /// hold function with same signature 
            /// hold one or more function
            /// has two usage:
            /// 1-functional programming 
            /// 2-event driven programming
            /// convert to class 
            /// regardless Access Modifer or naming

            #endregion

            #region ex1
            ///step1 make refrence
            CstmFun Refrence;

            ///step 2 initialize the Delagate
            Refrence = new CstmFun(StringFunction.fun);
            Refrence = StringFunction.fun;

            ///step 3 use Delagate
            //Console.WriteLine( Refrence.Invoke("mOhMmMEd"));
            // StringFunction.fun("mOhMmMEd");

            #endregion

            #region ex2
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //SortAlgorithem.BubbelSort(num,new Desc());//apply stratgy Design pattern
            Sort_Compare<int, int, bool> cc = So0rt_Comparer.gre;
            SortAlgorithem<int>.BubbelSort(num, cc);//using Delagate
            //SortAlgorithem<int>.BubbelSort(num, (x, y) => x < y); //landa method
            //foreach (var i in num) 
            //    Console.WriteLine( i );
            #endregion


            #region ex3
            List<int> list = Enumerable.Range(0, 100).ToList();

            List<int>odd= FindOdds(list);
            //foreach (var i in odd)
            //    Console.WriteLine(i);
            #endregion


           #region Build in Delagte
            //Predicate<int> predicate = new Predicate<int>(SomeFunction.fun);
            //Console.WriteLine(predicate.Invoke(5));
            ////build in Delagate take one paramter and retutn bool

            ///*==========================================================*/
            //Func<int, bool> func = new Func<int, bool>(SomeFunction.fun);
            ////build in Delagate take from one to 16 paramter and retutn value of (T)

            ///*==========================================================*/
            //Action action;// no paramter and no return value

            //Action<int> action1;//to 16 paramter and no retyrn value (void)


            #endregion

            #region anonymous and lambada
            Predicate<int> predicate = delegate (int q) {return q > 0;};
            var predicate1 = (int n) => n > 0;

            //lambada
            //=> called Fatarrow  and read as Goto 

             predicate =   q=> q > 0;

            #endregion



        }
    }

    #region class ex1
    class StringFunction
    {
        
        public static int fun(string q)
        {
            int count = 0;
            if (q is not null)
            {
                for (int i = 0; i < q.Length; i++)
                {
                    if(char.IsUpper(q[i]))
                    {
                        count++;
                    }
                }  
            }
            return count;
        }

    }

    #endregion


    #region Build in Delagte
    class SomeFunction
    {
        public static bool fun(int q)
        {
            return q > 0;
        }
    }

    #endregion
}
