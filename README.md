# Intro-To-Builder-Design-Pattern
Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.

<p align="center">
  <img src="https://github.com/user-attachments/assets/89f06734-2b58-4eee-9ee8-708475335774" width="800">
</p>


1. The Builder interface declares product construction steps that are common to all types of builders.

3. Concrete Builders provide different implementations of the construction steps. Concrete builders may produce products that don’t follow the common interface.

5. Products are resulting objects. Products constructed by different builders don’t have to belong to the same class hierarchy or interface.

7. The Director class defines the order in which to call construction steps, so you can create and reuse specific configurations of products.

9. The Client must associate one of the builder objects with the director. Usually, it’s done just once, via parameters of the director’s constructor. Then the director uses that builder object for all further construction. However, there’s an alternative approach for when the client passes the builder object to the production method of the director. In this case, you can use a different builder each time you produce something with the director.

Image and Description source: Dive Into DESIGN PATTERNS by Alexander Shvets <br/>
Link to the book : https://refactoring.guru/design-patterns/book
