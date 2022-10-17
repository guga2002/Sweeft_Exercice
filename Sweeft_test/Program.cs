using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft_test
{
  
    class Program
    {
//    {
//        1.     დაწერეთ ფუნქცია, რომელსაც გადაეცემა ტექსტი და აბრუნებს
//პალინდრომია თუ არა. (პალინდრომი არის ტექსტი რომელიც ერთნაირად
//იკითხება ორივე მხრიდან).
        static bool isPalindrome(string text)
        {
            return text.SequenceEqual( text.Reverse());// tu sityva tolia misi shebrunebulis aris  palindromi orive mxridan ernairad vkitxulobt
        }

        /*
         2.     გვაქვს 1,5,10,20 და 50 თეთრიანი მონეტები. დაწერეთ ფუნქცია, რომელსაც
         გადაეცემა თანხა (თეთრებში) და აბრუნებს მონეტების მინიმალურ
         რაოდენობას, რომლითაც შეგვიძლია ეს თანხა დავახურდაოთ.*/
        static int minSplit(int amount)
        {
            int droebitijami = amount;//   funqciashi samushao   kopio amount cvladistvis
            int raodenoba = 0;// vitvlit raodenobas  ,minimalurs

            raodenoba += droebitijami / 50;//mtelad gayofis   dros daabrunebs  maqs ramdeni 50 tetri sheidzleba
            droebitijami = droebitijami % 50;//ukve   jams  vxvdit  nashts rasac  50 daabrunebs
         
            raodenoba += droebitijami / 20;// aqac vaketebt ukve roca nashti wina gayofis dros  ukbve aris 50 ze naklebi
            droebitijami = droebitijami % 20;
         
            raodenoba += droebitijami / 10;
            droebitijami = droebitijami % 10;
        
            raodenoba += droebitijami / 5;
            droebitijami = droebitijami % 5;
         
            raodenoba += droebitijami / 1;
            droebitijami = droebitijami % 1;


            return raodenoba;

        }

        static bool contain(int[]ar,int el)
        {
            bool a=false;
            foreach (var item in ar)
            {
                if (item == el) a = true;

            }
            return a;
        }
        /*
         * 3.     მოცემულია მასივი, რომელიც შედგება მთელი რიცხვებისგან. დაწერეთ
           ფუნქცია რომელსაც გადაეცემა ეს მასივი და აბრუნებს მინიმალურ მთელ
           რიცხვს, რომელიც 0-ზე მეტია და ამ მასივში არ შედის.
        */
      static   int notContains(int[] arry)
        {
            int zoma = arry.Length + 1;// plius erti imitom uechvelad ro davsvat  is erti elementi
            for(int i=0;i<=zoma;i++)
            {
                if (arry.Contains(i) == false && i > 0) return i;//  an shegvidzlia  cili daviwyot  i=1 idan da agar mogviwevs
                // yvela iteraciaze dadebitobis shemowmeba  ...
        

            }

            return 0;//programa warumateblad dasrulda;
        }


        /*
          4.     მოცემულია String რომელიც შედგება „(„ და „)“ ელემენტებისგან. დაწერეთ
          ფუნქცია რომელიც აბრუნებს ფრჩხილები არის თუ არა მათემატიკურად
          სწორად დასმული.
         */
        static bool isProperly(String sequence)
        {
            int count1=0, count2=0;
            for (int i=0;i<sequence.Length;i++ )
            {
                if (sequence[i] == '(')count1++;
                if (sequence[i] == ')') count2++;
            }
         
            if (count1 != count2) return false;
            else
            {

                for(int i=0;i<sequence.Length;i++)
                {
                    switch(sequence[i])
                        {
                        case '+':
                        case '/':
                        case '*':
                        case '-':
                        case '%':
                            if (sequence.ElementAt(i++) == ')' || sequence.ElementAt(i--) == '(') return false; 
                            break;
                        default: ;
                            break; 
                            
                        }
                }


            }
            return true;
        }

        /*
         5.     გვაქვს n სართულიანი კიბე, ერთ მოქმედებაში შეგვიძლია ავიდეთ 1 ან 2
         საფეხურით. დაწერეთ ფუნქცია რომელიც დაითვლის n სართულზე ასვლის
         ვარიანტების რაოდენობას.
        */
        static int countVariants(int stearsCount)// amovxsnit rekursiuli gzit  n-2 istvis davamatebt  n-1  is  shemtxvevas 
                                                 //msgavsad  finbonaccisa yovel iteraciaze gvaqvs ori archevani , ase movaxerxebt yvela variantis datestvas 
        {
            if (stearsCount == 0)
                return 1;
            else if (stearsCount < 0)
                return 0;
            else return countVariants(stearsCount - 2) + countVariants(stearsCount - 1);
        }
        // kodis testiureba movaxerxe  n=2, n=3, n=4  safexuristvis da mushaobs  sworad .




        static void Main(string[] args)
        {
            #region pirveliamocana
            Console.WriteLine("shemoitane sityva da gavigebt aris tu ara palindromi");
            string strl = Console.ReadLine();
            if (isPalindrome(strl)) Console.WriteLine("sityva aris palindromi");
            else Console.WriteLine("ar aris palindromi");

            #endregion

            #region minimaluri raodenoba tanxis
            Console.WriteLine("Shemoitanet tanxa  tetrebshi");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"minimaluri raodenoba rasac gamoviyenebt xurdebis aris {minSplit(a)} ");
            #endregion

            #region minimaluri mteli ricxvi romelsac ar sheicavs masivi
            Console.WriteLine("ramdenelementiani masivi gsurt");
            int Nod = int.Parse(Console.ReadLine());
            int[] maseq = new int[Nod];
            for(int i=0;i<Nod;i++)
            {
                Console.WriteLine($"shemoitane me-{i + 1}  elementi");
                maseq[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($" aseti elementi aris {notContains(maseq)}");
            #endregion

            #region matematikuri gamosaxulebis siwore

            Console.WriteLine("Shemoitanet matematikuri gamosaxuleba ()  is gamoyenebit ");
            string mtgam = Console.ReadLine();
            if(isProperly(mtgam))
                Console.WriteLine( "gamosaxuleba sworia");
            else Console.WriteLine("gamosaxuleba  ar aris swori ");

            #endregion

            #region kibis amocana
            Console.WriteLine("Shemoitanet kibis safexurebis raodenoba ");
            int stepoden = int.Parse(Console.ReadLine());
            Console.WriteLine($" {stepoden} safexuriani kibeze asvlis yvela varianti aris {countVariants(stepoden)}");
            #endregion

            #region chveni struqturis gamoyenebis magaliti

           

            ArrayList ls = new ArrayList();
            for(int i=0;i<10;i++)
            {
                ls.Add(i + i * i);
            }

            Dictionary<int, int> ma = new Dictionary<int, int>();
            int it = 0;
            foreach (int item in ls)
            {
                ma.Add(item, it);
                it++;
            }

            Structure st = new Structure(ls, ma);
            st.Delete(3);// wavshalot elementi 

            #endregion

            #region testirebistvis



            // Console.WriteLine( notContains(mas));
            // string correct = "(5+5)*4+9;";
            // string incorect = "((5+6)*20)";
            // Console.WriteLine(isProperly(correct));
            // Console.WriteLine(isProperly(incorect));
            //Console.WriteLine(countVariants(3));
            #endregion
        }
    }
}
