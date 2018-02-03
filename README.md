# ExpressionEqualityComparer.

Wherever an IEqualityComperer<T> is used, pass
EqualityComparer.Create((t1, t2) => t1.AmIEqualTo(t2))

where AmIEqualTo is your custom equality method.

e.g.
List<MyClass> myList = ... ;
var myDistinctObjects = myList.Distinct(EqualityComparer.Create((t1,t2) => t1.AmIEqualTo(t2)));

