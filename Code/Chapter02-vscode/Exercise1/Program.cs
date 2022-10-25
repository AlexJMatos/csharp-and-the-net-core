using static System.Console;

// 1. What statement can you type in a C# file to discover the compiler and language version?
// #error version

/* 2. What are the two types of comments in C#?
There are two types, single line comments prefixed with // and multi line comment starting with /* and ending with */

/* 3. What is the difference between a verbatim string and an interpolated string?
A verbatim string is prefixed with the @ symbol and each character 
(except ") is interpreted as itself; for example, a backslash \ is a backslash \. An 
interpolated string is prefixed with the $ symbol and can include expressions 
surrounded with braces like this: {expression}. */

/* 4. Why should you be careful when using float and double values?
Answer: You should be careful when using float and double values because they are 
not guaranteed to be accurate, especially when performing equality comparisons. */

/* 5. How can you determine how many bytes a type like double uses in memory?
Answer: You can determine how many bytes a type like double uses in memory by 
using the sizeof() operator, for example, sizeof(double). */

/* 6. When should you use the var keyword?
Answer: You should only use the var keyword to declare local variables when you 
cannot specify a known type. It is easy to overuse var due to its convenience when 
initially writing code, but its use can make it harder to maintain code later. */

/* 7. What is the newest way to create an instance of a class like XmlDocument? 
Answer: The newest way to create an instance of a class like XmlDocument is to use a 
target-typed new expression, as shown in the following code: 
XmlDocument doc = new(); */

/* 8. Why should you be careful when using the dynamic type? 
Answer: You should be careful when using the dynamic type because the type of object 
stored in it is not checked until runtime, which can mean runtime exceptions being 
thrown if you attempt to use a member that does not exist on the type. */ 

/* 9. How do you right-align a format string? 
Answer: To right-align a format string, after the index or expression, add a comma and 
an integer value to specify a column width within which to align the value. Positive 
integers mean right-aligned, and negative integers mean left-aligned. */ 

/* 10. What character separates arguments for a console application? 
Answer: The space character separates arguments for a console application. */