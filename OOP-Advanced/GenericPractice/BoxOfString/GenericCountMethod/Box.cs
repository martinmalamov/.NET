﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace CustomList
public class Box<T> : IEnumerable<T> where T : IComparable<T>

{
    private readonly List<T> list;
    public Box()
    {
        this.list = new List<T>();

        //  this.Count = 0;
    }
    public Box(IEnumerable<T> items)
    {
        this.list = new List<T>(items);
    }

    public void Add(T element)
    {
        this.list.Add(element);
    }

    public T  Remove(int index)
    {
        T element = this.list[index];
        this.list.RemoveAt(index);
        return element;
    }

    public bool Contains(T element)
    {
        return this.list.Contains(element);
        //if (true)
        //{
        //    if (this.list.Contains(element))
        //    {
        //        //Console.WriteLine($"{true}");
        //        return true;
        //        //Console.WriteLine("True");
        //    }
        //    else
        //    {
        //        return false;
        //        // Console.WriteLine("False");
        //    }
        //}
    }

    public void Swap(int index1, int index2)
    {
        //T swap = this.Item[index1];
        //this.Item[index1] = this.Item[index2];
        //this.Item[index2] = swap;

        T swap = this.list[index1];
        this.list[index1] = this.list[index2];
        this.list[index2] = swap;

    }

    public int CountGreaterThan(T element)
    {
        int count = 0;
        foreach (var item in this.list)
        {
            if (item.CompareTo(element) > 0)
            {
                count++;
            }
        }
        return count;
    }

    public T Max()
    {
        return this.list.Max();
    }
    public T Min()
    {
        return this.list.Min();
    }
    public override string ToString()
    {
        return string.Join(Environment.NewLine, this.list);
    }



    public IEnumerator<T> GetEnumerator()
    {
        foreach (T item in this.list)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

}
