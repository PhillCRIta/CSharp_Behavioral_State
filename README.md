### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# State pattern
 The object can behave differently base of the its state. \
If you want add new states, you needn't modify the document class, instead you can add new State Class. \
The open-closed principle is respected. \
With the abstract class in substitution to an interface, you can create a hierachy of state classes and prevent duplication of methods. \
If a class needed only two state, the use of State patter is unnecessary. \
State patter is usefull when you have a large number of conditionals.