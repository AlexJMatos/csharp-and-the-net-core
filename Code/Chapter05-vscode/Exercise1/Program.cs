/*
1. What are the six combinations of access modifier keywords and what do they do?

Answer: The six combinations of access modifier keywords and their effects are
described in the following list:
• private: This modifier makes a member only visible inside the class.
• internal: This modifier makes a member only visible inside the same assembly.
• protected: This modifier makes a member only visible inside the class or
derived classes.
• internal protected: This modifier makes a member only visible inside the
class, derived classes, or within the same assembly.
• private protected: This modifier makes a member only visible inside the class
or derived classes that are within the same assembly.
• public: This modifier makes a member visible everywhere.
*/

/*
2. What is the difference between the static, const, and readonly keywords when
applied to a type member?

Answer: The differences between the static, const, and readonly keywords when
applied to a type member are described in the following list:
• static: This keyword makes the member shared by all instances, and it must be
accessed through the type, not an instance of the type.
• const: This keyword makes the field a fixed literal value that must never change
because, during compilation, assemblies that use the field copy the literal value
at the time of compilation.
• readonly: This keyword restricts the field so that it can only be assigned to
using a constructor or field initializer at runtime.
*/

/*
3. What does a constructor do?

Answer: A constructor allocates memory and initializes field values.
*/

/*
4. Why should you apply the [Flags] attribute to an enum type when you want to
store combined values?

Answer: If you don't apply the [Flags] attribute to an enum type when you want to
store combined values, then a stored enum value that is a combination will be returned
by a call to ToString as the stored integer value instead of one or more of the commaseparated
lists of text values.
*/

/*
5. Why is the partial keyword useful?

Answer: You can use the partial keyword to split the definition of a type over multiple
files.
*/

/*
6. What is a tuple?

Answer: A tuple is a data structure consisting of multiple parts. They are used when
you want to store multiple values as a unit without defining a type for them.
*/

/*
7. What does the record keyword do?

Answer: The record keyword defines a data structure that is immutable by default to
enable a more functional programming style. Like a class, a record can have properties
and methods, but the values of properties can only be set during initialization.
*/

/*
8. What does overloading mean?

Answer: Overloading is when you define more than one method with the same method
name and different input parameters.
*/

/*
9. What is the difference between a field and a property?

Answer: A field is a data storage location that can be referenced. A property is one or a
pair of methods that get and/or set a value. The value for a property is often stored in a
private field.
*/

/*
10. How do you make a method parameter optional?

Answer: You make a method parameter optional by assigning a default value to it in
the method signature.
*/