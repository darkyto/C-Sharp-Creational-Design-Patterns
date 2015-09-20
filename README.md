Creational Patterns
===================

Shord descriptions and use exmaples for **Singleton, Factory Method, Builder and Prototype** design patterns.


## Singelton ##

1. **Intends**
--------------

    Ensure a class has only one instance, and provide a global point of
    access to it. Encapsulated "just-in-time initialization" or
    "initialization on first use".

    

2. **Description**
------------------

Make the class of the single instance object responsible for creation, initialization, access, and enforcement. Declare the instance as a private static data member. Provide a public static member function that encapsulates all initialization code, and provides access to the instance.

The client calls the accessor function (using the class name and scope resolution operator) whenever a reference to the single instance is required.

Singleton should be considered only if all three of the following criteria are satisfied:

Ownership of the single instance cannot be reasonably assigned
Lazy initialization is desirable
Global access is not otherwise provided for
If ownership of the single instance, when and how initialization occurs, and global access are not issues, Singleton is not sufficiently interesting.

The Singleton pattern can be extended to support access to an application-specific number of instances.

The "static member function accessor" approach will not support subclassing of the Singleton class. If subclassing is desired, refer to the discussion in the book.

Deleting a Singleton class/instance is a non-trivial design problem. See "To Kill A Singleton" by John Vlissides for a discussion.

 
 3. **Structure**
---------------

![enter image description here](https://sourcemaking.com/files/v2/content/patterns/singleton1-2x.png)

![enter image description here](https://sourcemaking.com/files/v2/content/patterns/Singleton-2x.png)

 4. **Example**
---------------

The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance. It is named after the singleton set, which is defined to be a set containing one element. The office of the President of the United States is a Singleton. The United States Constitution specifies the means by which a president is elected, limits the term of office, and defines the order of succession. As a result, there can be at most one active president at any given time. Regardless of the personal identity of the active president, the title, "The President of the United States" is a global point of access that identifies the person in the office.
![enter image description here](https://sourcemaking.com/files/v2/content/patterns/Singleton_example1-2x.png)

**Check list**

**Define a private static attribute in the "single instance" class.
Define a public static accessor function in the class.
Do "lazy initialization" (creation on first use) in the accessor function.
Define all constructors to be protected or private.
Clients may only use the accessor function to manipulate the Singleton.**

**Rules of thumb**

Abstract Factory, Builder, and Prototype can use Singleton in their implementation.
Facade objects are often Singletons because only one Facade object is required.
State objects are often Singletons.
The advantage of Singleton over global variables is that you are absolutely sure of the number of instances when you use Singleton, and, you can change your mind and manage any number of instances.
The Singleton design pattern is one of the most inappropriately used patterns. Singletons are intended to be used when a class must have exactly one instance, no more, no less. Designers frequently use Singletons in a misguided attempt to replace global variables. A Singleton is, for intents and purposes, a global variable. The Singleton does not do away with the global; it merely renames it.
When is Singleton unnecessary? Short answer: most of the time. Long answer: when it's simpler to pass an object resource as a reference to the objects that need it, rather than letting objects access the resource globally. The real problem with Singletons is that they give you such a good excuse not to think carefully about the appropriate visibility of an object. Finding the right balance of exposure and protection for an object is critical for maintaining flexibility.
Our group had a bad habit of using global data, so I did a study group on Singleton. The next thing I know Singletons appeared everywhere and none of the problems related to global data went away. The answer to the global data question is not, "Make it a Singleton." The answer is, "Why in the hell are you using global data?" Changing the name doesn't change the problem. In fact, it may make it worse because it gives you the opportunity to say, "Well I'm not doing that, I'm doing this" – even though this and that are the same thing.

    using System;

  class MainApp
  {
 
    static void Main()
    {
      // Constructor is protected -- cannot use new 
      Singleton s1 = Singleton.Instance();
      Singleton s2 = Singleton.Instance();

      if (s1 == s2)
      {
        Console.WriteLine("Objects are the same instance");
      }

      // Wait for user 
      Console.Read();
    }
  }

  // "Singleton" 
  class Singleton
  {
    private static Singleton instance;

    // Note: Constructor is 'protected' 
    protected Singleton() 
    {
    }

    public static Singleton Instance()
    {
      // Use 'Lazy initialization' 
      if (instance == null)
      {
        instance = new Singleton();
      }

      return instance;
    }
  }
}

Output

    Objects are the same instance


## Factory Method ##

1. Intent
---------
Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
Defining a "virtual" constructor.
The new operator considered harmful.

2. Problem
---------
A framework needs to standardize the architectural model for a range of applications, but allow for individual applications to define their own domain objects and provide for their instantiation

3. Description
---------
Factory Method is to creating objects as Template Method is to implementing an algorithm. A superclass specifies all standard and generic behavior (using pure virtual "placeholders" for creation steps), and then delegates the creation details to subclasses that are supplied by the client.

Factory Method makes a design more customizable and only a little more complicated. Other design patterns require new classes, whereas Factory Method only requires a new operation.

People often use Factory Method as the standard way to create objects; but it isn't necessary if: the class that's instantiated never changes, or instantiation takes place in an operation that subclasses can easily override (such as an initialization operation).

Factory Method is similar to Abstract Factory but without the emphasis on families.

Factory Methods are routinely specified by an architectural framework, and then implemented by the user on the framework.

4. Structure
---------

![enter image description here](https://sourcemaking.com/files/v2/content/patterns/Factory_Method-2x.png)
An increasingly popular definition of factory method is: a static method of a class that returns an object of that class' type. But unlike a constructor, the actual object it returns might be an instance of a subclass. Unlike a constructor, an existing object might be reused, instead of a new object created. Unlike a constructor, factory methods can have different and more descriptive names (e.g. *Color.make_RGB_color(float red, float green, float blue*) and 
*Color.make_HSB_color(float hue, float saturation, float* *brightness)*
![enter image description here](https://sourcemaking.com/files/v2/content/patterns/Factory_Method_1-2x.png)
The client is totally decoupled from the implementation details of derived classes. Polymorphic creation is now possible.
![enter image description here](https://sourcemaking.com/files/v2/content/patterns/Factory_Method__-2x.png)

5. Example
---------
![enter image description here](https://sourcemaking.com/files/v2/content/patterns/Factory_Method_example1-2x.png)
The Factory Method defines an interface for creating objects, but lets subclasses decide which classes to instantiate. Injection molding presses demonstrate this pattern. Manufacturers of plastic toys process plastic molding powder, and inject the plastic into molds of the desired shapes. The class of toy (car, action figure, etc.) is determined by the mold.

**Check list**
If you have an inheritance hierarchy that exercises polymorphism, consider adding a polymorphic creation capability by defining a static factory method in the base class.
Design the arguments to the factory method. What qualities or characteristics are necessary and sufficient to identify the correct derived class to instantiate?
Consider designing an internal "object pool" that will allow objects to be reused instead of created from scratch.
Consider making all constructors private or protected.

**Rules of thumb**
Abstract Factory classes are often implemented with Factory Methods, but they can be implemented using Prototype.
Factory Methods are usually called within Template Methods.
***Factory Method: creation through inheritance. Prototype: creation through delegation.***
Often, designs start out using Factory Method (less complicated, more customizable, subclasses proliferate) and evolve toward Abstract Factory, Prototype, or Builder (more flexible, more complex) as the designer discovers where more flexibility is needed.
Prototype doesn't require subclassing, but it does require an Initialize operation. Factory Method requires subclassing, but doesn't require Initialize.
***The advantage of a Factory Method is that it can return the same instance multiple times, or can return a subclass rather than an object of that exact type.***
Some Factory Method advocates recommend that as a matter of language design (or failing that, as a matter of style) absolutely all constructors should be private or protected. It's no one else's business whether a class manufactures a new object or recycles an old one.
***The new operator considered harmful.*** There is a difference between requesting an object and creating one. The new operator always creates an object, and fails to encapsulate object creation. ***A Factory Method enforces that encapsulation, and allows an object to be requested without inextricable coupling to the act of creation.***

    using System;
using System.Collections;

  class MainApp
  {
    static void Main()
    {
      // An array of creators 
      Creator[] creators = new Creator[2];
      creators[0] = new ConcreteCreatorA();
      creators[1] = new ConcreteCreatorB();

      // Iterate over creators and create products 
      foreach(Creator creator in creators)
      {
        Product product = creator.FactoryMethod();
        Console.WriteLine("Created {0}", 
          product.GetType().Name);
      }

      // Wait for user 
      Console.Read();
    }
  }

  // "Product" 
  abstract class Product
  {
  }

  // "ConcreteProductA" 
  class ConcreteProductA : Product
  {
  }

  // "ConcreteProductB" 
  class ConcreteProductB : Product
  {
  }

  // "Creator" 
  abstract class Creator
  {
    public abstract Product FactoryMethod();
  }

  // "ConcreteCreator" 
  class ConcreteCreatorA : Creator
  {
    public override Product FactoryMethod()
    {
      return new ConcreteProductA();
    }
  }

  // "ConcreteCreator" 
  class ConcreteCreatorB : Creator
  {
    public override Product FactoryMethod()
    {
      return new ConcreteProductB();
    }
  }
output 

    Created ConcreteProductA
	Created ConcreteProductB


## Builder ##


1. Intent
---------
Separate the construction of a complex object from its representation so that the same construction process can create different representations.
Parse a complex representation, create one of several targets.

2 Problem
---------
An application needs to create the elements of a complex aggregate. The specification for the aggregate exists on secondary storage and one of many representations needs to be built in primary storage.

3. Description
---------
Separate the algorithm for interpreting (i.e. reading and parsing) a stored persistence mechanism (e.g. RTF files) from the algorithm for building and representing one of many target products (e.g. ASCII, TeX, text widget). The focus/distinction is on creating complex aggregates.

The "director" invokes "builder" services as it interprets the external format. The "builder" creates part of the complex object each time it is called and maintains all intermediate state. When the product is finished, the client retrieves the result from the "builder".

Affords finer control over the construction process. Unlike creational patterns that construct products in one shot, the Builder pattern constructs the product step by step under the control of the "director"

4. Structure
---------
The Reader encapsulates the parsing of the common input. The Builder hierarchy makes possible the polymorphic creation of many peculiar representations or targets.
![enter image description here](https://sourcemaking.com/files/v2/content/patterns/Builder-2x.png)

5. Example
---------
The Builder pattern separates the construction of a complex object from its representation so that the same construction process can create different representations. This pattern is used by fast food restaurants to construct children's meals. Children's meals typically consist of a main item, a side item, a drink, and a toy (e.g., a hamburger, fries, Coke, and toy dinosaur). Note that there can be variation in the content of the children's meal, but the construction process is the same. Whether a customer orders a hamburger, cheeseburger, or chicken, the process is the same. The employee at the counter directs the crew to assemble a main item, side item, and toy. These items are then placed in a bag. The drink is placed in a cup and remains outside of the bag. This same process is used at competing restaurants.
![enter image description here](https://sourcemaking.com/files/v2/content/patterns/Builder_example1-2x.png)
Check list
Decide if a common input and many possible representations (or outputs) is the problem at hand.
Encapsulate the parsing of the common input in a Reader class.
Design a standard protocol for creating all possible output representations. Capture the steps of this protocol in a Builder interface.
Define a Builder derived class for each target representation.
The client creates a Reader object and a Builder object, and registers the latter with the former.
The client asks the Reader to "construct".
The client asks the Builder to return the result.
Rules of thumb
Sometimes creational patterns are complementory: Builder can use one of the other patterns to implement which components get built. Abstract Factory, Builder, and Prototype can use Singleton in their implementations.
Builder focuses on constructing a complex object step by step. Abstract Factory emphasizes a family of product objects (either simple or complex). Builder returns the product as a final step, but as far as the Abstract Factory is concerned, the product gets returned immediately.
Builder often builds a Composite.
Often, designs start out using Factory Method (less complicated, more customizable, subclasses proliferate) and evolve toward Abstract Factory, Prototype, or Builder (more flexible, more complex) as the designer discovers where more flexibility is needed.

    using System;
using System.Collections;

  public class MainApp
  {
    public static void Main()
    { 
      // Create director and builders 
      Director director = new Director();

      Builder b1 = new ConcreteBuilder1();
      Builder b2 = new ConcreteBuilder2();

      // Construct two products 
      director.Construct(b1);
      Product p1 = b1.GetResult();
      p1.Show();

      director.Construct(b2);
      Product p2 = b2.GetResult();
      p2.Show();

      // Wait for user 
      Console.Read();
    }
  }

  // "Director" 
  class Director
  {
    // Builder uses a complex series of steps 
    public void Construct(Builder builder)
    {
      builder.BuildPartA();
      builder.BuildPartB();
    }
  }

  // "Builder" 
  abstract class Builder
  {
    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract Product GetResult();
  }

  // "ConcreteBuilder1" 
  class ConcreteBuilder1 : Builder
  {
    private Product product = new Product();

    public override void BuildPartA()
    {
      product.Add("PartA");
    }

    public override void BuildPartB()
    {
      product.Add("PartB");
    }

    public override Product GetResult()
    {
      return product;
    }
  }

  // "ConcreteBuilder2" 
  class ConcreteBuilder2 : Builder
  {
    private Product product = new Product();

    public override void BuildPartA()
    {
      product.Add("PartX");
    }

    public override void BuildPartB()
    {
      product.Add("PartY");
    }

    public override Product GetResult()
    {
      return product;
    }
  }

  // "Product" 
  class Product
  {
    ArrayList parts = new ArrayList();

    public void Add(string part)
    {
      parts.Add(part);
    }

    public void Show()
    {
      Console.WriteLine("\nProduct Parts -------");
      foreach (string part in parts)
        Console.WriteLine(part);
    }
  }

Output

    Product Parts -------
PartA
PartB

Product Parts -------
PartX
PartY



## Prototype ##

1. **Intends**
--------------

Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.
Co-opt one instance of a class for use as a breeder of all future instances.
The new operator considered harmful.

2. **Problem**
--------------
Application "hard wires" the class of object to create in each "new" expression.

3. **Description**
--------------
Declare an abstract base class that specifies a pure virtual "clone" method, and, maintains a dictionary of all "cloneable" concrete derived classes. Any class that needs a "polymorphic constructor" capability: derives itself from the abstract base class, registers its prototypical instance, and implements the clone() operation.

The client then, instead of writing code that invokes the "new" operator on a hard-wired class name, calls a "clone" operation on the abstract base class, supplying a string or enumerated data type that designates the particular concrete derived class desired.

4. **Structure**
--------------
The Factory knows how to find the correct Prototype, and each Product knows how to spawn new instances of itself.
![](https://sourcemaking.com/files/v2/content/patterns/Prototype-2x.png)

5. **Example**
--------------
![](https://sourcemaking.com/files/v2/content/patterns/Prototype_example1-2x.png)

Check list


- Add a clone() method to the existing "product" hierarchy.


- Design a "registry" that maintains a cache of prototypical objects. The registry could be encapsulated in a new Factory class, or in the base class of the "product" hierarchy.


- Design a factory method that: may (or may not) accept arguments, finds the correct prototype object, calls clone() on that object, and returns the result.
The client replaces all references to the new operator with calls to the factory method.

Rules of thumb


- Sometimes creational patterns are competitors: there are cases when either Prototype or Abstract Factory could be used properly. At other times they are complementory: 

- Abstract Factory might store a set of Prototypes from which to clone and return product objects. Abstract Factory, Builder, and Prototype can use Singleton in their implementations.


- Abstract Factory classes are often implemented with Factory Methods, but they can be implemented using Prototype.


- Factory Method: creation through inheritance. Prototype: creation through delegation.
Often, designs start out using Factory Method (less complicated, more customizable, subclasses proliferate) and evolve toward Abstract Factory, Protoype, or Builder (more flexible, more complex) as the designer discovers where more flexibility is needed.


- Prototype doesn't require subclassing, but it does require an "initialize" operation. Factory Method requires subclassing, but doesn't require Initialize.
Designs that make heavy use of the Composite and Decorator patterns often can benefit from Prototype as well.
Prototype co-opts one instance of a class for use as a breeder of all future instances.


- Prototypes are useful when object initialization is expensive, and you anticipate few variations on the initialization parameters. In this context, Prototype can avoid expensive "creation from scratch", and support cheap cloning of a pre-initialized prototype.


- Prototype is unique among the other creational patterns in that it doesn't require a class – only an object. Object-oriented languages like Self and Omega that do away with classes completely rely on prototypes for creating new objects.

	    using System;
	
		namespace DoFactory.GangOfFour.Prototype.Structural {
		 
		  // MainApp test application
		  class MainApp
		  {
		 
		    static void Main()
		    {
		      // Create two instances and clone each 
		      ConcretePrototype1 p1 = new ConcretePrototype1("I");
		      ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
		      Console.WriteLine ("Cloned: {0}", c1.Id);
		
		      ConcretePrototype2 p2 = new ConcretePrototype2("II");
		      ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
		      Console.WriteLine ("Cloned: {0}", c2.Id);
		
		      // Wait for user 
		      Console.Read();
		    }
		  }
		
		  // "Prototype" 
		  abstract class Prototype
		  {
		    private string id;
		
		    // Constructor 
		    public Prototype(string id)
		    {
		      this.id = id;
		    }
		
		    // Property 
		    public string Id
		    {
		      get{ return id; }
		    }
		
		    public abstract Prototype Clone();
		  }
		
		  // "ConcretePrototype1" 
		  class ConcretePrototype1 : Prototype
		  {
		    // Constructor 
		    public ConcretePrototype1(string id) : base(id) 
		    {
		    }
		
		    public override Prototype Clone()
		    {
		      // Shallow copy 
		      return (Prototype)this.MemberwiseClone();
		    }
		  }
		
		  // "ConcretePrototype2" 
		  class ConcretePrototype2 : Prototype
		  {
		    // Constructor 
		    public ConcretePrototype2(string id) : base(id) 
		    {
		    }
		
		    public override Prototype Clone()
		    {
		      // Shallow copy 
		      return (Prototype)this.MemberwiseClone();
		    }
		  }
		}