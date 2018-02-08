# ExpressionEqualityComparer.

Wherever an IEqualityComperer<T> is used, pass
EqualityComparer.Create((t1, t2) => t1.AmIEqualTo(t2))

where AmIEqualTo is your custom equality method.

e.g.
List<MyClass> myList = ... ;
var myDistinctObjects = myList.Distinct(EqualityComparer.Create((t1,t2) => t1.AmIEqualTo(t2)));


or

EqualityComparer<T>.Create<TVal>(t => t.GetTVal());
where GetTVal() is a function that returns a TVal that represents the equivalence of the T objects.

