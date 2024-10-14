using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ConsoleApp1.Extension
{
    public static class ExtensionMethodsDictionary
    {
        //runtimeoperator
        public static class OperatorAdd<T>
        {
            public static readonly Func<T, T, T> Add;

            static OperatorAdd()
            {
                var paramA = Expression.Parameter(typeof(T), "a");
                var paramB = Expression.Parameter(typeof(T), "b");

                var body = Expression.Add(paramA, paramB);
                Add = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            }
        }
        public static void NewOrdAdd<Key, Value>(this IDictionary<Key, Value> dictionary, Key key, Value value)
        {
            if (dictionary.TryAdd(key, value)) { }
            else
            {
                dynamic result = (dynamic)dictionary[key] + (dynamic)value;
                dictionary[key] = result;
            }
        }
        public static void NewOrAdd<Key, Value>(this Dictionary<Key, Value> dictionary, Key key, Value value)
        {
            if (dictionary.TryAdd(key, value)) { }
            else
            {
                Value val = dictionary[key];
                dictionary[key] = OperatorAdd<Value>.Add(dictionary[key], value);
            }
        }
    }
}
