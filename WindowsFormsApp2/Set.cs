using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    static class Set
    {
        
        public static bool isInArray(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    return true;
                }
            }
            return false;
        }

        public static int[] removeElement(int[] array, int index)
        {
            int[] result = new int[array.Length - 1];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (index != i)
                {
                    result[k] = array[i];
                    k++;
                }
            }
            return result;
        }

        public static int[] addElement(int[] array, int index, int element)
        {
            int[] result = new int[array.Length + 1];
            for (int i = 0; i < index; i++)
            {
                result[i] = array[i];
            }
            result[index] = element;
            for (int i = index + 1; i < result.Length; i++)
            {
                result[i] = array[i - 1];
            }
            return result;
        }

        public static int[] mergeArrays(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Length + array2.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i];
            }
            for (int i = array1.Length; i < result.Length; i++)
                for (int j = 0; j < array2.Length; j++)
                {
                    result[i] = array1[j];
                }
            return result;
        }

        public static string Display(int[] array)
        {
            string str = array[0].ToString();
            for (int i = 1; i < array.Length; ++i)
            {
                str += "," + array[i].ToString();
            }
            return str;
        }
    }
}
