using System;
using System.Linq.Expressions;

Console.WriteLine(Expression.Lambda<Func<string>>(Expression.TryFault(Expression.Constant("hi"), Expression.Constant("alternative"))).Compile()());
