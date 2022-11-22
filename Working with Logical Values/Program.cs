/*TASK: In this task, I will show you how to work with logical values.

 *  The type for logical values is called bool in C#. The value “yes” is written as true, and the
    value “no” is written as false. Here is the code:
 */

// Two logical (Boolean) variables
bool thePrettiestGirlLovesMe = true;
bool iAmHungry = false;

// Using exclamation mark to negate logical value
bool iAmNotHungry = !iAmHungry;

//Output
Console.WriteLine("She love me: " + thePrettiestGirlLovesMe);
Console.WriteLine("I am hungry: " + iAmHungry);
Console.WriteLine("I am not hungry: " + iAmNotHungry);

// Waiting for Enter
Console.ReadLine();


/* DICUSSION:
 * 
 *  Note that you use an exclamation mark whenever you need to negate a logical value (to
    flip it from “yes” to “no” and back again).
 */ 