using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatements
{
    public class ArrayListDataTypes
    {

        public ArrayList GetListOfData()
        {
            List<string> list = new List<string>();
            // list.Add

            ArrayList arrayList = new ArrayList();

            arrayList.Add("1");
            arrayList.Add("Mango");
            arrayList.Add(10);

            ArrayList arrayListProducts = new ArrayList();

            arrayList.Add("Macbook");
            arrayList.Add("Iphone");
            arrayList.Add("Samsung");
            arrayList.AddRange(arrayListProducts);

            return arrayList;

        }
    }
}
