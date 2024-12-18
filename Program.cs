using Behavioral_State;
/*
 The object can behave differently base of the its state.
If you want add new states, you needn't modify the document class, instead you can add new State Class
The open-closed principle is respected.
With the abstract class in substitution to an interface, you can create a hierachy of state classes and prevent duplication of methods.
If a class needed only two state, the use of State patter is unnecessary.
State patter is usefull when you have a large number of conditionals.
 */

//BAD SOLUTION WITH FIXED BRANCHING
Document_BADSOLUTION doc = new Document_BADSOLUTION();
doc.State = DocumentStates.Revisione;
//doc.CurrentUserRole = UserRoles.Amministratore;
doc.CurrentUserRole = UserRoles.Editore;
Console.WriteLine(doc.State);
doc.Publish();
Console.WriteLine(doc.State);
Console.WriteLine("********************");

//CORRECT SOLUTION WITH STATE PATTERN
DocumentContext doc2 = new DocumentContext(UserRoles.Editore);
Console.WriteLine(doc2.State);
doc2.Publish();
Console.WriteLine(doc2.State);
doc2.Publish();
Console.WriteLine(doc2.State);

Console.WriteLine("******************** ADMINISTRATOR");
doc2 = new DocumentContext(UserRoles.Amministratore);
Console.WriteLine(doc2.State);
doc2.Publish();
Console.WriteLine(doc2.State);
doc2.Publish();
Console.WriteLine(doc2.State);
Console.WriteLine("Return to draft state");
doc2.State = new DraftState(doc2);
Console.WriteLine(doc2.State);
doc2.Publish();
Console.WriteLine(doc2.State);
doc2.Publish();
Console.WriteLine(doc2.State);


Console.WriteLine("******************** EDITOR");
doc2 = new DocumentContext(UserRoles.Editore);
Console.WriteLine(doc2.State);
doc2.Publish();
Console.WriteLine(doc2.State);
doc2.Publish();
Console.WriteLine(doc2.State);
Console.WriteLine("Return to draft state");
doc2.State = new DraftState(doc2);
Console.WriteLine(doc2.State);
doc2.Publish();
Console.WriteLine(doc2.State);
doc2.Publish();
Console.WriteLine(doc2.State);

