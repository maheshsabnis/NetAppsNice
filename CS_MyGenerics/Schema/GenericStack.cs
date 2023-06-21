using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_MyGenerics.Schema
{
    /// <summary>
    /// The Generic Constraints, It will always be a class, where T : class
    /// 
    /// where T : Employee: This metand that I can be either EMployee or any derivation of Employee
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class GenericStack<T> where T : Employee
    {
        int top = 0;

        // Generic Memeber
        T[] items;

        public GenericStack()
        {
            items = new T[5];     
        }

        /* Generic Method with Generic Input and/or Output parameters */

        public void Push(T item)
        {
            items[top++] = item;
        }

        public T Pop() 
        {
            // Modify the Array here
            return items[--top];
        }

        public T[] ShowItems() 
        {
            return items;
        }
    }
}
