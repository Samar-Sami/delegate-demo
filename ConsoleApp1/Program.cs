namespace ConsoleApp1
{
    //class
    //struct
    //interface
    //enm
    //deleget


    //0 -defining delegate  
    public delegate int REturnFuncdeleget(string s);
    //returnfunc     //parameterFnc
    //compiler make deleget as a class as the same as func name 
    //constructor make 2 methods invoke
                               //  end  invoke
                               // make invoke

    //ref from deleget can refer to func or more [pointer to func or more]
    //func may be static or nana static 
    //function must be same signiture of method regardless name of func or access modifier
    //
    //  4steps  <=بيمر    delegate التعامل 
    //0 -defining delegate    
    //..delegate=>   constructor وبيتعمله  classبيتعامل معامله ال  
    // 1-declare ref from delegate
    //2- initialize ref from delegate
    //3-use deleget ref



    internal class Program
    {
        public static int SumChar(string word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                        count++;
                }
            }
           
            return count;
        }




        //function lowerChar طب لو عايزى اعمل 
        //deleget بتاعها هي كمان في ال address   كدة محتاجه احط ال 
        public static int SumlowerChar(string word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                        count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            // deleget is a c#  featuure
            //  class في الاول او في الاخر  deleget

            //  c# is a pure oop
            // using deleget:-
            // funtion programmng
            //event driven programming





            //  2 paradims              deleget  اللي بقدر اعمله من خلال   deleget 
            //*1.. implement function programming paradims
            //   بس في3 الاشهر لو موجودين  function programming paradims   عندي كتير في    
            //language support function programming:
            //1..  as a parameter    تانيه  funtion  بتاخد مني funtion 
            // 2..funtion inside  variable  باستخدام اللغة اقدر اخزن
            // 3..funtion return funtion
            //*2..implement event driven programming paradims



            // sort func   التاجيل يعني عندي    delegation  من اسمه جاي deleget
            //   الله اعلم مش هحدد دلوقت  asc or desc  <= sort  بناء علي ايه بتعملsort   بتعمل  
            //   اومال مين اللي هيبدا انه يحدها 
            //   deleget دي  func وابعت لل  delegetاقدر اني اعمل
            // func as a parameter  دي  func   يعني كاني ببعت لل   




            int x = 2;
            // variable  كذلك انا عايزة اخزنها   جوه
            //  هروح اعرفها deleget اذن هحتاج 

            // 1-declare ref from delegate
            REturnFuncdeleget stringFunc;

            //2- initialize ref from delegate
            stringFunc = new REturnFuncdeleget(SumChar) ;

            //syntax suger 
            string names = new string("mora");
            string named = "mora";

            //syntax suger 
            REturnFuncdeleget strFunc = SumChar;
            // strFunc = SumlowerChar;
            //    جديد بيشاور ع التانيه مش الاولي    obj  كده كاني عملت




            strFunc += SumlowerChar;
            //    للتانيه  REturn  هي  REturn  للاتنين بس اما يجي ي   call  كده عمل   
            //  لا في بيعملوا طباعه هيطبع اللي جوه 2 REturn  طب لو هي في اتنين فانكشن ومش الاتنين بيعملوا  
            //int  بترجع   function شايله 
            int Result = strFunc.Invoke("mora samIIIIIIR");
            //Invoke  => address اللي شايله ال func  لل call دي اللي بتعمل 

             Result = strFunc("mora samIIIIIIR");//are the same
            

            Console.WriteLine(Result);
         
        }
    }
}
