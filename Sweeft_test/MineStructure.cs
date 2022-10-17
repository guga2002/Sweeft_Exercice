using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Sweeft_test
{
    /*
     .     დაწერეთ საკუთარი მონაცემთა სტრუქტურა, რომელიც საშუალებას მოგვცემს 
    O(1) დროში წავშალოთ ელემენტი.
    */
    public class Structure
    {
        ArrayList arry;//   viyenebt arrais rata shevcvalot zoma
        Dictionary<int, int> dic;//pirveli elementi iqneba  array is mnishvneloba meore shesabamisi indeqsi

        public Structure( ArrayList ar,Dictionary<int,int> df)//inicializeba
        {
            arry = ar;
            dic = df;
        }

        private void swapit(ArrayList list, int i, int j)// funqcia listshi elementebis gasacvlelad
        {

            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
        public void Delete(int x)// washlis funqcia O(1)  droshi
        {

            int index = arry.IndexOf(x); //vnaxulobt  x elementis indeqs

            if (index == -1) // tu elementi ar arsebobs   mashin ver wavshlit
                return;


            dic.Remove(x);

            int size = arry.Count;//zoma anu elementebis raodenoba chvens monacemta struqturashi

            int last = arry.IndexOf(size - 1);
            swapit(arry, index, size - 1);

            arry.RemoveAt(size - 1);// wavshalet bolo elementi  arrayshi dro chirdeba O(1);
            dic.Add(last, index);//ganvaxlot mapi bolo elementistvis
        }
    }
}
